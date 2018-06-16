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
using FrbaHotel.ABMRol;
using FrbaHotel.ABMHotel;
using FrbaHotel.ABMHabitacion;

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

        private void btn_roles_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMRol01 formABMRol01 = new ABMRol01();
            formABMRol01.ShowDialog();
            this.Show();
        }

        private void btn_hoteles_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMHotel01 formABMHotel01 = new ABMHotel01();
            formABMHotel01.ShowDialog();
            this.Show();
        }

        private void btn_habitaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMHabitacion01 formABMHabitacion01 = new ABMHabitacion01();
            formABMHabitacion01.ShowDialog();
            this.Show();
        }
    }
}
