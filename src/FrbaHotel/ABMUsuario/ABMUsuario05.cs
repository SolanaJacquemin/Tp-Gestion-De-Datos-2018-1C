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
    public partial class ABMUsuario05 : Form
    {
        public decimal hotel_id;
        public string nombreSP;
        public string usuario;
        public decimal dgv_Hoteles_ID;

        public ABMUsuario05(string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            usuario = user;

            buscar();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string modo = "INS";
            this.Hide();
            ABMUsuario06 formABMUsuario06 = new ABMUsuario06(modo, usuario, 0);
            formABMUsuario06.ShowDialog();
            this.Show();
            this.buscar();
        }

        private void buscar()
        {
            dgv_Roles.Rows.Clear();
            Conexion con = new Conexion();
            con.strQuery = "SELECT R.Rol_Codigo, R.Rol_Nombre FROM FOUR_SIZONS.UsuarioXRol UR " +
                           "JOIN FOUR_SIZONS.Rol R ON R.Rol_Codigo = UR.Rol_Codigo " +
                           "WHERE UR.UsuarioXRol_Estado = 1 AND UR.Usuario_ID = '" + usuario + "'";
            con.executeQuery();
            if (!con.reader())
            {
                //MessageBox.Show("No se han encontrado usuarios. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Roles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgv_Roles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1) });
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
            DataGridViewRow selectedRow = dgv_Roles.Rows[index];
            dgv_Hoteles_ID = Convert.ToDecimal(selectedRow.Cells[0].Value.ToString());
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            string modo = "DLT";
            this.Hide();
            ABMUsuario06 formABMUsuario06 = new ABMUsuario06(modo, usuario, 0);
            formABMUsuario06.ShowDialog();
            this.Show();
            this.buscar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
