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
            txt_usuario.CharacterCasing = CharacterCasing.Upper;
            txt_password.CharacterCasing = CharacterCasing.Upper;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.closeConection();
            con.strQuery = "SELECT Usuario_Password, Usuario_Estado FROM FOUR_SIZONS.Usuario WHERE Usuario_ID='" + txt_usuario.Text + "'";

            con.executeQuery();

            if (con.reader())
            {
                if (txt_password.Text == con.lector.GetString(0))
                {
                    con.closeConection();
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
                con.closeConection();
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
