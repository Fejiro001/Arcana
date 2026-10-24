using Arcana.Models;
using Arcana.UI;

namespace Arcana.Forms
{
    public partial class ConsumePotionForm : Form
    {
        public ConsumePotionForm()
        {
            InitializeComponent();
            ArcanaTheme.Apply(this);
        }

        public ConsumePotionForm(BrewedPotion potion) : this()
        {
            lblPotionName.Text = potion.Name;
            lblEffect.Text = $"Effect: {potion.Effect}";
        }
    }
}
