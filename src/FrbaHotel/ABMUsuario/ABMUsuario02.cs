using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.ABMUsuario;
using FrbaHotel.Prompts;

namespace FrbaHotel.ABMUsuario
{
    public partial class ABMUsuario02 : Form
    {
        public static string modoABM;
        public string nombreSP;
        public string usuario;
        public int error;
        public decimal hotel;
        public decimal hotelppal;
        public bool esAdminGral;
        public bool abm_valido;

        public ABMUsuario02(string modo, string user, decimal hotelID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;

            usuario = user;
            modoABM = modo;
            hotelppal = hotelID;
            esAdminGral = false;

            txt_password.PasswordChar = '●';

            switch (modoABM)
            {
                case "INS":
                    labelTitulo.Text = "Alta de Usuario";
                    l_estado.Visible = false;
                    txt_estado.Visible = false;
                    l_log.Visible = false;
                    txt_intentoslog.Visible = false;
                    txt_hotel.Enabled = false;
                    cb_tipo_documento.DropDownStyle = ComboBoxStyle.DropDownList;
                    cb_rol.DropDownStyle = ComboBoxStyle.DropDownList;
                    break;
                case "DLT":
                    labelTitulo.Text = "Baja de Usuario";
                    txt_usuario.Text = usuario;
                    txt_apellido.Enabled = false;
                    txt_direccion.Enabled = false;
                    txt_nombre.Enabled = false;
                    txt_nro_documento.Enabled = false;
                    txt_password.Enabled = false;
                    txt_telefono.Enabled = false;
                    txt_usuario.Enabled = false;
                    cb_tipo_documento.Enabled = false;
                    dt_fecha_nac.Enabled = false;
                    cb_rol.Enabled = false;
                    txt_intentoslog.Enabled = false;
                    txt_mail.Enabled = false;
                    lhotel.Visible = false;
                    txt_hotel.Visible = false;
                    btn_promptHotel.Visible = false;
                    lbl_obligacion.Visible = false;
                    txt_estado.Enabled = false;
                    
                    break;
                case "UPD":
                    labelTitulo.Text = "Modificación de Usuario";
                    txt_usuario.Text = usuario;
                    txt_usuario.ReadOnly = true;
                    txt_estado.Visible = false;
                    l_estado.Visible = false;
                    lhotel.Visible = false;
                    txt_hotel.Visible = false;
                    btn_promptHotel.Visible = false;
                    cb_tipo_documento.DropDownStyle = ComboBoxStyle.DropDownList;
                    cb_rol.DropDownStyle = ComboBoxStyle.DropDownList;
                    break;
            }
            dt_fecha_nac.Format = DateTimePickerFormat.Custom;
            dt_fecha_nac.CustomFormat = "dd/MM/yyyy";

            //levantarCombos();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ABMUsuario_Load(object sender, EventArgs e)
        {
            levantarCombos();
            if (modoABM != "INS")
            {
                Conexion con = new Conexion();
                con.strQuery = "SELECT * FROM FOUR_SIZONS.Usuario WHERE Usuario_ID = '" + usuario + "'";
                con.executeQuery();

                while (con.reader())
                {
                    txt_password.Text = con.lector.GetString(1);
                    txt_nombre.Text = con.lector.GetString(2);
                    txt_apellido.Text = con.lector.GetString(3);
                    cb_tipo_documento.Text = con.lector.GetString(4);
                    txt_nro_documento.Text = con.lector.GetDecimal(5).ToString();
                    txt_telefono.Text = con.lector.GetString(6);
                    txt_direccion.Text = con.lector.GetString(7);
                    dt_fecha_nac.Value = con.lector.GetDateTime(8);
                    txt_mail.Text = con.lector.GetString(9);
                    if (con.lector.GetBoolean(10))
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
                    txt_intentoslog.Text = con.lector.GetDecimal(11).ToString();
                }

                con.closeConection();

                con.strQuery = "SELECT R.Rol_Nombre FROM FOUR_SIZONS.UsuarioXRol AS UR" +
                " JOIN FOUR_SIZONS.Rol AS R ON UR.Rol_Codigo= R.Rol_Codigo" +
                " WHERE UR.Usuario_ID = '" + usuario + "'";
                con.executeQuery();

                while (con.reader())
                {
                    cb_rol.Text = con.lector.GetString(0);
                }
                con.closeConection();
            }else{
                if ((modoABM == "INS") && (hotelppal != 0))
                {
                    Conexion con = new Conexion();
                    btn_promptHotel.Enabled = false;
                    con.strQuery = "SELECT H.Hotel_Nombre FROM FOUR_SIZONS.Hotel H WHERE H.Hotel_Codigo = " + hotelppal;
                    con.executeQuery();
                    if (con.reader())
                    {
                        txt_hotel.Text = con.lector.GetString(0);
                    }
                    con.closeConection();
                }

                if (modoABM == "DLT")
                {
                    Conexion con = new Conexion();
                    btn_promptHotel.Enabled = false;
                    con.strQuery = "SELECT H.Hotel_Nombre FROM FOUR_SIZONS.UsuarioXHotel UH " +
                                   "JOIN FOUR_SIZONS.Hotel H ON H.Hotel_Codigo = UH.Hotel_Codigo " +
                                   "WHERE UH.Usuario_ID = '" + usuario + "' AND H.Hotel_Codigo = " + hotelppal;
                    con.executeQuery();
                    if (con.reader())
                    {
                        txt_hotel.Text = con.lector.GetString(0);
                    }
                    con.closeConection();
                }

            }

        }

        public void ejecutarABMUsuario(string nombreStored)
        {
            if (MessageBox.Show("Está seguro que desea continuar con la operación?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        try
                        {
                            Conexion con = new Conexion();
                            Encriptor encriptor = new Encriptor();
                            con.strQuery = nombreStored;
                            con.execute();
                            con.command.CommandType = CommandType.StoredProcedure;

                            con.command.Parameters.Add("@username", SqlDbType.NVarChar).Value = txt_usuario.Text;
                            string msg = encriptor.Encrypt(txt_password.Text);
                            con.command.Parameters.Add("@password", SqlDbType.NVarChar).Value = encriptor.Encrypt(txt_password.Text);
                            con.command.Parameters.Add("@rolNombre", SqlDbType.NVarChar).Value = cb_rol.Text;
                            con.command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txt_nombre.Text;
                            con.command.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = txt_apellido.Text;
                            con.command.Parameters.Add("@tipoDoc", SqlDbType.NVarChar).Value = cb_tipo_documento.Text;
                            con.command.Parameters.Add("@numDoc", SqlDbType.Int).Value = txt_nro_documento.Text;
                            con.command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = txt_mail.Text;
                            con.command.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = txt_telefono.Text;
                            con.command.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = txt_direccion.Text;
                            con.command.Parameters.Add("@fechanac", SqlDbType.DateTime).Value = dt_fecha_nac.Value.ToString();

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

                            if (modoABM == "INS")
                            {
                                con.strQuery = "FOUR_SIZONS.altaUserXHot";
                                con.execute();
                                con.command.CommandType = CommandType.StoredProcedure;
                                if (hotel == 0)
                                {
                                    hotel = hotelppal;
                                }
                                con.command.Parameters.Add("@hotId", SqlDbType.Decimal).Value = hotel;
                                con.command.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = txt_usuario.Text;
                                if (modoABM == "DLT")
                                {
                                    con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;
                                }
                                else
                                {
                                    con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;
                                }
                                con.openConection();
                                con.command.ExecuteNonQuery();
                                con.closeConection();
                            }
                            MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            error = 1;
                            MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        error = 1;
                        MessageBox.Show("No se ha completado la operación", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
        }

        public void boton_aceptar_nuevo_Click(object sender, EventArgs e) 
        {
            error = 0;
            verificarCampos();
            if (error == 0)
            {
                nombreSP = "FOUR_SIZONS.AltaUsuario";
                ejecutarABMUsuario(nombreSP);
                txt_usuario.Text = "";
                txt_password.Text = "";
                cb_rol.Text = "";
                cb_tipo_documento.Text = "";
                txt_nro_documento.Text = "";
                txt_direccion.Text = "";
                txt_telefono.Text = "";
                txt_mail.Text = "";
                txt_nombre.Text = "";
                txt_apellido.Text = "";
                cb_rol.Items.Clear();
                cb_tipo_documento.Items.Clear();
                levantarCombos();
            }
        }

        private void levantarCombos() 
        {
            Conexion con = new Conexion();

            con.strQuery = "SELECT R.Rol_Codigo FROM FOUR_SIZONS.UsuarioXRol AS UR" +
            " JOIN FOUR_SIZONS.Rol AS R ON UR.Rol_Codigo= R.Rol_Codigo" +
            " WHERE UR.Usuario_ID = '" + usuario + "'";
            con.executeQuery();

            if (con.reader())
            {
                if(Convert.ToDecimal(con.lector.GetDecimal(0)) == 1)
                {
                    esAdminGral = true;
                }     
            }
            con.closeConection();

            con.strQuery = "SELECT Rol_Nombre FROM FOUR_SIZONS.Rol WHERE Rol_Estado = 1";
            con.executeQuery();
            while (con.reader())
            {
                if (con.lector.GetString(0) == "Administrador General")
                {
                    if (esAdminGral)
                    {
                        cb_rol.Items.Add(con.lector.GetString(0));
                    }
                }else{
                    if (con.lector.GetString(0) != "Guest")
                    {
                        cb_rol.Items.Add(con.lector.GetString(0));
                    }
                }
            }
            con.closeConection();

            
            con.strQuery = "SELECT Parametro_Descripcion FROM FOUR_SIZONS.Parametros WHERE Parametro_Codigo = 'DOCUMENTO'";
            con.executeQuery();
            while (con.reader())
            {
                cb_tipo_documento.Items.Add(con.lector.GetString(0));
            }
            con.closeConection();
        }

        private void verificarCampos()
        {
            if(txt_usuario.Text == ""||cb_rol.Text==""||txt_password.Text==""||txt_nombre.Text==""||txt_apellido.Text==""||cb_tipo_documento.Text==""||txt_nro_documento.Text==""||txt_telefono.Text==""||txt_direccion.Text==""||txt_mail.Text==""||txt_hotel.Text=="")
            {
                error = 1;
                MessageBox.Show("Por favor, complete todos los datos obligatorios.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (IsNumber(txt_nro_documento.Text) == false)
            {
                error = 1;
                MessageBox.Show("El campo Nro. de Documento debe ser un dato numérico.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
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

        public void boton_aceptar_Click(object sender, EventArgs e)
        {
            error = 0;
            
            if (error == 0)
            {
                switch (modoABM)
                {
                    case "INS":
                        verificarCampos();
                        nombreSP = "FOUR_SIZONS.AltaUsuario";
                        break;

                    case "UPD":
                        nombreSP = "FOUR_SIZONS.ModificacionUsuario";
                        break;

                    case "DLT":
                        // Baja lógica - Se pone estado en 0
                        nombreSP = "FOUR_SIZONS.ModificacionUsuario";
                        break;
                }
                
                if (error == 0)
                {
                    ejecutarABMUsuario(nombreSP);
                    this.Close();
                }
            }
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_promptUsu_Click(object sender, EventArgs e)
        {
            /*using (PromptHoteles prompt = new PromptHoteles())
            {
                prompt.ShowDialog();

                hotel_id = Convert.ToDecimal(prompt.TextBox1.Text);
                txt_hotel.Text = prompt.TextBox2.Text;
                
                prompt.Close();
            }
            this.Show();*/
        }

        private void btn_promptHotel_Click(object sender, EventArgs e)
        {
            using (PromptHoteles prompt = new PromptHoteles())
            {
                prompt.ShowDialog();

                if (prompt.TextBox1.Text != "")
                {
                    hotel = Convert.ToDecimal(prompt.TextBox1.Text);
                    txt_hotel.Text = prompt.TextBox2.Text;
                }
                prompt.Close();
                }
            this.Show();
        }

        public bool verificarObligatorios()
        {
            abm_valido = true;

            if (txt_nombre.Text == "") abm_valido = false;
            if (cb_tipo_documento.Text == "") abm_valido = false;
            if (txt_nro_documento.Text == "") abm_valido = false;
            if (txt_apellido.Text == "") abm_valido = false;
            if (txt_usuario.Text == "") abm_valido = false;
            if (txt_telefono.Text == "") abm_valido = false;
            if (txt_direccion.Text == "") abm_valido = false;
            if (txt_mail.Text == "") abm_valido = false;
            if (txt_hotel.Text == "") abm_valido = false;
            if (cb_rol.Text == "") abm_valido = false;
            if (txt_password.Text == "") abm_valido = false;

            return abm_valido;
        }

    }
}
