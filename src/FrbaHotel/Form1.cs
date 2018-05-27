using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class Form1 : Form
    {
        private Conexion con = new Conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //InitializeComponent();
            //Conexion con = new Conexion();
            con.query = "SELECT Cliente_Nombre, Cliente_Apellido, Cliente_NumDoc FROM FOUR_SIZONS.Cliente WHERE Cliente_Codigo = 1";
            con.ejecutarQuery();
            con.leerReader();
            textBox1.Text = con.lector.GetString(0);
            textBox2.Text = con.lector.GetString(1);
            textBox3.Text = con.lector.GetDecimal(2).ToString();
            con.cerrarConexion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
