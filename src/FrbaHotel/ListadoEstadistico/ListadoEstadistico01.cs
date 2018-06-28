using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ListadoEstadistico
{
    public partial class ListadoEstadistico01 : Form
    {
        public ListadoEstadistico01()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadoEstadistico01_Load(object sender, EventArgs e)
        {
            cb_Trimestre.Items.Add("");
            cb_Trimestre.Items.Add("1");
            cb_Trimestre.Items.Add("2");
            cb_Trimestre.Items.Add("3");

            cb_TipoListado.Items.Add("LISTADO 1");
            cb_TipoListado.Items.Add("LISTADO 2");
            cb_TipoListado.Items.Add("LISTADO 3");
            cb_TipoListado.Items.Add("LISTADO 4");
            cb_TipoListado.Items.Add("LISTADO 5");
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_Anio.Text = "";
            cb_Trimestre.Text = "";
            cb_TipoListado.Text = "";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
                        /*try
                        {
                            Conexion con = new Conexion();
                            Encriptor encriptor = new Encriptor();
                            con.strQuery = nombreStored;
                            con.execute();
                            con.command.CommandType = CommandType.StoredProcedure;
                            
                            con.command.Parameters.Add("@username", SqlDbType.NVarChar).Value = txt_usuario.Text;
                            con.command.Parameters.Add("@password", SqlDbType.NVarChar).Value = encriptor.Encrypt(txt_password.Text);
                            con.command.Parameters.Add("@rolNombre", SqlDbType.NVarChar).Value = cb_rol.Text;
                            con.command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txt_nombre.Text;
                            con.command.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = txt_apellido.Text;
                            con.command.Parameters.Add("@tipoDoc", SqlDbType.NVarChar).Value = cb_tipo_documento.Text;
                            con.command.Parameters.Add("@numDoc", SqlDbType.Int).Value = txt_nro_documento.Text;
                            con.command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = txt_mail.Text;
                            con.command.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = txt_telefono.Text;
                            con.command.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = txt_direccion.Text;
                            con.command.Parameters.Add("@fechanac", SqlDbType.DateTime).Value = dt_fecha_nac.Value.ToString();

                            if (modoABM == "DLT")
                            {
                                con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;
                            }else if (modoABM == "UPD")
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
                    }*/
        }
    }
}
