using Arcana.Data;
using Arcana.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arcana
{
    public partial class MainForm : Form
    {
        private Form? _activePage;

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

        private void OpenPage(Form page)
        {
            // Prevent users from accidentally closing BrewingFoorm while brewing
            if (_activePage is BrewingForm brewing && brewing.IsBrewing)
            {
                MessageBox.Show("Please finish brewing before switching pages.");

                page.Dispose();
                return;
            }

            _activePage?.Close();

            _activePage = page;

            page.TopLevel = false;
            page.FormBorderStyle = FormBorderStyle.None;
            page.Dock = DockStyle.Fill;

            pnlContent.AutoScroll = false;
            pnlContent.Controls.Add(page);

            // Display the page to the user
            page.Show();
            page.BringToFront();
        }

        // Display the ingredients form
        private void btnIngredients_Click(object sender, EventArgs e)
        {
            OpenPage(new IngredientsForm());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (_activePage is BrewingForm brewing && brewing.IsBrewing)
            {
                MessageBox.Show("Please finish brewing.");
                return;
            }

            _activePage?.Close();
            _activePage = null;

            pnlContent.AutoScroll = true;

            LoadDashboard();
        }

        private void btnRecipes_Click(object sender, EventArgs e)
        {
            OpenPage(new RecipesForm());
        }

        private void btnStartBrewing_Click(object sender, EventArgs e)
        {
            OpenPage(new BrewingForm());
        }

        private void btnBrewing_Click(object sender, EventArgs e)
        {
            OpenPage(new BrewingForm());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_activePage is BrewingForm brewing && brewing.IsBrewing)
            {
                e.Cancel = true;

                MessageBox.Show(
                    "Please finish brewing before closing Arcana.");
            }
        }

        private void btnPotions_Click(object sender, EventArgs e)
        {
            OpenPage(new PotionsForm());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenPage(new ReportsForm());
        }
    }
}
