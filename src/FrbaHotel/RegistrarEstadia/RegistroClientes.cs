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
        public decimal cliente;
        public string busqueda;
        public bool esCliente;

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
          /*  if (check_doc.Checked || check_mail.Checked)
            {
                switch (busqueda)
                {
                    case "doc":
                        if (IsNumber(txt_nro_documento.Text) == false)
                        {
                            MessageBox.Show("El número de documento debe ser un dato numérico.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (txt_nro_documento.Text != "" && cb_tipoDocumento.Text != "")
                            {
                                Conexion con = new Conexion();
                                con.strQuery = "SELECT Cliente_Codigo, Cliente_Nombre, Cliente_Apellido, Cliente_Telefono, Cliente_Dom_Calle, Cliente_Ciudad, Cliente_Pais, Cliente_mail"
                                + " FROM FOUR_SIZONS.Cliente WHERE Cliente_TipoDoc = '" + cb_tipoDocumento.Text + "'"
                                + " AND Cliente_NumDoc = " + txt_nro_documento.Text;
                                con.executeQuery();

                                if (!con.reader())
                                {
                                    esCliente = false;
                                    DialogResult dr = MessageBox.Show("No se ha encontrado sus datos en el sistema. Desea darse de alta?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (dr == DialogResult.Yes)
                                    {
                                        con.strQuery = "";
                                        txt_nombre.Enabled = true;
                                        txt_apellido.Enabled = true;
                                        txt_telefono.Enabled = true;
                                        txt_calle.Enabled = true;
                                        txt_pais.Enabled = true;
                                        txt_ciudad.Enabled = true;
                                        txt_nroCalle.Enabled = true;
                                        txt_piso.Enabled = true;
                                        txt_depto.Enabled = true;
                                        txt_mail.Enabled = true;
                                    }
                                    else if (dr == DialogResult.No)
                                    {
                                        MessageBox.Show("Por favor revise sus datos y vuelva a intentar", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                 /*   clienteID = Convert.ToDecimal(con.lector.GetDecimal(0).ToString());
                                    txt_nombre.Text = con.lector.GetString(1);
                                    txt_apellido.Text = con.lector.GetString(2);
                                    txt_telefono.Text = con.lector.GetString(3);
                                    txt_calle.Text = con.lector.GetString(4);
                                    txt_ciudad.Text = con.lector.GetString(5);
                                    txt_pais.Text = con.lector.GetString(6);
                                    txt_mail.Text = con.lector.GetString(7);
                                    esCliente = true;
                                }

                                con.closeConection();
                                buscoCliente = true;
                                if (esCliente)
                                {
                                    check_mail.Enabled = false;
                                    check_doc.Enabled = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Por favor, ingrese tipo y número de documento.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;

                    case "mail":
                        if (txt_mail.Text != "")
                        {
                            Conexion con = new Conexion();
                            con.strQuery = "SELECT Cliente_Codigo, Cliente_Nombre, Cliente_Apellido, Cliente_Telefono, Cliente_Dom_Calle, Cliente_Ciudad, Cliente_Pais, Cliente_TipoDoc, Cliente_NumDoc"
                            + " FROM FOUR_SIZONS.Cliente WHERE Cliente_Mail = '" + txt_mail.Text + "'";

                            con.executeQuery();

                            if (!con.reader())
                            {
                                esCliente = false;
                                DialogResult dr = MessageBox.Show("No se ha encontrado sus datos en el sistema. Desea darse de alta?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (dr == DialogResult.Yes)
                                {
                                    con.strQuery = "";
                                    txt_nombre.Enabled = true;
                                    txt_apellido.Enabled = true;
                                    txt_telefono.Enabled = true;
                                    txt_calle.Enabled = true;
                                    txt_pais.Enabled = true;
                                    txt_ciudad.Enabled = true;
                                    txt_nroCalle.Enabled = true;
                                    txt_piso.Enabled = true;
                                    txt_nro_documento.Enabled = true;
                                    cb_tipoDocumento.Enabled = true;
                                    txt_depto.Enabled = true;
                                }
                                else if (dr == DialogResult.No)
                                {
                                    MessageBox.Show("Por favor revise sus datos y vuelva a intentar", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                clienteID = Convert.ToDecimal(con.lector.GetDecimal(0).ToString());
                                txt_nombre.Text = con.lector.GetString(1);
                                txt_apellido.Text = con.lector.GetString(2);
                                txt_telefono.Text = con.lector.GetString(3);
                                txt_calle.Text = con.lector.GetString(4);
                                txt_ciudad.Text = con.lector.GetString(5);
                                txt_pais.Text = con.lector.GetString(6);
                                cb_tipoDocumento.Text=con.lector.GetString(7);
                                txt_nro_documento.Text=con.lector.GetDecimal(8).ToString();
                                esCliente = true;
                            }

                            con.closeConection();
                            buscoCliente = true;
                            if (esCliente)
                            {
                                check_mail.Enabled = false;
                                check_doc.Enabled = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese su mail.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                }
            }/*
            else MessageBox.Show("Por favor, seleccione algún tipo de búsqueda.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            
                if (cliente == 0)
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
                    try
                    {
                        Conexion con2 = new Conexion();

                        con2.strQuery = "four_sizons.RegistrarEstadiaXCliente";
                        con2.execute();
                        con2.command.CommandType = CommandType.StoredProcedure;

                        con2.command.Parameters.Add("@cliente", SqlDbType.Decimal).Value = cliente;
                        con2.command.Parameters.Add("@estadia", SqlDbType.Decimal).Value = estadia;

                        con2.openConection();
                        con2.command.ExecuteNonQuery();
                        con2.closeConection();
                        MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Cliente registrado. Desea registrar más clientes?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            txt_mail.Clear();
                            cb_tipoDocumento.Text = "";
                            txt_nro_documento.Text = "";
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }*/
        }

        private void check_doc_CheckedChanged(object sender, EventArgs e)
        {
            if (check_doc.Checked)
            {
                check_mail.Checked = false;
                txt_mail.Enabled = false;
                txt_nro_documento.Enabled = true;
                cb_tipoDocumento.Enabled = true;
                busqueda = "doc";
                txt_mail.Text = "";

            }
        }

        private void check_mail_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mail.Checked)
            {
                check_doc.Checked = false;
                txt_mail.Enabled = true;
                txt_nro_documento.Enabled = false;
                cb_tipoDocumento.Enabled = false;
                busqueda = "mail";
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
