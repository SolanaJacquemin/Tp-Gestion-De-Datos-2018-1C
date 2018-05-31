using System;
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
    public partial class ABMUsuario02 : Form
    {
        public ABMUsuario02(string modo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;
            switch (modo)
            {
                case "INS":
                    labelTitulo.Text = "Alta de Usuario";
                    break;
                case "DLT":
                    labelTitulo.Text = "Baja de Usuario";
                    break;
                case "UPD":
                    labelTitulo.Text = "Modificación de Usuario";
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ABMUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
