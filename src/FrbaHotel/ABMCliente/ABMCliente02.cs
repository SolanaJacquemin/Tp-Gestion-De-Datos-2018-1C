using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.ABMCliente;
using FrbaHotel.Prompts;

namespace FrbaHotel.ABMCliente
{

    public partial class ABMCliente02 : Form
    {
        public static string modoABM;
        public string nombre_sp;
        public int error;
        public decimal cliente;

        public ABMCliente02(string modo, decimal clie)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            modoABM = modo;
            cliente = clie;

            switch (modoABM)
            {
                case "INS":
                    lbl_titulo.Text = "Alta de Cliente";
                    txt_estado.Visible = false;
                    lbl_estado.Visible = false;
                    break;

                case "DLT":
                    lbl_titulo.Text = "Baja de Cliente";
                    txt_nombre.ReadOnly = true;
                    txt_apellido.ReadOnly = true;
                    txt_mail.ReadOnly = true;
                    txt_nro_doc.ReadOnly = true;
                    txt_telefono.ReadOnly = true;
                    txt_localidad.ReadOnly = true;
                    cb_tipo_doc.Enabled = false;
                    txt_telefono.ReadOnly = true;
                    txt_piso.ReadOnly = true;
                    txt_depto.ReadOnly = true;
                    txt_nro_calle.ReadOnly = true;
                    txt_calle.ReadOnly = true;
                    dt_fecha_nac.Enabled = false;
                    txt_nacionalidad.ReadOnly = true;
                    btn_aceptar_nuevo.Visible = false;
                    break;

                case "UPD":
                    lbl_titulo.Text = "Modificación de Cliente";
                    btn_aceptar_nuevo.Visible = false;
                    break;
            }

            dt_fecha_nac.Format = DateTimePickerFormat.Custom;
            dt_fecha_nac.CustomFormat = "dd/MM/yyyy";

            //levantarCombos();

        }

        private void ABMCliente02_Load(object sender, EventArgs e)
        {

            if (modoABM == "INS")
            {
                levantarCombos();
            }
            else
            {
                Conexion con = new Conexion();
                con.strQuery = "SELECT * FROM FOUR_SIZONS.Cliente WHERE Cliente_Codigo = '" + cliente + "'";
                con.executeQuery();
                
                while (con.reader())
                {
                    txt_nombre.Text = con.lector.GetString(1);
                    txt_apellido.Text = con.lector.GetString(2);
                    cb_tipo_doc.Text = con.lector.GetString(3);
                    txt_nro_doc.Text = con.lector.GetDecimal(4).ToString();
                    txt_telefono.Text = con.lector.GetString(11);
                    txt_calle.Text = con.lector.GetString(6);
                    txt_nro_calle.Text = con.lector.GetDecimal(7).ToString();
                    txt_piso.Text = con.lector.GetDecimal(8).ToString();
                    txt_depto.Text = con.lector.GetString(9);
                    dt_fecha_nac.Value = con.lector.GetDateTime(13);
                    txt_mail.Text = con.lector.GetString(10);
                    txt_nacionalidad.Text = con.lector.GetString(12);
                    txt_localidad.Text = con.lector.GetString(5);
                    
                        if (con.lector.GetBoolean(15))
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

            error = 0;
            switch (modoABM)
            {
                case "INS":
                    nombre_sp = "FOUR_SIZONS.AltaCliente";
                    break;

                case "UPD":
                    nombre_sp = "FOUR_SIZONS.modificacionCliente";
                    break;

                case "DLT":
                    // Baja lógica - Se pone estado en 0
                    nombre_sp = "FOUR_SIZONS.modificacionCliente";
                    break;
            }

            ejecutarABMCliente(nombre_sp);

            if (error == 0)
            {
                this.Close();
            }

        }


        private void btn_aceptar_nuevo_Click(object sender, EventArgs e)
        {
            error = 0;
            nombre_sp = "FOUR_SIZONS.AltaCliente";
            ejecutarABMCliente(nombre_sp);
            cb_tipo_doc.Text = "";
            txt_nro_doc.Text = "";
            txt_calle.Text = "";
            txt_telefono.Text = "";
            txt_mail.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_nacionalidad.Text = "";
            cb_tipo_doc.Items.Clear();

            //levantarCombos();
        }

        private void levantarCombos()
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT Parametro_Descripcion FROM FOUR_SIZONS.Parametros WHERE Parametro_Codigo = 'DOCUMENTO'";
            con.executeQuery();
            while (con.reader())
            {
                cb_tipo_doc.Items.Add(con.lector.GetString(0));
            }
            con.closeConection();
        }


        public void ejecutarABMCliente(string nombreStored)
        {
            if (MessageBox.Show("Está seguro que desea continuar con la operación?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    Conexion con = new Conexion();
                    con.strQuery = nombreStored;
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;

                    con.command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txt_nombre.Text;
                    con.command.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = txt_apellido.Text;
                    con.command.Parameters.Add("@tipoDoc", SqlDbType.NVarChar).Value = cb_tipo_doc.Text;
                    con.command.Parameters.Add("@numDoc", SqlDbType.Int).Value = txt_nro_doc.Text;
                    con.command.Parameters.Add("@localidad", SqlDbType.NVarChar).Value = txt_localidad.Text;
                    con.command.Parameters.Add("@calle", SqlDbType.NVarChar).Value = txt_calle.Text;
                    con.command.Parameters.Add("@numCalle", SqlDbType.Int).Value = txt_nro_calle.Text;
                    con.command.Parameters.Add("@piso", SqlDbType.Int).Value = txt_piso.Text;
                    con.command.Parameters.Add("@depto", SqlDbType.NVarChar).Value = txt_depto.Text;
                    con.command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = txt_mail.Text;
                    con.command.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = txt_telefono.Text;
                    con.command.Parameters.Add("@nacionalidad", SqlDbType.NVarChar).Value = txt_nacionalidad.Text;
                    con.command.Parameters.Add("@fechanac", SqlDbType.DateTime).Value = dt_fecha_nac.Value.ToString();

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

    }

}
