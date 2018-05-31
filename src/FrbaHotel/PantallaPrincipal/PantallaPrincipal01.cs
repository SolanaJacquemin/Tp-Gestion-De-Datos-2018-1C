using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.ABMUsuario;

namespace FrbaHotel.PantallaPrincipal
{
    public partial class PantallaPrincipal01 : Form
    {
        public PantallaPrincipal01()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMUsuario01 formABMUsuario01 = new ABMUsuario01();
            formABMUsuario01.ShowDialog();
            this.Show();
        }
    }
}
