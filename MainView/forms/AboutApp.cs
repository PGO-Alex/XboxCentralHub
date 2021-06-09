using System;
using System.Windows.Forms;

namespace MainView.forms
{
    partial class AboutApp : Form
    {
        public AboutApp()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
