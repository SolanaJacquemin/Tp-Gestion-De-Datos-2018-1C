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
    public partial class RegistrarCliente : Form
    {
        public string busqueda;
        public decimal estadia;
        public decimal error;
        public decimal clienteID;
        public bool esCliente;
        public bool buscoCliente;
        public bool abm_valido;

        public RegistrarCliente(decimal estadiaID)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            estadia = estadiaID;

            txt_nombre.Enabled = false;
            txt_apellido.Enabled = false;
            txt_telefono.Enabled = false;
            txt_calle.Enabled = false;
            txt_pais.Enabled = false;
            txt_ciudad.Enabled = false;
            cb_tipoDoc.Enabled = false;
            txt_numDoc.Enabled = false;
            txt_mail.Enabled = false;
            txt_nroCalle.Enabled = false;
            txt_piso.Enabled = false;
            txt_depto.Enabled = false;
            buscoCliente = false;

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

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT Parametro_Descripcion FROM FOUR_SIZONS.Parametros WHERE Parametro_Codigo = 'DOCUMENTO'";
            con.executeQuery();
            while (con.reader())
            {
                cb_tipoDoc.Items.Add(con.lector.GetString(0));
            }
            con.closeConection();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (check_doc.Checked || check_mail.Checked)
            {
                switch (busqueda)
                {
                    case "doc":
                        if (IsNumber(txt_numDoc.Text) == false)
                        {
                            MessageBox.Show("El número de documento debe ser un dato numérico.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (txt_numDoc.Text != "" && cb_tipoDoc.Text != "")
                            {
                                Conexion con = new Conexion();
                                con.strQuery = "SELECT Cliente_Codigo, Cliente_Nombre, Cliente_Apellido, Cliente_Telefono, Cliente_Dom_Calle, Cliente_Ciudad, Cliente_Pais, Cliente_mail"
                                + " FROM FOUR_SIZONS.Cliente WHERE Cliente_TipoDoc = '" + cb_tipoDoc.Text + "'"
                                + " AND Cliente_NumDoc = " + txt_numDoc.Text;
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
                                    clienteID = Convert.ToDecimal(con.lector.GetDecimal(0).ToString());
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
                                    txt_numDoc.Enabled = true;
                                    cb_tipoDoc.Enabled = true;
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
                                cb_tipoDoc.Text=con.lector.GetString(7);
                                txt_numDoc.Text=con.lector.GetDecimal(8).ToString();
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
            }
            else MessageBox.Show("Por favor, seleccione algún tipo de búsqueda.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ejecutarABMCliente()
        {

            try
            {
                Conexion con2 = new Conexion();
                con2.strQuery = "four_sizons.AltaCliente";
                con2.execute();
                con2.command.CommandType = CommandType.StoredProcedure;
                con2.command.Parameters.Add("@codigo", SqlDbType.Decimal).Direction = ParameterDirection.Output;
                con2.command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txt_nombre.Text;
                con2.command.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = txt_apellido.Text;
                con2.command.Parameters.Add("@numDoc", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_numDoc.Text);
                con2.command.Parameters.Add("@tipoDoc", SqlDbType.NVarChar).Value = cb_tipoDoc.Text;
                con2.command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = txt_mail.Text;
                con2.command.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = txt_telefono.Text;
                con2.command.Parameters.Add("@pais", SqlDbType.NVarChar).Value = txt_pais.Text;
                con2.command.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = txt_ciudad.Text;
                con2.command.Parameters.Add("@calle", SqlDbType.NVarChar).Value = txt_calle.Text;
                con2.command.Parameters.Add("@numCalle", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_nroCalle.Text);
                con2.command.Parameters.Add("@piso", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_piso.Text);
                con2.command.Parameters.Add("@depto", SqlDbType.NVarChar).Value = txt_depto.Text;
                con2.command.Parameters.Add("@localidad", SqlDbType.NVarChar).Value = " ";
                con2.command.Parameters.Add("@nacionalidad", SqlDbType.NVarChar).Value = " ";
                con2.command.Parameters.Add("@fechaNac", SqlDbType.DateTime).Value = "01-01-1990";
                con2.openConection();
                con2.command.ExecuteNonQuery();

                clienteID = Convert.ToDecimal(con2.command.Parameters["@codigo"].Value);
                con2.closeConection();

                con2.strQuery = "four_sizons.RegistrarEstadiaXCliente";
                con2.execute();
                con2.command.CommandType = CommandType.StoredProcedure;

                con2.command.Parameters.Add("@cliente", SqlDbType.Decimal).Value = clienteID;
                con2.command.Parameters.Add("@estadia", SqlDbType.Decimal).Value = estadia;

                con2.openConection();
                con2.command.ExecuteNonQuery();
                con2.closeConection();

                MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);             
            
            }
            catch (Exception ex)
            {
                error = 1;
                MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool verificarObligatorios()
        {
            abm_valido = true;

            if (txt_nombre.Text == "") abm_valido = false;
            if (txt_apellido.Text == "") abm_valido = false;
            if (cb_tipoDoc.Text == "") abm_valido = false;
            if (txt_numDoc.Text == "") abm_valido = false;
            if (txt_telefono.Text == "") abm_valido = false;
            if (txt_calle.Text == "") abm_valido = false;
            if (txt_nroCalle.Text == "") abm_valido = false;
            if (txt_mail.Text == "") abm_valido = false;
            if (txt_pais.Text == "") abm_valido = false;
            if (txt_piso.Text == "") txt_piso.Text = "0";

            return abm_valido;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            error = 0;
            if (!buscoCliente)
            {
                MessageBox.Show("Por favor, haga click en buscar antes de continuar.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!esCliente)
                {

                    if (verificarObligatorios() == false)
                    {
                        error = 1;
                        MessageBox.Show("Por favor, complete los campos obligatorios", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (IsNumber(txt_numDoc.Text) == false && txt_numDoc.Text != "")
                    {
                        error = 1;
                        MessageBox.Show("Por favor, el número de documento debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (IsNumber(txt_piso.Text) == false && txt_piso.Text != "")
                    {
                        error = 1;
                        MessageBox.Show("Por favor, el piso debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (IsNumber(txt_nroCalle.Text) == false && txt_nroCalle.Text != "")
                    {
                        error = 1;
                        MessageBox.Show("Por favor, el número de calle debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if(error==0) ejecutarABMCliente();
                }
                else
                {
                    
                    if (error == 0)
                    {
                        try
                        {
                            Conexion con = new Conexion();

                            con.strQuery = "four_sizons.RegistrarEstadiaXCliente";
                            con.execute();
                            con.command.CommandType = CommandType.StoredProcedure;

                            con.command.Parameters.Add("@cliente", SqlDbType.Decimal).Value = clienteID;
                            con.command.Parameters.Add("@estadia", SqlDbType.Decimal).Value = estadia;

                            con.openConection();
                            con.command.ExecuteNonQuery();
                            con.closeConection();
                            MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (MessageBox.Show("Cliente registrado. Desea registrar más clientes?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                txt_mail.Clear();
                                cb_tipoDoc.Text = "";
                                txt_numDoc.Text = "";
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }
            }

            if (error == 0) 
            {
                if (MessageBox.Show("Desea registrar otro cliente?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txt_apellido.Clear();
                    txt_calle.Clear();
                    txt_ciudad.Clear();
                    txt_depto.Clear();
                    txt_mail.Clear();
                    txt_nombre.Clear();
                    txt_nroCalle.Clear();
                    txt_numDoc.Clear();
                    txt_pais.Clear();
                    txt_telefono.Clear();
                    cb_tipoDoc.Text = "";
                    check_mail.Checked = false;
                    check_doc.Checked = false;
                }
                else 
                {
                    this.Close();
                }
            }
        }

        private void check_doc_CheckedChanged(object sender, EventArgs e)
        {
            if (check_doc.Checked)
            {
                check_mail.Checked = false;
                txt_mail.Enabled = false;
                txt_numDoc.Enabled = true;
                cb_tipoDoc.Enabled = true;
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
                txt_numDoc.Enabled = false;
                cb_tipoDoc.Enabled = false;
                busqueda = "mail";
            }
        }

        

        private void btn_vovler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
