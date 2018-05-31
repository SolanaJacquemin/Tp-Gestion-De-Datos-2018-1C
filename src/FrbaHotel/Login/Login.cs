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
            /*InitializeComponent();
            Conexion con = new Conexion();
            con.query = "SELECT Cliente_Nombre, Cliente_Apellido, Cliente_NumDoc FROM FOUR_SIZONS.Cliente WHERE Cliente_Codigo = 1";
            con.ejecutarQuery();
            con.leerReader();
            textBox1.Text = con.lector.GetString(0);
            textBox2.Text = con.lector.GetString(1);
            con.cerrarConexion();*/
            this.Hide(); 
            FrbaHotel.PantallaPrincipal.PantallaPrincipal01 pantallaPrincipal = new PantallaPrincipal01();           
            pantallaPrincipal.ShowDialog();
            this.Close(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
