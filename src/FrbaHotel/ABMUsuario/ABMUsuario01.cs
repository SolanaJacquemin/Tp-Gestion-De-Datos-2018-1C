using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ABMUsuario
{
    public partial class ABMUsuario01 : Form
    {
        public ABMUsuario01()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dgv_Usuarios.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Usuario_ID, Usuario_Password, Usuario_Nombre, Usuario_Apellido, " +
                            "Usuario_TipoDoc, Usuario_NroDoc, Usuario_Telefono, Usuario_Direccion, " +
                            "Usuario_Fec_Nac, Usuario_Mail, Usuario_Estado, Usuario_FallaLog " +
                            "FROM FOUR_SIZONS.Usuario ORDER BY Usuario_ID";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("La busqueda no produjo resultados");
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Usuarios.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1), con.lector.GetString(2),
            con.lector.GetString(3), con.lector.GetString(4), con.lector.GetDecimal(5), con.lector.GetString(6),
            con.lector.GetString(7), con.lector.GetDateTime(8), con.lector.GetString(9), con.lector.GetBoolean(10),
            con.lector.GetDecimal(11)});

            while (con.reader())
            {
                dgv_Usuarios.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1), con.lector.GetString(2),
                con.lector.GetString(3), con.lector.GetString(4), con.lector.GetDecimal(5), con.lector.GetString(6),
                con.lector.GetString(7), con.lector.GetDateTime(8), con.lector.GetString(9), con.lector.GetBoolean(10),
                con.lector.GetDecimal(11)});
            }
            con.closeConection();

            con.strQuery = "SELECT Parametro_Descripcion FROM FOUR_SIZONS.Parametros WHERE Parametro_Codigo = 'DOCUMENTO'";
            con.executeQuery();
            while (con.reader())
            {
                cb_tipodoc.Items.Add(con.lector.GetString(0));
            }
            con.closeConection();

        }

        private void boton_alta_Click(object sender, EventArgs e)
        {
            string modo = "INS";
            this.Hide();
            ABMUsuario02 formABMUsuario02 = new ABMUsuario02(modo);
            formABMUsuario02.ShowDialog();
            this.Show();
        }

        private void ABMUsuario01_Load(object sender, EventArgs e)
        {

        }

        private void boton_baja_Click(object sender, EventArgs e)
        {
            string modo = "DLT";
            this.Hide();
            ABMUsuario02 formABMUsuario02 = new ABMUsuario02(modo);
            formABMUsuario02.ShowDialog();
            this.Show();
        }

        private void boton_modificacion_Click(object sender, EventArgs e)
        {
            string modo = "UPD";
            this.Hide();
            ABMUsuario02 formABMUsuario02 = new ABMUsuario02(modo);
            formABMUsuario02.ShowDialog();
            this.Show();
        }

        private void dgv_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_Id.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            cb_tipodoc.Text = "";
            txt_nrodoc.Text = "";
            txt_mail.Text = "";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgv_Usuarios.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Usuario_ID, Usuario_Password, Usuario_Nombre, Usuario_Apellido, " +
                            "Usuario_TipoDoc, Usuario_NroDoc, Usuario_Telefono, Usuario_Direccion, " +
                            "Usuario_Fec_Nac, Usuario_Mail, Usuario_Estado, Usuario_FallaLog " +
                            "FROM FOUR_SIZONS.Usuario " +
                            " WHERE 1=1";
                            if (txt_Id.Text != "")
                                con.strQuery = con.strQuery + "AND Usuario_ID like '%" + txt_Id.Text + "%' ";
                            if (txt_nombre.Text != "")
                                con.strQuery = con.strQuery + "AND Usuario_Nombre like '%" + txt_nombre.Text + "%' ";
                            if (txt_apellido.Text != "")
                                con.strQuery = con.strQuery + "AND Usuario_Apellido like '%" + txt_apellido.Text + "%' ";
                            if (cb_tipodoc.Text != "")
                                con.strQuery = con.strQuery + "AND Usuario_TipoDoc like '%" + cb_tipodoc.Text + "%' ";
                            if (txt_nrodoc.Text != "")
                                con.strQuery = con.strQuery + "AND Usuario_NroDoc like '%" + txt_nrodoc.Text + "%' ";
                            if (txt_mail.Text != "")
                                con.strQuery = con.strQuery + "AND Usuario_Mail like '%" + txt_mail.Text + "%' ";
                            con.strQuery = con.strQuery + "ORDER BY Usuario_ID";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado usuarios. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Usuarios.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1), con.lector.GetString(2),
            con.lector.GetString(3), con.lector.GetString(4), con.lector.GetDecimal(5), con.lector.GetString(6),
            con.lector.GetString(7), con.lector.GetDateTime(8), con.lector.GetString(9), con.lector.GetBoolean(10),
            con.lector.GetDecimal(11)});

            while (con.reader())
            {
                dgv_Usuarios.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1), con.lector.GetString(2),
                con.lector.GetString(3), con.lector.GetString(4), con.lector.GetDecimal(5), con.lector.GetString(6),
                con.lector.GetString(7), con.lector.GetDateTime(8), con.lector.GetString(9), con.lector.GetBoolean(10),
                con.lector.GetDecimal(11)});
            }
            con.closeConection();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_promptUsu_Click(object sender, EventArgs e)
        {
            ABMUsuarioPrompt formABMUsuarioPrompt = new ABMUsuarioPrompt();
            formABMUsuarioPrompt.ShowDialog();
            this.Show();
        }
        
    }
}
