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


namespace FrbaHotel.ABMUsuario
{

    public partial class ABMUsuario02 : Form
    {
        public static string modoABM;
        public string nombreSP;
        public string usuario;
        public int error;

        public ABMUsuario02(string modo, string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;

            usuario = user;
            modoABM = modo;

            txt_password.PasswordChar = '●';

            switch (modoABM)
            {
                case "INS":
                    labelTitulo.Text = "Alta de Usuario";
                    l_estado.Visible = false;
                    txt_estado.Visible = false;
                    l_log.Visible = false;
                    txt_intentoslog.Visible = false;
                    break;
                case "DLT":
                    labelTitulo.Text = "Baja de Usuario";
                    txt_usuario.Text = usuario;
                    txt_apellido.ReadOnly = true;
                    txt_direccion.ReadOnly = true;
                    txt_nombre.ReadOnly = true;
                    txt_nro_documento.ReadOnly = true;
                    txt_password.ReadOnly = true;
                    txt_telefono.ReadOnly = true;
                    txt_usuario.ReadOnly = true;
                    cb_tipo_documento.Enabled = false;
                    dt_fecha_nac.Enabled = false;
                    cb_rol.Enabled = false;
                    txt_intentoslog.ReadOnly = true;
                    txt_mail.ReadOnly = true;
                    txt_hotel.ReadOnly = true;
                    btn_aceptar_nuevo.Visible = false;
                    break;
                case "UPD":
                    labelTitulo.Text = "Modificación de Usuario";
                    txt_usuario.Text = usuario;
                    txt_usuario.ReadOnly = true;
                    txt_estado.ReadOnly = true;
                    btn_aceptar_nuevo.Visible = false;
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
            if (modoABM == "INS")
            {
                levantarCombos();
            }
            else
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
                            //con.command.Parameters.Add("@hotelNombre", SqlDbType.NVarChar).Value = txt_hotel.Text;
                            if (modoABM == "DLT")
                            {
                                con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;
                            }else if (modoABM == "UPD")
                            {
                                con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;
                            }

                            con.openConection();
                            con.command.ExecuteNonQuery();

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
            txt_hotel.Text = "";
            cb_rol.Items.Clear();
            cb_tipo_documento.Items.Clear();
            levantarCombos();
        }

        private void levantarCombos() 
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT Rol_Nombre FROM FOUR_SIZONS.Rol";
            con.executeQuery();
            while (con.reader())
            {
                cb_rol.Items.Add(con.lector.GetString(0));
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

        public void boton_aceptar_Click(object sender, EventArgs e)
        {
            error = 0;
            switch (modoABM)
            {
                case "INS":
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
            ejecutarABMUsuario(nombreSP);
            if (error == 0) 
            {
                this.Close();
            }
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
