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
            using (PromptRoles prompt = new PromptRoles())
            {
                prompt.ShowDialog();
                if (prompt.TextBox1.Text != "")
                {
                    rol = Convert.ToDecimal(prompt.TextBox1.Text);
                    txt_rol.Text = prompt.TextBox2.Text;
                }
                prompt.Close();
            }
            this.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            if (modoABM == "INS")
            {
                con.strQuery = "FOUR_SIZONS.altaUserxRol";
            }
            else if (modoABM == "DLT")
            {
                con.strQuery = "FOUR_SIZONS.bajaUserxRol";
            }

            con.execute();
            con.command.CommandType = CommandType.StoredProcedure;
            con.command.Parameters.Add("@userID", SqlDbType.NVarChar).Value = usuario;
            con.command.Parameters.Add("@rolId", SqlDbType.Decimal).Value = rol;

            con.openConection();
            con.command.ExecuteNonQuery();
            con.closeConection();

            MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void ABMUsuario06_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT R.Rol_Nombre FROM FOUR_SIZONS.UsuarioXRol UR " +
                           "JOIN FOUR_SIZONS.Rol R ON R.Rol_Codigo = UR.Rol_Codigo " +
                           "WHERE UR.Usuario_ID = '" + usuario + "' AND R.Rol_Codigo = " + rol;
            con.executeQuery();

            if (con.reader())
            {
                txt_rol.Text = con.lector.GetString(0);
            }

            con.closeConection();
        }
    }
}
