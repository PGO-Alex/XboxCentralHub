using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Diagnostics;
using MainView.forms;
using Controller;
using System.Collections.Generic;
using MainView.CustomControls;
using Controller.Class;

namespace MainView
{
    public partial class XboxCentralHub : Form
    {
        public string mensaje = "", status = "";
        public Alerthandler alerthandler = new Alerthandler();
        public IconButton CurrentButton = new IconButton();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public XboxCentralHub()
        {
            InitializeComponent();
            Icon = Properties.Resources.gamepad128;
            CheckDBstatus();
            AddControls();
            ClockTimer.Enabled = true;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            string mensaje = "Cerrar Aplicacion?";
            string caption = "Esta seguro que desea cerrar la aplicacion?";
            DialogResult dialog = MessageBox.Show(mensaje, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes)
            {
                SaveAppData();
                Close();
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void SaveAppData()
        {
            
            
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            if (ActiveForm.WindowState == FormWindowState.Maximized)
            {
                ActiveForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
                ActiveForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            XboxCentralHub.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void ColapseButton_Click(object sender, EventArgs e)
        {
            if (SidePanel.Width < 260)
            {
                SidePanel.Width = 260;
                ColapseButton.IconChar = IconChar.ChevronLeft;
                TimeLabel.Visible = true;
                TimeCounterBox.Visible = true;
                CalendarBox.Visible = true;
            }
            else
            {
                ColapseButton.IconChar = IconChar.ChevronRight;
                SidePanel.Width = 40;
                TimeLabel.Visible = false;
                TimeCounterBox.Visible = false;
                CalendarBox.Visible = false;
            }
        }
        private void CheckDBstatus()
        {
            Process[] server = Process.GetProcessesByName("mysqld");

            if (server.Length != 0)
            {
                StatusBox.Text = "ok";
                StatusBox.BackColor = Color.Green;
                status = "ok";
                mensaje = "Base de datos conectada";
            }
            else
            {
                status = "error";
                mensaje = "Base de datos desconectada";
                StatusBox.Text = "error";
                StatusBox.BackColor = Color.Crimson;
            }
        }

        private void AboutThisButton_Click(object sender, EventArgs e)
        {
            AboutApp about = new AboutApp();
            about.Show();
        }

        private void AuthorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://pgo-alex.github.io/");
        }

        private List<ConsoleListItem> FillChildPanelBot()
        {
            dbContext db = new dbContext();
            List<ConsoleListItem> consoles = new List<ConsoleListItem>();
            if (consoles.Count > 0)
            {
                consoles.Clear();
            }
            var LConsolas = db.GetConsolas();
            LConsolas.Reverse();
            ChildPanelBot.SuspendLayout();
            foreach (var item in LConsolas)
            {
                ConsoleListItem console = new ConsoleListItem(item);
                console.Dock = DockStyle.Left;
                consoles.Add(console);
            }
            ChildPanelBot.ResumeLayout();
            return consoles;
        }

        private void UpdateConsoleList_Click(object sender, EventArgs e)
        {
            var controls = ChildPanelBot.Controls;
            foreach (Control item in controls)
            {
                item.Dispose();
            }
            ChildPanelBot.Controls.Clear();
            if (ChildPanelBot.Controls.Count == 0)
            {
                AddControls();
                ChildPanelBot.Refresh();
            }
            ChildPanelBot.Invalidate();
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            SettingsView settings = new SettingsView();
            settings.Show();
        }

        private void AddConsoleButton_Click(object sender, EventArgs e)
        {
            AddConsoleForm addConsole = new AddConsoleForm();
            addConsole.Show();
        }

        private void GenReportButton_Click(object sender, EventArgs e)
        {
            ReportContext report = new ReportContext();
            SaveFileDialog fileDialog = new SaveFileDialog();
            report.BuildPDF();
        }

        public void TimeChange()
        {
            TimeCounterBox.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            TimeChange();
            if (StatusBox.Text == "ok")
            {
                CheckDBButton.Enabled = false;
            }
            else
            {
                CheckDBButton.Enabled = true;
            }
        }

        private void CheckDBButton_Click(object sender, EventArgs e)
        {
            CheckDBstatus();
        }

        public void AddControls()
        {
            List<ConsoleListItem> receiver = new List<ConsoleListItem>();
            receiver = FillChildPanelBot();
            foreach (var item in receiver)
            {
                if (ChildPanelBot.Controls.Contains(item))
                {

                }
                else
                {
                    ChildPanelBot.Controls.Add(item);
                }
            }
        }

        private void Disposer(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
    }
}
