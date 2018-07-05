using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.RegistrarEstadia;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class RegistrarEstadia : Form
    {

        public decimal reserva;
        public string modoCheck;
        public int error;
        public string nombreSp;

        public RegistrarEstadia(string modo, decimal res)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            modoCheck = modo;
            reserva = res;

            switch (modoCheck)
            {
                case "IN":
                    lbl_Titulo.Text = "Abrir Estadía";
                    gb_Titulo.Text = "Check-in";
                    lbl_Fecha.Text = "Fecha de ingreso";
                    txt_CodReserva.ReadOnly = true;

                    break;

                case "OUT":
                    lbl_Titulo.Text = "Cerrar Estadía";
                    gb_Titulo.Text = "Check-out";
                    lbl_Fecha.Text = "Fecha de egreso";
                    txt_CodReserva.ReadOnly = true;

                    break;

            }
            dt_Fecha.Format = DateTimePickerFormat.Custom;
            dt_Fecha.CustomFormat = "dd/MM/yyyy";

        }


        private void RegistrarEstadia_Load(object sender, EventArgs e)
        {

            if (modoCheck == "IN")
            {
                Conexion con = new Conexion();
                con.strQuery = " select * from FOUR_SIZONS.Reserva where Reserva_Codigo = " + reserva;
                con.executeQuery();

                if (con.reader())
                {
                    txt_CodReserva.Text = con.lector.GetDecimal(0).ToString();
                    dt_Fecha.Value = con.lector.GetDateTime(2);

                    con.closeConection();
                }

            }
            else
            {
                Conexion con = new Conexion();
                con.strQuery = " select * from FOUR_SIZONS.Reserva where Reserva_Codigo = " + reserva;
                con.executeQuery();

                if (con.reader())
                {

                    txt_CodReserva.Text = con.lector.GetDecimal(0).ToString();
                    dt_Fecha.Value = con.lector.GetDateTime(3);

                    con.closeConection();
                }

                /*   
                       if (con.lector.GetBoolean(10))
                       {
                           txt_estado.Text = "ACTIVO";
                           txt_estado.BackColor = Color.WhiteSmoke;
                           txt_estado.ForeColor = Color.Green;

                       }
                       else
                       {
                           txt_estado.Text = "INACTIVO";
                           txt_estado.BackColor = Color.WhiteSmoke;
                           txt_estado.ForeColor = Color.Red;
                       }
                       txt_intentoslog.Text = con.lector.GetDecimal(11).ToString();
                       

                   con.closeConection();
                   */
            }
        }


        public void ejecutarRegistrarEstadia(string nombreStored)
        {
            if (MessageBox.Show("Está seguro que desea continuar con la operación?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    Conexion con = new Conexion();
                    con.strQuery = nombreStored;
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    con.command.Parameters.Add("@reserva", SqlDbType.Decimal).Value = txt_CodReserva.Text;
                    con.command.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = txt_Usuario.Text;
                    con.command.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dt_Fecha.Text;


                    /*      if (modoABM == "OUT")
                          {
                              con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;
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

        private void RegistrarEstadia_Load_1(object sender, System.EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, System.EventArgs e)
        {
            error = 0;
            switch (modoCheck)
            {
                case "IN":
                    nombreSp = "FOUR_SIZONS.RegistrarCheckIn";

                    //   COMO HAGO PARA QUE ENTRE A NUEVOCLIENTE?? 

                    break;

                case "OUT":
                    // SE EFCTIVIZA / CIERRA LA ESTADIA
                    nombreSp = "FOUR_SIZONS.RegistrarCheckOut";
                    break;
            }
            ejecutarRegistrarEstadia(nombreSp);
            if (error == 0)
            {
                this.Close();
            }
        }

        private void btn_Volver_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


    }

}

