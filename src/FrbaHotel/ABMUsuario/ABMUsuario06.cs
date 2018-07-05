using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Prompts;

namespace FrbaHotel.ABMUsuario
{
    public partial class ABMUsuario06 : Form
    {
        public static string modoABM;
        public decimal rol;
        public string usuario;

        public ABMUsuario06(string modo, string user, decimal rolID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            rol = rolID;
            usuario = user;
            modoABM = modo;

            switch (modoABM)
            {
                case "INS":
                    labelTitulo.Text = "Agregar Rol";
                    break;
                case "DLT":
                    labelTitulo.Text = "Eliminar Rol";
                    txt_rol.Enabled = false;
                    btn_promptUsu.Visible = false;
                    break;
            }
        }

        private void btn_promptUsu_Click(object sender, EventArgs e)
        {
            using (PromptRoles prompt = new PromptRoles())
            {
                prompt.ShowDialog();

                rol = Convert.ToDecimal(prompt.TextBox1.Text);
                txt_rol.Text = prompt.TextBox2.Text;

                prompt.Close();
            }
            this.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
