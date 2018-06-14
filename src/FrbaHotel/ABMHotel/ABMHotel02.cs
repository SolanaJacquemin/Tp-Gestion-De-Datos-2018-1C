using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ABMHotel
{
    public partial class ABMHotel02 : Form
    {
        public static string modoABM;
        public string nombreSP;
        public string hotel;
        public int error;

        public ABMHotel02(string modo, string hotelId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;

            hotel = hotelId;
            modoABM = modo;

            switch (modoABM)
            {
                case "INS":
                    labelTitulo.Text = "Alta de Hotel";
                    l_codigo.Visible = false;
                    l_estado.Visible = false;
                    txt_codigo.Visible = false;
                    txt_estado.Visible = false;
                    break;
                case "DLT":
                    labelTitulo.Text = "Baja de Hotel";
                    txt_codigo.ReadOnly = true;
                    txt_nombre.ReadOnly = true;
                    txt_mail.ReadOnly = true;
                    txt_telefono.ReadOnly = true;
                    txt_calle.ReadOnly = true;
                    txt_nroCalle.ReadOnly = true;
                    txt_ciudad.ReadOnly = true;
                    txt_pais.ReadOnly = true;
                    txt_recargaEstrella.ReadOnly = true;
                    dt_fecha_cre.Enabled = false;
                    cb_estrellas.Enabled = false;
                    btn_aceptar_nuevo.Visible = false;
                    break;
                case "UPD":
                    labelTitulo.Text = "Modificación de Hotel";
                    txt_codigo.ReadOnly = true;
                    txt_nombre.ReadOnly = false;
                    txt_mail.ReadOnly = false;
                    txt_telefono.ReadOnly = false;
                    txt_calle.ReadOnly = false;
                    txt_nroCalle.ReadOnly = false;
                    txt_ciudad.ReadOnly = false;
                    txt_pais.ReadOnly = false;
                    txt_recargaEstrella.ReadOnly = false;
                    dt_fecha_cre.Enabled = true;
                    cb_estrellas.Enabled = true;
                    txt_estado.Enabled = false;
                    btn_aceptar_nuevo.Visible = false;
                    break;
            }

            cb_estrellas.Items.Add("");
            cb_estrellas.Items.Add("1");
            cb_estrellas.Items.Add("2");
            cb_estrellas.Items.Add("3");
            cb_estrellas.Items.Add("4");
            cb_estrellas.Items.Add("5");

            dt_fecha_cre.Format = DateTimePickerFormat.Custom;
            dt_fecha_cre.CustomFormat = "dd/MM/yyyy";

        }

        private void ABMHotel02_Load(object sender, EventArgs e)
        {
            if (modoABM == "INS")
            {
                //levantarCombos();
            }
            else
            {
                txt_codigo.Text = hotel;
                Conexion con = new Conexion();
                con.strQuery = "SELECT * FROM FOUR_SIZONS.Hotel WHERE Hotel_Codigo = '" + hotel + "'";
                con.executeQuery();

                while (con.reader())
                {
                    txt_nombre.Text = con.lector.GetString(1);
                    txt_mail.Text = con.lector.GetString(2);
                    txt_telefono.Text = con.lector.GetString(3);
                    txt_calle.Text = con.lector.GetString(4);
                    txt_nroCalle.Text = con.lector.GetDecimal(5).ToString();
                    cb_estrellas.Text = con.lector.GetDecimal(6).ToString();
                    txt_recargaEstrella.Text = con.lector.GetDecimal(7).ToString();
                    txt_ciudad.Text = con.lector.GetString(8);
                    txt_pais.Text = con.lector.GetString(9);
                    dt_fecha_cre.Value = con.lector.GetDateTime(10);
                    if (con.lector.GetBoolean(11))
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

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_estado_Click(object sender, EventArgs e)
        {

        }

        private void dt_fecha_nac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ejecutarABMHotel(string nombreStored)
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
                    
                    if (modoABM != "INS")
                    {
                        con.command.Parameters.Add("@codigo", SqlDbType.Decimal).Value = txt_codigo.Text;
                    }
                    con.command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txt_nombre.Text;
                    con.command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = txt_mail.Text;
                    con.command.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = txt_telefono.Text;
                    con.command.Parameters.Add("@calle", SqlDbType.NVarChar).Value = txt_calle.Text;
                    con.command.Parameters.Add("@numCalle", SqlDbType.Decimal).Value = txt_nroCalle.Text;
                    con.command.Parameters.Add("@cantEstrellas", SqlDbType.Decimal).Value = cb_estrellas.Text;
                    con.command.Parameters.Add("@recarga_estrella", SqlDbType.Decimal).Value = txt_recargaEstrella.Text;
                    con.command.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = txt_ciudad.Text;
                    con.command.Parameters.Add("@pais", SqlDbType.NVarChar).Value = txt_pais.Text;
                    con.command.Parameters.Add("@fechaCreacion", SqlDbType.DateTime).Value = dt_fecha_cre.Text;
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

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            error = 0;
            switch (modoABM)
            {
                case "INS":
                    nombreSP = "FOUR_SIZONS.AltaHotel";
                    break;

                case "UPD":
                    nombreSP = "FOUR_SIZONS.ModificarHotel";
                    break;

                case "DLT":
                    // Baja lógica - Se pone estado en 0
                    nombreSP = "FOUR_SIZONS.ModificarHotel";
                    break;
            }
            ejecutarABMHotel(nombreSP);
            if (error == 0)
            {
                this.Close();
            }

        }

        private void btn_aceptar_nuevo_Click(object sender, EventArgs e)
        {
            error = 0;
            nombreSP = "FOUR_SIZONS.AltaHotel";
            ejecutarABMHotel(nombreSP);
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_mail.Text = "";
            txt_telefono.Text = "";
            txt_calle.Text = "";
            txt_nroCalle.Text = "";
            txt_ciudad.Text = "";
            txt_pais.Text = "";
            txt_recargaEstrella.Text = "";
            dt_fecha_cre.Text = "";
            cb_estrellas.Items.Clear();
            //levantarCombos();
        }
    }
}
