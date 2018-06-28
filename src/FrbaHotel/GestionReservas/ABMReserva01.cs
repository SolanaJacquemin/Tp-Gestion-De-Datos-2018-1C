using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GestionReservas
{
    public partial class ABMReserva01 : Form
    {
        public ABMReserva01()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            dgv_Reservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txt_ReservaId.ReadOnly = true;
            dgv_Reservas.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT TOP 50 RE.Reserva_Codigo, RE.Reserva_Fecha_Inicio, RE.Reserva_Fecha_Fin, " +
               "RE.Reserva_Precio, HO.Hotel_Nombre, CL.Cliente_Nombre + ' ' + CL.Cliente_Apellido, " +
               "RE.Reserva_Estado " + 
               "FROM FOUR_SIZONS.Reserva RE " + 
               "JOIN FOUR_SIZONS.Hotel HO ON HO.Hotel_Codigo = RE.Hotel_Codigo " + 
               "JOIN FOUR_SIZONS.Cliente CL ON CL.Cliente_Codigo = RE.Cliente_Codigo";

            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado usuarios. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Reservas.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetDateTime(1),
                con.lector.GetDateTime(2), con.lector.GetDecimal(3), con.lector.GetString(4), 
                con.lector.GetString(5), con.lector.GetDecimal(6)});

            while (con.reader())
            {
                dgv_Reservas.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetDateTime(1),
                con.lector.GetDateTime(2), con.lector.GetDecimal(3), con.lector.GetString(4),
                con.lector.GetString(5), con.lector.GetDecimal(6)});
            }

            dt_fechaDesde.Format = DateTimePickerFormat.Custom;
            dt_fechaDesde.CustomFormat = "dd/MM/yyyy";
            dt_fechaHasta.Format = DateTimePickerFormat.Custom;
            dt_fechaHasta.CustomFormat = "dd/MM/yyyy";

        }

        private void ABMReserva01_Load(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Reservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_Reservas.Rows[index];
            //dgv_Reservas = selectedRow.Cells[0].Value.ToString();
        }

        private void boton_generar_Click(object sender, EventArgs e)
        {
            string modo = "INS";
            this.Hide();
            ABMReserva02 formABMReserva02 = new ABMReserva02(modo, "SYSADM");
            formABMReserva02.ShowDialog();
            this.Show();
        }
    }
}
