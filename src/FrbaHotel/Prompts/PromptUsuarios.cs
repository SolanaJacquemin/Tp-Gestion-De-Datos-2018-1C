﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Prompts
{
    public partial class PromptUsuarios : Form
    {
        public PromptUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txt_aux_hotelid.Visible = false;
            dgvUsuariosPrompt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvUsuariosPrompt.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Usuario_ID, Usuario_Apellido " +
                           "FROM FOUR_SIZONS.Usuario ORDER BY Usuario_ID";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("La busqueda no produjo resultados");
                con.strQuery = "";
                con.closeConection();
                //return;
            }

            dgvUsuariosPrompt.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgvUsuariosPrompt.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1) });
            }
            con.closeConection();
        }

        private void PromptUsuarios_Load(object sender, EventArgs e)
        {

        }

        public TextBox TextBox1
        {
            get
            {
                return txt_aux_hotelid;
            }
        }

        private void dgvUsuariosPrompt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvUsuariosPrompt.Rows[index];
            string dgv_usuario_ID = selectedRow.Cells[0].Value.ToString();


            txt_aux_hotelid.Text = dgv_usuario_ID;

            this.Hide();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgvUsuariosPrompt.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Usuario_ID, Usuario_Apellido FROM FOUR_SIZONS.Usuario WHERE 1=1";
            if (txt_usuarioid.Text != "")
                con.strQuery = con.strQuery + " AND Usuario_ID like '%" + txt_usuarioid.Text + "%' ";
            con.strQuery = con.strQuery + "ORDER BY Usuario_ID";
            con.executeQuery();

            if (!con.reader())
            {
                MessageBox.Show("La busqueda no produjo resultados");
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgvUsuariosPrompt.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgvUsuariosPrompt.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1) });
            }

            con.closeConection();
        }
    }
}