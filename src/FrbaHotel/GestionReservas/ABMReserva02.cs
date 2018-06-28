using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GestionReservas
{
    public partial class ABMReserva02 : Form
    {
        public static string modoABM;
        public string nombreSP;
        public string usuario;
        public int error;

        public ABMReserva02(string modo, string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;

            usuario = user;
            modoABM = modo;

            dt_fechaDesde.Format = DateTimePickerFormat.Custom;
            dt_fechaDesde.CustomFormat = "dd/MM/yyyy";

            dt_fechaHasta.Format = DateTimePickerFormat.Custom;
            dt_fechaHasta.CustomFormat = "dd/MM/yyyy";
        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            error = 0;
            switch (modoABM)
            {
                case "INS":
                    nombreSP = "FOUR_SIZONS.GenerarReserva";
                    break;

                /*case "UPD":
                    nombreSP = "FOUR_SIZONS.ModificacionUsuario";
                    break;

                case "DLT":
                    // Baja lógica - Se pone estado en 0
                    nombreSP = "FOUR_SIZONS.ModificacionUsuario";
                    break;*/
            }
            ejecutarABMUsuario(nombreSP);
            if (error == 0)
            {
                this.Close();
            }
        }

        public void ejecutarABMUsuario(string nombreStored)
        {
            if (MessageBox.Show("Está seguro que desea continuar con la operación?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    Conexion con = new Conexion();
                    Encriptor encriptor = new Encriptor();
                    con.strQuery = nombreStored;
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    con.command.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = dt_fechaDesde.Value.ToString();
                    con.command.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = dt_fechaHasta.Value.ToString();
                    con.command.Parameters.Add("@userId", SqlDbType.NVarChar).Value = usuario;
                    con.command.Parameters.Add("@hotId", SqlDbType.Decimal).Value = 1;
                    con.command.Parameters.Add("@cliId", SqlDbType.Decimal).Value = 10;
                    con.command.Parameters.Add("@regId", SqlDbType.Decimal).Value = 2;

                    /*if (modoABM == "DLT")
                    {
                        con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;
                    }
                    else if (modoABM == "UPD")
                    {
                        con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;
                    }*/

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
    }
}
