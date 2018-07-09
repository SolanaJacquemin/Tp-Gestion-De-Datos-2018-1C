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

namespace FrbaHotel.ABMHotel
{
    public partial class ABMHotel02 : Form
    {
        public static string modoABM;
        public bool abm_valido;
        public string nombreSP;
        public decimal hotel;
        public string nombreHotel;
        public int error;
        public decimal codigoHotel;

        public ABMHotel02(string modo, decimal hotelId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;
            btn_regimen.Enabled = false;

            hotel = hotelId;
            modoABM = modo;

            cb_estrellas.DropDownStyle = ComboBoxStyle.DropDownList;

            switch (modoABM)
            {
                case "INS":
                    labelTitulo.Text = "Alta de Hotel";
                    l_estado.Visible = false;
                    txt_estado.Visible = false;
                    break;
                case "DLT":
                    labelTitulo.Text = "Baja de Hotel";
                    txt_nombre_hotel.Enabled = false;
                    txt_mail.Enabled = false;
                    txt_telefono.Enabled = false;
                    txt_calle.Enabled = false;
                    txt_nroCalle.Enabled = false;
                    txt_ciudad.Enabled = false;
                    txt_pais.Enabled = false;
                    txt_recargaEstrella.Enabled = false;
                    dt_fecha_cre.Enabled = false;
                    cb_estrellas.Enabled = false;
                    txt_estado.Visible = false;
                    l_estado.Visible = false;
                    break;
                case "UPD":
                    labelTitulo.Text = "Modificación de Hotel";
                    txt_nombre_hotel.Enabled = false;
                    txt_mail.ReadOnly = false;
                    txt_telefono.ReadOnly = false;
                    txt_calle.ReadOnly = false;
                    txt_nroCalle.ReadOnly = false;
                    txt_ciudad.ReadOnly = false;
                    txt_pais.ReadOnly = false;
                    txt_recargaEstrella.ReadOnly = false;
                    dt_fecha_cre.Enabled = true;
                    cb_estrellas.Enabled = true;
                    txt_estado.Visible = false;
                    l_estado.Visible = false;
                    break;
            }

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
            if (hotel != 0)
            {
                Conexion con = new Conexion();
                con.strQuery = "SELECT H.Hotel_Nombre FROM FOUR_SIZONS.Hotel H WHERE H.Hotel_Codigo = " + hotel;
                con.executeQuery();

                if (con.reader())
                {
                    txt_nombre_hotel.Text = con.lector.GetString(0);
                }
            }

            if (modoABM != "INS")
            {
                Conexion con = new Conexion();
                con.strQuery = "SELECT * FROM FOUR_SIZONS.Hotel WHERE Hotel_Codigo = '" + hotel + "'";
                con.executeQuery();

                while (con.reader())
                {
                    txt_nombre_hotel.Text = con.lector.GetString(1);
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
                    if (modoABM == "INS")
                    {
                        txt_nombre_hotel.Enabled = true;
                        txt_nombre_hotel.Text = "";
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
                    con.strQuery = nombreStored;
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    if (modoABM == "INS")
                    {
                        con.command.Parameters.Add("@codigo", SqlDbType.Decimal).Direction = ParameterDirection.Output;
                    }
                    else
                    {
                        con.command.Parameters.Add("@codigo", SqlDbType.NVarChar).Value = hotel;
                    }

                    con.command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txt_nombre_hotel.Text;
                    con.command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = txt_mail.Text;
                    con.command.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = txt_telefono.Text;
                    con.command.Parameters.Add("@calle", SqlDbType.NVarChar).Value = txt_calle.Text;
                    con.command.Parameters.Add("@numCalle", SqlDbType.Decimal).Value = txt_nroCalle.Text;
                    con.command.Parameters.Add("@cantEstrellas", SqlDbType.Decimal).Value = cb_estrellas.Text;
                    con.command.Parameters.Add("@recarga_estrella", SqlDbType.Decimal).Value = txt_recargaEstrella.Text;
                    con.command.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = txt_ciudad.Text;
                    con.command.Parameters.Add("@pais", SqlDbType.NVarChar).Value = txt_pais.Text;
                    con.command.Parameters.Add("@fechaCreacion", SqlDbType.DateTime).Value = readConfig.Config.fechaSystem().ToString();
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

                    if (modoABM == "INS") 
                    {
                        codigoHotel = Convert.ToDecimal(con.command.Parameters["@codigo"].Value);
                    }

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

        public bool verificarObligatorios()
        {
            abm_valido = true;

            if (txt_nombre_hotel.Text == "") abm_valido = false;
            if (txt_pais.Text == "") abm_valido = false;
            if (txt_nroCalle.Text == "") abm_valido = false;
            if (txt_telefono.Text == "") abm_valido = false;
            if (txt_calle.Text == "") abm_valido = false;
            if (txt_ciudad.Text == "") abm_valido = false;
            if (txt_mail.Text == "") abm_valido = false;
            if (txt_recargaEstrella.Text == "") abm_valido = false;
            if (cb_estrellas.Text == "") abm_valido = false;
            if (dt_fecha_cre.Text == "") abm_valido = false;

            return abm_valido;
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
            if (modoABM != "DLT") 
            {
                if (verificarObligatorios() == false)
                {
                    error = 1;
                    MessageBox.Show("Por favor, complete los campos obligatorios", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                if (IsNumber(cb_estrellas.Text) == false)
                {
                    error = 1;
                    MessageBox.Show("Por favor, el número de documento debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                if (IsNumber(txt_recargaEstrella.Text) == false)
                {
                    error = 1;
                    MessageBox.Show("Por favor, el piso debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                if (IsNumber(txt_nroCalle.Text) == false)
                {
                    error = 1;
                    MessageBox.Show("Por favor, el número de calle debe ser un dato numérico", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            }

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
            
            if (error == 0)
            {   
                ejecutarABMHotel(nombreSP);
                btn_regimen.Enabled = true; 
                MessageBox.Show("Cree regímenes para el hotel para continuar", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }

        }

        private void btn_aceptar_nuevo_Click(object sender, EventArgs e)
        {
            error = 0;
            if (verificarObligatorios() == false)
            {
                error = 1;
                MessageBox.Show("Por favor, complete los campos obligatorios", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            nombreSP = "FOUR_SIZONS.AltaHotel";
            if (error == 0)
            {
                ejecutarABMHotel(nombreSP);
                txt_nombre_hotel.Text = "";
                txt_mail.Text = "";
                txt_telefono.Text = "";
                txt_calle.Text = "";
                txt_nroCalle.Text = "";
                txt_ciudad.Text = "";
                txt_pais.Text = "";
                txt_recargaEstrella.Text = "";
                dt_fecha_cre.Text = "";
                cb_estrellas.Items.Clear();
            }
        }

        private void btn_promptUsu_Click(object sender, EventArgs e)
        {
            using (PromptHoteles prompt = new PromptHoteles())
            {
                prompt.ShowDialog();

                hotel = Convert.ToDecimal(prompt.TextBox1.Text);
                txt_nombre_hotel.Text = prompt.TextBox2.Text;

                prompt.Close();
            }
            this.Show();
        }

        private void btn_regimen_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMHotel04 formABMHotel04 = new ABMHotel04(modoABM, codigoHotel);
            formABMHotel04.ShowDialog();
            this.Show();
        }
    }
}
