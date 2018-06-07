using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ABMUsuario
{
    public partial class ABMUsuario02 : Form
    {
        public ABMUsuario02(string modo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;
            switch (modo)
            {
                case "INS":
                    labelTitulo.Text = "Alta de Usuario";
                    break;
                case "DLT":
                    labelTitulo.Text = "Baja de Usuario";
                    txt_apellido.ReadOnly = true;
                    txt_direccion.ReadOnly = true;
                    txt_nombre.ReadOnly = true;
                    txt_nro_documento.ReadOnly = true;
                    txt_password.ReadOnly = true;
                    txt_telefono.ReadOnly = true;
                    txt_usuario.ReadOnly = true;
                    cb_tipo_documento.Enabled = false;
                    dt_fecha_nac.Enabled = false;
                    break;
                case "UPD":
                    labelTitulo.Text = "Modificación de Usuario";
                    break;
            }
            dt_fecha_nac.Format = DateTimePickerFormat.Custom;
            dt_fecha_nac.CustomFormat = "dd/MM/yyyy";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ABMUsuario_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT Parametro_Descripcion FROM FOUR_SIZONS.Parametros WHERE Parametro_Codigo = 'DOCUMENTO'";
            con.executeQuery();
            while (con.reader())
            {
                cb_tipo_documento.Items.Add(con.lector.GetString(0));
            }
            con.closeConection();
        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Está seguro que desea borrar el usuario?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Conexion con = new Conexion();
            //con.strQuery = "EXEC ";
            //con.executeQuery();
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
