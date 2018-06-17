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
    public partial class PromptHoteles : Form
    {
        public PromptHoteles()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txt_aux_hotelid.Visible = false;
            txt_hotelnombre.Visible = false;
            dgvHotelesPrompt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvHotelesPrompt.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Hotel_Codigo, Hotel_Nombre " +
                           "FROM FOUR_SIZONS.Hotel ORDER BY Hotel_Codigo";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("La busqueda no produjo resultados");
                con.strQuery = "";
                con.closeConection();
                //return;
            }

            dgvHotelesPrompt.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgvHotelesPrompt.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });
            }
            con.closeConection();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgvHotelesPrompt.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Hotel_Codigo, Hotel_Nombre FROM FOUR_SIZONS.Hotel WHERE 1=1";
            if (txt_hotelid.Text != "")
                con.strQuery = con.strQuery + " AND Hotel_Codigo = " + txt_hotelid.Text + " ";
                con.strQuery = con.strQuery + " AND Hotel_Nombre like '%" + txt_hotelnombre.Text + "%' ";
                con.strQuery = con.strQuery + "ORDER BY Hotel_Codigo";
                con.executeQuery();

            if (!con.reader())
            {
                MessageBox.Show("La busqueda no produjo resultados");
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgvHotelesPrompt.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgvHotelesPrompt.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });
            }

            con.closeConection();

        }

        private void dgvHotelesPrompt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvHotelesPrompt.Rows[index];
            string dgv_hotel_ID = selectedRow.Cells[0].Value.ToString();
            string dgv_hotel_nombre = selectedRow.Cells[1].Value.ToString();

            txt_aux_hotelid.Text = dgv_hotel_ID;
            txt_aux_hotelnombre.Text = dgv_hotel_nombre;

            this.Hide();
        }

        public TextBox TextBox1
        {
            get
            {
                return txt_aux_hotelid;
            }
        }

        public TextBox TextBox2
        {
            get
            {
                return txt_aux_hotelnombre;
            }
        }
    }
}
