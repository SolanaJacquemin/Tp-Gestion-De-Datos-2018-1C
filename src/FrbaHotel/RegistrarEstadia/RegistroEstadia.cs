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
using System.Data.SqlClient;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class RegistrarEstadia : Form
    {
        public bool altaValida;
        public decimal reserva;
        public string modoCheck;
        public int error;
        public string nombreSp;
        public bool generarFactura;
        public bool facturaGenerada;
        public decimal estadoReserva;
        public decimal hotel;
        public decimal cantHab;
        public decimal tipoHab;
        public string mensajeHab;
        public string usuario;
        public decimal codigoEstadia;

        public RegistrarEstadia(string modo, decimal res, string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            modoCheck = modo;
            reserva = res;
            usuario = user;

            txt_estadia.Enabled = false;

            generarFactura = false;
            facturaGenerada = false;
            cb_medioPago.Items.Add("EFECTIVO");
            cb_medioPago.Items.Add("TARJETA");

            switch (modoCheck)
            {
                    
                case "IN":
                    lbl_Titulo.Text = "Abrir Estadía";
                    gb_Titulo.Text = "Check-in";
                    txt_CodReserva.ReadOnly = true;
                    txt_estadia.Visible = false;
                    lbl_estadia.Visible = false;
                  
                    break;

                case "OUT":
                    lbl_Titulo.Text = "Cerrar Estadía";
                    gb_Titulo.Text = "Check-out";
                    txt_CodReserva.ReadOnly = true;

                    break;

            }
        }

        public void ejecutarRegistrarEstadia(string nombreStored)
        {
            if (MessageBox.Show("Está seguro que desea continuar con la operación?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Conexion con = new Conexion();
                try
                {

                    con.strQuery = nombreStored;
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    con.command.Parameters.Add("@reserva", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_CodReserva.Text);
                    con.command.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
                    con.command.Parameters.Add("@codigo", SqlDbType.Decimal).Direction = ParameterDirection.Output;

                    con.openConection();
                    con.command.ExecuteNonQuery();
                    //con.closeConection();

                    codigoEstadia = Convert.ToDecimal(con.command.Parameters["@codigo"].Value);
                    txt_estadia.Text = codigoEstadia.ToString();

                    //con.openConection();
                    /*DataSet dataset = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(con.command);

                    da.Fill(dataset);

                    for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                    {
                        mensajeHab = mensajeHab + (dataset.Tables[0].Rows[i][0]).ToString() + " ";
                    }
                    MessageBox.Show("Las habitaciones que corresponden: " + mensajeHab, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    */con.closeConection();


                    MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        try
                        {
                            con.strQuery = "four_sizons.asignarHab";
                            con.execute();
                            con.command.CommandType = CommandType.StoredProcedure;

                            con.command.Parameters.Add("@estadia", SqlDbType.Decimal).Value = codigoEstadia;
                            con.command.Parameters.Add("@reserva", SqlDbType.Decimal).Value = reserva;

                            con.openConection();
                            DataSet dataset = new DataSet();
                            SqlDataAdapter da = new SqlDataAdapter(con.command);
                            con.closeConection();
                            da.Fill(dataset);


                            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                            {
                                mensajeHab = mensajeHab + (dataset.Tables[0].Rows[i][0]).ToString() + " ";
                            }
                            MessageBox.Show("Las habitaciones que corresponden: " + mensajeHab, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                        }
                        catch (Exception ex)
                        {
                            error = 1;
                            MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            if (modoCheck == "IN")
            {
                Conexion con = new Conexion();
                con.strQuery = "SELECT * FROM FOUR_SIZONS.Reserva WHERE Reserva_Codigo = " + reserva;
                con.executeQuery();

                if (con.reader())
                {
                    txt_CodReserva.Text = con.lector.GetDecimal(0).ToString();
                    //dt_Fecha.Value = con.lector.GetDateTime(2);
                    txt_hotel.Text = con.lector.GetDecimal(7).ToString();
                    estadoReserva = con.lector.GetDecimal(10);

                    //txt_hab.Text = con.lector.GetDecimal().ToString();
                    //txt_Usuario.Text = con.lector.GetDecimal().ToString();

                    con.closeConection();
                }

            }
            else
            {
                Conexion con = new Conexion();
                con.strQuery = " select * from FOUR_SIZONS.Estadia where Reserva_Codigo = " + reserva;
                con.executeQuery();

                if (con.reader())
                {
                    txt_estadia.Text = con.lector.GetDecimal(0).ToString();
                    txt_CodReserva.Text = con.lector.GetDecimal(1).ToString();
                    //dt_Fecha.Value = con.lector.GetDateTime(3);
                    txt_hotel.Text = con.lector.GetDecimal(10).ToString();
                    //txt_hab.Text = con.lector.GetDecimal(9).ToString();
                    //txt_Usuario.Text = con.lector.GetDecimal(8).ToString();

                    con.closeConection();
                }
            }
        }

        public bool verificarObligatorios()
        {
            altaValida = true;

                if (txt_hotel.Text == "") altaValida = false;
                if (txt_CodReserva.Text == "") altaValida = false;
                //if (dt_Fecha.Text == "") altaValida = false;
                //if (txt_Usuario.Text == "") altaValida = false;
                if (cb_medioPago.Text == "") altaValida = false;

            if (modoCheck == "INS")
            {
                //if (txt_hab.Text == "") altaValida = false;
                if (txt_estadia.Text == "") altaValida = false;
            }

            return altaValida;
        }

        bool IsNumber(string s)
        {
            if (s != "") return false;
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btn_Aceptar_Click(object sender, System.EventArgs e)
        {
            if((generarFactura == false) && (facturaGenerada == false))
            {
                error = 0;
                /*if (verificarObligatorios() == false)
                {
                    error = 1;
                    MessageBox.Show("Por favor, complete los campos obligatorios", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };*/

                if (error == 0)
                {
                    //FALTA VERIFICAR EL CB_MEDIO DE PAGO

                    switch (modoCheck)
                    {
                        case "IN":
                            nombreSp = "FOUR_SIZONS.RegistrarCheckIn";
                            //this.Hide();
                            //   COMO HAGO PARA QUE ENTRE A NUEVOCLIENTE?? 

                            break;

                        case "OUT":
                            // SE EFCTIVIZA / CIERRA LA ESTADIA
                            nombreSp = "FOUR_SIZONS.RegistrarCheckOut";
                            break;
                    }

                    if (error == 0)
                    {
                        ejecutarRegistrarEstadia(nombreSp);
                        generarFactura = true;
                       // this.Close();
                    }
                }

            }

            if ((generarFactura == true) && (facturaGenerada == false) && (error == 0))
            {
                MessageBox.Show("Por favor, genere la factura", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if ((generarFactura) && (facturaGenerada))
            {
                this.Close();
            }
        }

        private void btn_Volver_Click(object sender, System.EventArgs e)
        {
            if (generarFactura == true && facturaGenerada==true || generarFactura==false && facturaGenerada==false || error == 1)
            {
                this.Close();
            }

            else MessageBox.Show("Por favor, genere la factura", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            string formaPago = cb_medioPago.Text;
            if (facturaGenerada == false && generarFactura == true)
            {
                try
                {
                    Conexion con = new Conexion();
                    con.strQuery = "four_sizons.generarFactura ";
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    con.command.Parameters.Add("@estadia", SqlDbType.Decimal).Value = codigoEstadia;
                    con.command.Parameters.Add("@formaPago", SqlDbType.NVarChar).Value = formaPago;

                    con.openConection();
                    con.command.ExecuteNonQuery();
                    con.closeConection();
                    facturaGenerada = true;
                    MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Por favor, primero realice el check in", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_tarjeta_Click(object sender, EventArgs e)
        {
                this.Hide();
                AgregarTarjeta formTarjeta = new AgregarTarjeta(codigoEstadia);
                formTarjeta.ShowDialog();
                this.Show();
        }

    }

}

