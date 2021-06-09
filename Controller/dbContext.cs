using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Controller.Properties;
using System.Collections.Generic;
using Models.Class;

namespace Controller
{
    public class dbContext
    {
        public static string connectionString = Settings.Default.CS;
        public MySqlConnection sqlConnection = new MySqlConnection(connectionString);
        public List<Consola> DataSet = new List<Consola>();
        
        //Methods
        public List<Consola> GetConsola(int Id)
        {
            string query = "SELECT * FROM Consolas WHERE Id="+Id;
            MySqlCommand command = new MySqlCommand(query, sqlConnection);
            command.CommandTimeout = 60;
            MySqlDataReader dataReader;

            try
            {
                sqlConnection.Open();
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        var Obj = ObjBuilder(dataReader);
                        this.DataSet.Add(Obj);
                    }
                    sqlConnection.Close();
                    return DataSet;
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                    sqlConnection.Close();
                    return DataSet;
                }
                // Cerrar la conexión
                
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message, "Error en la conexion DB");
                return this.DataSet;
            }
        }
        public List<Consola> GetConsolas()
        {
            string query = "SELECT * FROM Consolas";
            MySqlCommand command = new MySqlCommand(query, sqlConnection);
            command.CommandTimeout = 60;
            MySqlDataReader dataReader;

            try
            {
                sqlConnection.Open();
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        var Obj = ObjBuilder(dataReader);
                        this.DataSet.Add(Obj);
                    }
                    sqlConnection.Close();
                    return DataSet;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                    sqlConnection.Close();
                    return this.DataSet;
                }
                // Cerrar la conexión
                
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message, "Error en la conexion DB");
                return this.DataSet;
            }
        }
        public void UpdateConsola(Consola consola, int Id)
        {
            string query = "UPDATE Consolas SET `Model`="+"'"+consola.Model + "'" +
                                                ",`Serial`="+"'"+consola.Serial + "'" +
                                                ",`Ip`=" + "'" + consola.Ip + "'" +
                                                ",`FechaCompra`=" + "'" + consola.FechaCompra.ToString("yyyy-MM-dd hh:mm:ss") + "'" +
                                                ",`HorasTrabajo`=" + "'" + consola.HorasTrabajo + "'" +
                                                ",`Metadata`=" + "'" + consola.Metadata + "'" +
                                                ",`ImagenConsola`=" + "'" + consola.ImagenConsola + "'" +
                                                ",`Status`=" + "'" + consola.Status + "'" +
                                                ",`Nombre`=" + "'" + consola.Nombre + "'" +
                                                ",`Usuario`=" + "'" + consola.Usuario + "'" +
                                                ",`Password`=" + "'" + consola.Password + "'" +
                                                $" WHERE Id ={Id}";
            MySqlCommand command = new MySqlCommand(query, sqlConnection);
            command.CommandTimeout = 60;
            MySqlDataReader dataReader;
            try
            {
                sqlConnection.Open();
                dataReader = command.ExecuteReader();
                if(dataReader != null)
                {
                    string message = "Consola actualizada correctamente";
                    string caption = "Consola Actualizada";
                    MessageBox.Show(message,caption,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                // Cerrar la conexión
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message, "Error al actualizar consola");
            }
        }
        public void DelConsola(int Id)
        {
            string query = $"DELETE FROM Consolas WHERE Id={Id}";
            MySqlCommand command = new MySqlCommand(query, sqlConnection);
            command.CommandTimeout = 60;
            MySqlDataReader dataReader;
            try
            {
                sqlConnection.Open();
                dataReader = command.ExecuteReader();
                if (dataReader != null)
                {
                    MessageBox.Show("Consola Eliminada correctamente");
                }
                // Cerrar la conexión
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message, "Error al eliminar la consola");
            }
        }
        public void InsertConsola(Consola Newconsola)
        {                                                                                                                                                                                    //Model,             Serial,              Ip,               FechaCompra,                HorasTrabajo               HorasTrabajo,Metadata,  ImagenConsola,                Status,              Nombre,               usuario,               Password
            string query = $"INSERT INTO `consolas` (`Model`, `Serial`, `Ip`, `FechaCompra`, `HorasTrabajo`, `Metadata`, `ImagenConsola`, `Status`, `Nombre`, `Usuario`, `Password`) VALUES ('{Newconsola.Model}','{Newconsola.Serial}','{Newconsola.Ip}','{Newconsola.FechaCompra.ToString("yyyy-MM-dd hh:mm:ss")}','{Newconsola.HorasTrabajo}','{Newconsola.Metadata}','{Newconsola.ImagenConsola}','{Newconsola.Status}','{Newconsola.Nombre}','{Newconsola.Usuario}','{Newconsola.Password}')";
            MySqlCommand command = new MySqlCommand(query, sqlConnection);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                sqlConnection.Open();
                reader = command.ExecuteReader();
                if (reader.RecordsAffected == 1)
                {
                    string caption = "Consola Agregada";
                    string message = "Consola registrada correctamente\nPor favor de clic en el boton de \"Actualizar lista de consolas\" para mostrar la consola agregada";
                    MessageBox.Show(message,caption);
                }
                // Cerrar la conexión
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message, "Error al registrar consola");
            }
        }
        public Consola ObjBuilder(MySqlDataReader dataReader)
        {
            Consola consola = new Consola();
            consola.Id = dataReader.GetInt32(0);
            consola.Model = dataReader.GetString(1);
            consola.Serial = dataReader.GetString(2);
            consola.Ip = dataReader.GetString(3);
            consola.FechaCompra = DateTime.Parse(dataReader.GetString(4));
            consola.HorasTrabajo = double.Parse(dataReader.GetString(5));
            consola.Metadata = dataReader.GetString(6);
            consola.ImagenConsola = dataReader.GetString(7);
            consola.Status = dataReader.GetString(8);
            consola.Nombre = dataReader.GetString(9);
            consola.Usuario = dataReader.GetString(10);
            consola.Password = dataReader.GetString(11);
            return consola;
        }
    }
}
