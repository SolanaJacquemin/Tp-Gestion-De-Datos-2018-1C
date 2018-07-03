using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.FacturarEstadia
{
    public partial class FacturarEstadia01 : Form
    {
        public decimal estadiaID;

        //public FacturarEstadia01(decimal estadia)
        public FacturarEstadia01()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dt_fecha_venc.Format = DateTimePickerFormat.Custom;
            dt_fecha_venc.CustomFormat = "dd/MM/yyyy";

            //estadiaID = estadia;
            //txt_estadiaId.Text = estadiaID.ToString();
            //txt_estadiaId.Enabled = false;
        }

        private void FacturarEstadia01_Load(object sender, EventArgs e)
        {
            cb_formaPago.Items.Add("EFECTIVO");
            cb_formaPago.Items.Add("TARJETA DE CRÉDITO");
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_facturar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                con.strQuery = "four_sizons.generarFactura ";
                con.execute();
                con.command.CommandType = CommandType.StoredProcedure;

                con.command.Parameters.Add("@estadia", SqlDbType.Decimal).Value = estadiaID;
                con.command.Parameters.Add("@formaPago", SqlDbType.NVarChar).Value = cb_formaPago.Text;

                con.openConection();
                con.command.ExecuteNonQuery();
                con.closeConection();
                
                if(cb_formaPago.Text == "TARJETA DE CRÉDITO")
                {
                    con.strQuery = "four_sizons.AgregarTarjeta ";
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    con.command.Parameters.Add("@Tarjeta_Numero", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_codigoTarj.Text);
                    con.command.Parameters.Add("@Tarjeta_Venc", SqlDbType.DateTime).Value = dt_fecha_venc.Value.ToString();
                    con.command.Parameters.Add("@Tarjeta_Cod", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_codigo.Text);
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
            }
        }
    }
}
