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
using FrbaHotel.GestionReservas;
using FrbaHotel.AbmCliente;
using FrbaHotel.ListadoEstadistico;
using FrbaHotel.Prompts;
using FrbaHotel.FacturarEstadia;
using FrbaHotel.RegistrarEstadia;

namespace FrbaHotel.PantallaPrincipal
{
    public partial class PantallaPrincipal01 : Form
    {
        public string usuario;
        public decimal hotelCant;
        public decimal hotel;
        public string hotelNombre;

        public PantallaPrincipal01(string userSession)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            usuario = userSession;

            btn_roles.Visible = false;
            btn_usuarios.Visible = false;
            btn_clientes.Visible = false;
            btn_estadias.Visible = false;
            btn_hoteles.Visible = false;
            btn_habitaciones.Visible = false;
            btn_reservas.Visible = false;
            btn_listado.Visible = false;

            txt_usuario.Text = usuario;
            txt_nombreHotel.Text = hotelNombre;

            txt_nombreHotel.Enabled = false;
            txt_usuario.Enabled = false;
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

        private void btn_reservas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMReserva01 formABMReserva01 = new ABMReserva01(usuario);
            formABMReserva01.ShowDialog();
            this.Show();
        }


        private void btn_listado_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadoEstadistico01 listadoEstadistico01 = new ListadoEstadistico01();
            listadoEstadistico01.ShowDialog();
            this.Show();
        }
        private void btn_clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMCliente01 formABMCliente01 = new ABMCliente01();
            formABMCliente01.ShowDialog();
            this.Show();
        }

        private void PantallaPrincipal01_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            
            con.strQuery = "SELECT Hotel_Codigo FROM FOUR_SIZONS.UsuarioXHotel WHERE Usuario_ID = '" + usuario + "'";
            con.executeQuery();

            while (con.reader())
            {
                hotelCant = hotelCant + 1;
            }
            con.closeConection();

            if (hotelCant > 1) 
            {
                using (PromptElegirHotel promptEH = new PromptElegirHotel(usuario))
                {
                    promptEH.ShowDialog();
                    hotel = Convert.ToDecimal(promptEH.TextBox1.Text);
                    hotelNombre = promptEH.TextBox2.Text;
                    //promptEH.Close();
                }
            }

            txt_nombreHotel.Text = hotelNombre;

            con.strQuery = "SELECT F.Func_Codigo FROM FOUR_SIZONS.UsuarioXRol UR" +
                            " JOIN FOUR_SIZONS.Rol R ON R.Rol_Codigo = UR.Rol_Codigo" +
                            " JOIN FOUR_SIZONS.RolXFunc RF ON RF.Rol_Codigo = UR.Rol_Codigo" +
                            " JOIN FOUR_SIZONS.Funcionalidad F ON F.Func_Codigo = RF.Func_Codigo" +
                            " WHERE UR.UsuarioXRol_Estado = 1 AND" +
                            " F.Func_Estado = 1 AND UR.Usuario_ID = '" + usuario + "'";

            con.executeQuery();
           /* if (!con.reader())
            {
                MessageBox.Show("No se han encontrado usuarios. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }*/

            string funcion;

            while (con.reader())
            {

                funcion = con.lector.GetDecimal(0).ToString();
                switch(funcion)
                {
                    case "1":
                        btn_roles.Visible = true;
                        break;
                    case "2":
                        btn_usuarios.Visible = true;
                        break;
                    case "3":
                        btn_clientes.Visible = true;
                        break;
                    case "4":
                        btn_hoteles.Visible = true;
                        break;
                    case "5":
                        btn_habitaciones.Visible = true;
                        break;
                    case "6":
                        break;
                    case "7":
                        btn_reservas.Visible = true;
                        break;
                    case "8":
                        btn_reservas.Visible = true;
                        break;
                    case "9":
                        btn_estadias.Visible = true;
                        break;
                    case "11":
                        btn_listado.Visible = true;
                        break;
                }
            }

            con.closeConection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacturarEstadia01 formFacturarEstadia01 = new FacturarEstadia01();
            formFacturarEstadia01.ShowDialog();
            this.Show();
        }

        private void btn_estadias_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionEstadias formGestionEstadia01 = new GestionEstadias();
            formGestionEstadia01.ShowDialog();
            this.Show();
        }
    }
}
