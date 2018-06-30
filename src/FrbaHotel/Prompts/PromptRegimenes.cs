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
    public partial class PromptRegimenes : Form
    {
        public PromptRegimenes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txt_aux_regimenid.Visible = false;
            txt_aux_regimennombre.Visible = false;
            dgvRegimenPrompt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvRegimenPrompt.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Regimen_Codigo, Regimen_Descripcion FROM FOUR_SIZONS.Regimen ORDER BY Regimen_Codigo";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("La busqueda no produjo resultados");
                con.strQuery = "";
                con.closeConection();
            }

            dgvRegimenPrompt.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgvRegimenPrompt.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });
            }
            con.closeConection();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgvRegimenPrompt.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Regimen_Codigo, Regimen_Descripcion FROM FOUR_SIZONS.Regimen WHERE 1=1";
            if (txt_regimenid.Text != "")
                con.strQuery = con.strQuery + " AND Regimen_Codigo = " + txt_regimenid.Text + " ";
            con.strQuery = con.strQuery + " AND Regimen_Descripcion like '%" + txt_regimennombre.Text + "%' ";
            con.strQuery = con.strQuery + "ORDER BY Regimen_Codigo";
            con.executeQuery();

            if (!con.reader())
            {
                MessageBox.Show("La busqueda no produjo resultados");
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgvRegimenPrompt.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgvRegimenPrompt.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });
            }

            con.closeConection();
        }

        public TextBox TextBox1
        {
            get
            {
                return txt_aux_regimenid;
            }
        }

        public TextBox TextBox2
        {
            get
            {
                return txt_aux_regimennombre;
            }
        }

        private void dgvRegimenPrompt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvRegimenPrompt.Rows[index];
            string dgv_regimen_ID = selectedRow.Cells[0].Value.ToString();
            string dgv_regimen_nombre = selectedRow.Cells[1].Value.ToString();

            txt_aux_regimenid.Text = dgv_regimen_ID;
            txt_aux_regimennombre.Text = dgv_regimen_nombre;

            this.Hide();
        }


    }
}
