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

        public string usuario;
        public decimal dgv_reserva_ID;
        public int index;

        public ABMReserva01(string userSession)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            dgv_Reservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Reservas.Rows.Clear();

            usuario = userSession;

            dt_fechaDesde.Format = DateTimePickerFormat.Custom;
            dt_fechaDesde.CustomFormat = "dd/MM/yyyy";
            dt_fechaHasta.Format = DateTimePickerFormat.Custom;
            dt_fechaHasta.CustomFormat = "dd/MM/yyyy";

            if (usuario == "GUEST") 
            {
                l_desde.Visible = false;
                dt_fechaDesde.Visible = false;
                l_hasta.Visible = false;
                dt_fechaHasta.Visible = false;
            }

        }

        private void ABMReserva01_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT TOP 50 RE.Reserva_Codigo, RE.Reserva_Fecha_Inicio, RE.Reserva_Fecha_Fin," +
               " RE.Reserva_Precio, HO.Hotel_Nombre, CL.Cliente_Nombre + ' ' + CL.Cliente_Apellido," +
               " RE.Reserva_Estado" +
               " FROM FOUR_SIZONS.Reserva RE" +
               " JOIN FOUR_SIZONS.Hotel HO ON HO.Hotel_Codigo = RE.Hotel_Codigo" +
               " JOIN FOUR_SIZONS.Cliente CL ON CL.Cliente_Codigo = RE.Cliente_Codigo" +
               " WHERE YEAR(RE.Reserva_FechaCreacion) = YEAR(GETDATE()) AND MONTH(RE.Reserva_FechaCreacion) = MONTH(GETDATE())" +
               " ORDER BY RE.Reserva_FechaCreacion";

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
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Reservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_Reservas.Rows[index];
            dgv_reserva_ID = Convert.ToDecimal(selectedRow.Cells[0].Value.ToString());
        }

        private void boton_generar_Click(object sender, EventArgs e)
        {
            string modo = "INS";
            this.Hide();
            ABMReserva02 formABMReserva02 = new ABMReserva02(modo, usuario);
            formABMReserva02.ShowDialog();
            this.Show();
        }

        private void buscar()
        {
            dgv_Reservas.Rows.Clear();

            Conexion con = new Conexion();
            if (usuario == "GUEST") 
            {
                con.strQuery = "SELECT Reserva_Codigo, Reserva_Fecha_Inicio, Reserva_Fecha_Fin, " +
               "RE.Reserva_Precio, HO.Hotel_Nombre, CL.Cliente_Nombre + ' ' + CL.Cliente_Apellido, " +
               "RE.Reserva_Estado " +
               "FROM FOUR_SIZONS.Reserva RE " +
               "JOIN FOUR_SIZONS.Hotel HO ON HO.Hotel_Codigo = RE.Hotel_Codigo " +
               "JOIN FOUR_SIZONS.Cliente CL ON CL.Cliente_Codigo = RE.Cliente_Codigo" +
               " WHERE 1=1 ";
                if (txt_reservaId.Text != "")
                    con.strQuery = con.strQuery + "AND RE.Reserva_Codigo = " + txt_reservaId.Text;
                con.strQuery = con.strQuery + " ORDER BY RE.Reserva_Codigo";
            }else{
                con.strQuery = "SELECT Reserva_Codigo, Reserva_Fecha_Inicio, Reserva_Fecha_Fin, " +
               "RE.Reserva_Precio, HO.Hotel_Nombre, CL.Cliente_Nombre + ' ' + CL.Cliente_Apellido, " +
               "RE.Reserva_Estado " +
               "FROM FOUR_SIZONS.Reserva RE " +
               "JOIN FOUR_SIZONS.Hotel HO ON HO.Hotel_Codigo = RE.Hotel_Codigo " +
               "JOIN FOUR_SIZONS.Cliente CL ON CL.Cliente_Codigo = RE.Cliente_Codigo" +
               " WHERE 1=1 ";
                if (txt_reservaId.Text != "")
                    con.strQuery = con.strQuery + "AND RE.Reserva_Codigo = " + txt_reservaId.Text;
                con.strQuery = con.strQuery + " ORDER BY RE.Reserva_Codigo";
            }

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
            con.closeConection();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
            string modo = "UPD";
            this.Hide();
            ABMReserva03 formABMReserva03 = new ABMReserva03(modo, usuario, dgv_reserva_ID);
            formABMReserva03.ShowDialog();
            this.Show();
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            string modo = "DLT";
            this.Hide();
            ABMReserva03 formABMReserva03 = new ABMReserva03(modo, usuario, dgv_reserva_ID);
            formABMReserva03.ShowDialog();
            this.Show();
        }
    }
}
