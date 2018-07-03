using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.ListadoEstadistico
{
    public partial class ListadoEstadistico01 : Form
    {
        public string nombreStored;
        //public DataSet dataset;

        public ListadoEstadistico01()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadoEstadistico01_Load(object sender, EventArgs e)
        {
            cb_Trimestre.Items.Add("");
            cb_Trimestre.Items.Add("1");
            cb_Trimestre.Items.Add("2");
            cb_Trimestre.Items.Add("3");

            cb_TipoListado.Items.Add("Hotel con mayor cantidad de reservas canceladas");
            cb_TipoListado.Items.Add("Hoteles con mayor cantidad de consumibles facturados");
            cb_TipoListado.Items.Add("Hoteles con mayor cantidad de días fuera de servicio");
            cb_TipoListado.Items.Add("Habitaciones con mayor cantidad de días y veces que fueron ocupadas");
            cb_TipoListado.Items.Add("Cliente con mayor cantidad de puntos");
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_Anio.Text = "";
            cb_Trimestre.Text = "";
            cb_TipoListado.Text = "";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            switch (cb_TipoListado.Text)
            {
                case "Hotel con mayor cantidad de reservas canceladas":
                    nombreStored = "FOUR_SIZONS.HotelesMasReservasC";
                    ejecutarListado(nombreStored, dataset);
                    dgv_Listado.ColumnCount = 1;
                    dgv_Listado.Columns[0].Name = "Código Hotel";

                    for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                    {
                        dgv_Listado.Rows.Add(new Object[] { (dataset.Tables[0].Rows[i][0]).ToString()});
                    }
                    break;
                case "Hoteles con mayor cantidad de consumibles facturados":
                    nombreStored = "FOUR_SIZONS.HotelesMayorConsFact";
                    ejecutarListado(nombreStored, dataset);
                    dgv_Listado.ColumnCount = 1;
                    dgv_Listado.Columns[0].Name = "Código Hotel";

                    for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                    {
                        dgv_Listado.Rows.Add(new Object[] { (dataset.Tables[0].Rows[i][0]).ToString()});
                    }
                    break;
                case "Hoteles con mayor cantidad de días fuera de servicio":
                    nombreStored = "FOUR_SIZONS.hotelMasCerrado";
                    ejecutarListado(nombreStored, dataset);
                    dgv_Listado.ColumnCount = 1;
                    dgv_Listado.Columns[0].Name = "Código Hotel";

                    for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                    {
                        dgv_Listado.Rows.Add(new Object[] { (dataset.Tables[0].Rows[i][0]).ToString()});
                    }
                    break;
                case "Habitaciones con mayor cantidad de días y veces que fueron ocupadas":
                    nombreStored = "FOUR_SIZONS.habOcupadas";
                    ejecutarListado(nombreStored, dataset);

                    dgv_Listado.ColumnCount = 2;
                    dgv_Listado.Columns[0].Name = "Número Habitación";
                    dgv_Listado.Columns[1].Name = "Código Hotel";

                    for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                    {
                        dgv_Listado.Rows.Add(new Object[] { (dataset.Tables[0].Rows[i][0]).ToString(), 
                                                            (dataset.Tables[0].Rows[i][1]).ToString()});
                    }
                    break;
                case "Cliente con mayor cantidad de puntos":
                    nombreStored = "FOUR_SIZONS.clieMayorPuntaje";
                    ejecutarListado(nombreStored, dataset);
                    dgv_Listado.ColumnCount = 2;
                    dgv_Listado.Columns[0].Name = "Código Cliente";

                    for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                    {
                        dgv_Listado.Rows.Add(new Object[] { (dataset.Tables[0].Rows[i][0]).ToString(), 
                                                            (dataset.Tables[0].Rows[i][1]).ToString()});
                    }
                    break;
            }

        }

        private void ejecutarListado(string nombreStored, DataSet dataset) 
        {
            try
            {
                Conexion con = new Conexion();
                con.strQuery = nombreStored;
                con.execute();
                con.command.CommandType = CommandType.StoredProcedure;

                con.command.Parameters.Add("@anio", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_Anio.Text);
                con.command.Parameters.Add("@tri", SqlDbType.Decimal).Value = Convert.ToDecimal(cb_Trimestre.Text);

                con.openConection();

                /*DataSet dataset = new DataSet();
                SqlDataAdapter adaptador = new SqlDataAdapter(con.command);

                adaptador.Fill(dataset);*/


                SqlDataAdapter da = new SqlDataAdapter(con.command);

                da.Fill(dataset);

                /*dgv_Listado.ColumnCount = 2;
                dgv_Listado.Columns[0].Name = "Número Habitación";
                dgv_Listado.Columns[1].Name = "Código Hotel";



                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    dgv_Listado.Rows.Add(new Object[] { (dataset.Tables[0].Rows[i][0]).ToString(), (dataset.Tables[0].Rows[i][1]).ToString() });
                }*/

                MessageBox.Show("Consulta correcta", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
