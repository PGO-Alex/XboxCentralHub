using System;
using System.Drawing;
using System.Windows.Forms;
using Models.Class;
using System.Net.NetworkInformation;
using System.Diagnostics;
using Controller.Class;
using Controller;
using MainView.forms;
using System.Media;

namespace MainView.CustomControls
{
    public partial class ConsoleListItem : UserControl
    {
        public RentContext rentContext = new RentContext();
        public Rent rent = new Rent();
        public string mensaje = "", status = "";
        public int segs = 00;
        public Alerthandler alerthandler = new Alerthandler();
        public Stopwatch watch = new Stopwatch();
        public Consola CurrentConsol = new Consola();
        public string stat;
        public ConsoleListItem(Consola consola)
        {
            CurrentConsol = consola;
            stat = CurrentConsol.Status;
            InitializeComponent();
            FillCard(consola);
            CheckConn.Enabled = true;
            
        }

        public void FillCard(Consola consola)
        {
            ConsoleName.Text = consola.Nombre;
            FechaCompraBox.Text = consola.FechaCompra.ToString("dd/MM/yyyy");
            ModelBox.Text = consola.Model;
            SerialBox.Text = consola.Serial;
            IpBox.Text = consola.Ip;
            IdLabel.Text = consola.Id.ToString();
            if (consola.ImagenConsola == "" | consola.ImagenConsola == null)
            {
                ImageBox.Image = Properties.Resources.XboxDefImage;
            }
            else if(consola.ImagenConsola != "")
            {
                ImageBox.ImageLocation = consola.ImagenConsola;
            }
            CheckConsoleConn(consola);
            ConsoleInfoBox.Text = consola.Metadata;
            HorasTBox.Text = consola.HorasTrabajo.ToString();
        }

        public void CheckConsoleConn(Consola consola)
        {
            Ping ping = new Ping();
            try
            {
                PingReply reply = ping.Send(consola.Ip);
                if (reply.Status == IPStatus.Success)
                {
                    this.StatusBox.Text = "Conectado";
                    this.StatusBox.BackColor = Color.LimeGreen;
                    this.StatusBox.ForeColor = Color.Black;
                    this.status = "Done";
                    this.mensaje = "Consola " + consola.Nombre + "con id:" + consola.Id.ToString() + " en Linea en: " + consola.Ip;
                }
                else if (reply.Status != IPStatus.Success)
                {
                    this.StatusBox.Text = "Error";
                    this.StatusBox.BackColor = Color.Crimson;
                    this.StatusBox.ForeColor = Color.White;
                    this.status = "Error";
                    this.mensaje = "Error consola: " + consola.Nombre + "con Id:" + consola.Id.ToString() + " No esta conectada a la red o esta apagada";
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("No se puede establecer conexion a la red local, revise su conexion a la red local e intentelo de nuevo","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            dbContext dbContext = new dbContext();
            string caption = "Advertencia de elimiancion de consola";
            string mensaje = "Estas seguro que deseas eliminar esta consola?\nConsola: "+CurrentConsol.Nombre+"\nIP: "+CurrentConsol.Ip;
            DialogResult result = MessageBox.Show(mensaje, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                dbContext.DelConsola(CurrentConsol.Id);
                this.Dispose();
            }
            else
            {

            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditConsole edit = new EditConsole(CurrentConsol);
            edit.Show();
        }

        private void RentButton_Click(object sender, EventArgs e)
        {

            string message = "";
            string caption = "";
            if (RentButton.Text == "Rentar Consola")
            {
                message = "Iniciar renta en la consola " + CurrentConsol.Nombre + "\nCon IP: " + CurrentConsol.Ip;
                caption = "Rentar Consola?";
            }
            else
            {
                message = "Detener renta en la consola " + CurrentConsol.Nombre + "\nCon IP: " + CurrentConsol.Ip;
                caption = "Detener renta?";
            }
            if (RentTypeBox.SelectedItem != null)
            {
                SystemSounds.Exclamation.Play();
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    if (RentTimer.Enabled == true)
                    {
                        rent.TimeFinish = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
                        rent.TimeWorked = DateTime.Parse(rent.TimeFinish.ToString()).Subtract(DateTime.Parse(rent.TimeStart.ToString()));
                        rentContext.InsertRent(rent);
                        TimeToRentBox.Enabled = true;
                        RentTypeBox.Enabled = true;
                        RentTimer.Enabled = false;
                        RentTimeBox.Text = "00:00:00";
                        RentButton.Text = "Rentar Consola";
                        RentButton.BackColor = Color.Transparent;
                        RentButton.ForeColor = Color.Black;
                        RentButton.IconColor = Color.Black;
                    }
                    else if (RentTimer.Enabled == false)
                    {
                        TimeToRentBox.Enabled = false;
                        RentTypeBox.Enabled = false;
                        RentTimeBox.ForeColor = Color.Black;
                        rent.StartTime = DateTime.Now;
                        rent.ConsolaId = CurrentConsol.Id;
                        rent.NombreConsola = CurrentConsol.Nombre;
                        rent.RentInfo = RentTypeBox.Text;
                        rent.TimeStart = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
                        RentTimer.Enabled = true;
                        segs = 00;
                        RentButton.Text = "Detener Renta";
                        RentButton.BackColor = Color.Crimson;
                        RentButton.ForeColor = Color.White;
                        RentButton.IconColor = Color.White;
                    }
                }
                else
                {
                    MessageBox.Show("El tipo de renta no pueden estar vacio");
                }
            }
        }

        private void RentTimer_Tick(object sender, EventArgs e)
        {
            segs++;
            RentTimeBox.Text = TimeSpan.FromSeconds(segs).ToString(@"hh\:mm\:ss");
            if(TimeSpan.Parse(RentTimeBox.Text) == TimeSpan.Parse(TimeToRentBox.Text))
            {
                RentTimeBox.ForeColor = Color.Crimson;
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Tiempo en la consola " + CurrentConsol.Nombre + " finalizo", "Alerta de tiempo finalizado");
            }
        }

        private void CheckConn_Tick(object sender, EventArgs e)
        {
            CheckConsoleConn(CurrentConsol);
        }
    }
}
