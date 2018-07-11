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
using FrbaHotel.Prompts;

namespace FrbaHotel.ABMCliente
{

    public partial class ABMCliente02 : Form
    {
        public static string modoABM;
        public string nombre_sp;
        public int error;
        public bool abm_valido;
        public decimal cliente;
        public decimal estadia;
        public string tipoDoc;
        public decimal nroDoc;
        public string mail;

        public ABMCliente02(string modo, decimal clienteID, decimal estadiaCheckin, string tipoDocCheckin, decimal nroDocCheckin, string mailCheckin)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            modoABM = modo;
            cliente = clienteID;
            cb_tipo_doc.DropDownStyle = ComboBoxStyle.DropDownList;
            levantarCombos();

            switch (modoABM)
            {
                case "INS":
                    labelTitulo.Text = "Alta de Cliente";
                    txt_puntos.Visible = false;
                    lpuntos.Visible = false;
                    lbl_estado.Visible = false;
                    txt_estado.Visible = false;
                    break;

                case "INSCHECKIN":
                    labelTitulo.Text = "Alta de Cliente";
                    txt_puntos.Visible = false;
                    lpuntos.Visible = false;
                    lbl_estado.Visible = false;
                    txt_estado.Visible = false;
                    estadia = estadiaCheckin;
                    tipoDoc = tipoDocCheckin;
                    nroDoc = nroDocCheckin;
                    mail = mailCheckin;
                    cb_tipo_doc.Text = tipoDoc;
                    txt_nro_doc.Text = nroDoc.ToString();
                    txt_mail.Text = mail;
                    break;

                case "DLT":
                    labelTitulo.Text = "Baja de Cliente";
                    btn_aceptar_nuevo.Visible = false;
                    txt_nombre.Enabled = false;
                    txt_apellido.Enabled = false;
                    cb_tipo_doc.Enabled = false;
                    txt_nro_doc.Enabled = false;
                    txt_localidad.Enabled = false;
                    txt_direccion.Enabled = false;
                    txt_nro_calle.Enabled = false;
                    txt_piso.Enabled = false;
                    txt_departamento.Enabled = false;
                    txt_mail.Enabled = false;
                    txt_telefono.Enabled = false;
                    txt_pais.Enabled = false;
                    txt_ciudad.Enabled = false;
                    txt_nacionalidad.Enabled = false;
                    dt_fecha_nac.Enabled = false;
                    txt_puntos.Enabled = false;
                    txt_estado.Enabled = false;
                    lbl_obligacion.Visible = false;
                    sacarAsteriscos();
                    break;

                case "UPD":
                    txt_estado.Visible = false;
                    lbl_estado.Visible = false;
                    labelTitulo.Text = "Modificación de Cliente";
                    btn_aceptar_nuevo.Visible = false;
                    lbl_obligacion.Visible = false;
                    sacarAsteriscos();
                    break;
            }

            dt_fecha_nac.Format = DateTimePickerFormat.Custom;
            dt_fecha_nac.CustomFormat = "dd/MM/yyyy";
        }

        public void sacarAsteriscos()
        {
            a1.Visible = false;
            a2.Visible = false;
            a3.Visible = false;
            a4.Visible = false;
            a5.Visible = false;
            a6.Visible = false;
            a7.Visible = false;
            a8.Visible = false;
            a9.Visible = false;
            a10.Visible = false;
            a11.Visible = false;
            a12.Visible = false;
            a13.Visible = false;
            a14.Visible = false;
        }

        private void ABMCliente02_Load(object sender, EventArgs e)
        {
            //levantarCombos();
            Conexion con = new Conexion();
            if (modoABM != "INS")
            {

                con.strQuery = "SELECT * FROM FOUR_SIZONS.Cliente WHERE Cliente_Codigo = '" + cliente + "'";
                con.executeQuery();

                while (con.reader())
                {
                    txt_nombre.Text = con.lector.GetString(1);
                    txt_apellido.Text = con.lector.GetString(2);
                    cb_tipo_doc.Text = con.lector.GetString(3);
                    txt_nro_doc.Text = con.lector.GetDecimal(4).ToString();
                    txt_localidad.Text = con.lector.GetString(5);
                    txt_direccion.Text = con.lector.GetString(6);
                    txt_nro_calle.Text = con.lector.GetDecimal(7).ToString();
                    txt_piso.Text = con.lector.GetDecimal(8).ToString();
                    txt_departamento.Text = con.lector.GetString(9);
                    txt_mail.Text = con.lector.GetString(10);
                    txt_telefono.Text = con.lector.GetString(11);
                    txt_pais.Text = con.lector.GetString(12);
                    txt_ciudad.Text = con.lector.GetString(13);
                    txt_nacionalidad.Text = con.lector.GetString(14);
                    dt_fecha_nac.Value = con.lector.GetDateTime(15);
                    txt_estado.Text = con.lector.GetBoolean(17).ToString();
                    
                    if (con.lector.GetBoolean(17))
                    {
                        txt_estado.Text = "ACTIVO";
                        txt_estado.BackColor = Color.WhiteSmoke;
                        txt_estado.ForeColor = Color.Green;

                    }
                    else
                    {
                        txt_estado.Text = "INACTIVO";
                        txt_estado.BackColor = Color.WhiteSmoke;
                        txt_estado.ForeColor = Color.Red;
                    }
                }

                con.closeConection();
            }     
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

            if (modoABM != "DLT")
            {
                error = 0;
                if (verificarObligatorios() == false)
                {
                    error = 1;
                    MessageBox.Show("Por favor, complete los campos obligatorios", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                if (IsNumber(txt_nro_doc.Text) == false)
                {
                    error = 1;
                    MessageBox.Show("Por favor, el número de documento debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                if (IsNumber(txt_piso.Text) == false && txt_piso.Text != "")
                {
                    error = 1;
                    MessageBox.Show("Por favor, el piso debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                if (IsNumber(txt_nro_calle.Text) == false && txt_nro_calle.Text !="")
                {
                    error = 1;
                    MessageBox.Show("Por favor, el número de calle debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            }

            switch (modoABM)
            {
                case "INS":
                    nombre_sp = "FOUR_SIZONS.AltaCliente";
                    break;

                case "UPD":

                    nombre_sp = "FOUR_SIZONS.ModificacionCliente";
                    break;

                case "DLT":
                    // Baja lógica - Se pone estado en 0
                    nombre_sp = "FOUR_SIZONS.ModificacionCliente";
                    break;
            }

            if (error == 0)
            {
                if (modoABM != "INSCHECKIN")
                {
                    ejecutarABMCliente(nombre_sp);
                    this.Close();
                }
                else 
                {
                    ejecutarABMClienteCheckIn();
                }
            }
        }

        private void ejecutarABMClienteCheckIn()
        {
            try
            {
                Conexion con = new Conexion();
                con.strQuery = "FOUR_SIZONS.AltaCliente";
                con.execute();
                con.command.CommandType = CommandType.StoredProcedure;

                con.command.Parameters.Add("@codigo", SqlDbType.Decimal).Direction = ParameterDirection.Output;
                con.command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txt_nombre.Text;
                con.command.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = txt_apellido.Text;
                con.command.Parameters.Add("@numDoc", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_nro_doc.Text);
                con.command.Parameters.Add("@tipoDoc", SqlDbType.NVarChar).Value = cb_tipo_doc.Text;
                con.command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = txt_mail.Text;
                con.command.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = txt_telefono.Text;
                con.command.Parameters.Add("@pais", SqlDbType.NVarChar).Value = txt_pais.Text;
                con.command.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = txt_ciudad.Text;
                con.command.Parameters.Add("@calle", SqlDbType.NVarChar).Value = txt_direccion.Text;
                con.command.Parameters.Add("@numCalle", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_nro_calle.Text);
                con.command.Parameters.Add("@piso", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_piso.Text);
                con.command.Parameters.Add("@depto", SqlDbType.NVarChar).Value = txt_departamento.Text;
                con.command.Parameters.Add("@localidad", SqlDbType.NVarChar).Value = txt_localidad.Text;
                con.command.Parameters.Add("@nacionalidad", SqlDbType.NVarChar).Value = txt_nacionalidad.Text;
                con.command.Parameters.Add("@fechaNac", SqlDbType.DateTime).Value = dt_fecha_nac.Value.ToString();

                con.openConection();
                con.command.ExecuteNonQuery();

                cliente = Convert.ToDecimal(con.command.Parameters["@codigo"].Value);

                con.closeConection();

                con.strQuery = "four_sizons.RegistrarEstadiaXCliente";
                con.execute();
                con.command.CommandType = CommandType.StoredProcedure;

                con.command.Parameters.Add("@cliente", SqlDbType.Decimal).Value = cliente;
                con.command.Parameters.Add("@estadia", SqlDbType.Decimal).Value = estadia;

                con.openConection();
                con.command.ExecuteNonQuery();
                con.closeConection();

                MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                error = 1;
                MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_aceptar_nuevo_Click(object sender, EventArgs e)
        {
            error = 0;
            if (verificarObligatorios() == false)
            {
                error = 1;
                MessageBox.Show("Por favor, complete los campos obligatorios", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            if (IsNumber(txt_nro_doc.Text) == false)
            {
                error = 1;
                MessageBox.Show("Por favor, el número de documento debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            if (IsNumber(txt_piso.Text) == false && txt_piso.Text != "")
            {
                error = 1;
                MessageBox.Show("Por favor, el piso debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            if (IsNumber(txt_nro_calle.Text) == false && txt_nro_calle.Text != "")
            {
                error = 1;
                MessageBox.Show("Por favor, el número de calle debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            if (error == 0)
            {

                if (modoABM != "INSCHECKIN")
                {
                    nombre_sp = "FOUR_SIZONS.AltaCliente";
                    ejecutarABMCliente(nombre_sp);
                    cb_tipo_doc.Text = "";
                    txt_nro_doc.Text = "";
                    txt_direccion.Text = "";
                    txt_telefono.Text = "";
                    txt_mail.Text = "";
                    txt_nombre.Text = "";
                    txt_piso.Text = "";
                    txt_nro_calle.Text = "";
                    txt_apellido.Text = "";
                    txt_nacionalidad.Text = "";
                    txt_localidad.Text = "";
                    txt_pais.Text = "";
                    txt_ciudad.Text = "";
                }
                else
                {
                    ejecutarABMClienteCheckIn();
                    cb_tipo_doc.Text = "";
                    txt_nro_doc.Text = "";
                    txt_direccion.Text = "";
                    txt_telefono.Text = "";
                    txt_mail.Text = "";
                    txt_nombre.Text = "";
                    txt_piso.Text = "";
                    txt_nro_calle.Text = "";
                    txt_apellido.Text = "";
                    txt_nacionalidad.Text = "";
                    txt_localidad.Text = "";
                    txt_pais.Text = "";
                    txt_ciudad.Text = "";
                }

            }
        }

        public bool verificarObligatorios()
        {
            abm_valido = true;

            if (txt_nombre.Text == "") abm_valido = false;
            if (txt_apellido.Text == "") abm_valido = false;
            if (cb_tipo_doc.Text == "") abm_valido= false;
            if (txt_nro_doc.Text == "") abm_valido = false;
            if (txt_telefono.Text == "") abm_valido = false;
            if (txt_direccion.Text == "") abm_valido = false;
            if (dt_fecha_nac.Text == "") abm_valido = false;
            if (txt_nro_calle.Text == "") abm_valido = false;
            if (txt_mail.Text == "") abm_valido = false;
            if (txt_nacionalidad.Text == "") abm_valido = false;
            if (txt_piso.Text == "") txt_piso.Text = "0";

            return abm_valido;
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

        private void levantarCombos()
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT Parametro_Descripcion FROM FOUR_SIZONS.Parametros WHERE Parametro_Codigo = 'DOCUMENTO'";
            con.executeQuery();

            cb_tipo_doc.Items.Clear();
            while (con.reader())
            {
                cb_tipo_doc.Items.Add(con.lector.GetString(0));
            }
            con.closeConection();
        }
             
         public void ejecutarABMCliente(string nombreStored)
         {
            if (MessageBox.Show("Está seguro que desea continuar con la operación?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                        try
                        {
                            Conexion con = new Conexion();
                            con.strQuery = nombreStored;
                            con.execute();
                            con.command.CommandType = CommandType.StoredProcedure;

                            if (modoABM == "INS")
                            {
                                con.command.Parameters.Add("@codigo", SqlDbType.Decimal).Direction = ParameterDirection.Output;
                            }
                            else
                            {
                                con.command.Parameters.Add("@codigo", SqlDbType.NVarChar).Value = cliente;
                            }
                            con.command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txt_nombre.Text;
                            con.command.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = txt_apellido.Text;
                            con.command.Parameters.Add("@numDoc", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_nro_doc.Text);
                            con.command.Parameters.Add("@tipoDoc", SqlDbType.NVarChar).Value = cb_tipo_doc.Text;
                            con.command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = txt_mail.Text;
                            con.command.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = txt_telefono.Text;
                            con.command.Parameters.Add("@pais", SqlDbType.NVarChar).Value = txt_pais.Text;
                            con.command.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = txt_ciudad.Text;
                            con.command.Parameters.Add("@calle", SqlDbType.NVarChar).Value = txt_direccion.Text;
                            con.command.Parameters.Add("@numCalle", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_nro_calle.Text);
                            con.command.Parameters.Add("@piso", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_piso.Text);
                            con.command.Parameters.Add("@depto", SqlDbType.NVarChar).Value = txt_departamento.Text;
                            con.command.Parameters.Add("@localidad", SqlDbType.NVarChar).Value = txt_localidad.Text;
                            con.command.Parameters.Add("@nacionalidad", SqlDbType.NVarChar).Value = txt_nacionalidad.Text;
                            con.command.Parameters.Add("@fechaNac", SqlDbType.DateTime).Value = dt_fecha_nac.Value.ToString();
                            if (modoABM == "DLT")
                            {
                                con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;
                            }
                            else if (modoABM == "UPD")
                            {
                                con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;
                            }
                            
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
             
        }
         
    }

}
