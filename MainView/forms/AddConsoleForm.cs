using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Models.Class;
using Controller.Class;
using Controller;
using MainView.Properties;

namespace MainView.forms
{
    public partial class AddConsoleForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public string PassWord;
        public char PassChar;
        public string newImagePath = "";
        public Color colorT = Settings.Default.SettingTextColor;
        public Color colorB = Settings.Default.SettingBackColor;

        public AddConsoleForm()
        {
            InitializeComponent();
            StatusBox.SelectedItem = StatusBox.Items[0];
            DateBox.Value = DateTime.Now;
            HWBox.ReadOnly = true;
            HWBox.Enabled = false;
            this.Icon = Resources.gamepad128;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void DisplayPassButton_Click(object sender, EventArgs e)
        {
            display.Enabled = true;
            PassBox.UseSystemPasswordChar = false;
            PassWord = PassBox.Text;
        }

        private void display_Tick(object sender, EventArgs e)
        {
            display.Enabled = false;
            PassBox.UseSystemPasswordChar = true;
        }

        private void SaveConsoleButton_Click(object sender, EventArgs e)
        {
            dbContext db = new dbContext();
            Consola consola = new Consola();
            string caption = "Registro de nueva consola";
            string message = "Desea registrar la consola con los datos mencionados?";
            DialogResult result = MessageBox.Show(AddConsoleForm.ActiveForm,message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                
                consola.FechaCompra = DateBox.Value;
                consola.HorasTrabajo = Convert.ToDouble(HWBox.Text);
                consola.Ip = IpBox.Text; //validar
                consola.Model = ModelBox.Text; //validar
                consola.Serial = SerialBox.Text; //validar
                consola.Nombre = NameBox.Text; //validar
                consola.Status = StatusBox.SelectedItem.ToString();
                PassBox.UseSystemPasswordChar = false;
                consola.Password = PassBox.Text; //validar
                PassBox.UseSystemPasswordChar = true;
                consola.Usuario = UsernameBox.Text; //validar
                consola.Metadata = MetadataBox.Text; //validar
                if(ImageBox.ImageLocation == null)
                {
                    Random random = new Random();
                    int Rnumero = random.Next();
                    Image image = Properties.Resources.XboxDefImage;
                    string path = Alerthandler.directoryPath + Properties.Resources.XboxDefImage + $"{Rnumero}.png";
                    image.Save(Alerthandler.directoryPath +image+$"{Rnumero}.png");
                    consola.ImagenConsola = path;
                }
                if (consola.Ip == "" | consola.Nombre == "" | consola.Model == "" | consola.Password == "" | consola.Metadata == "" | consola.Usuario == "" | consola.Serial == "")
                {
                    string msg = "Las propiedades IP, NOMBRE, MODELO, CONTRASEÑA, USUARIO, INFORMACION ADICIONAL y SERIAL no pueden estar vacios.";
                    string title = "Error al registrar la consola";
                    MessageBox.Show(msg,title);
                }
                else
                {
                    db.InsertConsola(consola);
                    ClearControls();
                    Close();
                }
            }
            else if(result == DialogResult.Cancel)
            {

            }
        }

        private void ClearControls()
        {
            HWBox.Text = "0";
            IpBox.Text = "";
            ModelBox.Text = "";
            SerialBox.Text = ""; //validar
            NameBox.Text = ""; //validar
            PassBox.UseSystemPasswordChar = false;
            PassBox.Text = ""; //validar
            PassBox.UseSystemPasswordChar = true;
            UsernameBox.Text = "";
            MetadataBox.Text = "";
        }

        private void ChangeImageButton_Click(object sender, EventArgs e)
        {
            OpenImageDialog.ShowDialog();
            Image imagen = Image.FromFile(OpenImageDialog.FileName);
            string imagePath = Alerthandler.directoryPath + OpenImageDialog.SafeFileName;
            imagen.Save(imagePath);
            ImageBox.Image = Image.FromFile(imagePath);
        }

        private void SaveButtonCheck_Tick(object sender, EventArgs e)
        {
            if(IpBox.Text == ""
                || ModelBox.Text == ""
                || SerialBox.Text == ""
                || NameBox.Text == ""
                || PassBox.Text == ""
                || UsernameBox.Text == ""
                || MetadataBox.Text == "")
            {
                SaveConsoleButton.Enabled = false;
                SaveConsoleButton.BackColor = colorB;
                SaveConsoleButton.ForeColor = colorT;
            }
            else
            {
                SaveConsoleButton.Enabled = true;
                SaveConsoleButton.BackColor = colorT;
                SaveConsoleButton.ForeColor = colorB;
            }
        }

        private void AddConsoleForm_Load(object sender, EventArgs e)
        {
            SaveButtonCheck.Enabled = string.IsNullOrEmpty(ModelBox.Text) & string.IsNullOrEmpty(SerialBox.Text) & string.IsNullOrEmpty(NameBox.Text) & string.IsNullOrEmpty(PassBox.Text) & string.IsNullOrEmpty(MetadataBox.Text) & string.IsNullOrEmpty(IpBox.Text) & string.IsNullOrEmpty(UsernameBox.Text);
        }
    }
}
