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
    public partial class ABMUsuario03 : Form
    {
        public decimal hotel_id;
        public string nombreSP;
        public string usuario;
        public decimal dgv_Hoteles_ID;

        public ABMUsuario03(string user, decimal HotelID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            usuario = user;
            hotel_id = HotelID;

            buscar();
        }

        private void ABMUsuario03_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string modo = "INS";
            this.Hide();
            ABMUsuario04 formABMUsuario04 = new ABMUsuario04(modo, usuario, hotel_id);
            formABMUsuario04.ShowDialog();
            this.Show();
            this.buscar();
        }

        private void buscar()
        {
            dgv_Hoteles.Rows.Clear();
            Conexion con = new Conexion();
            con.strQuery = "SELECT H.Hotel_Codigo, H.Hotel_Nombre FROM FOUR_SIZONS.UsuarioXHotel AS UH " +
                           "JOIN FOUR_SIZONS.Hotel AS H ON H.Hotel_Codigo = UH.Hotel_Codigo " +
                           "WHERE UH.UsuarioXHotel_Estado = 1 AND UH.Usuario_ID = '" + usuario + "'";
                            if (hotel_id != 0)
                            {
                                con.strQuery = con.strQuery + " AND H.Hotel_Codigo = " + hotel_id;
                            }
            con.executeQuery();
            if (!con.reader())
            {
                //MessageBox.Show("No se han encontrado usuarios. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Hoteles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgv_Hoteles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });
            }
            con.closeConection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string modo = "DLT";
            this.Hide();
            ABMUsuario04 formABMUsuario04 = new ABMUsuario04(modo, usuario, dgv_Hoteles_ID);
            formABMUsuario04.ShowDialog();
            this.Show();
            
            this.buscar();
        }

        private void dgv_Hoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_Hoteles.Rows[index];
            dgv_Hoteles_ID = Convert.ToDecimal(selectedRow.Cells[0].Value.ToString());
        }
    }
}
