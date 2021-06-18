using System.Drawing;
using System.Windows.Forms;
using System;
using MainView.Properties;

namespace MainView.CustomControls
{

    public partial class ImageListItem : UserControl
    {
        public ImageListItem(Image image)
        {
            InitializeComponent();
            ImageBox.Image = image;

        }
    }
}
