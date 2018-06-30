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

namespace FrbaHotel.GestionReservas
{
    public partial class ABMReserva02 : Form
    {
        public static string modoABM;
        public string nombreSP;
        public string usuario;
        public int error;
        public decimal hotelID;
        public decimal regimenID;

        public string clienteID;

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

            txt_fechaCreacion.Text = (DateTime.Today).ToShortDateString();
            txt_fechaCreacion.ReadOnly = true;

            txt_nombre.ReadOnly = true;
            txt_apellido.ReadOnly = true;
            txt_telefono.ReadOnly = true;
            txt_direccion.ReadOnly = true;
            txt_pais.ReadOnly = true;
            txt_ciudad.ReadOnly = true;
            
        }

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            error = 0;
            if (txt_mail.Text == "")
            {
                error = 1;
                MessageBox.Show("Por favor, ingrese el mail", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (cb_tipoDocumento.Text == "")
            {
                error = 1;
                MessageBox.Show("Por favor, ingrese el tipo de documento", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txt_nro_documento.Text == "")
            {
                error = 1;
                MessageBox.Show("Por favor, ingrese el número de documento", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (error == 0)
            {
                Conexion con = new Conexion();
                //con.strQuery = "SELECT Cliente_Codigo, Cliente_Nombre, Cliente_Apellido, Cliente_TipoDoc, Cliente_NumDoc--, Cliente_Telefono, Cliente_Direccion, Cliente_Ciudad, Cliente_Pais"
                con.strQuery = "SELECT Cliente_Codigo, Cliente_Nombre, Cliente_Apellido, Cliente_TipoDoc, Cliente_NumDoc"
                + " FROM FOUR_SIZONS.Cliente WHERE Cliente_TipoDoc = '" + cb_tipoDocumento.Text + "'"
                + " AND Cliente_NumDoc = " + txt_nro_documento.Text
                + " AND Cliente_Mail = '" + txt_mail.Text + "'";
                con.executeQuery();

                if (!con.reader())
                {
                    DialogResult dr = MessageBox.Show("No se ha encontrado sus datos en el sistema. Desea darse de alta?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        con.strQuery = "";
                        txt_nombre.ReadOnly = false;
                        txt_apellido.ReadOnly = false;
                        txt_telefono.ReadOnly = false;
                        txt_direccion.ReadOnly = false;
                        txt_pais.ReadOnly = false;
                        txt_ciudad.ReadOnly = false;
                    }else if(dr == DialogResult.No){
                        MessageBox.Show("Por favor revise sus datos y vuelva a intentar", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }else{
                        clienteID = con.lector.GetDecimal(0).ToString();
                        txt_nombre.Text = con.lector.GetString(1);
                        txt_apellido.Text = con.lector.GetString(2);
                        //txt_telefono.Text = con.lector.GetString(3);
                        //txt_direccion.Text = con.lector.GetString(4);
                        //txt_ciudad.Text = con.lector.GetString(5);
                        //txt_pais.Text = con.lector.GetString(6);
                }

                con.closeConection();
            }
        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {

            nombreSP = "FOUR_SIZONS.GenerarReserva";



            /*error = 0;
            switch (modoABM)
            {
                case "INS":
                    
                    break;

                case "UPD":
                    nombreSP = "FOUR_SIZONS.ModificacionUsuario";
                    break;

                case "DLT":
                    // Baja lógica - Se pone estado en 0
                    nombreSP = "FOUR_SIZONS.ModificacionUsuario";
                    break;
            }*/
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
                    con.command.Parameters.Add("@hotId", SqlDbType.Decimal).Value = hotelID;
                    con.command.Parameters.Add("@cliId", SqlDbType.Decimal).Value = clienteID;
                    con.command.Parameters.Add("@regId", SqlDbType.Decimal).Value = regimenID;

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
                cb_tipoHabitacion.Items.Add(con.lector.GetDecimal(0) + " - " + con.lector.GetString(1));
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
                hotelID = Convert.ToDecimal(formPromptHotel01.TextBox1.Text);
                txt_hotel.Text = formPromptHotel01.TextBox2.Text;
                formPromptHotel01.Close();
            }
            this.Show();
        }

        private void btn_regimen_Click(object sender, EventArgs e)
        {
            using (PromptRegimenes formPromptRegimen01 = new PromptRegimenes())
            {
                formPromptRegimen01.ShowDialog();
                regimenID = Convert.ToDecimal(formPromptRegimen01.TextBox1.Text);
                txt_regimen.Text = formPromptRegimen01.TextBox2.Text;
                formPromptRegimen01.Close();
            }
            this.Show();
        }
    }
}
