using System;
using System.Windows.Forms;
using MainView.Properties;

namespace MainView.forms
{
    partial class AboutApp : Form
    {
        public AboutApp()
        {
            InitializeComponent();
            this.Icon = Resources.gamepad128;
            labelCompanyName.Text = Settings.Default.CompanyName;
            labelCopyright.Text = Settings.Default.Copyright;
            labelVersion.Text = Settings.Default.AppVersion;
            labelProductName.Text = Settings.Default.AppTitle;
            textBoxDescription.Text = Settings.Default.Description;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
