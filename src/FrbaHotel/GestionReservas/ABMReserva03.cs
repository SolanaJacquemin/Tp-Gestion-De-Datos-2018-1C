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
    public partial class ABMReserva03 : Form
    {

        public static string modoABM;
        public string nombreSP;
        public string usuario;
        public decimal hotelID;
        public decimal regimenID;
        public int error;

        public ABMReserva03(string modo, string user, decimal reservaID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;

            usuario = user;
            modoABM = modo;
            txt_reservaID.Text = reservaID.ToString();

            cb_tipoHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;

            switch (modoABM)
            {
                case "DLT":
                    labelTitulo.Text = "Cancelar Reserva";
                    dt_fechaDesde.Enabled = false;
                    dt_fechaHasta.Enabled = false;
                    cb_tipoHabitacion.Enabled = false;
                    txt_reservaID.ReadOnly = true;
                    txt_regimen.ReadOnly = true;
                    txt_hotel.ReadOnly = true;
                    txt_detalle.ReadOnly = false;
                    break;
                case "UPD":
                    labelTitulo.Text = "Modificación de Reserva";
                    dt_fechaDesde.Enabled = true;
                    dt_fechaHasta.Enabled = true;
                    cb_tipoHabitacion.Enabled = true;
                    txt_reservaID.ReadOnly = false;
                    txt_regimen.ReadOnly = false;
                    txt_hotel.ReadOnly = false;
                    txt_detalle.ReadOnly = false;
                    break;
            }
            dt_fechaDesde.Format = DateTimePickerFormat.Custom;
            dt_fechaDesde.CustomFormat = "dd/MM/yyyy";

            dt_fechaHasta.Format = DateTimePickerFormat.Custom;
            dt_fechaHasta.CustomFormat = "dd/MM/yyyy";
        }

        private void ABMReserva03_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();

            con.strQuery = "SELECT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion FROM FOUR_SIZONS.Habitacion_Tipo ORDER BY Habitacion_Tipo_Codigo";
            con.executeQuery();
            while (con.reader())
            {
                cb_tipoHabitacion.Items.Add(con.lector.GetString(1));
            }
            con.closeConection();

            con.strQuery = "SELECT HT.Habitacion_Tipo_Descripcion, R.Reserva_Fecha_Inicio, R.Reserva_Fecha_Fin, H.Hotel_Codigo, H.Hotel_Nombre, R.Regimen_Codigo, REG.Regimen_Descripcion" +
                           " FROM FOUR_SIZONS.Reserva R" +
                           " JOIN FOUR_SIZONS.Habitacion_TipoXReser HTR ON HTR.Reserva_Codigo = R.Reserva_Codigo" +
                           " JOIN FOUR_SIZONS.Habitacion_Tipo HT ON HT.Habitacion_Tipo_Codigo = HTR.Habitacion_Tipo_Codigo" +
                           " JOIN FOUR_SIZONS.Hotel H ON H.Hotel_Codigo = R.Hotel_Codigo" +
                           " JOIN FOUR_SIZONS.Regimen REG ON REG.Regimen_Codigo = R.Regimen_Codigo" +
                           " WHERE R.Reserva_Codigo = " + txt_reservaID.Text;
            con.executeQuery();

            while (con.reader())
            {
                cb_tipoHabitacion.Text = con.lector.GetString(0);
                dt_fechaDesde.Value = con.lector.GetDateTime(1);
                dt_fechaHasta.Value = con.lector.GetDateTime(2);
                hotelID = Convert.ToDecimal(con.lector.GetDecimal(3).ToString());
                txt_hotel.Text = con.lector.GetString(4);
                regimenID = Convert.ToDecimal(con.lector.GetDecimal(5).ToString());
                txt_regimen.Text = con.lector.GetString(6); 
            }
            con.closeConection();

            con.strQuery = "SELECT ResMod_Detalle FROM FOUR_SIZONS.ReservaMod WHERE Reserva_Codigo = " + txt_reservaID.Text;
            con.executeQuery();

            while (con.reader())
            {
                txt_detalle.Text = con.lector.GetString(0);
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

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                con.strQuery = "four_sizons.ModificarReserva";
                con.execute();
                con.command.CommandType = CommandType.StoredProcedure;
                
                //MessageBox.Show((Convert.ToDecimal(txt_cantHab.Text)).ToString());
                con.command.Parameters.Add("@codigoReserva", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_reservaID.Text);
                con.command.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = dt_fechaDesde.Value.ToString();
                con.command.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = dt_fechaHasta.Value.ToString();
                con.command.Parameters.Add("@userId", SqlDbType.NVarChar).Value = usuario;
                con.command.Parameters.Add("@hotid", SqlDbType.Decimal).Value = hotelID;
                con.command.Parameters.Add("@tipoHab", SqlDbType.NVarChar).Value = cb_tipoHabitacion.Text;
                con.command.Parameters.Add("@detalle", SqlDbType.NVarChar).Value = txt_detalle.Text;
                con.command.Parameters.Add("@regId", SqlDbType.Decimal).Value = regimenID;
                
                if (modoABM == "DLT")
                {
                    con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;
                }
                else if (modoABM == "UPD")
                {
                    con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;
                }

                con.openConection();
                con.command.ExecuteNonQuery();
                con.closeConection();

                MessageBox.Show("Operación exitosa", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                error = 1;
                MessageBox.Show("Error al completar la operación. " + ex.Message, "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}