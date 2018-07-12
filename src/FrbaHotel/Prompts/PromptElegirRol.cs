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
    public partial class PromptElegirRol : Form
    {
        public string usuario;

        public PromptElegirRol(string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txt_aux_rolid.Visible = false;
            txt_aux_rolnombre.Visible = false;
            dgvRolesPrompt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvRolesPrompt.Rows.Clear();

            usuario = user;
        }

        private void PromptElegirRol_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();



            con.strQuery = "SELECT R.Rol_Codigo, R.Rol_Nombre FROM FOUR_SIZONS.UsuarioXRol UR"
                           + " JOIN FOUR_SIZONS.Rol R ON R.Rol_Codigo = UR.Rol_Codigo"
                           + " WHERE UR.UsuarioXRol_Estado = 1 AND R.Rol_Estado = 1 AND UR.Usuario_ID = '" + usuario + "'";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("La busqueda no produjo resultados");
                con.strQuery = "";
                con.closeConection();
                //return;
            }

            dgvRolesPrompt.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgvRolesPrompt.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });
            }

            con.closeConection();
        }

        private void dgvRolesPrompt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dgvRolesPrompt.Rows[index];
                string dgv_roles_ID = selectedRow.Cells[0].Value.ToString();
                string dgv_roles_nombre = selectedRow.Cells[1].Value.ToString();

                txt_aux_rolid.Text = dgv_roles_ID;
                txt_aux_rolnombre.Text = dgv_roles_nombre;
            }
            this.Hide();
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
