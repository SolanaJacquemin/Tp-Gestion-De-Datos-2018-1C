using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ABMRol
{
    public partial class ABMRol02 : Form
    {
        public static string modoABM;
        public string nombreSP;
        public string rol;
        public int error;

        public ABMRol02(string modo, string rolId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;

            rol = rolId;
            modoABM = modo;

            switch (modoABM)
            {
                case "INS":
                    labelTitulo.Text = "Alta de Rol";

                    break;
                case "DLT":
                    labelTitulo.Text = "Baja de Rol";

                    break;
                case "UPD":
                    labelTitulo.Text = "Modificación de Rol";

                    break;
            }
        }

        private void ABMRol02_Load(object sender, EventArgs e)
        {
            

            Conexion con = new Conexion();
            con.strQuery = "SELECT * FROM FOUR_SIZONS.Funcionalidad ORDER BY Func_Codigo";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado usuarios. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            
            string func_nombre = con.lector.GetString(1);
            //MessageBox.Show(func_nombre);
            lb_func.Items.Add(func_nombre);

            //lb_func.Items.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
            //con.lector.GetBoolean(2)});
            //dgv_Roles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
            //con.lector.GetBoolean(2)});

           

            while (con.reader())
            {
                

              //  lb_func.Items.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
            //con.lector.GetBoolean(2)});
            }
            con.closeConection();
        }
    }
}
