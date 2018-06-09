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
            con.strQuery = "SELECT Usuario_Password, Usuario_FallaLog FROM FOUR_SIZONS.Usuario WHERE Usuario_ID='" + txt_usuario.Text + "'";

            con.executeQuery();

            if (con.reader())
            {
                string passwordRet = con.lector.GetString(0);
                decimal falla_logRet = con.lector.GetDecimal(1);
                if (falla_logRet < 3)
                {
                    if (txt_password.Text == passwordRet)
                    {
                        con.closeConection();
                        this.Hide();
                        FrbaHotel.PantallaPrincipal.PantallaPrincipal01 pantallaPrincipal = new PantallaPrincipal01();
                        pantallaPrincipal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        con.closeConection();
                        MessageBox.Show("La contraseña es incorrecta", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (falla_logRet < 2)
                        {
                            con.strQuery = "UPDATE FOUR_SIZONS.Usuario SET Usuario_FallaLog = Usuario_FallaLog + 1 WHERE Usuario_ID='" + txt_usuario.Text + "'";
                            con.executeNoReturnQuery();
                            con.closeConection();
                        }else{
                            con.strQuery = "UPDATE FOUR_SIZONS.Usuario SET Usuario_FallaLog = Usuario_FallaLog + 1, Usuario_Estado = 0 WHERE Usuario_ID='" + txt_usuario.Text + "'";
                            con.executeNoReturnQuery();
                            MessageBox.Show("El usuario está deshabilitado", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.closeConection();
                        }

                    }
                }
                else
                {
                    con.closeConection();
                    MessageBox.Show("El usuario está deshabilitado", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
