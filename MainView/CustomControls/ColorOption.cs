using System.Drawing;
using System.Windows.Forms;

namespace MainView.CustomControls
{
    public partial class ColorOption : UserControl
    {
        public ColorOption(Color color)
        {
            InitializeComponent();
            ColorNameBox.Text = color.Name;
        }
    }
}
