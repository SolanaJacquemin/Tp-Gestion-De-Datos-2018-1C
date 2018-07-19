using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class RegistrarConsumible : Form
    {
        public decimal dgv_consumible_id;
        public int index;
        public decimal estadia;
        public decimal reserva;
        public string cons_nombre;
        public int error;
        public int cantAgr;

        public RegistrarConsumible(decimal res)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dgv_consumibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_consumibles.Rows.Clear();
            reserva = res;

            txt_CodReserva.Enabled = false;
            txt_Estadia.Enabled = false;

            Conexion con = new Conexion();
            con.strQuery = " select Estadia_Codigo from FOUR_SIZONS.Estadia where Reserva_Codigo = " + reserva;
            con.executeQuery();

            if (con.reader())
            {
                estadia = con.lector.GetDecimal(0);
            }
            else
            {
                MessageBox.Show("No se ha encontrado la estadía. Por favor, realice una nueva búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.closeConection();

            //limpiar();

            levantarGrilla();

            txt_Estadia.Text = estadia.ToString();
            txt_CodReserva.Text = reserva.ToString();
        }

        public void levantarGrilla()
        {
            dgv_consumibles.Rows.Clear();
            Conexion con = new Conexion();
            con.strQuery = "SELECT C.Consumible_Codigo, C.Consumible_Descripcion, C.Consumible_Precio, EC.estXcons_cantidad FROM FOUR_SIZONS.EstadiaXConsumible EC" +
                           " JOIN FOUR_SIZONS.Consumible C ON C.Consumible_Codigo = EC.Consumible_Codigo" +
                           " WHERE EC.Estadia_Codigo =" + estadia;
            con.executeQuery();

            while (con.reader())
            {
                dgv_consumibles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
                con.lector.GetDecimal(2), con.lector.GetDecimal(3)});
            }
            con.closeConection();

        }

        public void limpiar()
        {
        }

        private void buscar()
        {
            dgv_consumibles.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = " SELECT * FROM FOUR_SIZONS.Estadia WHERE 1=1 ";

            if (txt_Estadia.Text != "")
                con.strQuery = con.strQuery + " AND Estadia_Codigo = " + txt_Estadia.Text;
            if (txt_CodReserva.Text != "")
                con.strQuery = con.strQuery + " AND Reserva_Codigo = " + txt_CodReserva.Text;

            con.executeQuery();

            if (!con.reader())
            {
                MessageBox.Show("No se ha encontrado la estadía. Revise el criterio de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_consumibles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetDecimal(1),
            con.lector.GetDateTime(2), con.lector.GetDateTime(3), con.lector.GetDecimal(4), con.lector.GetDecimal(5),
            con.lector.GetDecimal(6), con.lector.GetString(7), con.lector.GetString(8), con.lector.GetDecimal(9),
            con.lector.GetDecimal(10), con.lector.GetBoolean(11)});

            con.closeConection();

        }

        private void RegistrarConsumible_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT * FROM FOUR_SIZONS.Consumible";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado consumibles. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }
            //con.closeConection();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
        }

        private void dgv_consumibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                DataGridViewRow selectedRow = dgv_consumibles.Rows[index];
                dgv_consumible_id = Convert.ToDecimal(selectedRow.Cells[0].Value.ToString());
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMConsumible formConsumibles = new ABMConsumible("INS", estadia, dgv_consumible_id);
            formConsumibles.ShowDialog();
            this.Show();
            levantarGrilla();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMConsumible formConsumibles = new ABMConsumible("UPD", estadia, dgv_consumible_id);
            formConsumibles.ShowDialog();
            this.Show();
            levantarGrilla();
        }

    }
}
