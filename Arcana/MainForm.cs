using Arcana.Forms;
using Arcana.Repositories;

namespace Arcana
{
    public partial class MainForm : Form
    {
        private readonly DashboardRepository _dashboardRepository = new();
        private Form? _activePage;

        public MainForm()
        {
            InitializeComponent();
        }
        private void LoadDashboard()
        {
            LoadDashboardCounts();
            LoadRecentBrews();
            LoadSuggestedRecipe();
        }

        private void LoadDashboardCounts()
        {
            var counts = _dashboardRepository.GetCounts();

            lblIngredientCount.Text = counts.Ingredients.ToString();
            lblRecipeCount.Text = counts.Recipes.ToString();
            lblPotionCount.Text = counts.Potions.ToString();
        }

        private void LoadRecentBrews()
        {
            var brews = _dashboardRepository.GetRecentBrews();

            lstRecentBrews.Items.Clear();

            lblRecentActivityEmpty.Visible = brews.Count == 0;
            lstRecentBrews.Visible = brews.Count > 0;

            foreach (var brew in brews)
            {
                DateTime localTime = DateTime
                    .SpecifyKind(brew.BrewedAt, DateTimeKind.Utc)
                    .ToLocalTime();

                string activity = $"{brew.Name} - {localTime:MMM dd, yyyy h:mm tt}";

                lstRecentBrews.Items.Add(activity);
            }
        }

        private void LoadSuggestedRecipe()
        {
            var recipe = _dashboardRepository.GetSuggestedRecipe();

            if (recipe == null)
            {
                lblSuggestedRecipe.Text = "No brewable recipes available";

                lblBrewingDescription.Text = "Check your recipes and ingredient iinventory.";

                btnStartBrewing.Enabled = _dashboardRepository.GetCounts().Recipes > 0;

                return;
            }

            lblSuggestedRecipe.Text = recipe.Name;

            lblBrewingDescription.Text =
                $"{recipe.Element} ● {recipe.Effect} ● " +
                $"{recipe.DurationSeconds} seconds";

            btnStartBrewing.Enabled = true;
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
