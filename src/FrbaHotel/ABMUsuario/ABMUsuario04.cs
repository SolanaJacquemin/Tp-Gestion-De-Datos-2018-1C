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

namespace FrbaHotel.ABMUsuario
{
    public partial class ABMUsuario04 : Form
    {
        public static string modoABM;
        public decimal hotel;
        public string usuario;

        public ABMUsuario04(string modo, string user, decimal hotelID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            hotel = hotelID;
            usuario = user;
            modoABM = modo;

            switch (modoABM)
            {
                case "INS":
                    labelTitulo.Text = "Agregar Hotel";
                    break;
                case "DLT":
                    labelTitulo.Text = "Eliminar Hotel";
                    txt_hotel.Enabled = false;
                    btn_promptUsu.Visible = false;
                    break;
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.strQuery = "FOUR_SIZONS.altaUserXHot";
            con.execute();
            con.command.CommandType = CommandType.StoredProcedure;
            con.command.Parameters.Add("@hotId", SqlDbType.Decimal).Value = hotel;
            con.command.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
            if (modoABM == "DLT")
            {
                con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;
            }
            else if (modoABM == "INS")
            {
                con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;
            }
            con.openConection();
            con.command.ExecuteNonQuery();
            con.closeConection();

            MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_promptUsu_Click(object sender, EventArgs e)
        {
            using (PromptHoteles prompt = new PromptHoteles())
            {
                prompt.ShowDialog();

                hotel = Convert.ToDecimal(prompt.TextBox1.Text);
                txt_hotel.Text = prompt.TextBox2.Text;

                prompt.Close();
            }
            this.Show();
        }

        private void ABMUsuario04_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT H.Hotel_Nombre FROM FOUR_SIZONS.UsuarioXHotel UH " +
                           "JOIN FOUR_SIZONS.Hotel H ON H.Hotel_Codigo = UH.Hotel_Codigo " +
                           "WHERE UH.Usuario_ID = '" + usuario + "' AND H.Hotel_Codigo = " + hotel;
            con.executeQuery();

            if(con.reader())
            {
                txt_hotel.Text = con.lector.GetString(0);
            }

            con.closeConection();
        }
    }
}