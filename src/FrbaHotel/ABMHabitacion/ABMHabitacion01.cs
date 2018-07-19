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

namespace FrbaHotel.ABMHabitacion
{
    public partial class ABMHabitacion01 : Form
    {
        public decimal dgv_hotel_ID;
        public decimal dgv_habitacion_ID;
        public int index;
        public decimal hotel;
        public decimal error;
        public bool esAdminGral;
        public string usuario;
        public bool estado;

        public ABMHabitacion01(decimal hotelID, string usuarioID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            error = 0;
            hotel = hotelID;
            usuario = usuarioID;

            cb_tipoFrente.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipohab.DropDownStyle = ComboBoxStyle.DropDownList;

            iniciarGrilla();

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

            con.strQuery = "SELECT U.Usuario_ID, U.Usuario_Nombre, U.Usuario_Apellido, U.Usuario_TipoDoc, U.Usuario_NroDoc, U.Usuario_Telefono, U.Usuario_Direccion, U.Usuario_Fec_Nac, U.Usuario_Mail, U.Usuario_Estado, U.Usuario_FallaLog" +
                           " FROM FOUR_SIZONS.Usuario U" +
                           " JOIN FOUR_SIZONS.UsuarioXRol UR ON UR.Usuario_ID = U.Usuario_ID" +
                           " WHERE UR.Rol_Codigo = 1 AND U.Usuario_ID = '" + usuario + "'";

            con.executeQuery();

            esAdminGral = false;
            if (con.reader())
            {
                esAdminGral = true;
            }
            con.closeConection();

        }


        public void iniciarGrilla()
        {

            dgv_Habitaciones.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "select Ho.Hotel_Nombre, Ha.Hotel_Codigo, Ha.Habitacion_Numero, Ha.Habitacion_Piso, HT.Habitacion_Tipo_Descripcion, " +
            "Ha.Habitacion_Frente, Ha.Habitacion_Estado from FOUR_SIZONS.Habitacion as Ha JOIN FOUR_SIZONS.Hotel " +
            "as Ho on Ho.Hotel_Codigo = Ha.Hotel_Codigo JOIN FOUR_SIZONS.Habitacion_Tipo as HT on " +
            "HT.Habitacion_Tipo_Codigo = Ha.Habitacion_Tipo_Codigo" +
                            " WHERE 1=1";
            if ((hotel != 0) && (!esAdminGral))
            {
                con.strQuery = con.strQuery + " AND HO.Hotel_Codigo = " + hotel;
                btn_promptHotel.Enabled = false;
            }
            con.strQuery = con.strQuery + " ORDER BY Ho.Hotel_Codigo, Ha.Habitacion_Numero";
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

            dgv_Habitaciones.ClearSelection();
            foreach (DataGridViewRow row in dgv_Habitaciones.Rows)
                if (Convert.ToBoolean(row.Cells[6].Value) == false)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
        }

        public void limpiar()
        {
            dgv_Habitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Habitaciones.Rows.Clear();
            txt_hotel.Text = "";
            txt_piso.Text = "";
            txt_nro_hab.Text = "";
            cb_tipohab.Items.Clear();
            cb_tipoFrente.Items.Clear();
            iniciarGrilla();

        }

        bool IsNumber(string s)
        {
            if (s != "")
            {
                foreach (char c in s)
                {
                    if (!Char.IsDigit(c))
                        return false;
                }
                return true;
            }
            else return false;
        }

        private void buscar()
        {


            if ((!IsNumber(txt_piso.Text) && txt_piso.Text != "") || (!IsNumber(txt_nro_hab.Text) && txt_nro_hab.Text != ""))
            {
                MessageBox.Show("Por favor, tanto el piso como el número de habitación deben ser un datos numéricos.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
                if (cb_tipoFrente.Text != "")
                    con.strQuery = con.strQuery + "AND Ha.Habitacion_Frente = '" + cb_tipoFrente.Text + "' ";
                if (cb_tipohab.Text != "")
                    con.strQuery = con.strQuery + "AND HT.Habitacion_Tipo_Descripcion = '" + cb_tipohab.Text + "' ";
                if (hotel != 0)
                {
                    con.strQuery = con.strQuery + " AND HO.Hotel_Codigo = " + hotel;
                }
                con.strQuery = con.strQuery + " ORDER BY Ho.Hotel_Codigo, Ha.Habitacion_Numero";
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

                dgv_Habitaciones.ClearSelection();
                foreach (DataGridViewRow row in dgv_Habitaciones.Rows)
                    if (Convert.ToBoolean(row.Cells[6].Value) == false)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
            }
        }

        private void boton_alta_Click(object sender, EventArgs e)
        {
            if (error == 0)
            {
                string modo = "INS";
                this.Hide();
                ABMHabitacion02 formABMHabitacion02 = new ABMHabitacion02(modo, hotel, dgv_habitacion_ID);
                formABMHabitacion02.ShowDialog();
                this.Show();
                this.buscar();
                this.iniciarGrilla();
            }
            
        }
        private void boton_baja_Click(object sender, EventArgs e)
        {
            if (dgv_Habitaciones.SelectedRows.Count > 0)
            {
                if (!estado)
                {
                    MessageBox.Show("No puede dar de baja a una habitación dada de baja", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                        string modo = "DLT";
                        this.Hide();
                        ABMHabitacion02 formABMHabitacion02 = new ABMHabitacion02(modo, dgv_hotel_ID, dgv_habitacion_ID);
                        formABMHabitacion02.ShowDialog();
                        this.Show();
                        this.buscar();
                        this.iniciarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una habitación de la grilla primero", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void boton_modificacion_Click(object sender, EventArgs e)
        {
            if (dgv_Habitaciones.SelectedRows.Count > 0)
            {
                if (!estado)
                {
                    if (MessageBox.Show("La habitación se encuentra inhabilitada, desea darle de alta?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string modo = "UPD";
                        this.Hide();
                        ABMHabitacion02 formABMHabitacion02 = new ABMHabitacion02(modo, dgv_hotel_ID, dgv_habitacion_ID);
                        formABMHabitacion02.ShowDialog();
                        this.Show();
                        this.buscar();
                        this.iniciarGrilla();
                    }
                }
                else
                {
                    string modo = "UPD";
                    this.Hide();
                    ABMHabitacion02 formABMHabitacion02 = new ABMHabitacion02(modo, dgv_hotel_ID, dgv_habitacion_ID);
                    formABMHabitacion02.ShowDialog();
                    this.Show();
                    this.buscar();
                    this.iniciarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una habitación de la grilla primero", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ABMHabitacion01_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            if (hotel != 0)
            {
                
                con.strQuery = "SELECT H.Hotel_Nombre FROM FOUR_SIZONS.Hotel H WHERE H.Hotel_Codigo = " + hotel;
                con.executeQuery();

                if (con.reader())
                {
                    txt_hotel.Text = con.lector.GetString(0);
                }
                con.closeConection();
                txt_hotel.Enabled = false;
            }

            dgv_Habitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cb_tipoFrente.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipohab.DropDownStyle = ComboBoxStyle.DropDownList;
            dgv_Habitaciones.Rows.Clear();

            con.strQuery = "select Ho.Hotel_Nombre, Ha.Hotel_Codigo, Ha.Habitacion_Numero, Ha.Habitacion_Piso, HT.Habitacion_Tipo_Descripcion, " +
            "Ha.Habitacion_Frente, Ha.Habitacion_Estado from FOUR_SIZONS.Habitacion as Ha JOIN FOUR_SIZONS.Hotel " +
            "as Ho on Ho.Hotel_Codigo = Ha.Hotel_Codigo JOIN FOUR_SIZONS.Habitacion_Tipo as HT on " +
            "HT.Habitacion_Tipo_Codigo = Ha.Habitacion_Tipo_Codigo ";
            if (hotel != 0)
            {
                con.strQuery = con.strQuery + " AND HO.Hotel_Codigo = " + hotel;
            }
            con.strQuery = con.strQuery + " ORDER BY Ho.Hotel_Codigo, Ha.Habitacion_Numero";

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

            dgv_Habitaciones.ClearSelection();
            foreach (DataGridViewRow row in dgv_Habitaciones.Rows)
                if (Convert.ToBoolean(row.Cells[6].Value) == false)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }

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

        public void refrescarGrid()
        {

        }

        public void dgv_Habitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0) 
            {
                error = 0;
                DataGridViewRow selectedRow = dgv_Habitaciones.Rows[index];
                dgv_hotel_ID = Convert.ToDecimal(selectedRow.Cells[1].Value.ToString());
                dgv_habitacion_ID = Convert.ToDecimal(selectedRow.Cells[2].Value.ToString());
                estado = Convert.ToBoolean(selectedRow.Cells[6].Value);
            }
            else
            {
                error = 1;
            }
        }

        private void btn_promptUsu_Click(object sender, EventArgs e)
        {

        }

        private void btn_promptHotel_Click(object sender, EventArgs e)
        {
            using (PromptHoteles prompt = new PromptHoteles())
            {
                prompt.ShowDialog();

                if (prompt.TextBox1.Text != "")
                {
                    hotel = Convert.ToDecimal(prompt.TextBox1.Text);
                    txt_hotel.Text = prompt.TextBox2.Text;
                }

                prompt.Close();
            }
        }

    }
}