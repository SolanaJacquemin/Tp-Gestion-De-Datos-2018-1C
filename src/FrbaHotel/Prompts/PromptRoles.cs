using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Prompts
{
    public partial class PromptRoles : Form
    {
        public PromptRoles()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txt_aux_rolid.Visible = false;
            txt_aux_rolnombre.Visible = false;
            dgvRolesPrompt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvRolesPrompt.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Rol_Codigo, Rol_Nombre " +
                           "FROM FOUR_SIZONS.Rol ORDER BY Rol_Codigo";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("La busqueda no produjo resultados");
                con.strQuery = "";
                con.closeConection();
            }

            dgvRolesPrompt.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgvRolesPrompt.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });
            }
            con.closeConection();
        }

        private void dgvHotelesPrompt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dgvRolesPrompt.Rows[index];
                string dgv_hotel_ID = selectedRow.Cells[0].Value.ToString();
                string dgv_hotel_nombre = selectedRow.Cells[1].Value.ToString();

                txt_aux_rolid.Text = dgv_hotel_ID;
                txt_aux_rolnombre.Text = dgv_hotel_nombre;
            }
            this.Hide();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgvRolesPrompt.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Rol_Codigo, Rol_Nombre FROM FOUR_SIZONS.Rol WHERE 1=1";
            if (txt_rolid.Text != "")
                con.strQuery = con.strQuery + " AND Rol_Codigo = " + txt_rolid.Text + " ";
            con.strQuery = con.strQuery + " AND Rol_Nombre like '%" + txt_rolnombre.Text + "%' ";
            con.strQuery = con.strQuery + "ORDER BY Rol_Codigo";
            con.executeQuery();

            if (!con.reader())
            {
                MessageBox.Show("La busqueda no produjo resultados");
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgvRolesPrompt.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgvRolesPrompt.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });
            }

            con.closeConection();
        }

        public TextBox TextBox1
        {
            get
            {
                return txt_aux_rolid;
            }
        }

        public TextBox TextBox2
        {
            get
            {
                return txt_aux_rolnombre;
            }
        }

    }
}
