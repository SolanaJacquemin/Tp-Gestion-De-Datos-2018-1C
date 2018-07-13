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
        public string user;
        public decimal estado;
        public PromptRoles(string us)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txt_aux_rolid.Visible = false;
            txt_aux_rolnombre.Visible = false;
            dgvRolesPrompt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvRolesPrompt.Rows.Clear();
            user=us;

            Conexion con = new Conexion();
            con.strQuery = "select r.Rol_Codigo, r.Rol_Nombre from FOUR_SIZONS.Rol r where r.Rol_Codigo "+
                "not in (select ur.Rol_Codigo from FOUR_SIZONS.UsuarioXRol ur where '" + user +"' = ur.Usuario_ID "+
                "and ur.UsuarioXRol_Estado=1) and r.Rol_Estado=1 ORDER BY Rol_Codigo";
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
         /*   dgvRolesPrompt.Rows.Clear();

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

            con.closeConection();*/
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
