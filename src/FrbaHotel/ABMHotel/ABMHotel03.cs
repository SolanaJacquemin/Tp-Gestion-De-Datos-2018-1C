using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ABMHotel
{
    public partial class ABMHotel03 : Form
    {
        public decimal hotel;

        public ABMHotel03(decimal hotelID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;

            hotel = hotelID;

            dt_fechaDesdeC.Format = DateTimePickerFormat.Custom;
            dt_fechaDesdeC.CustomFormat = "dd/MM/yyyy";

            dt_fechaHastaC.Format = DateTimePickerFormat.Custom;
            dt_fechaHastaC.CustomFormat = "dd/MM/yyyy";
        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            // se agrega el código en un try / catch para poder capturar los errores
            try
            {
                // se crea un nuevo conector, se asigna el nombre del stored y con execute se crea el nuevo comando sql
                Conexion con = new Conexion();
                con.strQuery = "four_sizons.cerrarHotel";
                con.execute();
                con.command.CommandType = CommandType.StoredProcedure;
                // se agregan los parámetros al stored procedure
                con.command.Parameters.Add("@Cerrado_FechaI", SqlDbType.DateTime).Value = dt_fechaDesdeC.Value.ToString();
                con.command.Parameters.Add("@Cerrado_FechaF", SqlDbType.DateTime).Value = dt_fechaHastaC.Value.ToString();
                con.command.Parameters.Add("@Cerrado_Detalle", SqlDbType.NVarChar).Value = txt_detalle.Text;
                con.command.Parameters.Add("@Hotel_Codigo", SqlDbType.Decimal).Value = hotel;
                // se abre la conexión con la base de datos y se ejecuta
                con.openConection();
                con.command.ExecuteNonQuery();
                con.closeConection();

                MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ABMHotel03_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();

            con.strQuery = "SELECT Hotel_Nombre FROM FOUR_SIZONS.Hotel WHERE Hotel_Codigo = '" + hotel + "'";
            con.executeQuery();
            while (con.reader())
            {
               txt_hotelNombre.Text = con.lector.GetString(0);
            }
            con.closeConection();
            txt_hotelNombre.Enabled = false;
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
