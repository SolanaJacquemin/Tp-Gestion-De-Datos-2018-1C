using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarConsumible
{
    public partial class Form1 : Form
    {
        public decimal dgv_CodEstadia;
        public int index;
        public decimal estadia;
        public decimal reserva;
        public string cons_nombre;
        public int error;
        public int cantAgr;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dgv_Estadia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Estadia.Rows.Clear();
            //          reserva=res;

            /*        Conexion con = new Conexion();
                    con.strQuery = " select Estadia_Codigo from FOUR_SIZONS.Estadia where Reserva_Codigo = " + reserva;
                    if (con.reader())
                    {
                        estadia = con.lector.GetDecimal(0);
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado la estadía. Por favor, realice una nueva búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }*/

            limpiar();
            //      txt_Estadia.Text = estadia.ToString();
        }

        public void limpiar()
        {

            txt_CodReserva.Text = "";
            txt_Estadia.Text = "";

            dgv_Estadia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Estadia.Rows.Clear();


            Conexion con = new Conexion();
            con.strQuery = "SELECT top 100 * FROM FOUR_SIZONS.Estadia" +
                            " WHERE 1=1";
            con.executeQuery();

            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado estadías. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Estadia.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetDecimal(1),
            con.lector.GetDateTime(2), con.lector.GetDateTime(3), con.lector.GetDecimal(4), con.lector.GetDecimal(5),
            con.lector.GetDecimal(6), con.lector.GetString(7), con.lector.GetString(8), con.lector.GetDecimal(9),
            con.lector.GetDecimal(10), con.lector.GetBoolean(11)});

            while (con.reader())
            {
                dgv_Estadia.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetDecimal(1),
            con.lector.GetDateTime(2), con.lector.GetDateTime(3), con.lector.GetDecimal(4), con.lector.GetDecimal(5),
            con.lector.GetDecimal(6), con.lector.GetString(7), con.lector.GetString(8), con.lector.GetDecimal(9),
            con.lector.GetDecimal(10), con.lector.GetBoolean(11)});
            }
            con.closeConection();
        }

        private void buscar()
        {
            dgv_Estadia.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = " SELECT * FROM FOUR_SIZONS.Estadia WHERE 1=1 ";

            if (txt_Estadia.Text != "")
                con.strQuery = con.strQuery + " AND Estadia_Codigo = " + txt_Estadia.Text;
            if (txt_CodReserva.Text != "")
                con.strQuery = con.strQuery + " AND Reserva_Codigo = " + txt_CodReserva.Text;

            con.executeQuery();

            if (!con.reader())
            {
                MessageBox.Show("No se ha encontrado la estadía. Revise el criterio de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Estadia.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetDecimal(1),
            con.lector.GetDateTime(2), con.lector.GetDateTime(3), con.lector.GetDecimal(4), con.lector.GetDecimal(5),
            con.lector.GetDecimal(6), con.lector.GetString(7), con.lector.GetString(8), con.lector.GetDecimal(9),
            con.lector.GetDecimal(10), con.lector.GetBoolean(11)});

            con.closeConection();

        }

        private void Consumibles_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT * FROM FOUR_SIZONS.Consumible";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado consumibles. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

        }

        public void ejecutarConsumible()
        {


            if (MessageBox.Show("Está seguro que desea continuar con la operación?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    estadia = Convert.ToDecimal(txt_Estadia.Text);

                    Conexion con = new Conexion();
                    con.strQuery = "FOUR_SIZONS.RegistrarConsXest";
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    con.command.Parameters.Add("@estadia", SqlDbType.Decimal).Value = estadia;
                    con.command.Parameters.Add("@consumible", SqlDbType.NVarChar).Value = cb_consumibles.SelectedItem;
                    con.command.Parameters.Add("@cant", SqlDbType.Decimal).Value = Convert.ToDecimal(cb_cantidad.SelectedItem);

                    con.openConection();
                    con.command.ExecuteNonQuery();
                    con.closeConection();


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

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            buscar();
        }

        private void btn_Limpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void boton_aceptar_Click_1(object sender, EventArgs e)
        {
            if (error == 0)
            {
                ejecutarConsumible();
                this.Close();
            }
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
