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

namespace FrbaHotel.ABMHotel
{
    public partial class ABMHotel01 : Form
    {
        public string dgv_hotel_codigo;
        public int index;
        public decimal hotel;
        public string usuario;
        public bool esAdminGral;

        public ABMHotel01(decimal hotelID, string userID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            hotel = hotelID;
            usuario = userID;
            esAdminGral = false;

            Conexion con = new Conexion();
            con.strQuery = "select Rol_Codigo from FOUR_SIZONS.UsuarioXRol Where Usuario_ID = '" + usuario + "'";
            con.executeQuery();
            if (con.reader())
            {
                esAdminGral = true;
            }
            con.closeConection();

            dgv_Hoteles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Hoteles.Rows.Clear();

            cb_estrellas.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_estrellas.Items.Add("");
            cb_estrellas.Items.Add("1");
            cb_estrellas.Items.Add("2");
            cb_estrellas.Items.Add("3");
            cb_estrellas.Items.Add("4");
            cb_estrellas.Items.Add("5");
            txt_codigo.Enabled = false;
        }

        public void iniciarGrilla()
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT * FROM FOUR_SIZONS.Hotel ";
            if ((hotel != 0) && (esAdminGral == false))
            {
                con.strQuery = con.strQuery + " WHERE Hotel_Codigo = " + hotel;
            }
            con.strQuery = con.strQuery + " ORDER BY Hotel_Codigo";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado hoteles. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Hoteles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
            con.lector.GetString(2), con.lector.GetString(3), con.lector.GetString(4), con.lector.GetDecimal(5),
            con.lector.GetDecimal(6), con.lector.GetDecimal(7), con.lector.GetString(8), con.lector.GetString(9),
            con.lector.GetDateTime(10), con.lector.GetBoolean(11)});

            while (con.reader())
            {
                dgv_Hoteles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
                con.lector.GetString(2), con.lector.GetString(3), con.lector.GetString(4), con.lector.GetDecimal(5),
                con.lector.GetDecimal(6), con.lector.GetDecimal(7), con.lector.GetString(8), con.lector.GetString(9),
                con.lector.GetDateTime(10), con.lector.GetBoolean(11)});
            }
            con.closeConection();

            dgv_Hoteles.ClearSelection();
            foreach (DataGridViewRow row in dgv_Hoteles.Rows)
                if (Convert.ToBoolean(row.Cells[11].Value) == false)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
        }

        private void buscar()
        {
            dgv_Hoteles.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT * FROM FOUR_SIZONS.Hotel WHERE 1=1";
            if (txt_codigo.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_Codigo =" + hotel;
            if (txt_nombre.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_Nombre like '%" + txt_nombre.Text + "%' ";
            if (txt_mail.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_Mail like '%" + txt_mail.Text + "%' ";
            if (txt_telefono.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_Telefono like '%" + txt_telefono.Text + "%' ";
            if (txt_calle.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_Calle like '%" + txt_calle.Text + "%' ";
            if (cb_estrellas.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_CantEstrella = " + cb_estrellas.Text + " ";
            if (txt_ciudad.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_Ciudad like '%" + txt_ciudad.Text + "%' ";
            if (txt_pais.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_Pais like '%" + txt_pais.Text + "%' ";
            con.strQuery = con.strQuery + "ORDER BY Hotel_Codigo";
            con.executeQuery();

            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado hoteles. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Hoteles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
            con.lector.GetString(2), con.lector.GetString(3), con.lector.GetString(4), con.lector.GetDecimal(5),
            con.lector.GetDecimal(6), con.lector.GetDecimal(7), con.lector.GetString(8), con.lector.GetString(9),
            con.lector.GetDateTime(10), con.lector.GetBoolean(11)});

            while (con.reader())
            {
                dgv_Hoteles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
                con.lector.GetString(2), con.lector.GetString(3), con.lector.GetString(4), con.lector.GetDecimal(5),
                con.lector.GetDecimal(6), con.lector.GetDecimal(7), con.lector.GetString(8), con.lector.GetString(9),
                con.lector.GetDateTime(10), con.lector.GetBoolean(11)});
            }
            con.closeConection();

            dgv_Hoteles.ClearSelection();
            foreach (DataGridViewRow row in dgv_Hoteles.Rows)
                if (Convert.ToBoolean(row.Cells[11].Value) == false)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
        }

          public void limpiar()
          {
            dgv_Hoteles.Rows.Clear();
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_mail.Text = "";
            txt_telefono.Text = "";
            txt_calle.Text = "";
            cb_estrellas.SelectedItem = "";
            txt_ciudad.Text = "";
            txt_pais.Text = "";
            iniciarGrilla();
        }         

        private void ABMHotel_Load(object sender, EventArgs e)
        {
            if (hotel != 0)
            {
                Conexion con = new Conexion();
                con.strQuery = "SELECT H.Hotel_Nombre FROM FOUR_SIZONS.Hotel H WHERE H.Hotel_Codigo = " + hotel;
                con.executeQuery();

                if (con.reader())
                {
                    txt_codigo.Text = con.lector.GetString(0);
                }
                txt_codigo.Enabled = false;
                btn_promptHotel.Enabled = false;
                txt_codigo.Enabled = false;
            }
            dgv_Hoteles.ClearSelection();
            limpiar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void cb_estrellas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_alta_Click(object sender, EventArgs e)
        {
            string modo = "INS";
            this.Hide();
            ABMHotel02 formABMUsuario02 = new ABMHotel02(modo, hotel);
            formABMUsuario02.ShowDialog();
            this.Show();
            this.buscar();
        }

        private void boton_baja_Click(object sender, EventArgs e)
        {
            if (dgv_Hoteles.SelectedRows.Count > 0)
            {
            string modo = "DLT";
            this.Hide();
            ABMHotel02 formABMUsuario02 = new ABMHotel02(modo, Convert.ToDecimal(dgv_hotel_codigo));
            formABMUsuario02.ShowDialog();
            this.Show();
            this.buscar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un hotel de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boton_modificacion_Click(object sender, EventArgs e)
        {
            if (dgv_Hoteles.SelectedRows.Count > 0)
            {
            string modo = "UPD";
            this.Hide();
            ABMHotel02 formABMUsuario02 = new ABMHotel02(modo, Convert.ToDecimal(dgv_hotel_codigo));
            formABMUsuario02.ShowDialog();
            this.Show();
            this.buscar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un hotel de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void dgv_Hoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_Hoteles.Rows[index];
            dgv_hotel_codigo = selectedRow.Cells[0].Value.ToString();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            if (dgv_Hoteles.SelectedRows.Count > 0)
            {
                this.Hide();
            ABMHotel03 formABMHotel03 = new ABMHotel03(Convert.ToDecimal(dgv_hotel_codigo));
            formABMHotel03.ShowDialog();
            this.Show();
            this.buscar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un hotel de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_promptHotel_Click(object sender, EventArgs e)
        {
            using (PromptHoteles prompt = new PromptHoteles())
            {
                prompt.ShowDialog();

                if (prompt.TextBox1.Text != "")
                {
                    hotel = Convert.ToDecimal(prompt.TextBox1.Text);
                    txt_codigo.Text = prompt.TextBox2.Text;
                }
                prompt.Close();
                }
            this.Show();
        }

        private void btn_regimen_Click(object sender, EventArgs e)
        {
            if (dgv_Hoteles.SelectedRows.Count > 0)
            {
                this.Hide();
                ABMHotel04 formABMHotel04 = new ABMHotel04("UPD", Convert.ToDecimal(dgv_hotel_codigo));
                formABMHotel04.ShowDialog();
                this.Show();
                this.buscar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un hotel de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
