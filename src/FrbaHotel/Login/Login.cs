using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaHotel.PantallaPrincipal;
using FrbaHotel.GestionReservas;

namespace FrbaHotel
{
    public partial class Login : Form
    {
        private Conexion con = new Conexion();
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //txt_usuario.CharacterCasing = CharacterCasing.Upper;

            txt_password.PasswordChar = '●';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../FOUR_SIZONS.JPG");
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            int errLogin = 0;
            if (txt_usuario.Text == "")
            {
                MessageBox.Show("Ingrese el usuario", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errLogin = 1;
            }

            if (txt_password.Text == "")
            {
                MessageBox.Show("Ingrese la contraseña", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errLogin = 1;
            }

            if (errLogin == 0)
            {
                try 
                {
                    Conexion con = new Conexion();
                    Encriptor encriptor = new Encriptor();
                    con.strQuery = "FOUR_SIZONS.ValidarUsuario";
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    con.command.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = txt_usuario.Text;
                    string msg = encriptor.Encrypt(txt_password.Text);
                    con.command.Parameters.Add("@password", SqlDbType.NVarChar).Value = encriptor.Encrypt(txt_password.Text);

                    con.openConection();
                    con.command.ExecuteNonQuery();
                    con.closeConection();
                    //con.command.Parameters.Add("@loginok", SqlDbType.Decimal).Direction = ParameterDirection.Output;

                    /*var errMsg = new SqlParameter();

                    errMsg.ParameterName = "@errorMsg";
                    errMsg.SqlDbType = System.Data.SqlDbType.NVarChar;
                    errMsg.Direction = ParameterDirection.Output;
                    errMsg.Size = 100;
                    con.command.Parameters.Add(errMsg);

                    con.openConection();
                    con.command.ExecuteNonQuery();
                    con.closeConection();
                    if ((Convert.ToDecimal(con.command.Parameters["@loginok"].Value) == 0))
                    {
                        MessageBox.Show(Convert.ToString(con.command.Parameters["@errorMsg"].Value), "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.Hide();
                        FrbaHotel.PantallaPrincipal.PantallaPrincipal01 pantallaPrincipal = new PantallaPrincipal01(txt_usuario.Text);
                        pantallaPrincipal.ShowDialog();
                        this.Show();
                        txt_usuario.Clear();
                        txt_password.Clear();                    
                    }*/
                    this.Hide();
                    FrbaHotel.PantallaPrincipal.PantallaPrincipal01 pantallaPrincipal = new PantallaPrincipal01(txt_usuario.Text);
                    pantallaPrincipal.ShowDialog();
                    this.Show();
                    txt_usuario.Clear();
                    txt_password.Clear();
                    this.StartPosition = FormStartPosition.CenterScreen;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_reservar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMReserva01 formABMReserva01 = new ABMReserva01("GUEST", 0);
            formABMReserva01.ShowDialog();
            txt_usuario.Clear();
            txt_password.Clear();
            this.Show();
        }

    }
}
