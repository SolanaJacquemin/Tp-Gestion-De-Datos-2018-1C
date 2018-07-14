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
using FrbaHotel;
using FrbaHotel.ABMCliente;
using System.Data.SqlClient;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class RegistrarEstadia : Form
    {
        public bool altaValida;
        public bool clieResRegistrado;
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
        public decimal cliente;


        public RegistrarEstadia(string modo, decimal res, string user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            modoCheck = modo;
            reserva = res;
            usuario = user;

            txt_estadia.Enabled = false;
            txt_hotel.Enabled = false;
            txt_CodReserva.Text = reserva.ToString();

            generarFactura = false;
            facturaGenerada = false;

            btn_tarjeta.Visible = false;
            cb_medioPago.Items.Add("EFECTIVO");
            cb_medioPago.Items.Add("TARJETA");

            switch (modoCheck)
            {
                    
                case "IN":
                    labelTitulo.Text = "Abrir Estadía";
                    gb_Titulo.Text = "Check-in";
                    txt_CodReserva.ReadOnly = true;
                    txt_estadia.Visible = false;
                    lbl_estadia.Visible = false;
                    cb_medioPago.DropDownStyle = ComboBoxStyle.DropDownList;
                    dt_fechaSalida.Visible = false;
                    label2.Visible = false;
                    btn_factura.Text = "Generar Factura";
                    break;

                case "OUT":
                    labelTitulo.Text = "Cerrar Estadía";
                    gb_Titulo.Text = "Check-out";
                    txt_CodReserva.ReadOnly = true;
                    btn_regClientes.Visible = false;
                    cb_medioPago.DropDownStyle = ComboBoxStyle.DropDownList;
                    dt_fechaSalida.Format = DateTimePickerFormat.Custom;
                    dt_fechaSalida.CustomFormat = "dd/MM/yyyy";
                    break;

            }

        }

        public void ejecutarRegistrarEstadia(string nombreStored)
        {
            if (MessageBox.Show("Está seguro que desea continuar con la operación?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if(modoCheck == "IN")
                    {
                        Conexion con = new Conexion();
                        con.strQuery = nombreStored;
                        con.execute();
                        con.command.CommandType = CommandType.StoredProcedure;

                        con.command.Parameters.Add("@reserva", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_CodReserva.Text);
                        con.command.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
                        con.command.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now.ToString("dd/MM/yyyy");
                        con.command.Parameters.Add("@codigo", SqlDbType.Decimal).Direction = ParameterDirection.Output;

                        con.openConection();

                        DataSet dataset = new DataSet();
                        SqlDataAdapter da = new SqlDataAdapter(con.command);

                        da.Fill(dataset);

                        for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                        {
                            mensajeHab = mensajeHab + (dataset.Tables[0].Rows[i][0]).ToString() + " ";
                        }

                        codigoEstadia = Convert.ToDecimal(con.command.Parameters["@codigo"].Value);
                        txt_estadia.Text = codigoEstadia.ToString();

                        MessageBox.Show("Las habitaciones que corresponden: " + mensajeHab, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.closeConection();


                        MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        /*try
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
                        }*/
                    }else{
                        Conexion con = new Conexion();
                        con.strQuery = nombreStored;
                        con.execute();
                        con.command.CommandType = CommandType.StoredProcedure;

                        con.command.Parameters.Add("@estadia", SqlDbType.Decimal).Value = codigoEstadia;
                        con.command.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
                        con.command.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dt_fechaSalida.Value.ToString();

                        con.openConection();
                        con.command.ExecuteNonQuery();

                        con.closeConection();

                        MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                con.strQuery = "SELECT H.Hotel_Codigo, H.Hotel_Nombre, R.Reserva_Codigo, R.Reserva_Estado, R.Cliente_Codigo " +
                               " FROM FOUR_SIZONS.Reserva R" + 
                               " JOIN FOUR_SIZONS.Hotel H ON H.Hotel_Codigo = R.Hotel_Codigo" +
                               " WHERE R.Reserva_Codigo = " + reserva;
                con.executeQuery();

                if (con.reader())
                {
                    hotel = con.lector.GetDecimal(0);
                    txt_hotel.Text = con.lector.GetString(1);
                    txt_CodReserva.Text = con.lector.GetDecimal(2).ToString();
                    estadoReserva = con.lector.GetDecimal(3);
                    cliente = con.lector.GetDecimal(4);
                    con.closeConection();
                }

            }
            else
            {
                Conexion con = new Conexion();
                con.strQuery = "SELECT E.Estadia_Codigo, H.Hotel_Codigo, H.Hotel_Nombre" +
                               " FROM FOUR_SIZONS.Estadia E" +
                               " JOIN FOUR_SIZONS.Hotel H ON H.Hotel_Codigo = E.Hotel_Codigo" +
                               " WHERE E.Reserva_Codigo = " + reserva;
                con.executeQuery();

                if (con.reader())
                {
                    codigoEstadia = con.lector.GetDecimal(0);
                    hotel = con.lector.GetDecimal(1);
                    txt_hotel.Text = con.lector.GetString(2);
                    txt_estadia.Text = codigoEstadia.ToString();
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
                    }
                }

            }

            if ((generarFactura == true) && (facturaGenerada == false))
            {
                MessageBox.Show("Por favor, genere la factura.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            error = 0;
            if (cb_medioPago.Text == "") 
            {
                error = 1;
                MessageBox.Show("Por favor, ingrese un medio de pago", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (error == 0)
            {
                if (modoCheck == "IN")
                {
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
                            con.command.Parameters.Add("@fechaI", SqlDbType.DateTime).Value = readConfig.Config.fechaSystem().ToString();

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
                else
                {
                    try
                    {
                        Conexion con = new Conexion();
                        con.strQuery = "four_sizons.modificarFactura";
                        con.execute();
                        con.command.CommandType = CommandType.StoredProcedure;

                        con.command.Parameters.Add("@estadia", SqlDbType.Decimal).Value = codigoEstadia;
                        con.command.Parameters.Add("@formaPago", SqlDbType.NVarChar).Value = formaPago;
                        con.command.Parameters.Add("@fechaI", SqlDbType.DateTime).Value = DateTime.Now.ToString("dd/MM/yyyy");
                        con.command.Parameters.Add("@estado", SqlDbType.Decimal).Value = 1;

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
            }
            
        }
        private void btn_tarjeta_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroTarjeta formTarjeta = new RegistroTarjeta(0,codigoEstadia);
            formTarjeta.ShowDialog();
            this.Show();
        }

        private void btn_regClientes_Click(object sender, EventArgs e)
        {            
            if (clieResRegistrado == true)
            {
                if (MessageBox.Show("Cliente de la reserva registrado. Desea registrar más clientes?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RegistroClientes formRegisClie = new RegistroClientes(codigoEstadia);
                    formRegisClie.ShowDialog();
                }
            }
            if (((generarFactura == true) && (facturaGenerada == false) && error == 0) || (generarFactura == false) && (facturaGenerada == false))
            {
                MessageBox.Show("Por favor, realice el check in y genere la factura primero.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Conexion con = new Conexion();
                    con.strQuery = "four_sizons.RegistrarEstadiaXCliente";
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    con.command.Parameters.Add("@cliente", SqlDbType.Decimal).Value = cliente;
                    con.command.Parameters.Add("@estadia", SqlDbType.Decimal).Value = codigoEstadia;

                    con.openConection();
                    con.command.ExecuteNonQuery();
                    con.closeConection();

                    if (MessageBox.Show("Cliente de la reserva registrado. Desea registrar más clientes?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Hide();
                        RegistroClientes formRegisClie = new RegistroClientes(codigoEstadia);
                        formRegisClie.ShowDialog();
                        clieResRegistrado = true;
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cb_medioPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_medioPago.Text == "TARJETA")
            {
                btn_tarjeta.Visible = true;
            }
            else
            {
                btn_tarjeta.Visible = false;
            }
        }

    }

}