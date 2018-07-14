using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrbaHotel
{
    class Conexion
    {
        public string strConection;
        public string strQuery = "";
        public SqlCommand command;
        public SqlConnection conector;
        public SqlDataReader lector;

        public Conexion() // Lee el archivo de configuración y genera la conexión
        {
            this.strConection = readConfig.Config.strConection();
            this.conector = new SqlConnection(this.strConection);
        }

        public void execute() // crea la nueva consulta a ejecutar
        {
            command = new SqlCommand(strQuery, conector);
        }

        public void openConection() // Abre la conexión
        {
            conector.Open();
        }
        public void closeConection() // Cierra la conexión
        {
            conector.Close();
        }
        
        public void executeNoReturnQuery() // Ejecuta consulta de stored procedures
        {
            this.openConection();
            execute();
            command.ExecuteNonQuery();
            this.closeConection();
        }

        public void executeQuery() // Ejecuta la consulta
        {
            this.openConection();
            execute();
            lector = command.ExecuteReader();
        }

        public bool reader() // Lee los datos del lector
        {
            return lector.Read();
        }
    }
}
