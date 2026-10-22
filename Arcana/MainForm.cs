using Arcana.Data;

namespace Arcana
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void LoadDashboard()
        {
            using var context = new AlchemyContext();

            int ingredientCount = context.Ingredients
                .Count(i => i.IsActive);

            int recipeCount = context.Recipes
                .Count(r => r.IsActive);

            int potionCount = context.BrewedPotions
                .Count(p => p.Status == "Available");

            lblIngredientCount.Text = ingredientCount.ToString();
            lblRecipeCount.Text = recipeCount.ToString();
            lblPotionCount.Text = potionCount.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }
    }
}
