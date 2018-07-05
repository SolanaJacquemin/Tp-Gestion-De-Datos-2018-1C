using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ABMHabitacion
{
    public partial class ABMHabitacion01 : Form
    {
        public decimal dgv_hotel_ID;
        public decimal dgv_habitacion_ID;
        public int index;

        public ABMHabitacion01()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            cb_tipoFrente.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipohab.DropDownStyle = ComboBoxStyle.DropDownList;

            iniciarGrilla();
            refrescarGrid();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Habitacion_Tipo_Descripcion FROM FOUR_SIZONS.Habitacion_Tipo";
            con.executeQuery();
            while (con.reader())
            {
                cb_tipohab.Items.Add(con.lector.GetString(0));
            }
            con.closeConection();

            cb_tipoFrente.Items.Add("S");
            cb_tipoFrente.Items.Add("N");
        }


        public void iniciarGrilla()
        {
            dgv_Habitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cb_tipoFrente.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipohab.DropDownStyle = ComboBoxStyle.DropDownList;
            dgv_Habitaciones.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "select Ho.Hotel_Nombre, Ha.Hotel_Codigo, Ha.Habitacion_Numero, Ha.Habitacion_Piso, HT.Habitacion_Tipo_Descripcion, " +
            "Ha.Habitacion_Frente, Ha.Habitacion_Estado from FOUR_SIZONS.Habitacion as Ha JOIN FOUR_SIZONS.Hotel " +
            "as Ho on Ho.Hotel_Codigo = Ha.Hotel_Codigo JOIN FOUR_SIZONS.Habitacion_Tipo as HT on " +
            "HT.Habitacion_Tipo_Codigo = Ha.Habitacion_Tipo_Codigo ORDER BY Ho.Hotel_Codigo, Ha.Habitacion_Numero";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado usuarios. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Habitaciones.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetDecimal(1),
            con.lector.GetDecimal(2), con.lector.GetDecimal(3), con.lector.GetString(4), con.lector.GetString(5),
            con.lector.GetBoolean(6)});

            while (con.reader())
            {
                dgv_Habitaciones.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetDecimal(1),
                con.lector.GetDecimal(2), con.lector.GetDecimal(3), con.lector.GetString(4), con.lector.GetString(5),
                con.lector.GetBoolean(6)});
            }
            con.closeConection();
        }

        public void limpiar()
        {
            dgv_Habitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Habitaciones.Rows.Clear();
            txt_nombre_hotel.Text = "";
            txt_piso.Text = "";
            txt_nro_hab.Text = "";
            cb_tipohab.Items.Clear();
            cb_tipoFrente.Items.Clear();
            iniciarGrilla();
            refrescarGrid();
        }

        private void buscar()
        {
            dgv_Habitaciones.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "select Ho.Hotel_Nombre, Ha.Hotel_Codigo, Ha.Habitacion_Numero, Ha.Habitacion_Piso, HT.Habitacion_Tipo_Descripcion, " +
            "Ha.Habitacion_Frente, Ha.Habitacion_Estado from FOUR_SIZONS.Habitacion as Ha JOIN FOUR_SIZONS.Hotel " +
            "as Ho on Ho.Hotel_Codigo = Ha.Hotel_Codigo JOIN FOUR_SIZONS.Habitacion_Tipo as HT on " +
            "HT.Habitacion_Tipo_Codigo = Ha.Habitacion_Tipo_Codigo" +
                            " WHERE 1=1";
            
            if (txt_nro_hab.Text != "")
                con.strQuery = con.strQuery + "AND Habitacion_Numero = " + txt_nro_hab.Text + " ";
            if (txt_piso.Text != "")
                con.strQuery = con.strQuery + "AND Ha.Habitacion_Piso = " + txt_piso.Text + " ";
            
            con.strQuery = con.strQuery + "ORDER BY Ho.Hotel_Codigo, Ha.Habitacion_Numero";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado habitaciones. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Habitaciones.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetDecimal(1),
            con.lector.GetDecimal(2), con.lector.GetDecimal(3), con.lector.GetString(4), con.lector.GetString(5),
            con.lector.GetBoolean(6)});

            while (con.reader())
            {
                dgv_Habitaciones.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetDecimal(1),
                con.lector.GetDecimal(2), con.lector.GetDecimal(3), con.lector.GetString(4), con.lector.GetString(5),
                con.lector.GetBoolean(6)});
            }
            con.closeConection();
        }

        private void boton_alta_Click(object sender, EventArgs e)
        {
            string modo = "INS";
            this.Hide();
            ABMHabitacion02 formABMHabitacion02 = new ABMHabitacion02(modo, dgv_hotel_ID, dgv_habitacion_ID);
            formABMHabitacion02.ShowDialog();
            this.Show();
            this.buscar();
            this.refrescarGrid();
        }

        private void boton_baja_Click(object sender, EventArgs e)
        {
            string modo = "DLT";
            this.Hide();
            ABMHabitacion02 formABMHabitacion02 = new ABMHabitacion02(modo, dgv_hotel_ID, dgv_habitacion_ID);
            formABMHabitacion02.ShowDialog();
            this.Show();
            this.buscar();
            this.refrescarGrid();
        }

        private void boton_modificacion_Click(object sender, EventArgs e)
        {
            string modo = "UPD";
            this.Hide();
            ABMHabitacion02 formABMHabitacion02 = new ABMHabitacion02(modo, dgv_hotel_ID, dgv_habitacion_ID);
            formABMHabitacion02.ShowDialog();
            this.Show();
            this.buscar();
            this.refrescarGrid();
        }

        private void refrescarGrid()
        {
            dgv_Habitaciones.ClearSelection();
            foreach (DataGridViewRow row in dgv_Habitaciones.Rows)
                if (Convert.ToBoolean(row.Cells[6].Value) == false)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
        }

        private void ABMHabitacion01_Load(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void dgv_Habitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_Habitaciones.Rows[index];
            dgv_hotel_ID = Convert.ToDecimal(selectedRow.Cells[1].Value.ToString());
            dgv_habitacion_ID = Convert.ToDecimal(selectedRow.Cells[2].Value.ToString());
        }

    }
}