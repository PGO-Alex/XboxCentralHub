using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Controller;
using Controller.Class;
using Models.Class;
using MainView.Properties;

namespace MainView.forms
{
    public partial class EditConsole : Form
    {
        public string PassWord = "";
        public Consola consolToEdit = new Consola();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public EditConsole(Consola consola)
        {
            InitializeComponent();
            consolToEdit = consola;
            NewConsoleBuilder();
            HWBox.ReadOnly = true;
            HWBox.Enabled = false;
            this.Icon = Resources.gamepad128;
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void NewConsoleBuilder()
        {
            HWBox.Text = consolToEdit.HorasTrabajo.ToString();
            IpBox.Text = consolToEdit.Ip;
            ModelBox.Text = consolToEdit.Model; ;
            SerialBox.Text = consolToEdit.Serial;
            NameBox.Text = consolToEdit.Nombre; //validar
            PassBox.UseSystemPasswordChar = false;
            PassBox.Text = consolToEdit.Password; //validar
            PassBox.UseSystemPasswordChar = true;
            UsernameBox.Text = consolToEdit.Usuario;
            MetadataBox.Text = consolToEdit.Metadata;
            DateBox.Value = DateTime.Parse(consolToEdit.FechaCompra.ToString("dd/MM/yyyy"));
            ImageBox.ImageLocation = consolToEdit.ImagenConsola;
            StatusBox.SelectedItem = StatusBox.Items[StatusBox.Items.IndexOf(consolToEdit.Status)];
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayPassButton_Click(object sender, EventArgs e)
        {
            display.Enabled = true;
            PassBox.UseSystemPasswordChar = false;
            PassWord = PassBox.Text;
        }


        private void ChangeImageButton_Click(object sender, EventArgs e)
        {
            OpenImageDialog.ShowDialog();
            Image imagen = Image.FromFile(OpenImageDialog.FileName);
            string imagePath = Alerthandler.directoryPath + OpenImageDialog.SafeFileName;
            imagen.Save(imagePath);
            ImageBox.Image = Image.FromFile(imagePath);
        }

        private void SaveConsoleButton_Click(object sender, EventArgs e)
        {
            dbContext db = new dbContext();
            Consola consola = new Consola();
            string caption = "Actualizacion de consola";
            string message = "Desea actualizar la consola con los datos registrados?";
            DialogResult result = MessageBox.Show(AddConsoleForm.ActiveForm, message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
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
                if (ImageBox.ImageLocation == null)
                {
                    Random random = new Random();
                    int Rnumero = random.Next();
                    Image image = Properties.Resources.XboxDefImage;
                    string path = Alerthandler.directoryPath + Properties.Resources.XboxDefImage + $"{Rnumero}.png";
                    image.Save(Alerthandler.directoryPath + image + $"{Rnumero}.png");
                    consola.ImagenConsola = path;
                }
                else
                {
                    consola.ImagenConsola = ImageBox.ImageLocation;
                }

                if (consola.Ip == "" | consola.Nombre == "" | consola.Model == "" | consola.Password == "" | consola.Metadata == "" | consola.Usuario == "" | consola.Serial == "")
                {
                    string msg = "Las propiedades IP, NOMBRE, MODELO, CONTRASEÑA, USUARIO, INFORMACION ADICIONAL y SERIAL no pueden estar vacios.";
                    string title = "Error al actualizar la consola";
                    MessageBox.Show(msg, title);
                }
                else
                {
                    db.UpdateConsola(consola,consolToEdit.Id);
                    Close();
                }
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void StatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(StatusBox.SelectedItem.ToString() == "Activo")
            {
                MessageLabel.Text = "*El valor por defecto durante el registro es \"Activo\"";
            }
            if(StatusBox.SelectedItem.ToString() == "Desactivado")
            {
                MessageLabel.Text = "*El valor \"Desactivado\" indica que la consola no esta disponible";
            }
            if (StatusBox.SelectedItem.ToString() == "Ok")
            {
                MessageLabel.Text = "*El valor \"Ok\" indica que la consola no tiene problemas";
            }
            if (StatusBox.SelectedItem.ToString() == "Error")
            {
                MessageLabel.Text = "*El valor \"Error\" indica que la consola funciona con problemas";
            }
        }
        private void SaveButtonCheck_Tick(object sender, EventArgs e)
        {
            if (IpBox.Text == ""
                || ModelBox.Text == ""
                || SerialBox.Text == ""
                || NameBox.Text == ""
                || PassBox.Text == ""
                || UsernameBox.Text == ""
                || MetadataBox.Text == "")
            {
                SaveConsoleButton.Enabled = false;
                SaveConsoleButton.BackColor = Color.White;
                SaveConsoleButton.ForeColor = Color.Black;
            }
            else
            {
                SaveConsoleButton.Enabled = true;
                SaveConsoleButton.BackColor = Color.Black;
                SaveConsoleButton.ForeColor = Color.White;
            }
        }

        private void EditConsole_Load(object sender, EventArgs e)
        {
            SaveButtonCheck.Enabled = string.IsNullOrEmpty(ModelBox.Text) & string.IsNullOrEmpty(SerialBox.Text) & string.IsNullOrEmpty(NameBox.Text) & string.IsNullOrEmpty(PassBox.Text) & string.IsNullOrEmpty(MetadataBox.Text) & string.IsNullOrEmpty(IpBox.Text) & string.IsNullOrEmpty(UsernameBox.Text);
        }

        private void display_Tick(object sender, EventArgs e)
        {
            display.Enabled = false;
            PassBox.UseSystemPasswordChar = true;
        }
    }
}
