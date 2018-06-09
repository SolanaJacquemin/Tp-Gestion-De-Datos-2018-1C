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
    public partial class ABMUsuarioPrompt : Form
    {
        public ABMUsuarioPrompt()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txt_aux_userid.Visible = false;
            dgvUsuariosPrompt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvUsuariosPrompt.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Usuario_ID, Usuario_Apellido " +
                           "FROM FOUR_SIZONS.Usuario ORDER BY Usuario_ID";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("La busqueda no produjo resultados");
                con.strQuery = "";
                con.closeConection();
                //return;
            }

            dgvUsuariosPrompt.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgvUsuariosPrompt.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1) });
            }
            con.closeConection();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            dgvUsuariosPrompt.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Usuario_ID, Usuario_Apellido FROM FOUR_SIZONS.Usuario WHERE 1=1";
            if (txt_usuarioid.Text != "")
                con.strQuery = con.strQuery + " AND Usuario_ID like '%" + txt_usuarioid.Text + "%' ";
            con.strQuery = con.strQuery + "ORDER BY Usuario_ID";
            con.executeQuery();

            if (!con.reader())
            {
                MessageBox.Show("La busqueda no produjo resultados");
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgvUsuariosPrompt.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgvUsuariosPrompt.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1) });
            }

            con.closeConection();
        }

        private void ABMUsuarioPrompt_Load(object sender, EventArgs e)
        {

        }

        public void dgvUsuariosPrompt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Int32 selectedRowCount = dgvUsuariosPrompt.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append("Row: ");
                    sb.Append(dgvUsuariosPrompt.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Total: " + selectedRowCount.ToString());
                MessageBox.Show(sb.ToString(), "Selected Rows");
            }*/
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvUsuariosPrompt.Rows[index];
            string dgv_usuario_ID = selectedRow.Cells[0].Value.ToString();
            
            
            txt_aux_userid.Text = dgv_usuario_ID;

            this.Hide();
        }

        /*public string dgv_usuario_ID
        {
            get
            {
                return dgv_usuario_ID;
            }
        }*/

        public TextBox TextBox1 {
            get 
            {
                return txt_aux_userid;
            }
        }

    }
}
