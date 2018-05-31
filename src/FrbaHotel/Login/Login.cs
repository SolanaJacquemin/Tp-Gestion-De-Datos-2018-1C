using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.PantallaPrincipal;

namespace FrbaHotel
{
    public partial class Login : Form
    {
        private Conexion con = new Conexion();
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.cerrarConexion();
            con.query = "SELECT Usuario_Password, Usuario_Estado FROM FOUR_SIZONS.Usuario WHERE Usuario_ID='" + textBox1.Text + "'";

            con.ejecutarQuery();

            if (con.leerReader())
            {
                if (textBox2.Text == con.lector.GetString(0))
                {
                    con.cerrarConexion();
                    this.Hide();
                    FrbaHotel.PantallaPrincipal.PantallaPrincipal01 pantallaPrincipal = new PantallaPrincipal01();
                    pantallaPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else{
                con.cerrarConexion();
                MessageBox.Show("El usuario no existe", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
