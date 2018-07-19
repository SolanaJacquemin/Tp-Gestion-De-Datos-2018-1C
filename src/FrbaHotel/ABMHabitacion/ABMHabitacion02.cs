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

namespace FrbaHotel.ABMHabitacion
{
    public partial class ABMHabitacion02 : Form
    {
        public static string modoABM;
        public string nombreSP;
        public decimal habitacion;
        public decimal hotel;
        public int error;
        public bool valido;

        public ABMHabitacion02(string modo, decimal hotelID, decimal hab)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;

            hotel = hotelID;
            habitacion = hab;
            modoABM = modo;

            cb_tipohab.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipoFrente.DropDownStyle = ComboBoxStyle.DropDownList;

            levantarCombos();
            txt_hotel.Enabled = false;
            switch (modoABM)
            {
                case "INS":
                    labelTitulo.Text = "Alta de Habitación";
                    txt_estado.Visible = false;
                    l_estado.Visible = false;
                    cb_tipoFrente.DropDownStyle = ComboBoxStyle.DropDownList;
                    cb_tipohab.DropDownStyle = ComboBoxStyle.DropDownList;
                    break;
                case "DLT":
                    labelTitulo.Text = "Baja de Habitación";
                    txt_hotel.Text = hotel.ToString();
                    txt_nro_hab.Text = habitacion.ToString();
                    txt_hotel.Enabled = false;
                    txt_estado.Enabled = false;
                    txt_nro_hab.Enabled = false;
                    txt_piso.Enabled = false;
                    cb_tipoFrente.Enabled = false;
                    cb_tipohab.Enabled = false;
                    txt_descripcion.Enabled= true;
                    lbl_obligacion.Visible = false;
                    break;
                case "UPD":
                    labelTitulo.Text = "Modificación de Habitación";
                    txt_hotel.Text = hotel.ToString();
                    txt_nro_hab.Text = habitacion.ToString();
                    txt_hotel.Enabled = true;
                    txt_estado.Enabled = true;
                    txt_nro_hab.Enabled = true;
                    txt_piso.Enabled = true;
                    cb_tipoFrente.Enabled = true;
                    cb_tipohab.Enabled = false;
                    l_estado.Enabled = false;
                    txt_estado.Enabled = false;
                    txt_nro_hab.Enabled = false;
                    break;
            }
            //dt_fecha_nac.Format = DateTimePickerFormat.Custom;
            //dt_fecha_nac.CustomFormat = "dd/MM/yyyy";

            
        }

        private void levantarCombos() 
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT Habitacion_Tipo_Descripcion FROM FOUR_SIZONS.Habitacion_Tipo";
            con.executeQuery();
            while (con.reader())
            {
                cb_tipohab.Items.Add(con.lector.GetString(0));
            }
            con.closeConection();

            cb_tipoFrente.Items.Add("S");
            cb_tipoFrente.Items.Add("N");
        }

                    

        private void ABMHabitacion02_Load(object sender, EventArgs e)
        {
            if (hotel != 0)
            {
                Conexion con = new Conexion();
                con.strQuery = "SELECT H.Hotel_Nombre FROM FOUR_SIZONS.Hotel H WHERE H.Hotel_Codigo = " + hotel;
                con.executeQuery();

                if (con.reader())
                {
                    txt_hotel.Text = con.lector.GetString(0);
                }
                con.closeConection();
                txt_hotel.Enabled = false;
                btn_promptHotel.Enabled = false;

            }

            else
            {
                Conexion con = new Conexion();
                con.strQuery = "SELECT HO.Hotel_Nombre, HT.Habitacion_Tipo_Descripcion, HA.Habitacion_Frente, " +
                               "HA.Habitacion_Piso, HA.Habitacion_Descripcion, HA.Habitacion_Estado " +
                               "FROM FOUR_SIZONS.Habitacion HA JOIN FOUR_SIZONS.Habitacion_Tipo HT on " +
                               "HT.Habitacion_Tipo_Codigo = HA.Habitacion_Tipo_Codigo JOIN FOUR_SIZONS.Hotel HO " +
                               "on HO.Hotel_Codigo = HA.Hotel_Codigo WHERE HA.Habitacion_Numero = " + habitacion +
                               " AND HA.Hotel_Codigo = " + hotel;
                con.executeQuery();

                while (con.reader())
                {
                    txt_hotel.Text = con.lector.GetString(0);
                    cb_tipohab.Text = con.lector.GetString(1);
                    cb_tipoFrente.Text = con.lector.GetString(2);
                    txt_piso.Text = con.lector.GetDecimal(3).ToString();
                    txt_descripcion.Text = con.lector.GetString(4);
                    if (con.lector.GetBoolean(5))
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

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            error = 0;
            txt_hotel.Enabled = false;
            switch (modoABM)
            {
                case "INS":
                    verificarObligatorios();
                    if ((!IsNumber(txt_nro_hab.Text) && txt_nro_hab.Text != "")||(!IsNumber(txt_piso.Text)&&txt_piso.Text!=""))
                    {
                        MessageBox.Show("Por favor, tanto el piso como el número de habitación deben ser un datos numéricos.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    nombreSP = "FOUR_SIZONS.AltaHabitacion";
                    break;

                case "UPD":
                    if ((!IsNumber(txt_nro_hab.Text) && txt_nro_hab.Text != "") || (!IsNumber(txt_piso.Text) && txt_piso.Text != ""))
                    {
                        MessageBox.Show("Por favor, tanto el piso como el número de habitación deben ser un datos numéricos.", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    nombreSP = "FOUR_SIZONS.ModificarHabitacion";
                    break;

                case "DLT":
                    // Baja lógica - Se pone estado en 0
                    nombreSP = "FOUR_SIZONS.ModificarHabitacion";
                    break;
            }
            
            if (error == 0)
            {   
                ejecutarABMHabitacion(nombreSP);
                this.Close();
                levantarCombos();
            }
        }

        public bool verificarObligatorios()
        {
            if (txt_hotel.Text == "") valido = false;
            if (cb_tipohab.Text == "") valido = false;
            if (txt_nro_hab.Text == "") valido = false;
            if (txt_piso.Text == "") valido = false;
            if (cb_tipoFrente.Text == "") valido = false;
            if (txt_descripcion.Text == "") valido = false;

            return valido;
        }

        public void ejecutarABMHabitacion(string nombreStored)
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
                    // se agregan los parámetros al stored procedure
                    if (modoABM == "INS")
                    {
                        string newS = "EXEC " + nombreStored + " " + txt_nro_hab.Text + "," + txt_piso.Text + "," + cb_tipoFrente.Text + "," + hotel.ToString() + "," + cb_tipohab.Text + "," + txt_descripcion.Text;
                        con.command.Parameters.Add("@numero", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_nro_hab.Text);
                        con.command.Parameters.Add("@piso", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_piso.Text);
                        con.command.Parameters.Add("@frente", SqlDbType.NVarChar).Value = cb_tipoFrente.Text;
                        con.command.Parameters.Add("@HotelId", SqlDbType.Decimal).Value = hotel;
                        con.command.Parameters.Add("@TipoHab", SqlDbType.NVarChar).Value = cb_tipohab.Text;
                        con.command.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = txt_descripcion.Text;

                    }else{
                        string newS = "EXEC " + nombreStored + " " + txt_nro_hab.Text + "," + hotel.ToString() + "," + txt_piso.Text + "," + cb_tipoFrente.Text + "," + cb_tipohab.Text + "," + txt_descripcion.Text + " 1";
                        con.command.Parameters.Add("@numero", SqlDbType.Decimal).Value = txt_nro_hab.Text;
                        con.command.Parameters.Add("@HotId", SqlDbType.Decimal).Value = hotel;
                        con.command.Parameters.Add("@piso", SqlDbType.Decimal).Value = txt_piso.Text;
                        con.command.Parameters.Add("@ubicacion", SqlDbType.NVarChar).Value = cb_tipoFrente.Text;
                        con.command.Parameters.Add("@TipoHab", SqlDbType.NVarChar).Value = cb_tipohab.Text;
                        con.command.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = txt_descripcion.Text;
                        if (modoABM == "UPD")
                        {
                            con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;
                        }else{
                            con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;
                        }
                    }
                    // se abre la conexión con la base de datos y se ejecuta
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

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_promptHotel_Click(object sender, EventArgs e)
        {
            using (PromptHoteles prompt = new PromptHoteles())
            {
                prompt.ShowDialog();

                if (prompt.TextBox1.Text != "")
                {
                    hotel = Convert.ToDecimal(prompt.TextBox1.Text);
                    txt_hotel.Text = prompt.TextBox2.Text;
                }

                prompt.Close();
            }
            this.Show();
        }

    }
}