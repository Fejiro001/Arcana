using Arcana.Repositories;
using Arcana.UI;

namespace Arcana.Forms
{
    public partial class ReportsForm : Form
    {
        private readonly ReportRepository _repository = new();
        public ReportsForm()
        {
            InitializeComponent();
            ArcanaTheme.Apply(this);
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            // Default is first day of the month to today
            dtpStart.Value = new DateTime(today.Year, today.Month, 1);
            dtpEnd.Value = today;

            dgvPopularPotions.AutoGenerateColumns = false;
            dgvIngredientUsage.AutoGenerateColumns = false;

            LoadReport();
        }


        private void LoadReport()
        {
            DateTime startDate = dtpStart.Value.Date;
            DateTime endDate = dtpEnd.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show(
                    "The start date cannot be after the end date.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // BrewingService records the brewing date in UTC
            // DateTimePickers display dates in the user's local time.
            // So, convert local date to UTC.
            // The end date is inclusive for the user.
            DateTime startUtc = DateTime.SpecifyKind(
                startDate, DateTimeKind.Local).ToUniversalTime();

            DateTime endUtcExclusive = DateTime.SpecifyKind(
                endDate.AddDays(1),
                DateTimeKind.Local).ToUniversalTime();

            try
            {
                var report = _repository.GetReport(
                    startUtc, endUtcExclusive);

                lblTotalBrewed.Text = report.TotalBrewed.ToString();
                lblTotalConsumed.Text = report.TotalConsumed.ToString();

                dgvPopularPotions.DataSource = null;
                dgvPopularPotions.DataSource = report.PopularPotions;

                dgvIngredientUsage.DataSource = null;
                dgvIngredientUsage.DataSource = report.IngredientUsage;

                dgvPopularPotions.CurrentCell = null;
                dgvPopularPotions.ClearSelection();

                dgvIngredientUsage.CurrentCell = null;
                dgvIngredientUsage.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to generate reports: {ex.Message}",
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LoadReport();
        }
    }
}
