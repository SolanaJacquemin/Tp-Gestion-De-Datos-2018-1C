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
        public string cliente;

        public ABMCliente02(string modo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            modoABM = modo;

            switch (modoABM)
            {
                case "INS":
                    lbl_titulo.Text = "Alta de Cliente";
                    break;

                case "DLT":
                    lbl_titulo.Text = "Baja de Cliente";
                    txt_nombre.ReadOnly = true;
                    txt_apellido.ReadOnly = true;
                    txt_mail.ReadOnly = true;
                    txt_nro_doc.ReadOnly = true;
                    cb_tipo_doc.Enabled = false;
                    txt_telefono.ReadOnly = true;
                    txt_direccion.ReadOnly = true;
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


        }

        private void ABMCliente02_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
