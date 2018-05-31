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
    public partial class ABMUsuario01 : Form
    {
        public ABMUsuario01()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void boton_alta_Click(object sender, EventArgs e)
        {
            string modo = "INS";
            this.Hide();
            ABMUsuario02 formABMUsuario02 = new ABMUsuario02(modo);
            formABMUsuario02.ShowDialog();
            this.Show();
        }

        private void ABMUsuario01_Load(object sender, EventArgs e)
        {

        }

        private void boton_baja_Click(object sender, EventArgs e)
        {
            string modo = "DLT";
            this.Hide();
            ABMUsuario02 formABMUsuario02 = new ABMUsuario02(modo);
            formABMUsuario02.ShowDialog();
            this.Show();
        }

        private void boton_modificacion_Click(object sender, EventArgs e)
        {
            string modo = "UPD";
            this.Hide();
            ABMUsuario02 formABMUsuario02 = new ABMUsuario02(modo);
            formABMUsuario02.ShowDialog();
            this.Show();
        }
    }
}
