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
                    labelTitulo.Text = "Alta de Cliente";
                    txt_puntos.Visible = false;
                    lpuntos.Visible = false;
                    break;

                case "DLT":
                    labelTitulo.Text = "Baja de Cliente";
                    txt_nombre.Enabled = false;
                    txt_apellido.Enabled = false;
                    cb_tipo_doc.Enabled = false;
                    txt_nro_doc.Enabled = false;
                    txt_localidad.Enabled = false;
                    txt_direccion.Enabled = false;
                    txt_nro_calle.Enabled = false;
                    txt_piso.Enabled = false;
                    txt_departamento.Enabled = false;
                    txt_mail.Enabled = false;
                    txt_telefono.Enabled = false;
                    txt_pais.Enabled = false;
                    txt_ciudad.Enabled = false;
                    txt_nacionalidad.Enabled = false;
                    dt_fecha_nac.Enabled = false;
                    txt_puntos.Enabled = false;
                    break;

                case "UPD":
                    labelTitulo.Text = "Modificación de Cliente";
                    btn_aceptar_nuevo.Visible = false;
                    break;
            }

            dt_fecha_nac.Format = DateTimePickerFormat.Custom;
            dt_fecha_nac.CustomFormat = "dd/MM/yyyy";

            //levantarCombos();

        }

        private void ABMCliente02_Load(object sender, EventArgs e)
        {

            Conexion con = new Conexion();
            con.strQuery = "SELECT Parametro_Descripcion FROM FOUR_SIZONS.Parametros WHERE Parametro_Codigo = 'DOCUMENTO'";
            con.executeQuery();
            while (con.reader())
            {
                cb_tipo_doc.Items.Add(con.lector.GetString(0));
            }
            con.closeConection();
            
            if (modoABM == "INS")
            {
                //levantarCombos();
            }
            else
            {
                con.strQuery = "SELECT * FROM FOUR_SIZONS.Cliente WHERE Cliente_Codigo = '" + cliente + "'";
                con.executeQuery();

                while (con.reader())
                {
                    txt_nombre.Text = con.lector.GetString(1);
                    txt_apellido.Text = con.lector.GetString(2);
                    cb_tipo_doc.Text = con.lector.GetString(3);
                    txt_nro_doc.Text = con.lector.GetDecimal(4).ToString();
                    txt_localidad.Text = con.lector.GetString(5);
                    txt_direccion.Text = con.lector.GetString(6);
                    txt_nro_calle.Text = con.lector.GetDecimal(7).ToString();
                    txt_piso.Text = con.lector.GetDecimal(8).ToString();
                    txt_departamento.Text = con.lector.GetString(9);
                    txt_mail.Text = con.lector.GetString(10);
                    txt_telefono.Text = con.lector.GetString(11);
                    txt_pais.Text = con.lector.GetString(12);
                    txt_ciudad.Text = con.lector.GetString(13);
                    txt_nacionalidad.Text = con.lector.GetString(14);
                    dt_fecha_nac.Value = con.lector.GetDateTime(15);
                    txt_puntos.Text = con.lector.GetDecimal(16).ToString();
                    /*if (con.lector.GetBoolean(10))
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
                    txt_intentoslog.Text = con.lector.GetDecimal(11).ToString();*/
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
                    nombre_sp = "FOUR_SIZONS.ModificacionCliente";
                    break;

                case "DLT":
                    // Baja lógica - Se pone estado en 0
                    nombre_sp = "FOUR_SIZONS.ModificacionCliente";
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
            txt_direccion.Text = "";
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

                            if (modoABM != "INS")
                            {
                                con.command.Parameters.Add("@codigo", SqlDbType.Decimal).Value = cliente;
                            }
                            con.command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txt_nombre.Text;
                            con.command.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = txt_apellido.Text;
                            con.command.Parameters.Add("@numDoc", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_nro_doc.Text);
                            con.command.Parameters.Add("@tipoDoc", SqlDbType.NVarChar).Value = cb_tipo_doc.Text;
                            con.command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = txt_mail.Text;
                            con.command.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = txt_telefono.Text;
                            con.command.Parameters.Add("@pais", SqlDbType.NVarChar).Value = txt_pais.Text;
                            con.command.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = txt_ciudad.Text;
                            con.command.Parameters.Add("@calle", SqlDbType.NVarChar).Value = txt_direccion.Text;
                            con.command.Parameters.Add("@numCalle", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_nro_calle.Text);
                            con.command.Parameters.Add("@piso", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_piso.Text);
                            con.command.Parameters.Add("@depto", SqlDbType.NVarChar).Value = txt_departamento.Text;
                            con.command.Parameters.Add("@localidad", SqlDbType.NVarChar).Value = txt_localidad.Text;
                            con.command.Parameters.Add("@nacionalidad", SqlDbType.NVarChar).Value = txt_nacionalidad.Text;
                            con.command.Parameters.Add("@fechaNac", SqlDbType.DateTime).Value = dt_fecha_nac.Value.ToString();
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
             
        }
         
    }

}

