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
        public decimal hotel_id;
        public string usuario;
        public bool esAdminGral;
        public string dgv_usuario_Estado;

        public ABMUsuario01(string user, decimal HotelID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            hotel_id = HotelID;
            usuario = user;
            esAdminGral = false;

            dgv_Usuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txt_Id.ReadOnly = true;
            cb_tipodoc.DropDownStyle = ComboBoxStyle.DropDownList;
            dgv_Usuarios.Rows.Clear();

            iniciarGrilla();
            refrescarGrid();

            Conexion con = new Conexion();

            con.strQuery = "SELECT Parametro_Descripcion FROM FOUR_SIZONS.Parametros WHERE Parametro_Codigo = 'DOCUMENTO'";
            con.executeQuery();
            cb_tipodoc.Items.Add("");
            while (con.reader())
            {
                cb_tipodoc.Items.Add(con.lector.GetString(0));
            }
            con.closeConection();
        }

        private void iniciarGrilla() 
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT U.Usuario_ID, U.Usuario_Nombre, U.Usuario_Apellido, U.Usuario_TipoDoc, U.Usuario_NroDoc, U.Usuario_Telefono, U.Usuario_Direccion, U.Usuario_Fec_Nac, U.Usuario_Mail, U.Usuario_Estado, U.Usuario_FallaLog" +
                           " FROM FOUR_SIZONS.Usuario U" +
                           " JOIN FOUR_SIZONS.UsuarioXRol UR ON UR.Usuario_ID = U.Usuario_ID" +
                           " WHERE UR.Rol_Codigo = 1 AND U.Usuario_ID = '" + usuario + "'";

            con.executeQuery();


            if (con.reader())
            {
                esAdminGral = true;
            }

            con.closeConection();

            if (esAdminGral)
            {
                con.strQuery = "SELECT Usuario_ID, Usuario_Nombre, Usuario_Apellido, " +
                                "Usuario_TipoDoc, Usuario_NroDoc, Usuario_Telefono, Usuario_Direccion, " +
                                "Usuario_Fec_Nac, Usuario_Mail, Usuario_Estado, Usuario_FallaLog " +
                                "FROM FOUR_SIZONS.Usuario ORDER BY Usuario_ID";
            }
            else
            {
                con.strQuery = "SELECT U.Usuario_ID, U.Usuario_Nombre, U.Usuario_Apellido, U.Usuario_TipoDoc, U.Usuario_NroDoc, U.Usuario_Telefono, U.Usuario_Direccion, U.Usuario_Fec_Nac, U.Usuario_Mail, U.Usuario_Estado, U.Usuario_FallaLog " +
                               "FROM FOUR_SIZONS.Usuario U JOIN FOUR_SIZONS.UsuarioXHotel UH ON UH.Usuario_ID = U.Usuario_ID";
                if (hotel_id != 0)
                {
                    con.strQuery = con.strQuery + " WHERE Hotel_Codigo = " + hotel_id;
                }
                con.strQuery = con.strQuery + " ORDER BY U.Usuario_ID ";
            }

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

        private void boton_alta_Click(object sender, EventArgs e)
        {
            string modo = "INS";
            this.Hide();
            ABMUsuario02 formABMUsuario02 = new ABMUsuario02(modo, usuario, hotel_id);
            formABMUsuario02.ShowDialog();
            this.Show();
            limpiar();
            this.refrescarGrid();
        }

        private void boton_hoteles_Click(object sender, EventArgs e)
        {
            if (dgv_usuario_Estado == "False")
            {
                MessageBox.Show("El usuario está deshabilitado. Operación cancelada", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dgv_Usuarios.SelectedRows.Count > 0)
                {
                    this.Hide();
                    ABMUsuario03 formABMUsuario03 = new ABMUsuario03(dgv_usuario_ID, hotel_id);
                    formABMUsuario03.ShowDialog();
                    this.Show();
                    limpiar();
                    this.refrescarGrid();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un usuario de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void boton_baja_Click(object sender, EventArgs e)
        {
            if (dgv_usuario_Estado == "False")
            {
                MessageBox.Show("No puede dar de baja a un usuario dado de baja", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dgv_Usuarios.SelectedRows.Count > 0)
                {
                    string modo = "DLT";
                    this.Hide();
                    ABMUsuario02 formABMUsuario02 = new ABMUsuario02(modo, dgv_usuario_ID, hotel_id);
                    formABMUsuario02.ShowDialog();
                    this.Show();
                    limpiar();
                    this.refrescarGrid();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un usuario de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void boton_modificacion_Click(object sender, EventArgs e)
        {
            if (dgv_Usuarios.SelectedRows.Count > 0)
            {
                if (dgv_usuario_Estado=="False")
                {
                    if (MessageBox.Show("El usuario se encuentra inhabilitado, desea darle de alta?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string modo = "UPD";
                        this.Hide();
                        ABMUsuario02 formABMUsuario02 = new ABMUsuario02(modo, dgv_usuario_ID, hotel_id);
                        formABMUsuario02.ShowDialog();
                        this.Show();
                        limpiar();
                        this.refrescarGrid();
                    }
                }
                else
                {
                    string modo = "UPD";
                    this.Hide();
                    ABMUsuario02 formABMUsuario02 = new ABMUsuario02(modo, dgv_usuario_ID, hotel_id);
                    formABMUsuario02.ShowDialog();
                    this.Show();
                    limpiar();
                    this.refrescarGrid();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void buscar()
        {
            dgv_Usuarios.Rows.Clear();
            Conexion con = new Conexion();
            if (hotel_id == 0)
            {

                con.strQuery = "SELECT Usuario_ID, Usuario_Nombre, Usuario_Apellido, " +
                                "Usuario_TipoDoc, Usuario_NroDoc, Usuario_Telefono, Usuario_Direccion, " +
                                "Usuario_Fec_Nac, Usuario_Mail, Usuario_Estado, Usuario_FallaLog " +
                                "FROM FOUR_SIZONS.Usuario " +
                                " WHERE 1=1";
                if (txt_Id.Text != "")
                    con.strQuery = con.strQuery + "AND Usuario_ID = '" + txt_Id.Text + "' ";
                if (txt_nombre.Text != "")
                    con.strQuery = con.strQuery + "AND Usuario_Nombre like '%" + txt_nombre.Text + "%' ";
                if (txt_apellido.Text != "")
                    con.strQuery = con.strQuery + "AND Usuario_Apellido like '%" + txt_apellido.Text + "%' ";
                if (cb_tipodoc.Text != "")
                    con.strQuery = con.strQuery + "AND Usuario_TipoDoc like '%" + cb_tipodoc.Text + "%' ";
                if (txt_nrodoc.Text != "")
                    con.strQuery = con.strQuery + "AND Usuario_NroDoc like '%" + txt_nrodoc.Text + "%' ";
                if (txt_mail.Text != "")
                {
                    con.strQuery = con.strQuery + "AND Usuario_Mail like '%" + txt_mail.Text + "%' ";
                }
                con.strQuery = con.strQuery + "ORDER BY Usuario_ID";
            }else{
                con.strQuery = "SELECT U.Usuario_ID, U.Usuario_Nombre, U.Usuario_Apellido, U.Usuario_TipoDoc, U.Usuario_NroDoc, U.Usuario_Telefono, U.Usuario_Direccion, U.Usuario_Fec_Nac, U.Usuario_Mail, U.Usuario_Estado, U.Usuario_FallaLog " +
                "FROM FOUR_SIZONS.Usuario U JOIN FOUR_SIZONS.UsuarioXHotel UH ON UH.Usuario_ID = U.Usuario_ID";
                if (hotel_id != 0)
                {
                    con.strQuery = con.strQuery + " WHERE Hotel_Codigo = " + hotel_id;
                }
                con.strQuery = con.strQuery + " ORDER BY U.Usuario_ID ";
            }



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
            using (PromptUsuarios prompt = new PromptUsuarios(hotel_id))
            {
                prompt.ShowDialog();
                if (prompt.TextBox1.Text != "")
                {
                    txt_Id.Text = prompt.TextBox1.Text;
                    prompt.Close();
                }
            }
            this.Show();
        }

        public void dgv_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                DataGridViewRow selectedRow = dgv_Usuarios.Rows[index];
                dgv_usuario_ID = selectedRow.Cells[0].Value.ToString();
                dgv_usuario_Estado = selectedRow.Cells[9].Value.ToString();
            }
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

        public void limpiar()
        {
            txt_Id.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            cb_tipodoc.Text = "";
            txt_nrodoc.Text = "";
            txt_mail.Text = "";
            dgv_Usuarios.Rows.Clear();
            iniciarGrilla();
            refrescarGrid();
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
            if (dgv_usuario_Estado == "False")
            {
                MessageBox.Show("El usuario está deshabilitado. Operación cancelada", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
}
