using Arcana.Data;
using Arcana.Forms;

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
            SetActiveNavigation(btnDashboard);
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
            NavigateTo(new IngredientsForm(), btnIngredients);
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
            SetActiveNavigation(btnDashboard);
        }

        private void btnRecipes_Click(object sender, EventArgs e)
        {
            NavigateTo(new RecipesForm(), btnRecipes);
        }

        private void btnStartBrewing_Click(object sender, EventArgs e)
        {
            NavigateTo(new BrewingForm(), btnBrewing);
        }

        private void btnBrewing_Click(object sender, EventArgs e)
        {
            NavigateTo(new BrewingForm(), btnBrewing);
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
            NavigateTo(new PotionsForm(), btnPotions);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            NavigateTo(new ReportsForm(), btnReports);
        }

        private void SetActiveNavigation(Button activeButton)
        {
            Button[] buttons =
            {
                btnDashboard,
                btnIngredients,
                btnRecipes,
                btnBrewing,
                btnPotions,
                btnReports
            };

            foreach (Button button in buttons)
            {
                bool isActive = button == activeButton;

                button.BackColor = isActive
                    ? Color.FromArgb(81, 65, 123)
                    : Color.FromArgb(36, 34, 53);

                button.ForeColor = Color.FromArgb(246, 240, 255);

                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;

                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(104, 79, 158);
            }
        }

        private void NavigateTo(Form page, Button button)
        {
            OpenPage(page);

            // Only highlight the button if navigation succeeded
            if (ReferenceEquals(_activePage, page))
            {
                SetActiveNavigation(button);
            }
        }
    }
}
