using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using FrbaHotel.RegistrarConsumible;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class GestionEstadias : Form
    {

        public decimal dgv_CodReserva;
        public int index;
        public decimal reserva;
        public string user;
        public decimal hotel;

        public GestionEstadias(decimal hotelID, string userID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dgv_Reserva.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Reserva.Rows.Clear();
            user = userID;

            limpiar();
            refrescarGrid();

        }

        private void refrescarGrid()
        {
            dgv_Reserva.ClearSelection();
            foreach (DataGridViewRow row in dgv_Reserva.Rows)
            {
                if (Convert.ToDecimal(row.Cells[10].Value) == 6)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                if (Convert.ToDecimal(row.Cells[10].Value) == 3||Convert.ToDecimal(row.Cells[10].Value) == 4||Convert.ToDecimal(row.Cells[10].Value) == 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void GestionEstadia_Load(object sender, EventArgs e)
        {
            dgv_Reserva.Rows.Clear();
            limpiar();
            refrescarGrid();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar();

        }

        private void buscar()
        {
            dgv_Reserva.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT TOP 100 Reserva_Codigo, Reserva_FechaCreacion, Reserva_Fecha_Inicio, Reserva_Fecha_Fin, Reserva_Cant_Noches," +
                "Reserva_Precio, Usuario_ID, Hotel_Codigo, Cliente_Codigo, Regimen_Codigo, Reserva_Estado FROM FOUR_SIZONS.Reserva " +
                            " WHERE 1=1";

            if (txt_CodReserva.Text != "")
                con.strQuery = con.strQuery + " AND Reserva_Codigo = " + txt_CodReserva.Text;

            con.executeQuery();

            if (!con.reader())
            {
                MessageBox.Show("No se ha encontrado la reserva. Revise el criterio de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Reserva.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetDateTime(1),
            con.lector.GetDateTime(2), con.lector.GetDateTime(3), con.lector.GetDecimal(4), con.lector.GetDecimal(5),
            con.lector.GetString(6), con.lector.GetDecimal(7), con.lector.GetDecimal(8), con.lector.GetDecimal(9),
            con.lector.GetDecimal(10)});

            con.closeConection();

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        public void limpiar()
        {

            dgv_Reserva.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Reserva.Rows.Clear();
            txt_CodReserva.Text = "";

            Conexion con = new Conexion();
            con.strQuery = "SELECT TOP 100 Reserva_Codigo, Reserva_FechaCreacion, Reserva_Fecha_Inicio, Reserva_Fecha_Fin, Reserva_Cant_Noches," +
                "Reserva_Precio, Usuario_ID, Hotel_Codigo, Cliente_Codigo, Regimen_Codigo, Reserva_Estado FROM FOUR_SIZONS.Reserva " +
                            " WHERE 1=1";

            con.executeQuery();

            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado reservas. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Reserva.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetDateTime(1),
            con.lector.GetDateTime(2), con.lector.GetDateTime(3), con.lector.GetDecimal(4), con.lector.GetDecimal(5),
            con.lector.GetString(6), con.lector.GetDecimal(7), con.lector.GetDecimal(8), con.lector.GetDecimal(9),
            con.lector.GetDecimal(10)});

            while (con.reader())
            {
                dgv_Reserva.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetDateTime(1),
            con.lector.GetDateTime(2), con.lector.GetDateTime(3), con.lector.GetDecimal(4), con.lector.GetDecimal(5),
            con.lector.GetString(6), con.lector.GetDecimal(7), con.lector.GetDecimal(8), con.lector.GetDecimal(9),
            con.lector.GetDecimal(10)});
            }
            con.closeConection();
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            if (dgv_Reserva.SelectedRows.Count == 1)
            {
                string modo = "IN";
                this.Hide();
                RegistrarEstadia formRegistrarEstadia = new RegistrarEstadia(modo, dgv_CodReserva, user);
                formRegistrarEstadia.ShowDialog();
                this.Show();
                //  this.buscar();
                //  this.refrescarGrid();
            }
            else MessageBox.Show("Debe seleccionar una reserva de la grilla primero", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            if (dgv_Reserva.SelectedRows.Count == 1)
            {
                string modo = "OUT";
                this.Hide();
                RegistrarEstadia formRegistrarEstadia = new RegistrarEstadia(modo, dgv_CodReserva, user);
                formRegistrarEstadia.ShowDialog();
                this.Show();
                //  this.buscar();
                //    this.refrescarGrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una reserva de la grilla primero", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_consumibles_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarConsumible formConsumibles = new RegistrarConsumible(dgv_CodReserva);
            formConsumibles.ShowDialog();
            this.Show();
        }

        private void dgv_Reserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_Reserva.Rows[index];
            dgv_CodReserva = Convert.ToDecimal(selectedRow.Cells[0].Value.ToString());
        }

    }
}
