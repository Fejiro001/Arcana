using Arcana.Models;

namespace Arcana.Forms
{
    public partial class ConsumePotionForm : Form
    {
        public ConsumePotionForm()
        {
            InitializeComponent();
        }

        public ConsumePotionForm(BrewedPotion potion) : this()
        {
            lblPotionName.Text = potion.Name;
            lblEffect.Text = $"Effect: {potion.Effect}";
        }
    }
}
