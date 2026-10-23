using Arcana.Models;
using Arcana.Repositories;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Arcana.Forms
{
    public partial class RecipesForm : Form
    {
        private readonly RecipeRepository _repository = new();
        // A collection that supports data binding
        private readonly BindingList<RecipeIngredientEntry> _ingredients = new();

        private int? _selectedRecipeId;
        private bool _isLoading;

        public RecipesForm()
        {
            InitializeComponent();

            dgvRecipes.AutoGenerateColumns = false;
            dgvRecipeIngredients.AutoGenerateColumns = false;

            dgvRecipeIngredients.DataSource = _ingredients;
        }

        private void RecipesForm_Load(object sender, EventArgs e)
        {
            cmbIngredient.DisplayMember = "Name";
            cmbIngredient.ValueMember = "Id";
            cmbIngredient.DataSource = _repository.GetAvailableIngredients();

            LoadRecipes();
        }

        private void LoadRecipes()
        {
            _isLoading = true;

            try
            {
                dgvRecipes.DataSource = null;
                dgvRecipes.DataSource = _repository.GetAll();

                dgvRecipes.CurrentCell = null;
                dgvRecipes.ClearSelection();

                ClearEditor();
            }
            finally
            {
                _isLoading = false;
            }
        }

        private void ClearEditor()
        {
            bool previousLoading = _isLoading;
            _isLoading = true;

            try
            {
                _selectedRecipeId = null;

                txtRecipeName.Clear();
                txtEffect.Clear();
                txtElement.Clear();

                nudDuration.Value = 1;
                nudQuantity.Value = 1;

                _ingredients.Clear();

                dgvRecipes.CurrentCell = null;
                dgvRecipes.ClearSelection();

                btnUpdateRecipe.Enabled = false;
                btnRetireRecipe.Enabled = false;
            }
            finally
            {
                _isLoading = previousLoading;
            }
        }

        private void btnAddIngredientToRecipe_Click(object sender, EventArgs e)
        {
            if (cmbIngredient.SelectedItem is not Ingredient ingredient) return;

            int quantity = (int)nudQuantity.Value;

            if (_ingredients.Any(i => i.IngredientId == ingredient.Id))
            {
                MessageBox.Show(
                    "This ingredient is already in the recipe. " + "Remove it first to change its quantity.");
                return;
            }

            _ingredients.Add(new RecipeIngredientEntry
            {
                IngredientId = ingredient.Id,
                IngredientName = ingredient.Name,
                Unit = ingredient.Unit,
                QuantityRequired = quantity
            });
        }

        private void btnRemoveIngredientFromRecipe_Click(object sender, EventArgs e)
        {
            if (dgvRecipeIngredients.CurrentRow?.DataBoundItem is RecipeIngredientEntry ingredient)
            {
                _ingredients.Remove(ingredient);
            }
        }

        private void SaveRecipe(int recipeId)
        {
            Recipe recipe = new Recipe
            {
                Id = recipeId,
                Name = txtRecipeName.Text,
                Effect = txtEffect.Text,
                Element = txtElement.Text,
                DurationSeconds = (int)nudDuration.Value
            };

            try
            {
                _repository.Save(recipe, _ingredients.ToList());

                LoadRecipes();

                MessageBox.Show(
                    "Recipe saved successfully!",
                    "Arcana",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error");
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Unable to save the recipe to the database.",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            SaveRecipe(0);
        }

        private void btnUpdateRecipe_Click(object sender, EventArgs e)
        {
            if (_selectedRecipeId.HasValue)
            {
                SaveRecipe(_selectedRecipeId.Value);
            }
        }

        private void dgvRecipes_SelectionChanged(object sender, EventArgs e)
        {
            if (_isLoading || dgvRecipes.SelectedRows.Count == 0) return;

            if (dgvRecipes.SelectedRows[0].DataBoundItem is not Recipe selected) return;

            var recipe = _repository.GetById(selected.Id);

            if (recipe == null) return;

            _selectedRecipeId = recipe.Id;

            txtRecipeName.Text = recipe.Name;
            txtEffect.Text = recipe.Effect;
            txtElement.Text = recipe.Element;
            nudDuration.Value = recipe.DurationSeconds;

            _ingredients.Clear();

            foreach (var item in recipe.RecipeIngredients)
            {
                _ingredients.Add(new RecipeIngredientEntry
                {
                    IngredientId = item.IngredientId,
                    IngredientName = item.Ingredient.Name,
                    Unit = item.Ingredient.Unit,
                    QuantityRequired = item.QuantityRequired
                });
            }

            btnUpdateRecipe.Enabled = recipe.IsActive;
            btnRetireRecipe.Enabled = recipe.IsActive;
        }

        private void btnRetireRecipe_Click(object sender, EventArgs e)
        {
            if (!_selectedRecipeId.HasValue) return;

            var confirmRetirement = MessageBox.Show(
                "Are you sure you want to retire this recipe?",
                "Confirm Retirement",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmRetirement != DialogResult.Yes) return;

            try
            {
                _repository.Retire(_selectedRecipeId.Value);
                LoadRecipes();

                MessageBox.Show("Recipe retired successfully!");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearRecipe_Click(object sender, EventArgs e)
        {
            ClearEditor();
        }

        private void RecipesForm_Shown(object sender, EventArgs e)
        {
            BeginInvoke(new Action(ClearEditor));
        }

        private void dgvRecipes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRecipes.Columns[e.ColumnIndex].Name == "colRecipeStatus" && e.Value is bool isActive)
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
