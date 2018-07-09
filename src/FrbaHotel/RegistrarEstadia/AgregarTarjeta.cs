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
        public bool tarjetaAgregada;
        public decimal error;
        public bool valido;
        public decimal estadia;
        public decimal cliente;

        public AgregarTarjeta(decimal est)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            estadia = est;

            dt_fecha_venc.Format = DateTimePickerFormat.Custom;
            dt_fecha_venc.CustomFormat = "dd/MM/yyyy";
            
        }

        private void AgregarTarjeta_Load_1(object sender, EventArgs e)
        {

            Conexion con = new Conexion();
            con.strQuery="select Cliente_Codigo from FOUR_SIZONS.EstadiaXCliente where Estadia_Codigo = " + estadia;
            con.executeQuery();
            if(con.reader())
            {
             cliente = con.lector.GetDecimal(0);
            }
            con.closeConection();

            txt_estadiaId.Text = estadia.ToString();
            txt_estadiaId.Enabled = false;
            txt_codigoCli.Text = cliente.ToString();
            
        }
        public bool verificarObligatorios()
        {
            valido = true;

            if (txt_estadiaId.Text == "") valido = false;
            if (txt_numero.Text == "") valido = false;
            if (dt_fecha_venc.Text == "") valido = false;
            if (txt_titular.Text == "") valido = false;
            if (cb_marcaTarj.Text == "") valido = false;
            if (txt_codigoTarj.Text == "") valido = false;
            if (txt_codigoCli.Text=="") valido=false;

            return valido;
        }

        private void boton_confirmar_Click(object sender, EventArgs e)
        {
            if (verificarObligatorios() == true)
            {

                try
                {
                    Conexion con = new Conexion();
                    con.strQuery = "four_sizons.AgregarTarjeta ";
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    con.command.Parameters.Add("@Tarjeta_Numero", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_codigoTarj.Text);
                    con.command.Parameters.Add("@Tarjeta_Venc", SqlDbType.DateTime).Value = dt_fecha_venc.Value;
                    con.command.Parameters.Add("@Tarjeta_Cod", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_numero.Text);
                    con.command.Parameters.Add("@Tarjeta_Titular", SqlDbType.NVarChar).Value = txt_titular.Text;
                    con.command.Parameters.Add("@Tarjeta_Marca", SqlDbType.NVarChar).Value = cb_marcaTarj.Text;
                    con.command.Parameters.Add("@Cliente_Codigo", SqlDbType.Decimal).Value = txt_codigoCli.Text;

                    con.openConection();
                    con.command.ExecuteNonQuery();
                    con.closeConection();
                    MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    error = 1;
                    MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Por favor, complete los campos obligatorios", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }    
        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    
    }
}