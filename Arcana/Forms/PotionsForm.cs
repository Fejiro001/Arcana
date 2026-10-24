using Arcana.Models;
using Arcana.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Arcana.Forms
{
    public partial class PotionsForm : Form
    {
        private readonly PotionRepository _repository = new();

        private int? _selectedPotionId;
        private bool _isLoading;

        public PotionsForm()
        {
            InitializeComponent();

            dgvPotions.AutoGenerateColumns = false;
        }

        private void PotionsForm_Load(object sender, EventArgs e)
        {
            LoadPotions();
        }

        // Loads non-deleted potions
        private void LoadPotions()
        {
            _isLoading = true;

            try
            {
                dgvPotions.DataSource = null;
                dgvPotions.DataSource = _repository.GetAll();

                dgvPotions.CurrentCell = null;
                dgvPotions.ClearSelection();

                UpdateSelectedPotion(null);
            }
            finally
            {
                _isLoading = false;
            }
        }

        private void UpdateSelectedPotion(BrewedPotion? potion)
        {
            _selectedPotionId = potion?.Id;

            lblSelectedEffect.Text = potion == null
                ? "Select a potion to view its effect."
                : potion.Effect;

            btnConsume.Enabled = potion?.Status == "Available";
            btnDelete.Enabled = potion != null;
        }

        private void dgvPotions_SelectionChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            BrewedPotion? potion = null;

            if (dgvPotions.SelectedRows.Count > 0)
            {
                potion = dgvPotions.SelectedRows[0]
                    .DataBoundItem as BrewedPotion;
            }

            UpdateSelectedPotion(potion);
        }

        // Prevent initial selecting row
        private void PotionsForm_Shown(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                dgvPotions.CurrentCell = null;
                dgvPotions.ClearSelection();
                UpdateSelectedPotion(null);
            }));
        }

        private void ExecuteOperation(Action operation, string successMessage)
        {
            try
            {
                operation();

                LoadPotions();

                MessageBox.Show(
                    successMessage,
                    "Arcana",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Potion Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                LoadPotions();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Unable to update the potion inventory.",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                LoadPotions();
            }
        }

        private void btnConsume_Click(object sender, EventArgs e)
        {
            if (!_selectedPotionId.HasValue) return;

            if (dgvPotions.SelectedRows.Count == 0) return;

            if (dgvPotions.SelectedRows[0].DataBoundItem is not BrewedPotion potion) return;

            if (potion.Status != "Available") return;

            // The dialog box
            using var dialog = new ConsumePotionForm(potion);

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            ExecuteOperation(
                () => _repository.Consume(potion.Id),
                $"{potion.Name} consumed successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!_selectedPotionId.HasValue) return;

            int potionId = _selectedPotionId.Value;

            var confirmation = MessageBox.Show(
                "Are you sure you want to delete this potion?",
                "Delete Potion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmation != DialogResult.Yes) return;

            ExecuteOperation(
                () => _repository.Delete(potionId),
                "Potion deleted successfully!");
        }
    }
}
