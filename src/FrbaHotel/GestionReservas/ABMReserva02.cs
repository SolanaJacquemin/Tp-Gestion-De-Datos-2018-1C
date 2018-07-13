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
using System.Data.SqlClient;
using FrbaHotel;

namespace FrbaHotel.GestionReservas
{
    public partial class ABMReserva02 : Form
    {
        public static string modoABM;
        public string nombreSP;
        public string usuario;
        public int error;
        public int errorBusqueda;
        public decimal hotelID;
        public decimal regimenID;
        public decimal clienteID;
        public bool esCliente;
        public bool buscoCliente;
        public bool tieneDisponibilidad;
        public decimal reservaID;
        public string busqueda;
        public decimal hotel;
        public bool abm_valido;
        public string mensaje;

        public ABMReserva02(string modo, string user, decimal hotelID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;

            usuario = user;
            modoABM = modo;

            hotel = hotelID;

            cb_tipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipoHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;

            dt_fechaDesde.Format = DateTimePickerFormat.Custom;
            dt_fechaDesde.CustomFormat = "dd/MM/yyyy";

            dt_fechaHasta.Format = DateTimePickerFormat.Custom;
            dt_fechaHasta.CustomFormat = "dd/MM/yyyy";

            txt_fechaCreacion.Text = readConfig.Config.fechaSystem().ToString();
            txt_fechaCreacion.Enabled = false;

            txt_nombre.Enabled = false;
            txt_apellido.Enabled = false;
            txt_telefono.Enabled = false;
            txt_calle.Enabled = false;
            txt_pais.Enabled = false;
            txt_ciudad.Enabled = false;
            txt_costoTotal.Enabled = false;
            cb_tipoDocumento.Enabled = false;
            txt_nro_documento.Enabled = false;
            txt_mail.Enabled = false;
            txt_calle.Enabled = false;
            txt_nroCalle.Enabled = false;
            txt_piso.Enabled = false;
            txt_depto.Enabled = false;
            btn_buscarCliente.Enabled = false;
            buscoCliente = false;
            tieneDisponibilidad = false;
            check_doc.Enabled = false;
            check_mail.Enabled = false;

            if (hotel != 0)
            {
                Conexion con = new Conexion();
                con.strQuery = "SELECT Hotel_Nombre FROM FOUR_SIZONS.Hotel WHERE Hotel_Codigo = " + hotel;
                con.executeQuery();

                while (con.reader())
                {
                    txt_hotel.Text = con.lector.GetString(0);
                    btn_hotel.Visible = false;
                    txt_hotel.Enabled = false;
                }
                con.closeConection();
            }

        }


        bool IsNumber(string s)
        {
            if (s != "")
            {
                foreach (char c in s)
                {
                    if (!Char.IsDigit(c))
                        return false;
                }
                return true;
            }
            else return false;
        }

        public bool verificarObligatorios()
        {
            abm_valido = true;

            if (txt_nombre.Text == "") abm_valido = false;
            if (txt_apellido.Text == "") abm_valido = false;
            if (cb_tipoDocumento.Text == "") abm_valido = false;
            if (txt_nro_documento.Text == "") abm_valido = false;
            if (txt_telefono.Text == "") abm_valido = false;
            if (txt_calle.Text == "") abm_valido = false;
            if (txt_nroCalle.Text == "") abm_valido = false;
            if (txt_mail.Text == "") abm_valido = false;
            if (txt_pais.Text == "") abm_valido = false;
            if (txt_piso.Text == "") txt_piso.Text = "0";

            return abm_valido;
        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            if (!tieneDisponibilidad)
            {
                MessageBox.Show("Por favor haga click en Verificar Disponibilidad antes de continuar", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else{
                if (!buscoCliente)
                {
                    MessageBox.Show("Por favor haga click en buscar cliente antes de continuar", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!esCliente)
                    {
                        if (verificarObligatorios() == false)
                        {
                            error = 1;
                            MessageBox.Show("Por favor, complete los campos obligatorios", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        };

                        if (IsNumber(txt_nro_documento.Text) == false)
                        {
                            error = 1;
                            MessageBox.Show("Por favor, el número de documento debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        };
                        if (IsNumber(txt_piso.Text) == false && txt_piso.Text != "")
                        {
                            error = 1;
                            MessageBox.Show("Por favor, el piso debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        };
                        if (IsNumber(txt_nroCalle.Text) == false && txt_nroCalle.Text != "")
                        {
                            error = 1;
                            MessageBox.Show("Por favor, el número de calle debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        };
                    }

                    switch (modoABM)
                    {
                        case "INS":
                            nombreSP = "FOUR_SIZONS.GenerarReserva";
                            break;
                    }
                    
                    if (error == 0)
                    {   
                        ejecutarAltaReserva(nombreSP);
                        this.Close();
                    }
                }
            }
        }

        public void ejecutarAltaReserva(string nombreStored)
        {
            if (MessageBox.Show("Está seguro que desea continuar con la operación?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (modoABM == "INS")
                {
                    if (esCliente == false)
                    {    
                        ejecutarABMCliente();
                    }

                    try
                    {
                        Conexion con = new Conexion();
                        con.strQuery = nombreStored;
                        con.execute();
                        con.command.CommandType = CommandType.StoredProcedure;
                        string newS = "EXEC " + nombreStored + " " + dt_fechaHasta.Value.ToString() + "," + dt_fechaHasta.Value.ToString() + "," + usuario + "," +
                            hotelID.ToString() + "," + clienteID.ToString() + "," + regimenID.ToString() + "," + txt_cantHab.Text + "," +
                             cb_tipoHabitacion.Text + "," + txt_costoTotal.Text + "," + readConfig.Config.fechaSystem().ToString();
                        con.command.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = dt_fechaDesde.Value.ToString();
                        con.command.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = dt_fechaHasta.Value.ToString();
                        con.command.Parameters.Add("@userId", SqlDbType.NVarChar).Value = usuario;
                        con.command.Parameters.Add("@hotId", SqlDbType.Decimal).Value = hotelID;
                        con.command.Parameters.Add("@cliId", SqlDbType.Decimal).Value = clienteID;
                        con.command.Parameters.Add("@regId", SqlDbType.Decimal).Value = regimenID;
                        con.command.Parameters.Add("@cantHab", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_cantHab.Text);
                        con.command.Parameters.Add("@tipoHabDesc", SqlDbType.NVarChar).Value = cb_tipoHabitacion.Text;
                        con.command.Parameters.Add("@precio", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_costoTotal.Text);
                        con.command.Parameters.Add("@fechaCreacion", SqlDbType.DateTime).Value = readConfig.Config.fechaSystem().ToString();

                        con.openConection();
                        con.command.ExecuteNonQuery();
                        con.closeConection();

                        //ejecutarAltaTipoHab();

                        con.strQuery = "SELECT TOP 1 Reserva_Codigo FROM FOUR_SIZONS.Reserva WHERE Cliente_Codigo = " + clienteID + " ORDER BY Reserva_Codigo DESC";
                        con.executeQuery();

                        if (con.reader())
                        {
                            reservaID = Convert.ToDecimal(con.lector.GetDecimal(0).ToString());
                        }

                        con.closeConection();

                        MessageBox.Show("Operación exitosa. El código de reserva es " + reservaID.ToString() , "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        error = 1;
                        MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else{
                    try
                    {
                        Conexion con = new Conexion();
                        con.strQuery = nombreStored;
                        con.execute();
                        con.command.CommandType = CommandType.StoredProcedure;

                        con.command.Parameters.Add("@codigoReserva", SqlDbType.Decimal).Value = dt_fechaDesde.Value.ToString();
                        con.command.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = dt_fechaDesde.Value.ToString();
                        con.command.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = dt_fechaHasta.Value.ToString();
                        con.command.Parameters.Add("@userId", SqlDbType.NVarChar).Value = usuario;
                        con.command.Parameters.Add("@hotId", SqlDbType.Decimal).Value = hotelID;
                        con.command.Parameters.Add("@cliId", SqlDbType.Decimal).Value = clienteID;
                        con.command.Parameters.Add("@regId", SqlDbType.Decimal).Value = regimenID;
                        con.command.Parameters.Add("@detalle", SqlDbType.NVarChar).Value = usuario;

                    }
                    catch (Exception ex)
                    {
                        error = 1;
                        MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }

        public void ejecutarABMCliente()
        {

            try
            {
                Conexion con2 = new Conexion();
                con2.strQuery = "four_sizons.AltaCliente";
                con2.execute();
                con2.command.CommandType = CommandType.StoredProcedure;
                con2.command.Parameters.Add("@codigo", SqlDbType.Decimal).Direction = ParameterDirection.Output;
                con2.command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txt_nombre.Text;
                con2.command.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = txt_apellido.Text;
                con2.command.Parameters.Add("@numDoc", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_nro_documento.Text);
                con2.command.Parameters.Add("@tipoDoc", SqlDbType.NVarChar).Value = cb_tipoDocumento.Text;
                con2.command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = txt_mail.Text;
                con2.command.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = txt_telefono.Text;
                con2.command.Parameters.Add("@pais", SqlDbType.NVarChar).Value = txt_pais.Text;
                con2.command.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = txt_ciudad.Text;
                con2.command.Parameters.Add("@calle", SqlDbType.NVarChar).Value = txt_calle.Text;
                con2.command.Parameters.Add("@numCalle", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_nroCalle.Text);
                con2.command.Parameters.Add("@piso", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_piso.Text);
                con2.command.Parameters.Add("@depto", SqlDbType.NVarChar).Value = txt_depto.Text;
                con2.command.Parameters.Add("@localidad", SqlDbType.NVarChar).Value = " ";
                con2.command.Parameters.Add("@nacionalidad", SqlDbType.NVarChar).Value = " ";
                con2.command.Parameters.Add("@fechaNac", SqlDbType.DateTime).Value = "01-01-1990";
                con2.openConection();
                con2.command.ExecuteNonQuery();

                clienteID = Convert.ToDecimal(con2.command.Parameters["@codigo"].Value);
                con2.closeConection();
            }
            catch (Exception ex)
            {
                error = 1;
                MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ejecutarAltaTipoHab()
        {

            Conexion con4 = new Conexion();

            con4.strQuery = "SELECT Reserva_Codigo FROM FOUR_SIZONS.Reserva WHERE Cliente_Codigo = " + clienteID;
            con4.executeQuery();

            if (con4.reader())
            {
                reservaID = Convert.ToDecimal(con4.lector.GetDecimal(0).ToString());
            }

            con4.closeConection();

            try
            {
                Conexion con = new Conexion();
                con.strQuery = "four_sizons.altaTipoHabXRes";
                con.execute();
                con.command.CommandType = CommandType.StoredProcedure;

                //MessageBox.Show((Convert.ToDecimal(txt_cantHab.Text)).ToString());
                con.command.Parameters.Add("@tipoHab", SqlDbType.NVarChar).Value = cb_tipoHabitacion.Text;
                con.command.Parameters.Add("@cantHab", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_cantHab.Text);
                con.command.Parameters.Add("@reservaCodigo", SqlDbType.Decimal).Value = reservaID;
                con.openConection();
                con.command.ExecuteNonQuery();
                con.closeConection();

            }
            catch (Exception ex)
            {
                error = 1;
                MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ABMReserva02_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT Parametro_Descripcion FROM FOUR_SIZONS.Parametros WHERE Parametro_Codigo = 'DOCUMENTO'";
            con.executeQuery();
            while (con.reader())
            {
                cb_tipoDocumento.Items.Add(con.lector.GetString(0));
            }
            con.closeConection();

            con.strQuery = "SELECT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion FROM FOUR_SIZONS.Habitacion_Tipo ORDER BY Habitacion_Tipo_Codigo";
            con.executeQuery();

            while (con.reader())
            {
                cb_tipoHabitacion.Items.Add(con.lector.GetString(1));
            }
            con.closeConection();

        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hotel_Click(object sender, EventArgs e)
        {
            using (PromptHoteles formPromptHotel01 = new PromptHoteles())
            {
                formPromptHotel01.ShowDialog();
                if (formPromptHotel01.TextBox1.Text != "")
                {
                    hotelID = Convert.ToDecimal(formPromptHotel01.TextBox1.Text);
                    hotel = 0;
                    txt_hotel.Text = formPromptHotel01.TextBox2.Text;
                }
                formPromptHotel01.Close();
            }
            txt_regimen.Clear();
            this.Show();
        }

        private void btn_regimen_Click(object sender, EventArgs e)
        {
            if (txt_hotel.Text != "")
            {
                if (hotel == 0)
                {
                    hotel = hotelID;
                }
                using (PromptRegimenes formPromptRegimen01 = new PromptRegimenes(hotel))
                {
                    formPromptRegimen01.ShowDialog();
                    if (formPromptRegimen01.TextBox1.Text != "")
                    {
                        regimenID = Convert.ToDecimal(formPromptRegimen01.TextBox1.Text);
                        txt_regimen.Text = formPromptRegimen01.TextBox2.Text;
                    }
                    formPromptRegimen01.Close();
                }
                this.Show();
            }
            else MessageBox.Show("Debe seleccionar un hotel primero para poder ofrecerle los regímenes", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_aceptar_nuevo_Click(object sender, EventArgs e)
        {
            ejecutarABMCliente();
        }

        private void verificarCampos1()
        {
            if (cb_tipoHabitacion.Text == "" || txt_cantHab.Text == ""||txt_hotel.Text=="")
            {
                error = 1;
                MessageBox.Show("Por favor, complete todos los campos.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (dt_fechaHasta.Value <= dt_fechaDesde.Value)
            {
                error = 1;
                MessageBox.Show("El campo Fecha Desde no puede ser igual o posterior a Fecha Hasta", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_disponibilidad_Click(object sender, EventArgs e)
        {
            error = 0;
            verificarCampos1();
            if(error == 0)
            {
                try
                {
                    Conexion con = new Conexion();
                    con.strQuery = "four_sizons.DisponibilidadyPrecio";
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;
                    string newS = "EXEC " + "four_sizons.DisponibilidadyPrecio" + " " + dt_fechaDesde.Value.ToString() + "," + dt_fechaHasta.Value.ToString() + "," + hotelID.ToString() + ","
                        + regimenID.ToString() +"," + txt_cantHab.Text + "," + cb_tipoHabitacion.Text;
                    con.command.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = dt_fechaDesde.Value.ToString();
                    con.command.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = dt_fechaHasta.Value.ToString();
                    con.command.Parameters.Add("@hotId", SqlDbType.Decimal).Value = hotel;
                    con.command.Parameters.Add("@regId", SqlDbType.Decimal).Value = regimenID;
                    con.command.Parameters.Add("@canthab", SqlDbType.Decimal).Value = txt_cantHab.Text;
                    con.command.Parameters.Add("@tipoHabDesc", SqlDbType.NVarChar).Value = cb_tipoHabitacion.Text;
                    //con.command.Parameters.Add("@precio", SqlDbType.Decimal).Direction = ParameterDirection.Output;

                    /*con.openConection();
                    con.command.ExecuteNonQuery();
                    con.closeConection();*/

                    con.openConection();
                    DataSet dataset = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(con.command);

                    da.Fill(dataset);

                    if (txt_regimen.Text == "")
                    {
                        using (PromptElegirRegimenXReserva promptRXR = new PromptElegirRegimenXReserva(dataset))
                        {
                            promptRXR.ShowDialog();
                            regimenID = Convert.ToDecimal(promptRXR.TextBox1.Text);
                            txt_regimen.Text = promptRXR.TextBox2.Text;
                            txt_costoTotal.Text = promptRXR.TextBox3.Text;
                            if (txt_costoTotal.Text != "")
                                MessageBox.Show("El precio total de su estadía es de: U$S " + txt_costoTotal.Text, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {                        
                        txt_regimen.Text = (dataset.Tables[0].Rows[0][0]).ToString();
                        txt_costoTotal.Text = (dataset.Tables[0].Rows[0][2]).ToString();
                        MessageBox.Show("Existe disponbilidad y el precio total de su estadía es de: U$S " + txt_costoTotal.Text, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    /*for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                    {
                        mensaje = mensaje + (dataset.Tables[0].Rows[i][0]).ToString() + " - " + (dataset.Tables[0].Rows[i][1]).ToString() + " - " + (dataset.Tables[0].Rows[i][2]).ToString();
                    }

                    MessageBox.Show(mensaje);*/



                    //txt_costoTotal.Text = con.command.Parameters["@precio"].Value.ToString();

                    con.closeConection();

                    //txt_costoTotal.Text = con.command.Parameters["@precio"].Value.ToString();
                    
                    tieneDisponibilidad = true;


                    if (tieneDisponibilidad)
                    {
                        btn_buscarCliente.Enabled = true;
                        check_doc.Enabled = true;
                        check_mail.Enabled = true;
                    }
                  /*  else 
                    {
                        btn_buscarCliente.Enabled = false;
                        check_doc.Enabled = false;
                        check_mail.Enabled = false;
                    }*/
                }
                catch (Exception ex)
                {
                    error = 1;
                    MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_buscarCliente_Click_1(object sender, EventArgs e)
        {
            if (check_doc.Checked || check_mail.Checked)
            {
                switch (busqueda)
                {
                    case "doc":
                        if (IsNumber(txt_nro_documento.Text) == false)
                        {
                            MessageBox.Show("El número de documento debe ser un dato numérico.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (txt_nro_documento.Text != "" && cb_tipoDocumento.Text != "")
                            {
                                Conexion con = new Conexion();
                                con.strQuery = "SELECT Cliente_Codigo, Cliente_Nombre, Cliente_Apellido, Cliente_Telefono, Cliente_Dom_Calle, Cliente_Ciudad, Cliente_Pais, Cliente_mail"
                                + " FROM FOUR_SIZONS.Cliente WHERE Cliente_TipoDoc = '" + cb_tipoDocumento.Text + "'"
                                + " AND Cliente_NumDoc = " + txt_nro_documento.Text;
                                con.executeQuery();

                                if (!con.reader())
                                {
                                    esCliente = false;
                                    DialogResult dr = MessageBox.Show("No se ha encontrado sus datos en el sistema. Desea darse de alta?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (dr == DialogResult.Yes)
                                    {
                                        con.strQuery = "";
                                        txt_nombre.Enabled = true;
                                        txt_apellido.Enabled = true;
                                        txt_telefono.Enabled = true;
                                        txt_calle.Enabled = true;
                                        txt_pais.Enabled = true;
                                        txt_ciudad.Enabled = true;
                                        txt_nroCalle.Enabled = true;
                                        txt_piso.Enabled = true;
                                        txt_depto.Enabled = true;
                                        txt_mail.Enabled = true;
                                    }
                                    else if (dr == DialogResult.No)
                                    {
                                        MessageBox.Show("Por favor revise sus datos y vuelva a intentar", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    clienteID = Convert.ToDecimal(con.lector.GetDecimal(0).ToString());
                                    txt_nombre.Text = con.lector.GetString(1);
                                    txt_apellido.Text = con.lector.GetString(2);
                                    txt_telefono.Text = con.lector.GetString(3);
                                    txt_calle.Text = con.lector.GetString(4);
                                    txt_ciudad.Text = con.lector.GetString(5);
                                    txt_pais.Text = con.lector.GetString(6);
                                    txt_mail.Text = con.lector.GetString(7);
                                    esCliente = true;
                                }

                                con.closeConection();
                                buscoCliente = true;
                                if (esCliente)
                                {
                                    check_mail.Enabled = false;
                                    check_doc.Enabled = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Por favor, ingrese tipo y número de documento.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;

                    case "mail":
                        if (txt_mail.Text != "")
                        {
                            Conexion con = new Conexion();
                            con.strQuery = "SELECT Cliente_Codigo, Cliente_Nombre, Cliente_Apellido, Cliente_Telefono, Cliente_Dom_Calle, Cliente_Ciudad, Cliente_Pais, Cliente_TipoDoc, Cliente_NumDoc"
                            + " FROM FOUR_SIZONS.Cliente WHERE Cliente_Mail = '" + txt_mail.Text + "'";

                            con.executeQuery();

                            if (!con.reader())
                            {
                                esCliente = false;
                                DialogResult dr = MessageBox.Show("No se ha encontrado sus datos en el sistema. Desea darse de alta?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (dr == DialogResult.Yes)
                                {
                                    con.strQuery = "";
                                    txt_nombre.Enabled = true;
                                    txt_apellido.Enabled = true;
                                    txt_telefono.Enabled = true;
                                    txt_calle.Enabled = true;
                                    txt_pais.Enabled = true;
                                    txt_ciudad.Enabled = true;
                                    txt_nroCalle.Enabled = true;
                                    txt_piso.Enabled = true;
                                    txt_nro_documento.Enabled = true;
                                    cb_tipoDocumento.Enabled = true;
                                    txt_depto.Enabled = true;
                                }
                                else if (dr == DialogResult.No)
                                {
                                    MessageBox.Show("Por favor revise sus datos y vuelva a intentar", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                clienteID = Convert.ToDecimal(con.lector.GetDecimal(0).ToString());
                                txt_nombre.Text = con.lector.GetString(1);
                                txt_apellido.Text = con.lector.GetString(2);
                                txt_telefono.Text = con.lector.GetString(3);
                                txt_calle.Text = con.lector.GetString(4);
                                txt_ciudad.Text = con.lector.GetString(5);
                                txt_pais.Text = con.lector.GetString(6);
                                cb_tipoDocumento.Text=con.lector.GetString(7);
                                txt_nro_documento.Text=con.lector.GetDecimal(8).ToString();
                                esCliente = true;
                            }

                            con.closeConection();
                            buscoCliente = true;
                            if (esCliente)
                            {
                                check_mail.Enabled = false;
                                check_doc.Enabled = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese su mail.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                }
            }
            else MessageBox.Show("Por favor, seleccione algún tipo de búsqueda.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void check_doc_CheckedChanged(object sender, EventArgs e)
        {
            if (check_doc.Checked)
            {
                check_mail.Checked = false;
                txt_mail.Enabled = false;
                txt_nro_documento.Enabled = true;
                cb_tipoDocumento.Enabled = true;
                busqueda = "doc";
                txt_mail.Text = "";

            }
        }

        private void check_mail_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mail.Checked)
            {
                check_doc.Checked = false;
                txt_mail.Enabled = true;
                txt_nro_documento.Enabled = false;
                cb_tipoDocumento.Enabled = false;
                busqueda = "mail";
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txt_cantHab.Clear();
            txt_apellido.Clear();
            txt_calle.Clear();
            txt_ciudad.Clear();
            txt_costoTotal.Clear();
            txt_depto.Clear();
            txt_hotel.Clear();
            txt_mail.Clear();
            txt_nombre.Clear();
            txt_nro_documento.Clear();
            txt_nroCalle.Clear();
            txt_pais.Clear();
            txt_piso.Clear();
            txt_regimen.Clear();
            txt_telefono.Clear();
        }



    }
}
