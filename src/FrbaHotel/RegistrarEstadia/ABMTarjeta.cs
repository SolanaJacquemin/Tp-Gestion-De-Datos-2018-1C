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
    public partial class ABMTarjeta : Form
    {
        public bool tarjetaAgregada;
        public decimal error;
        public bool valido;
        public decimal estadia;
        public decimal cliente;
        public string modoABM;
        public string nombreStored;
        public decimal tarjeta;

        public ABMTarjeta(string modo, decimal tarjetaID, decimal clienteID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            cliente = clienteID;
            modoABM = modo;
            tarjeta = tarjetaID;

            switch (modoABM)
            {
                case "INS":
                    labelTitulo.Text = "Agregar Tarjeta";
                    break;
                case "DLT":
                    labelTitulo.Text = "Cancelar Tarjeta";
                    txt_codigoTarj.Enabled = false;
                    txt_numero.Enabled = false;
                    txt_titular.Enabled = false;
                    cb_marcaTarj.Enabled = false;
                    dt_fecha_venc.Enabled = false;
                    break;
            }

            Conexion con = new Conexion();
            con.strQuery = "SELECT * FROM FOUR_SIZONS.Tarjeta WHERE Tarjeta_Numero = " + tarjeta;
            con.executeQuery();

            while (con.reader())
            {
                txt_numero.Text = con.lector.GetDecimal(0).ToString();
                dt_fecha_venc.Value = con.lector.GetDateTime(1);
                txt_codigoTarj.Text = con.lector.GetDecimal(2).ToString();
                txt_titular.Text = con.lector.GetString(3);
                cb_marcaTarj.Text = con.lector.GetString(4);
            }

            dt_fecha_venc.Format = DateTimePickerFormat.Custom;
            dt_fecha_venc.CustomFormat = "dd/MM/yyyy";

        }

        public bool verificarObligatorios()
        {
            valido = true;
            if (txt_numero.Text == "") valido = false;
            if (dt_fecha_venc.Text == "") valido = false;
            if (txt_titular.Text == "") valido = false;
            if (cb_marcaTarj.Text == "") valido = false;
            if (txt_codigoTarj.Text == "") valido = false;

            return valido;
        }

        private void boton_confirmar_Click(object sender, EventArgs e)
        {
            if (modoABM == "INS")
            {
                tarjeta = Convert.ToDecimal(txt_numero.Text);
                nombreStored = "four_sizons.AgregarTarjeta";
            }
            else
            {
                nombreStored = "four_sizons.cancelarTarjeta";
            }
            if (verificarObligatorios() == true)
            {
                try
                {
                    Conexion con = new Conexion();
                    con.strQuery = nombreStored;
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    con.command.Parameters.Add("@Tarjeta_Numero", SqlDbType.Decimal).Value = tarjeta;
                    if (modoABM == "INS")
                    {
                        con.command.Parameters.Add("@Tarjeta_Venc", SqlDbType.DateTime).Value = dt_fecha_venc.Value.ToString();
                        con.command.Parameters.Add("@Tarjeta_Cod", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_codigoTarj.Text);
                        con.command.Parameters.Add("@Tarjeta_Titular", SqlDbType.NVarChar).Value = txt_titular.Text;
                        con.command.Parameters.Add("@Tarjeta_Marca", SqlDbType.NVarChar).Value = cb_marcaTarj.Text;
                        con.command.Parameters.Add("@Cliente_Codigo", SqlDbType.Decimal).Value = Convert.ToDecimal(cliente); 
                    }

                    con.openConection();
                    con.command.ExecuteNonQuery();
                    con.closeConection();

                    error = 0;
                    MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    error = 1;
                    MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Por favor, complete los campos obligatorios", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (error == 0) 
            {
                this.Close();
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ABMTarjeta_Load(object sender, EventArgs e)
        {
            /*Conexion con = new Conexion();
            con.strQuery = "select Cliente_Codigo from FOUR_SIZONS.EstadiaXCliente where Estadia_Codigo = " + estadia;
            con.executeQuery();
            if (con.reader())
            {
                cliente = con.lector.GetDecimal(0);
            }
            con.closeConection();

            txt_codigoCli.Text = cliente.ToString();*/
        }    
    }
}
