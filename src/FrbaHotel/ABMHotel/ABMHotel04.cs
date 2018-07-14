using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ABMHotel
{
    public partial class ABMHotel04 : Form
    {
        public static string modoABM;
        public string nombreSP;
        public decimal hotel;
        public int error;
        public DateTime hoy;
        public string regimen_nombre;
        public decimal regimen_codigo;
        public bool altaValida;

        public ABMHotel04(string modo, decimal HotelID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;

            hotel = HotelID;
            modoABM = modo;
            hoy = DateTime.Today;

            switch (modoABM)
            {
                case "INS":
                    labelTitulo.Text = "Alta de Régimen";
                    break;
                case "DLT":
                    labelTitulo.Text = "Baja de Régimen";
                    lb_regimen.Enabled = false;
                    lb_regimen_usralta.Enabled = false;
                    btn_agregar.Enabled = false;
                    btn_agregarTodo.Enabled = false;
                    btn_eliminar.Enabled = false;
                    btn_eliminarTodo.Enabled = false;
                    break;
                case "UPD":
                    labelTitulo.Text = "Modificación de Régimen";
                    break;
            }
        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            // Se determina el stored procedure a utilizar
            switch (modoABM)
            {
                case "INS":
                    if (lb_regimen_usralta.Items.Count != 0)
                    {
                        nombreSP = "FOUR_SIZONS.altaRegXHotel";
                    }
                    else
                    {
                        error = 1;
                        MessageBox.Show("El hotel no puede no tener regímenes.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "UPD":
                    if (lb_regimen_usralta.Items.Count != 0)
                    {
                        nombreSP = "FOUR_SIZONS.modificarRegXhot";
                    }
                    else
                    {
                        error = 1;
                        MessageBox.Show("El hotel no puede no tener regímenes.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    break;

                case "DLT":
                    // Baja lógica - Se pone estado en 0
                    nombreSP = "FOUR_SIZONS.ModificacionRol";
                    break;
            }

            if (error == 0)
            {
                ejecutarABMRol(nombreSP);
                this.Close();
            }
        }

        public void ejecutarABMRol(string nombreStored)
        {
            if (MessageBox.Show("Está seguro que desea continuar con la operación?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // se agrega el código en un try / catch para poder capturar los errores
                try
                {
                    // se crea un nuevo conector, se asigna el nombre del stored y con execute se crea el nuevo comando sql
                    Conexion con = new Conexion();
                    con.strQuery = nombreStored;
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    if (modoABM == "INS")
                    {
                        // Se generan llamadas sucesivas para ingresar todos los regimenes
                        for (int i = 0; i < lb_regimen_usralta.Items.Count; i++)
                        {
                            con.execute();
                            con.command.CommandType = CommandType.StoredProcedure;
                            // se agregan los parámetros al stored procedure
                            con.command.Parameters.Add("@regimen", SqlDbType.NVarChar).Value = lb_regimen.Items[i].ToString();
                            con.command.Parameters.Add("@hotID", SqlDbType.NVarChar).Value = hotel;
                            // se abre la conexión con la base de datos, se ejecuta y se cierra
                            con.openConection();
                            con.command.ExecuteNonQuery();
                            con.closeConection();
                        }
                    }
                    else
                    {
                        // en caso de modificar se cambia el nombre del sp y se itera los llamados por cada uno de los elementos del listbox
                        con.strQuery = "FOUR_SIZONS.modificarRegXhot";
                        for (int i = 0; i < lb_regimen_usralta.Items.Count; i++)
                        {
                            con.execute();
                            con.command.CommandType = CommandType.StoredProcedure;

                            con.command.Parameters.Add("@hotel", SqlDbType.Decimal).Value = hotel;
                            con.command.Parameters.Add("@reg", SqlDbType.NVarChar).Value = lb_regimen_usralta.Items[i].ToString();
                            con.command.Parameters.Add("@fechaMod", SqlDbType.DateTime).Value = hoy;
                            con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;

                            // se abre la conexión con la base de datos, se ejecuta y se cierra
                            con.openConection();
                            con.command.ExecuteNonQuery();
                            con.closeConection();
                        }
                        // se itera los llamados por cada uno de los elementos del listbox para dar de baja
                        for (int i = 0; i < lb_regimen_usrbaja.Items.Count; i++)
                        {
                            con.execute();
                            con.command.CommandType = CommandType.StoredProcedure;

                            con.command.Parameters.Add("@hotel", SqlDbType.Decimal).Value = hotel;
                            con.command.Parameters.Add("@reg", SqlDbType.NVarChar).Value = lb_regimen_usralta.Items[i].ToString();
                            con.command.Parameters.Add("@fechaMod", SqlDbType.DateTime).Value = hoy;

                            string msg = lb_regimen_usralta.Items[i].ToString();

                            con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;
                            con.openConection();
                            con.command.ExecuteNonQuery();
                            con.closeConection();
                        }

                    }
                    MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    error = 1;
                    MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                error = 1;
                MessageBox.Show("No se ha completado la operación", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (lb_regimen.SelectedItem != null)
            {
                lb_regimen_usralta.Items.Add(lb_regimen.SelectedItem);
            }
            else
            {
                MessageBox.Show("No hay ítem seleccionado");
            }
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (lb_regimen_usralta.SelectedItem != null)
            {
                lb_regimen_usrbaja.Items.Add(lb_regimen_usralta.SelectedItem);
                lb_regimen_usralta.Items.Remove(lb_regimen_usralta.SelectedItem);
            }
            else
            {
                MessageBox.Show("No hay ítem seleccionado");
            }
        }

        private void btn_agregarTodo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_regimen.Items.Count; i++)
            {
                lb_regimen_usralta.Items.Add(lb_regimen.Items[i].ToString());
            }
        }

        private void btn_eliminarTodo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_regimen_usralta.Items.Count; i++)
            {
                lb_regimen_usrbaja.Items.Add(lb_regimen_usralta.Items[i].ToString());
            }
            lb_regimen_usralta.Items.Clear();
        }

        private void ABMHotel04_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT H.Hotel_Nombre FROM FOUR_SIZONS.Hotel H WHERE H.Hotel_Codigo = " + hotel;
            con.executeQuery();

            if (con.reader())
            {
                txt_nombre.Text = con.lector.GetString(0);
                txt_nombre.Enabled = false;
            }
            con.closeConection();

            con.strQuery = "SELECT * FROM FOUR_SIZONS.Regimen ORDER BY Regimen_Codigo";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado hoteles. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            regimen_nombre = con.lector.GetString(1);
            lb_regimen.Items.Add(regimen_nombre);

            while (con.reader())
            {
                regimen_nombre = con.lector.GetString(1);
                lb_regimen.Items.Add(regimen_nombre);
            }
            con.closeConection();


            if (modoABM != "INS")
            {

                con.strQuery = "SELECT R.Regimen_Descripcion" + 
                               " FROM FOUR_SIZONS.RegXHotel RH JOIN FOUR_SIZONS.Regimen R ON R.Regimen_Codigo = RH.Regimen_Codigo" +
                               " WHERE RegXHotel_Estado = 1 AND RH.Hotel_Codigo = " + hotel;
                con.executeQuery();

                while (con.reader())
                {
                    lb_regimen_usralta.Items.Add(con.lector.GetString(0));
                }
                con.closeConection();
            }
        }
    }
}
