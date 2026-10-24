
using System.Drawing;
using System.Windows.Forms;

namespace Arcana.UI
{
    public static class ArcanaTheme
    {
        // Arcana colour palette
        public static readonly Color Background =
            Color.FromArgb(25, 24, 39);

        public static readonly Color Surface =
            Color.FromArgb(41, 38, 60);

        public static readonly Color InputBackground =
            Color.FromArgb(30, 28, 46);

        public static readonly Color Primary =
            Color.FromArgb(128, 90, 202);

        public static readonly Color Secondary =
            Color.FromArgb(81, 65, 123);

        public static readonly Color Danger =
            Color.FromArgb(73, 48, 68);

        public static readonly Color TextPrimary =
            Color.FromArgb(246, 240, 255);

        public static readonly Color TextSecondary =
            Color.FromArgb(185, 179, 206);

        public static readonly Color Accent =
            Color.FromArgb(196, 167, 255);

        public static readonly Color Border =
            Color.FromArgb(65, 58, 85);

        // Examines each control on the form and applies the appropriate style.
        public static void Apply(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                switch (control)
                {
                    case DataGridView grid:
                        StyleGrid(grid);
                        break;

                    case Button button:
                        StyleButton(button);
                        break;

                    case TextBox textBox:
                        StyleTextBox(textBox);
                        break;

                    case ComboBox comboBox:
                        StyleComboBox(comboBox);
                        break;

                    case NumericUpDown numeric:
                        StyleNumericUpDown(numeric);
                        break;
                }

                // Style controls inside nested panels.
                if (control.HasChildren)
                    Apply(control);
            }
        }

        private static void StyleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.ForeColor = TextPrimary;
            button.UseVisualStyleBackColor = false;
            button.Cursor = Cursors.Hand;

            button.BackColor =
                button.Tag?.ToString()?.ToLower() switch
                {
                    "primary" => Primary,
                    "danger" => Danger,
                    "neutral" => Surface,
                    _ => Secondary
                };

            button.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(104, 79, 158);
        }

        private static void StyleTextBox(TextBox textBox)
        {
            textBox.BackColor = InputBackground;
            textBox.ForeColor = TextPrimary;
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private static void StyleComboBox(ComboBox comboBox)
        {
            comboBox.BackColor = InputBackground;
            comboBox.ForeColor = TextPrimary;
            comboBox.FlatStyle = FlatStyle.Flat;
        }

        private static void StyleNumericUpDown(
            NumericUpDown numeric)
        {
            numeric.BackColor = InputBackground;
            numeric.ForeColor = TextPrimary;
            numeric.BorderStyle = BorderStyle.FixedSingle;
        }

        private static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Surface;
            grid.BorderStyle = BorderStyle.None;

            grid.RowHeadersVisible = false;
            grid.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            grid.GridColor = Border;
            grid.RowTemplate.Height = 34;

            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            grid.ColumnHeadersHeight = 38;

            // Column headers
            grid.ColumnHeadersDefaultCellStyle.BackColor =
                Secondary;

            grid.ColumnHeadersDefaultCellStyle.ForeColor =
                TextPrimary;

            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Secondary;

            // Regular rows
            grid.DefaultCellStyle.BackColor = Surface;
            grid.DefaultCellStyle.ForeColor = TextPrimary;

            grid.DefaultCellStyle.SelectionBackColor =
                Secondary;

            grid.DefaultCellStyle.SelectionForeColor =
                TextPrimary;

            // Alternating rows
            grid.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(47, 43, 67);

            grid.AlternatingRowsDefaultCellStyle.ForeColor =
                TextPrimary;

            grid.AlternatingRowsDefaultCellStyle.SelectionBackColor =
                Secondary;

            grid.AlternatingRowsDefaultCellStyle.SelectionForeColor =
                TextPrimary;
        }
    }
}
