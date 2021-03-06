﻿using System;
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
    public partial class RegistroTarjeta : Form
    {
        public decimal cliente;
        public decimal estadia;
        public decimal dgv_tarjeta_ID;

        public RegistroTarjeta(decimal clienteID, decimal estadiaID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            cliente = clienteID;
            estadia = estadiaID;

            txt_cliente.Enabled = false;
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMTarjeta formTarjeta = new ABMTarjeta("INS", dgv_tarjeta_ID,cliente);
            formTarjeta.ShowDialog();
            this.levantarGrilla();
            this.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMTarjeta formTarjeta = new ABMTarjeta("DLT", dgv_tarjeta_ID,cliente);
            formTarjeta.ShowDialog();
            this.levantarGrilla();
            this.Show();
        }

        private void levantarGrilla() 
        {
            dgv_tarjetas.Rows.Clear();
            Conexion con = new Conexion();

            con.strQuery = "SELECT T.Tarjeta_Numero, T.Tarjeta_Titular, T.Tarjeta_Marca, T.Tarjeta_Venc" +
                " FROM FOUR_SIZONS.Tarjeta T JOIN FOUR_SIZONS.Cliente C ON C.Cliente_Codigo = T.Cliente_Codigo" +
                " WHERE T.Tarjeta_Estado = 1 AND C.Cliente_Codigo = " + cliente;

            con.executeQuery();


            while (con.reader())
            {
                dgv_tarjetas.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
                con.lector.GetString(2), con.lector.GetDateTime(3)});
            }
            con.closeConection();
        }

        private void RegistroTarjeta_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            if (cliente == 0) 
            {
                con.strQuery = "SELECT C.Cliente_Codigo, C.Cliente_Nombre + ' ' + UPPER(C.Cliente_Apellido) FROM FOUR_SIZONS.EstadiaXCliente EC" +
                               " JOIN FOUR_SIZONS.Cliente C ON C.Cliente_Codigo = EC.Cliente_Codigo" +
                               " WHERE EC.Estadia_Codigo = " + estadia;
                con.executeQuery();
                if (con.reader())
                {
                    cliente = con.lector.GetDecimal(0);
                    txt_cliente.Text = con.lector.GetString(1);
                }
            }else{
                con.strQuery = "SELECT Cliente_Nombre + ' ' + UPPER(Cliente_Apellido) FROM FOUR_SIZONS.Cliente WHERE Cliente_Codigo = " + cliente;
                con.executeQuery();
                if (con.reader())
                {
                    txt_cliente.Text = con.lector.GetString(0);
                }
            }

            con.closeConection();

            con.strQuery = "SELECT T.Tarjeta_Numero, T.Tarjeta_Titular, T.Tarjeta_Marca, T.Tarjeta_Venc" +
                            " FROM FOUR_SIZONS.Tarjeta T JOIN FOUR_SIZONS.Cliente C ON C.Cliente_Codigo = T.Cliente_Codigo" +
                            " WHERE T.Tarjeta_Estado = 1 AND C.Cliente_Codigo = " + cliente;

            con.executeQuery();

            //dgv_tarjetas.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
            //con.lector.GetString(2), con.lector.GetDateTime(3)});

            while (con.reader())
            {
                dgv_tarjetas.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
                con.lector.GetString(2), con.lector.GetDateTime(3)});
            }
            con.closeConection();
        }

        private void dgv_tarjetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dgv_tarjetas.Rows[index];
                dgv_tarjeta_ID = Convert.ToDecimal(selectedRow.Cells[0].Value.ToString());
            }
        }
    }
}