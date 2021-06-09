using System;

namespace Models.Class
{
    public class Consola
    {
        private int id;
        private string model;
        private string serial;
        private string ip;
        private DateTime fechaCompra;
        private double horasTrabajo;
        private string metadata;
        private string imagenConsola;
        private string status;
        private string nombre;
        private string password;
        private string usuario;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Status { get => status; set => status = value; }
        public string ImagenConsola { get => imagenConsola; set => imagenConsola = value; }
        public int Id { get => id; set => id = value; }
        public string Model { get => model; set => model = value; }
        public string Serial { get => serial; set => serial = value; }
        public string Ip { get => ip; set => ip = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public double HorasTrabajo { get => horasTrabajo; set => horasTrabajo = value; }
        public string Metadata { get => metadata; set => metadata = value; }
    }
}
