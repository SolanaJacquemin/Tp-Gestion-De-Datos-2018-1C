using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.ABMCliente;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class RegistroClientes : Form
    {
        public decimal estadia;
        public decimal error;

        public RegistroClientes(decimal estadiaID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            estadia = estadiaID;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool IsNumber(string s)
        {
            if (s != "")
            {
                foreach (char c in s)
                {
                    if (!Char.IsDigit(c))
                        return false;
                }
                return true;
            }
            else return false;
        }

        private void btn_registrarCliente_Click(object sender, EventArgs e)
        {
            error = 0;
            if (cb_tipoDocumento.Text == "")
            {
                error = 1;
                MessageBox.Show("El campo Tipo de Documento no puede estar vacío", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txt_nro_documento.Text == "")
            {
                error = 1;
                MessageBox.Show("El campo Nro de Documento no puede estar vacío", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (IsNumber(txt_nro_documento.Text) == false)
            {
                error = 1;
                MessageBox.Show("El campo Nro de Documento no puede contener carácteres", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txt_mail.Text == "")
            {
                error = 1;
                MessageBox.Show("El campo Mail no puede estar vacío", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (error == 0)
            {
                Conexion con = new Conexion();
                con.strQuery = "SELECT Cliente_Codigo, Cliente_Nombre, Cliente_Apellido, Cliente_Telefono, Cliente_Dom_Calle, Cliente_Ciudad, Cliente_Pais"
                + " FROM FOUR_SIZONS.Cliente WHERE Cliente_TipoDoc = '" + cb_tipoDocumento.Text + "'"
                + " AND Cliente_NumDoc = " + txt_nro_documento.Text
                + " AND Cliente_Mail = '" + txt_mail.Text + "'";
                con.executeQuery();
                //con.closeConection();

                if (!con.reader())
                {
                    //Llama a ABMCliente02
                    string tipoDoc = cb_tipoDocumento.Text;
                    decimal nroDoc = Convert.ToDecimal(txt_nro_documento.Text);
                    string mail = txt_mail.Text;
                    this.Hide();
                    ABMCliente02 formAltaCliente = new ABMCliente02("INSCHECKIN", 0, estadia, tipoDoc, nroDoc, mail);
                    formAltaCliente.ShowDialog();
                    this.Show();
                }
                else
                {
                    decimal cliente = con.lector.GetDecimal(0);
                    con.strQuery = "four_sizons.RegistrarEstadiaXCliente";
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    con.command.Parameters.Add("@cliente", SqlDbType.Decimal).Value = cliente;
                    con.command.Parameters.Add("@estadia", SqlDbType.Decimal).Value = estadia;

                    con.openConection();
                    con.command.ExecuteNonQuery();
                    con.closeConection();

                    MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void VerificaClientes_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT Parametro_Descripcion FROM FOUR_SIZONS.Parametros WHERE Parametro_Codigo = 'DOCUMENTO'";
            con.executeQuery();
            while (con.reader())
            {
                cb_tipoDocumento.Items.Add(con.lector.GetString(0));
            }
            con.closeConection();
        }
    }
}
