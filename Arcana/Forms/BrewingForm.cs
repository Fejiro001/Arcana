using Arcana.Models;
using Arcana.Repositories;
using Arcana.Services;
using Arcana.UI;
using System.Diagnostics;

namespace Arcana.Forms
{
    public partial class BrewingForm : Form
    {
        private readonly RecipeRepository _recipeRepository = new();
        private readonly BrewingService _brewingService = new();

        // To measure actual time elapsed
        private readonly Stopwatch _stopwatch = new();

        private int _brewingRecipeId;
        private int _durationSeconds;
        private bool _isBrewing;

        public bool IsBrewing => _isBrewing;

        public BrewingForm()
        {
            InitializeComponent();
            ArcanaTheme.Apply(this);
        }

        // Populate dropdown with active recipes
        private void BrewingForm_Load(object sender, EventArgs e)
        {
            cmbRecipes.DisplayMember = "Name";
            cmbRecipes.ValueMember = "Id";

            cmbRecipes.DataSource = _recipeRepository.GetAll()
                .Where(r => r.IsActive)
                .ToList();

            progressBarBrew.Minimum = 0;
            progressBarBrew.Maximum = 100;
            progressBarBrew.Value = 0;

            lblProgress.Text = "0%";

            tmrBrew.Interval = 100;

            UpdateSelectedRecipe();
        }

        private void UpdateSelectedRecipe()
        {
            lstRequirements.Items.Clear();

            if (cmbRecipes.SelectedItem is not Recipe selected)
            {
                lblBrewingRecipeName.Text = "No recipe selected";
                lblBrewingRecipeEffect.Text = "No recipe selected";
                lblBrewingRecipeElement.Text = "No recipe selected";
                lblDuration.Text = "No recipe selected";
                lblStatus.Text = "No available recipes.";
                btnBrew.Enabled = false;
                return;
            }

            var recipe = _recipeRepository.GetById(selected.Id);

            if (recipe == null)
                return;

            lblBrewingRecipeName.Text = recipe.Name;
            lblBrewingRecipeEffect.Text = recipe.Effect;
            lblBrewingRecipeElement.Text = recipe.Element;
            lblDuration.Text =
                $"Brewing Time: {recipe.DurationSeconds} seconds";

            foreach (var item in recipe.RecipeIngredients)
            {
                string requirement =
                    $"{item.Ingredient.Name}: " +
                    $"{item.QuantityRequired} {item.Ingredient.Unit} " +
                    $"(Available: {item.Ingredient.Stock})";

                lstRequirements.Items.Add(requirement);
            }

            string? error = _brewingService.GetStockError(recipe.Id);

            lblStatus.Text = error ?? "Ready to brew!";
            btnBrew.Enabled = !_isBrewing && error == null;
        }

        private void cmbRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isBrewing) return;

            progressBarBrew.Value = 0;
            lblProgress.Text = "0%";

            UpdateSelectedRecipe();
        }

        private void btnBrew_Click(object sender, EventArgs e)
        {
            if (_isBrewing) return;

            if (cmbRecipes.SelectedItem is not Recipe selected) return;

            // Inventory validation.
            string? error = _brewingService.GetStockError(selected.Id);

            if (error != null)
            {
                MessageBox.Show(
                    error,
                    "Cannot Brew Potion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                UpdateSelectedRecipe();
                return;
            }

            _brewingRecipeId = selected.Id;
            _durationSeconds = selected.DurationSeconds;
            _isBrewing = true;

            progressBarBrew.Value = 0;
            lblProgress.Text = "0%";
            lblStatus.Text = $"Brewing {selected.Name}...";

            btnBrew.Enabled = false;
            cmbRecipes.Enabled = false;

            _stopwatch.Restart();
            tmrBrew.Start();
        }

        private async void tmrBrew_Tick(object sender, EventArgs e)
        {
            if (!_isBrewing) return;

            double elapsedSeconds = _stopwatch.Elapsed.TotalSeconds;

            int percentage = (int)Math.Min(
                100,
                elapsedSeconds / _durationSeconds * 100
            );

            progressBarBrew.Value = percentage;
            lblProgress.Text = $"{percentage}%";

            if (elapsedSeconds < _durationSeconds) return;

            tmrBrew.Stop();
            _stopwatch.Stop();

            await FinishBrewingAsync();
        }

        private async Task FinishBrewingAsync()
        {
            string? resultMessage = null;

            lblStatus.Text = "Finalizing potion...";

            try
            {
                // Execute database work away from the UI thread.
                var potion = await Task.Run(() =>
                    _brewingService.CompleteBrew(_brewingRecipeId));

                resultMessage = $"{potion.Name} brewed successfully!";

                MessageBox.Show(
                    $"{potion.Name} is ready!\n\n" +
                    $"Effect: {potion.Effect}",
                    "Brewing Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                resultMessage = "Brewing failed. Please check your inventory.";

                progressBarBrew.Value = 0;
                lblProgress.Text = "0%";

                MessageBox.Show(
                    ex.Message,
                    "Brewing Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                _isBrewing = false;
                cmbRecipes.Enabled = true;

                UpdateSelectedRecipe();

                lblStatus.Text = resultMessage ?? "Ready to brew.";
            }
        }
    }
}
