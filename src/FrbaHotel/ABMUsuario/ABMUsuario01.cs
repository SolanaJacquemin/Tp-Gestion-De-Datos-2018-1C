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

    public partial class ABMUsuario01 : Form
    {
        public string dgv_usuario_ID;
        public int index;

        public ABMUsuario01()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dgv_Usuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txt_Id.ReadOnly = true;
            cb_tipodoc.DropDownStyle = ComboBoxStyle.DropDownList;
            dgv_Usuarios.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Usuario_ID, Usuario_Nombre, Usuario_Apellido, " +
                            "Usuario_TipoDoc, Usuario_NroDoc, Usuario_Telefono, Usuario_Direccion, " +
                            "Usuario_Fec_Nac, Usuario_Mail, Usuario_Estado, Usuario_FallaLog " +
                            "FROM FOUR_SIZONS.Usuario ORDER BY Usuario_ID";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado usuarios. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Usuarios.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1),
            con.lector.GetString(2), con.lector.GetString(3), con.lector.GetDecimal(4), con.lector.GetString(5),
            con.lector.GetString(6), con.lector.GetDateTime(7), con.lector.GetString(8), con.lector.GetBoolean(9),
            con.lector.GetDecimal(10)});

            while (con.reader())
            {
                dgv_Usuarios.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1),
                con.lector.GetString(2), con.lector.GetString(3), con.lector.GetDecimal(4), con.lector.GetString(5),
                con.lector.GetString(6), con.lector.GetDateTime(7), con.lector.GetString(8), con.lector.GetBoolean(9),
                con.lector.GetDecimal(10)});
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
            ABMUsuario02 formABMUsuario02 = new ABMUsuario02(modo, txt_Id.Text);
            formABMUsuario02.ShowDialog();
            this.Show();
            this.buscar();
            this.refrescarGrid();
        }

        private void boton_hoteles_Click(object sender, EventArgs e)
        {
            if (dgv_Usuarios.SelectedRows.Count > 0)
            {
                this.Hide();
                ABMUsuario03 formABMUsuario03 = new ABMUsuario03(dgv_usuario_ID);
                formABMUsuario03.ShowDialog();
                this.Show();
                this.buscar();
                this.refrescarGrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boton_baja_Click(object sender, EventArgs e)
        {
            if (dgv_Usuarios.SelectedRows.Count > 0)
            {
                string modo = "DLT";
                this.Hide();
                ABMUsuario02 formABMUsuario02 = new ABMUsuario02(modo, dgv_usuario_ID);
                formABMUsuario02.ShowDialog();
                this.Show();
                this.buscar();
                this.refrescarGrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void boton_modificacion_Click(object sender, EventArgs e)
        {
            if (dgv_Usuarios.SelectedRows.Count > 0)
            {
                string modo = "UPD";
                this.Hide();
                ABMUsuario02 formABMUsuario02 = new ABMUsuario02(modo, dgv_usuario_ID);
                formABMUsuario02.ShowDialog();
                this.Show();
                this.buscar();
                this.refrescarGrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void buscar()
        {
            dgv_Usuarios.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Usuario_ID, Usuario_Nombre, Usuario_Apellido, " +
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

            dgv_Usuarios.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1),
            con.lector.GetString(2), con.lector.GetString(3), con.lector.GetDecimal(4), con.lector.GetString(5),
            con.lector.GetString(6), con.lector.GetDateTime(7), con.lector.GetString(8), con.lector.GetBoolean(9),
            con.lector.GetDecimal(10)});

            while (con.reader())
            {
                dgv_Usuarios.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1),
                con.lector.GetString(2), con.lector.GetString(3), con.lector.GetDecimal(4), con.lector.GetString(5),
                con.lector.GetString(6), con.lector.GetDateTime(7), con.lector.GetString(8), con.lector.GetBoolean(9),
                con.lector.GetDecimal(10)});
            }
            con.closeConection();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_promptUsu_Click(object sender, EventArgs e)
        {
            using (PromptUsuarios prompt = new PromptUsuarios())
            {
                prompt.ShowDialog();
                txt_Id.Text = prompt.TextBox1.Text;
                prompt.Close();
            }
            this.Show();
        }

        public void dgv_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_Usuarios.Rows[index];
            dgv_usuario_ID = selectedRow.Cells[0].Value.ToString();
        }

        private void refrescarGrid()
        {
            dgv_Usuarios.ClearSelection();
            foreach (DataGridViewRow row in dgv_Usuarios.Rows)
                if (Convert.ToBoolean(row.Cells[9].Value) == false)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
        }

        private void ABMUsuario01_Load(object sender, EventArgs e)
        {
            refrescarGrid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_roles_Click(object sender, EventArgs e)
        {
            if (dgv_Usuarios.SelectedRows.Count > 0)
            {
                this.Hide();
                ABMUsuario05 formABMUsuario05 = new ABMUsuario05(dgv_usuario_ID);
                formABMUsuario05.ShowDialog();
                this.Show();
                this.buscar();
                this.refrescarGrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
