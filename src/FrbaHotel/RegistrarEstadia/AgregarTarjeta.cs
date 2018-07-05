using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class AgregarTarjeta : Form
    {
        public AgregarTarjeta()
        {
            InitializeComponent();
        }

        private void boton_confirmar_Click(object sender, EventArgs e)
        {
      /*      //VALIDACIONES
            try
            {
                /*Conexion con = new Conexion();
                con.strQuery = "four_sizons.generarFactura ";
                con.execute();
                con.command.CommandType = CommandType.StoredProcedure;

                con.command.Parameters.Add("@estadia", SqlDbType.Decimal).Value = estadiaID;
                con.command.Parameters.Add("@formaPago", SqlDbType.NVarChar).Value = cb_formaPago.Text;

                con.openConection();
                con.command.ExecuteNonQuery();
                con.closeConection();

                    Conexion con = new Conexion();
                    con.strQuery = "four_sizons.AgregarTarjeta ";
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    con.command.Parameters.Add("@Tarjeta_Numero", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_codigoTarj.Text);
                    con.command.Parameters.Add("@Tarjeta_Venc", SqlDbType.DateTime).Value = dt_fecha_venc.Value.ToString();
                    con.command.Parameters.Add("@Tarjeta_Cod", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_numero.Text);
                    con.command.Parameters.Add("@Tarjeta_Titular", SqlDbType.NVarChar).Value = txt_titular.Text;
                    con.command.Parameters.Add("@Tarjeta_Marca", SqlDbType.NVarChar).Value = cb_marcaTarj.Text;
                    con.command.Parameters.Add("@Cliente_Codigo", SqlDbType.Decimal).Value = txt_codigoCli.Text;

                    con.openConection();
                    con.command.ExecuteNonQuery();
                    con.closeConection();
                }


                MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
          catch (Exception ex)
            {
                MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
            
        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarTarjeta_Load_1(object sender, EventArgs e)
        {
            //public FacturarEstadia01(decimal estadia)
            this.StartPosition = FormStartPosition.CenterScreen;

            dt_fecha_venc.Format = DateTimePickerFormat.Custom;
            dt_fecha_venc.CustomFormat = "dd/MM/yyyy";

            //estadiaID = estadia;
            //txt_estadiaId.Text = estadiaID.ToString();
            //txt_estadiaId.Enabled = false;
        }
    }
}
