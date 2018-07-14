using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Prompts;

namespace FrbaHotel.ABMUsuario
{
    public partial class ABMUsuario06 : Form
    {
        public static string modoABM;
        public decimal rol;
        public string usuario;

        public ABMUsuario06(string modo, string user, decimal rolID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            rol = rolID;
            usuario = user;
            modoABM = modo;

            txt_rol.Enabled = false;
            switch (modoABM)
            {
                case "INS":
                    labelTitulo.Text = "Agregar Rol";
                    break;
                case "DLT":
                    labelTitulo.Text = "Eliminar Rol";
                    btn_promptUsu.Visible = false;
                    break;
            }
        }

        private void btn_promptUsu_Click(object sender, EventArgs e)
        {
            PromptRoles prompt = new PromptRoles(usuario);
            
                prompt.ShowDialog();
                if (prompt.TextBox1.Text != "")
                {
                    rol = Convert.ToDecimal(prompt.TextBox1.Text);
                    txt_rol.Text = prompt.TextBox2.Text;
                }
                prompt.Close();
            
            this.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            // se agrega el código en un try / catch para poder capturar los errores
            try 
            {
                // se crea un nuevo conector, se asigna el nombre del stored y con execute se crea el nuevo comando sql
                Conexion con = new Conexion();
                // se determina el sp a utilizar
                if (modoABM == "INS")
                {
                    con.strQuery = "FOUR_SIZONS.altaUserxRol";
                }
                else if (modoABM == "DLT")
                {
                    con.strQuery = "FOUR_SIZONS.bajaUserxRol";
                }
                con.execute();
                // se agregan los parámetros al stored procedure
                con.command.CommandType = CommandType.StoredProcedure;
                con.command.Parameters.Add("@userID", SqlDbType.NVarChar).Value = usuario;
                con.command.Parameters.Add("@rolId", SqlDbType.Decimal).Value = rol;
                // se abre la conexión con la base de datos, se ejecuta y se cierra
                con.openConection();
                con.command.ExecuteNonQuery();
                con.closeConection();

                MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ABMUsuario06_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT R.Rol_Nombre FROM FOUR_SIZONS.UsuarioXRol UR " +
                           "JOIN FOUR_SIZONS.Rol R ON R.Rol_Codigo = UR.Rol_Codigo " +
                           "WHERE R.Rol_Estado = 1 AND UR.Usuario_ID = '" + usuario + "' AND R.Rol_Codigo = " + rol;
            con.executeQuery();

            if (con.reader())
            {
                txt_rol.Text = con.lector.GetString(0);
            }

            con.closeConection();
        }
    }
}
