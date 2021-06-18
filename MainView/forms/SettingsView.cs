using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MainView.Properties;
using Controller.Class;
using MainView.CustomControls;

namespace MainView.forms
{
    public partial class SettingsView : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public SettingsView()
        {
            InitializeComponent();
            BuildNewDBCS.Enabled = true;
            this.Icon = Resources.gamepad128;
        }

        private void TopBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        static public List<Color> ThemeColorList()
        {
            List<Color> ThemeColors = new List<Color>()
            {
                Color.White,
                Color.Black,
                Color.Crimson,
                Color.DeepPink,
                Color.HotPink,
                Color.DeepSkyBlue,
                Color.DarkBlue,
                Color.Purple,
                Color.Green,
                Color.Coral
            };
            return ThemeColors;
        }
        static public List<Color> FontColorList()
        {
            List<Color> FontColors = new List<Color>()
            {
                Color.White,
                Color.Black,
                Color.Crimson,
                Color.DeepPink,
                Color.HotPink,
                Color.DeepSkyBlue,
                Color.DarkBlue,
                Color.Purple,
                Color.Green,
                Color.Coral
            };
            return FontColors;
        }
        private void SettingsView_Load(object sender, EventArgs e)
        {
            DefaultState();
            CurrentConnBox.Text = Alerthandler.GetCurrentCS();
            ColorDownList.SelectedItem = ColorDownList.Items.IndexOf(Settings.Default.SettingBackColor.Name);
            var colors = ThemeColorList();
            var Tcolors = FontColorList();
            foreach (Color item in colors)
            {
                ColorDownList.Items.Add(item);
            }
            foreach (Color item in Tcolors)
            {
                TextColorDownList.Items.Add(item);
            }

        }

        private void ColorDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            var colors = ThemeColorList();
            try
            {
                Settings.Default.SettingBackColor = colors[ColorDownList.SelectedIndex];
                Settings.Default.Save();
            }
            catch (Exception err)
            {
                RColorLabel.Text = err.Message;
            }
            if (Settings.Default.SettingBackColor == colors[ColorDownList.SelectedIndex])
            {
                RColorLabel.Text = "Se ha cambiado el color a " + colors[ColorDownList.SelectedIndex].Name;
            }
        }

        private void TextColorDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            var colors = FontColorList();
            try
            {
                Settings.Default.SettingTextColor = colors[TextColorDownList.SelectedIndex];
                Settings.Default.Save();
            }
            catch (Exception err)
            {
                RTextColorLabel.Text = err.Message;
            }
            if (Settings.Default.SettingBackColor == colors[TextColorDownList.SelectedIndex])
            {
                RTextColorLabel.Text = "Se ha cambiado el color a " + colors[TextColorDownList.SelectedIndex].Name;
            }
        }

        public void DefaultState()
        {
            IpBox.Clear();
            DBNameBox.Clear();

            UsernameCheck.Checked = true;
            if (UsernameCheck.Checked)
            {
                UsernameBox.Clear();
                UsernameBox.Enabled = false;
            }
            PassCheck.Checked = true;
            if (PassCheck.Checked)
            {
                PassBox.Clear();
                PassBox.Enabled = false;
            }
            PortCheck.Checked = true;
            if (PortCheck.Checked)
            {
                PortBox.Clear();
                PortBox.Enabled = false;
            }
        }

        private void UsernameCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (UsernameBox.Enabled == true)
            {
                UsernameBox.Enabled = false;
            }
            else if (UsernameBox.Enabled == false)
            {
                UsernameBox.Enabled = true;
            }
        }

        private void PortCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PortBox.Enabled == true)
            {
                PortBox.Enabled = false;
            }
            else if (PortBox.Enabled == false)
            {
                PortBox.Enabled = true;
            }
        }

        private void PassCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PassBox.Enabled == true)
            {
                PassBox.Enabled = false;
            }
            else if (PassBox.Enabled == false)
            {
                PassBox.Enabled = true;
            }
        }
        private void SaveNewDBChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BuildedCSBox.Text))
            {
                
            }
            else
            {
                if (Alerthandler.ChangeDBConn(BuildedCSBox.Text))
                {
                    MessageBox.Show("Se ah cambiado con exito la \"Cadena de conexion\"", "Cambio realizado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ah cambiado la \"Cadena de conexion\"", "Error en la configuracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BuildNewDBCS_Tick(object sender, EventArgs e)
        {
            // IP & Pass & Database
            if (PassCheck.Checked == false & UsernameCheck.Checked & PortCheck.Checked)
            {
                BuildedCSBox.Clear();
                BuildedCSBox.Text = $"datasource = {IpBox.Text};password={PassBox.Text};database={DBNameBox.Text};";
            }
            // IP & Username & Database 
            if (UsernameCheck.Checked == false & PortCheck.Checked & PassCheck.Checked)
            {
                BuildedCSBox.Clear();
                BuildedCSBox.Text = $"datasource = {IpBox.Text};username={UsernameBox.Text};database={DBNameBox.Text};";
            }
            // IP & Password & Database
            if (PortCheck.Checked == false & PassCheck.Checked & UsernameCheck.Checked)
            {
                BuildedCSBox.Clear();
                BuildedCSBox.Text = $"datasource = {IpBox.Text};port={PortBox.Text};database={DBNameBox.Text};";
            }
            // IP & Username & Password & Database
            if (PassCheck.Checked == false & UsernameCheck.Checked == false & PortCheck.Checked)
            {
                BuildedCSBox.Clear();
                BuildedCSBox.Text = $"datasource = {IpBox.Text};username={UsernameBox.Text};password={PassBox.Text};database={DBNameBox.Text};";
            }
            // IP & Port & Password & Database
            if (PassCheck.Checked == false & UsernameCheck.Checked & PortCheck.Checked == false)
            {
                BuildedCSBox.Clear();
                BuildedCSBox.Text = $"datasource = {IpBox.Text};port={PortBox.Text};password={PassBox.Text};database={DBNameBox.Text};";
            }
            // IP & Port & Username & Database
            if (PortCheck.Checked == false & PassCheck.Checked & UsernameCheck.Checked == false)
            {
                BuildedCSBox.Clear();
                BuildedCSBox.Text = $"datasource = {IpBox.Text};port={PortBox.Text};username={UsernameBox.Text};database={DBNameBox.Text};";
            }
            // IP & Port &Username & Password & Password & Database
            if (UsernameCheck.Checked == false & PortCheck.Checked == false & PassCheck.Checked == false)
            {
                BuildedCSBox.Clear();
                BuildedCSBox.Text = $"datasource = {IpBox.Text};port={PortBox.Text};username={UsernameBox.Text};password={PassBox.Text};database={DBNameBox.Text};";
            }
            // IP & Database
            if (UsernameCheck.Checked & PortCheck.Checked & PassCheck.Checked)
            {
                BuildedCSBox.Clear();
                BuildedCSBox.Text = $"datasource = {IpBox.Text};database={DBNameBox.Text};";
            }
            /////some others conditions to check/////

            //check if new database name and ip are null or empty and set new connection string box value to NewCSBox
            if (string.IsNullOrEmpty(DBNameBox.Text) & string.IsNullOrEmpty(IpBox.Text))
            {
                BuildedCSBox.Clear();
                BuildedCSBox.Text = NewCSBox.Text;
            }
            //Enable Save button if the new connection string box is not null or empty
            if(string.IsNullOrEmpty(BuildedCSBox.Text) == false)
            {
                SaveNewDBChange.Enabled = true;
            }
            else if (string.IsNullOrEmpty(BuildedCSBox.Text))
            {
                SaveNewDBChange.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DefaultState();
        }

        private void NewCSBox_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(NewCSBox.Text) == false)
            {
                IpBox.Enabled = false;
                DBNameBox.Enabled = false;
            }
            if (string.IsNullOrEmpty(NewCSBox.Text))
            {
                IpBox.Enabled = true;
                DBNameBox.Enabled = true;
            }
        }
    }
}
