﻿using System;
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
    public partial class ABMUsuarioPrompt : Form
    {
        public ABMUsuarioPrompt()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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
                return;
            }

            dgvUsuariosPrompt.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgvUsuariosPrompt.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1) });
            }
            con.closeConection();
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

        private void ABMUsuarioPrompt_Load(object sender, EventArgs e)
        {

        }

        /*private void dgvUsuariosPrompt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       

        }*/

        private void dgvUsuariosPrompt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvUsuariosPrompt.Rows[index];
            string dgv_usuario_ID = selectedRow.Cells[0].Value.ToString();
            string dgv_usuario_apellido = selectedRow.Cells[1].Value.ToString();

            //MessageBox.Show(selectedRow.Cells[0].Value.ToString()); 
        }
    }
}