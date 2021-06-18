using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Controller.Properties;
using Models.Class;
using System.Windows.Forms;

namespace Controller
{
    public class RentContext
    {
        public static string connectionString = Settings.Default.CS;
        public MySqlConnection sqlConnection = new MySqlConnection(connectionString);
        public List<string[]> DataSet = new List<string[]>();
        public string DBTable = "rentas";


        public void InsertRent(Rent renta)
        {
            string query = $"INSERT INTO `{DBTable}` (`ConsolaId`,`TimeStart`,`TimeFinish`,`TimeWorked`,`NombreConsola`,`StartTime`,`RentInfo`) VALUES('{renta.ConsolaId}','{renta.TimeStart}','{renta.TimeFinish}','{renta.TimeWorked}','{renta.NombreConsola}','{renta.StartTime:yyyy-MM-dd HH:mm:ss}','{renta.RentInfo}');";
            MySqlCommand command = new MySqlCommand(query, sqlConnection)
            {
                CommandTimeout = 60
            };
            MySqlDataReader dataReader;

            try
            {
                sqlConnection.Open();
                dataReader = command.ExecuteReader();

                if (dataReader.RecordsAffected == 1)
                {
                    
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la renta en la base de datos.");
                    sqlConnection.Close();
                }

            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message, "Error en la conexion DB");
            }

        }

        public List<string[]> GetRentsToday()
        {
            string query = $"SELECT * FROM {DBTable} WHERE StartTime LIKE '{DateTime.Now:yyyy-MM-dd}%'";
            MySqlCommand command = new MySqlCommand(query, sqlConnection)
            {
                CommandTimeout = 60
            };
            MySqlDataReader dataReader;
            try
            {
                sqlConnection.Open();
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    try
                    {
                        while (dataReader.Read())
                        {
                            string[] row = {dataReader.GetString(0) , dataReader.GetString(1) , dataReader.GetString(2) , dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5) , dataReader.GetString(6) , dataReader.GetString(7)};

                            DataSet.Add(row);
                        }
                        return DataSet;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Error al llenar el data set");
                        return DataSet;
                    }
                    
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                    sqlConnection.Close();
                    return DataSet;
                }
                
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message, "Error al consultar la Base de datos");
                return DataSet;
            }
        }

        /*public string RentBuilder(MySqlDataReader dataReader)
        {
            string checknull = "";
            if (string.IsNullOrEmpty(dataReader.GetString(4)))
            {
                checknull = "";
            }
            return row;
        }*/
    }
}
