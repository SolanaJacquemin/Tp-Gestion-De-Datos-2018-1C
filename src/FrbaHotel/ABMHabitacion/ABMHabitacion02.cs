using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ABMHabitacion
{
    public partial class ABMHabitacion02 : Form
    {
        public static string modoABM;
        public string nombreSP;
        public decimal habitacion;
        public decimal hotel;
        public int error;

        public ABMHabitacion02(string modo, decimal hot, decimal hab)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;

            hotel = hot;
            habitacion = hab;

            modoABM = modo;

            switch (modoABM)
            {
                case "INS":
                    labelTitulo.Text = "Alta de Habitación";
                    break;
                case "DLT":
                    labelTitulo.Text = "Baja de Habitación";
                    txt_hotel_codigo.Text = hotel.ToString();
                    txt_nro_hab.Text = habitacion.ToString();
                    txt_hotel_codigo.ReadOnly = true;
                    txt_hotel_nombre.ReadOnly = true;
                    txt_estado.ReadOnly = true;
                    txt_nro_hab.ReadOnly = true;
                    txt_piso.ReadOnly = true;
                    cb_tipoFrente.Enabled = false;
                    cb_tipohab.Enabled = false;
                    txt_descripcion.ReadOnly = true;
                    btn_aceptar_nuevo.Visible = false;
                    break;
                case "UPD":
                    labelTitulo.Text = "Modificación de Habitación";
                    txt_hotel_codigo.Text = hotel.ToString();
                    txt_nro_hab.Text = habitacion.ToString();
                    txt_hotel_codigo.ReadOnly = true;
                    txt_hotel_nombre.ReadOnly = true;
                    txt_estado.ReadOnly = true;
                    txt_nro_hab.ReadOnly = true;
                    txt_piso.ReadOnly = true;
                    cb_tipoFrente.Enabled = false;
                    cb_tipohab.Enabled = false;
                    btn_aceptar_nuevo.Visible = false;
                    break;
            }
            //dt_fecha_nac.Format = DateTimePickerFormat.Custom;
            //dt_fecha_nac.CustomFormat = "dd/MM/yyyy";

            //levantarCombos();
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

            if (modoABM == "INS")
            {
                levantarCombos();
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
                    txt_hotel_nombre.Text = con.lector.GetString(0);
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

                /*con.strQuery = "SELECT R.Rol_Nombre FROM FOUR_SIZONS.UsuarioXRol AS UR" +
                " JOIN FOUR_SIZONS.Rol AS R ON UR.Rol_Codigo= R.Rol_Codigo" +
                " WHERE UR.Usuario_ID = '" + usuario + "'";
                con.executeQuery();

                while (con.reader())
                {
                    cb_rol.Text = con.lector.GetString(0);
                }
                con.closeConection();*/

            }


        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            error = 0;
            switch (modoABM)
            {
                case "INS":
                    nombreSP = "FOUR_SIZONS.AltaHabitacion";
                    break;

                case "UPD":
                    nombreSP = "FOUR_SIZONS.ModificarHabitacion";
                    break;

                case "DLT":
                    // Baja lógica - Se pone estado en 0
                    nombreSP = "FOUR_SIZONS.ModificarHabitacion";
                    break;
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

                    if (modoABM == "INS")
                    {
                        con.command.Parameters.Add("@numero", SqlDbType.Decimal).Value = txt_nro_hab.Text;
                        con.command.Parameters.Add("@piso", SqlDbType.Decimal).Value = txt_piso.Text;
                        con.command.Parameters.Add("@frente", SqlDbType.NVarChar).Value = cb_tipoFrente.Text;
                        con.command.Parameters.Add("@HotelId", SqlDbType.Decimal).Value = txt_hotel_codigo.Text;
                        con.command.Parameters.Add("@TipoHab", SqlDbType.NVarChar).Value = cb_tipohab.Text;
                        con.command.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = txt_descripcion.Text;

                    }else{
                        con.command.Parameters.Add("@numero", SqlDbType.Decimal).Value = txt_nro_hab.Text;
                        con.command.Parameters.Add("@HotId", SqlDbType.Decimal).Value = txt_hotel_codigo.Text;
                        con.command.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = txt_descripcion.Text;
                        if (modoABM == "UPD")
                        {
                            con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;
                        }else{
                            con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;
                        }
                    }

                    con.openConection();
                    con.command.ExecuteNonQuery();

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

    }
}