using Arcana.Models;
using Arcana.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Arcana.Forms
{
    public partial class IngredientsForm : Form
    {
        private readonly IngredientRepository _repository = new();
        private int? _selectedIngredientId;
        private bool _isLoadingIngredients;

        public IngredientsForm()
        {
            InitializeComponent();

            dgvIngredients.AutoGenerateColumns = false;
        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            cmbRarity.DataSource = Enum.GetValues<IngredientRarity>();

            LoadIngredients();
        }

        private void LoadIngredients()
        {
            _isLoadingIngredients = true;

            try
            {
                dgvIngredients.DataSource = null;
                dgvIngredients.DataSource = _repository.GetAll(txtSearch.Text.Trim());

                dgvIngredients.ClearSelection();
                dgvIngredients.CurrentCell = null;

                ClearEditor();
            }
            finally
            {
                _isLoadingIngredients = false;
            }
        }

        // Clear the form, unselect cells from the table and disable the retire and clear button
        private void ClearEditor()
        {
            _selectedIngredientId = null;

            txtIngredientName.Clear();
            txtUnit.Clear();
            nudStock.Value = 0;

            cmbRarity.SelectedItem = IngredientRarity.Common;

            dgvIngredients.ClearSelection();
            dgvIngredients.CurrentCell = null;

            btnUpdate.Enabled = false;
            btnRetire.Enabled = false;
        }

        private void dgvIngredients_SelectionChanged(object sender, EventArgs e)
        {
            if (_isLoadingIngredients || dgvIngredients.SelectedRows.Count == 0) return;

            if (dgvIngredients.CurrentRow?.DataBoundItem is not Ingredient ingredient) return;

            _selectedIngredientId = ingredient.Id;

            // Populate the form with the selected ingredient
            txtIngredientName.Text = ingredient.Name;
            txtUnit.Text = ingredient.Unit;
            nudStock.Value = ingredient.Stock;
            cmbRarity.SelectedItem = ingredient.Rarity;

            btnUpdate.Enabled = ingredient.IsActive;
            btnRetire.Enabled = ingredient.IsActive;
        }

        // Validate the inputs before submitting
        private Ingredient? ReadIngredientInputs()
        {
            string name = txtIngredientName.Text.Trim();
            string unit = txtUnit.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter an ingredient name.");
                return null;
            }

            if (string.IsNullOrWhiteSpace(unit))
            {
                MessageBox.Show("Please enter a measurement unit.");
                return null;
            }

            if (cmbRarity.SelectedItem is not IngredientRarity rarity)
            {
                MessageBox.Show("Please select a rarity.");
                return null;
            }

            return new Ingredient
            {
                Name = name,
                Unit = unit,
                Stock = (int)nudStock.Value,
                Rarity = rarity
            };
        }

        // Error handler ffor the form buttons
        private void ExecuteOperation(Action operation, string successMessage)
        {
            try
            {
                operation();
                LoadIngredients();

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
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "The database could not save these changes.",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Add a new ingredient
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var ingredient = ReadIngredientInputs();

            if (ingredient == null) return;

            ExecuteOperation(
                () => _repository.Add(ingredient),
                "Ingredient added successfully!");
        }

        // Update the ingredient
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!_selectedIngredientId.HasValue) return;

            var ingredient = ReadIngredientInputs();

            if (ingredient == null) return;

            ingredient.Id = _selectedIngredientId.Value;

            ExecuteOperation(
                () => _repository.Update(ingredient),
                "Ingredient updated successfully!");
        }

        // Retire the ingredient
        private void btnRetire_Click(object sender, EventArgs e)
        {
            if (!_selectedIngredientId.HasValue) return;

            var confirmRetirement = MessageBox.Show(
                "Are you sure you want to retire this ingredient?",
                "Confirm Retirement",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // User clicked the "No" button
            if (confirmRetirement != DialogResult.Yes) return;

            int ingredientId = _selectedIngredientId.Value;

            ExecuteOperation(
                () => _repository.Retire(ingredientId),
                "Ingredient retired successfully!");
        }

        // Clear the editor
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearEditor();
        }

        // Searching for an ingredient
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadIngredients();
        }

        // First time form is shown, clear any selection
        private void IngredientsForm_Shown(object sender, EventArgs e)
        {
            BeginInvoke(new Action(ClearEditor));
        }

        // Displays Active in green and Retired in muted red
        private void dgvIngredients_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvIngredients.Columns[e.ColumnIndex].Name == "colStatus" && e.Value is bool isActive)
            {
                e.Value = isActive ? "Active" : "Retired";
                e.CellStyle.ForeColor = isActive
                    ? Color.FromArgb(145, 199, 166)
                    : Color.FromArgb(219, 154, 154);

                e.FormattingApplied = true;
            }
        }
    }
}
