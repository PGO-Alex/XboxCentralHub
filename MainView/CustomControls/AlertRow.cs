using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainView.CustomControls
{
    public partial class AlertRow : UserControl
    {
        public AlertRow(string status, string message)
        {
            InitializeComponent();
            AlertFiller(status, message);
        }

        private void CloseRow_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
        }
        public void AlertFiller(string status,string message)
        {
            if (status == "Error" | status == "error" | status == "ERROR")
            {
                StatusButton.IconColor = Color.Crimson;
                StatusButton.IconChar = IconChar.Times;
            }
            else if (status == "done" | status == "DONE" | status == "Done" | status == "ok" | status == "OK" | status == "Ok" | status == "oK")
            {
                StatusButton.IconColor = Color.Green;
                StatusButton.IconChar = IconChar.Check;
            }
            else if (status == "Waiting")
            {
                StatusButton.IconColor = Color.LightYellow;
                StatusButton.IconChar = IconChar.Clock;
            }
            MensajeBox.Text = message;
            TimeBox.Text = DateTime.Now.ToString("hh:mm");
        }
    }
}
