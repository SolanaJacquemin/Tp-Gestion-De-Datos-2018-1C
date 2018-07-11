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
        public DateTime dgv_reserva_Fecha;
        public DateTime hoy;
        public int index;
        public decimal hotel;

        public ABMReserva01(string userSession, decimal hotelID)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            dgv_Reservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Reservas.Rows.Clear();

            usuario = userSession;
            hotel = hotelID;
            hoy = DateTime.Today;

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
                chk_conFecha.Visible = false;
            }

        }

        private void levantarGrilla() 
        {
            if (usuario != "GUEST")
            {
                Conexion con = new Conexion();
                con.strQuery = "SELECT TOP 50 RE.Reserva_Codigo, RE.Reserva_Fecha_Inicio, RE.Reserva_Fecha_Fin," +
                   " RE.Reserva_Precio, HO.Hotel_Nombre, CL.Cliente_Nombre + ' ' + CL.Cliente_Apellido," +
                   " RE.Reserva_Estado" +
                   " FROM FOUR_SIZONS.Reserva RE" +
                   " JOIN FOUR_SIZONS.Hotel HO ON HO.Hotel_Codigo = RE.Hotel_Codigo" +
                   " JOIN FOUR_SIZONS.Cliente CL ON CL.Cliente_Codigo = RE.Cliente_Codigo" +
                   " WHERE 1=1";
                   //" WHERE YEAR(RE.Reserva_FechaCreacion) = YEAR(GETDATE()) AND MONTH(RE.Reserva_FechaCreacion) = MONTH(GETDATE())";
                if (hotel != 0)
                {
                    con.strQuery = con.strQuery + " AND HO.Hotel_Codigo = " + hotel;
                }
                con.strQuery = con.strQuery + " ORDER BY RE.Reserva_Codigo";

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

                dgv_Reservas.ClearSelection();
                decimal estado;
                foreach (DataGridViewRow row in dgv_Reservas.Rows) 
                {
                    estado = Convert.ToDecimal(row.Cells[6].Value);
                    if (estado != 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }

                dgv_Reservas.ClearSelection();
            }
        }

        private void ABMReserva01_Load(object sender, EventArgs e)
        {
            levantarGrilla();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Reservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0) 
            {
                DataGridViewRow selectedRow = dgv_Reservas.Rows[index];
                dgv_reserva_ID = Convert.ToDecimal(selectedRow.Cells[0].Value.ToString());
                dgv_reserva_Fecha = Convert.ToDateTime(selectedRow.Cells[1].Value);
            }
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
               "JOIN FOUR_SIZONS.Cliente CL ON CL.Cliente_Codigo = RE.Cliente_Codigo " +
                              "WHERE 1=1";
                if (txt_reservaId.Text == "")
                {
                    con.strQuery = con.strQuery + " AND RE.Reserva_Codigo = 0";
                }
                else
                {
                    con.strQuery = con.strQuery + " AND RE.Reserva_Codigo = " + txt_reservaId.Text;
                }
            }else{
                string sqlFormattedDate1;
                string sqlFormattedDate2;
                sqlFormattedDate1 = dt_fechaDesde.Value.ToString("dd-MM-yyyy");
                sqlFormattedDate2 = dt_fechaHasta.Value.ToString("dd-MM-yyyy");
                con.strQuery = "SELECT TOP 50 Reserva_Codigo, Reserva_Fecha_Inicio, Reserva_Fecha_Fin, " +
               "RE.Reserva_Precio, HO.Hotel_Nombre, CL.Cliente_Nombre + ' ' + CL.Cliente_Apellido, " +
               "RE.Reserva_Estado " +
               "FROM FOUR_SIZONS.Reserva RE " +
               "JOIN FOUR_SIZONS.Hotel HO ON HO.Hotel_Codigo = RE.Hotel_Codigo " +
               "JOIN FOUR_SIZONS.Cliente CL ON CL.Cliente_Codigo = RE.Cliente_Codigo " +
               "WHERE 1=1";
                if (txt_reservaId.Text != "") 
                {
                    con.strQuery = con.strQuery + " AND RE.Reserva_Codigo = " + txt_reservaId.Text;
                }
                if (chk_conFecha.Checked) 
                {
                    con.strQuery = con.strQuery + " AND (RE.Reserva_Fecha_Inicio >= '" + sqlFormattedDate1 + "' AND RE.Reserva_Fecha_Fin <= '" + sqlFormattedDate2 + "')";
                }
                con.strQuery = con.strQuery + " ORDER BY RE.Reserva_Codigo";
            }

            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado reservas. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            dgv_Reservas.ClearSelection();
            decimal estado;
            foreach (DataGridViewRow row in dgv_Reservas.Rows)
            {
                estado = Convert.ToDecimal(row.Cells[6].Value);
                if (estado != 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            con.closeConection();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            decimal error = 0;
            if (chk_conFecha.Checked)
            {
                if (dt_fechaHasta.Value < dt_fechaDesde.Value)
                {
                    error = 1;
                    MessageBox.Show("El campo Fecha Hasta no puede ser posterior a Fecha Desde", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if(error == 0)
            {
                buscar();
            }

        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
            dgv_reserva_Fecha = dgv_reserva_Fecha.Date;
            if (dgv_reserva_Fecha == hoy)
            {
                MessageBox.Show("No se puede modificar una reserva el mismo día del inicio de la misma", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dgv_Reservas.SelectedRows.Count > 0)
                {
                    string modo = "UPD";
                    this.Hide();
                    ABMReserva03 formABMReserva03 = new ABMReserva03(modo, usuario, dgv_reserva_ID);
                    formABMReserva03.ShowDialog();
                    this.Show();
                    this.buscar();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una reserva de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            if (dgv_Reservas.SelectedRows.Count > 0)
            {
                string modo = "DLT";
                this.Hide();
                ABMReserva03 formABMReserva03 = new ABMReserva03(modo, usuario, dgv_reserva_ID);
                formABMReserva03.ShowDialog();
                this.Show();
                this.buscar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una reserva de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_reservaId.Clear();
            dgv_Reservas.Rows.Clear();
            dgv_Reservas.ClearSelection();
            if (usuario != "GUEST")
            {
                dt_fechaDesde.Value = hoy;
                dt_fechaHasta.Value = hoy;
                levantarGrilla();
            }

        }
    }
}