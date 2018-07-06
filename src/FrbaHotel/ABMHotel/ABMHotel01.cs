﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ABMHotel
{
    public partial class ABMHotel01 : Form
    {
        public string dgv_hotel_codigo;
        public int index;

        public ABMHotel01()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dgv_Hoteles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Hoteles.Rows.Clear();

            cb_estrellas.DropDownStyle = ComboBoxStyle.DropDownList;

            iniciarGrilla();

            cb_estrellas.Items.Add("");
            cb_estrellas.Items.Add("1");
            cb_estrellas.Items.Add("2");
            cb_estrellas.Items.Add("3");
            cb_estrellas.Items.Add("4");
            cb_estrellas.Items.Add("5");
        }



        private void refrescarGrid()
        {
            dgv_Hoteles.ClearSelection();
            foreach (DataGridViewRow row in dgv_Hoteles.Rows)
                if (Convert.ToBoolean(row.Cells[11].Value) == false)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
        }

        public void iniciarGrilla()
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT * FROM FOUR_SIZONS.Hotel ORDER BY Hotel_Codigo";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado usuarios. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Hoteles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
            con.lector.GetString(2), con.lector.GetString(3), con.lector.GetString(4), con.lector.GetDecimal(5),
            con.lector.GetDecimal(6), con.lector.GetDecimal(7), con.lector.GetString(8), con.lector.GetString(9),
            con.lector.GetDateTime(10), con.lector.GetBoolean(11)});

            while (con.reader())
            {
                dgv_Hoteles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
                con.lector.GetString(2), con.lector.GetString(3), con.lector.GetString(4), con.lector.GetDecimal(5),
                con.lector.GetDecimal(6), con.lector.GetDecimal(7), con.lector.GetString(8), con.lector.GetString(9),
                con.lector.GetDateTime(10), con.lector.GetBoolean(11)});
            }
            con.closeConection();
        }

        private void buscar()
        {
            dgv_Hoteles.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT * FROM FOUR_SIZONS.Hotel WHERE 1=1";
            if (txt_codigo.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_Codigo =" + txt_codigo.Text;
            if (txt_nombre.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_Nombre like '%" + txt_nombre.Text + "%' ";
            if (txt_mail.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_Mail like '%" + txt_mail.Text + "%' ";
            if (txt_telefono.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_Telefono like '%" + txt_telefono.Text + "%' ";
            if (txt_calle.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_Calle like '%" + txt_calle.Text + "%' ";
            if (cb_estrellas.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_CantEstrella = " + cb_estrellas.Text + " ";
            if (txt_ciudad.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_Ciudad like '%" + txt_ciudad.Text + "%' ";
            if (txt_pais.Text != "")
                con.strQuery = con.strQuery + "AND Hotel_Pais like '%" + txt_pais.Text + "%' ";
            con.strQuery = con.strQuery + "ORDER BY Hotel_Codigo";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado usuarios. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Hoteles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
            con.lector.GetString(2), con.lector.GetString(3), con.lector.GetString(4), con.lector.GetDecimal(5),
            con.lector.GetDecimal(6), con.lector.GetDecimal(7), con.lector.GetString(8), con.lector.GetString(9),
            con.lector.GetDateTime(10), con.lector.GetBoolean(11)});

            while (con.reader())
            {
                dgv_Hoteles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
                con.lector.GetString(2), con.lector.GetString(3), con.lector.GetString(4), con.lector.GetDecimal(5),
                con.lector.GetDecimal(6), con.lector.GetDecimal(7), con.lector.GetString(8), con.lector.GetString(9),
                con.lector.GetDateTime(10), con.lector.GetBoolean(11)});
            }
            con.closeConection();
        }

        private void ABMHotel_Load(object sender, EventArgs e)
        {
            //refrescarGrid();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void cb_estrellas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_mail.Text = "";
            txt_telefono.Text = "";
            txt_calle.Text = "";
            cb_estrellas.Text = "";
            txt_ciudad.Text = "";
            txt_pais.Text = "";
            iniciarGrilla();
            refrescarGrid();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_alta_Click(object sender, EventArgs e)
        {
            string modo = "INS";
            this.Hide();
            ABMHotel02 formABMUsuario02 = new ABMHotel02(modo, txt_codigo.Text);
            formABMUsuario02.ShowDialog();
            this.Show();
            this.buscar();
            this.refrescarGrid();
        }

        private void boton_baja_Click(object sender, EventArgs e)
        {
            string modo = "DLT";
            this.Hide();
            ABMHotel02 formABMUsuario02 = new ABMHotel02(modo, dgv_hotel_codigo);
            formABMUsuario02.ShowDialog();
            this.Show();
            this.buscar();
            this.refrescarGrid();
        }

        private void boton_modificacion_Click(object sender, EventArgs e)
        {
            string modo = "UPD";
            this.Hide();
            ABMHotel02 formABMUsuario02 = new ABMHotel02(modo, dgv_hotel_codigo);
            formABMUsuario02.ShowDialog();
            this.Show();
            this.buscar();
            this.refrescarGrid();
        }

        public void dgv_Hoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_Hoteles.Rows[index];
            dgv_hotel_codigo = selectedRow.Cells[0].Value.ToString();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            string modo = "CLS";
            this.Hide();
            ABMHotel03 formABMHotel03 = new ABMHotel03(Convert.ToDecimal(dgv_hotel_codigo));
            formABMHotel03.ShowDialog();
            this.Show();
            this.buscar();
            this.refrescarGrid();
        }
    }
}
