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
    public partial class PromptElegirRegimenXReserva : Form
    {
        public PromptElegirRegimenXReserva(DataSet listado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvRegimenPrompt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            MessageBox.Show("Existe disponbilidad. Por favor elija el tipo de régimen deseado", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataSet dataset = new DataSet();

            dataset = listado;

            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                dgvRegimenPrompt.Rows.Add(new Object[] { (dataset.Tables[0].Rows[i][0]).ToString(), 
                                                         (dataset.Tables[0].Rows[i][1]).ToString(),
                                                         (dataset.Tables[0].Rows[i][2]).ToString()});
            }
        }

        public TextBox TextBox1
        {
            get
            {
                return txt_aux_regimennombre;
            }
        }

        public TextBox TextBox2
        {
            get
            {
                return txt_aux_regimenpreciototal;
            }
        }

        private void dgvRegimenPrompt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dgvRegimenPrompt.Rows[index];
                string dgv_regimen_nombre = selectedRow.Cells[0].Value.ToString();
                decimal dgv_regimen_preciototal = Convert.ToDecimal(selectedRow.Cells[2].Value.ToString());

                txt_aux_regimennombre.Text = dgv_regimen_nombre;
                txt_aux_regimenpreciototal.Text = dgv_regimen_preciototal.ToString();
            }
            this.Hide();
        }
    }
}
