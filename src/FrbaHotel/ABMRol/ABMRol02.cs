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
        public string func_nombre;
        public decimal func_codigo;
        public bool altaValida;

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
                    lEstado.Visible = false;
                    txt_estado.Visible = false;
                    lbl_obligacion.ForeColor = Color.Red;
                    break;
                case "DLT":
                    labelTitulo.Text = "Baja de Rol";
                    txt_nombreRol.ReadOnly = true;
                    lb_func.Enabled = false;
                    lb_func_usralta.Enabled = false;
                    btn_agregar.Enabled = false;
                    btn_agregarTodo.Enabled = false;
                    btn_eliminar.Enabled = false;
                    btn_eliminarTodo.Enabled = false;
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

            // Se cargan las funcionalidades a una lista de selección
            func_nombre = con.lector.GetString(1);
            lb_func.Items.Add(func_nombre);

            while (con.reader())
            {
                func_nombre = con.lector.GetString(1);
                lb_func.Items.Add(func_nombre);
            }
            con.closeConection();


            if (modoABM != "INS")
            {
                
                con.strQuery = "SELECT * FROM FOUR_SIZONS.Rol WHERE Rol_Codigo = '" + rol + "'";
                con.executeQuery();

                while (con.reader())
                {
                    txt_nombreRol.Text = con.lector.GetString(1);
                    if (con.lector.GetBoolean(2))
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

                con.strQuery = "SELECT * FROM FOUR_SIZONS.RolXFunc WHERE Rol_Codigo = '" + rol + "'";
                con.executeQuery();

                while (con.reader())
                {
                    func_codigo = con.lector.GetDecimal(1);

                    Conexion con2 = new Conexion();
                    con2.strQuery = "SELECT F.Func_Nombre FROM FOUR_SIZONS.RolXFunc RF" + 
                                    " JOIN FOUR_SIZONS.Funcionalidad F ON F.Func_Codigo = RF.Func_Codigo " +
                                    " WHERE RF.Rol_Codigo = " + rol + " AND RF.Func_Codigo = " + func_codigo + 
                                    " AND RF.RolXFunc_Estado = 1";
                    con2.executeQuery();
                    while (con2.reader())
                    {
                        lb_func_usralta.Items.Add(con2.lector.GetString(0));
                    }
                    con2.closeConection(); 
                }
                con.closeConection();
            }
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (lb_func.SelectedItem != null)
            {
                lb_func_usralta.Items.Add(lb_func.SelectedItem);
            }
            else
            {
                MessageBox.Show("No hay ítem seleccionado");
            }
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (lb_func_usralta.SelectedItem != null)
            {
                lb_func_usrbaja.Items.Add(lb_func_usralta.SelectedItem);
                lb_func_usralta.Items.Remove(lb_func_usralta.SelectedItem);
            }
            else
            {
                MessageBox.Show("No hay ítem seleccionado");
            }
        }

        private void btn_agregarTodo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_func.Items.Count; i++)
            {
                lb_func_usralta.Items.Add(lb_func.Items[i].ToString());
            }
        }

        private void btn_eliminarTodo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_func_usralta.Items.Count; i++)
            {
                lb_func_usrbaja.Items.Add(lb_func_usralta.Items[i].ToString());
            }
            lb_func_usralta.Items.Clear();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool verificarObligatorios()
        {
            altaValida = true;

            if (txt_nombreRol.Text == "") altaValida = false;
            return altaValida;
        }

        bool IsNumber(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {

            error = 0;
            if (verificarObligatorios() == false)
            {
                error = 1;
                MessageBox.Show("Por favor, complete los campos obligatorios", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (IsNumber(txt_nombreRol.Text))
            {
                error = 1;
                MessageBox.Show("Por favor, el nombre del rol no debe contener números", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            switch (modoABM)
            {
                case "INS":
                    nombreSP = "FOUR_SIZONS.InsertarRol";
                    break;
            
                case "UPD":
                    nombreSP = "FOUR_SIZONS.ModificacionRol";
                    break;

                case "DLT":
                    // Baja lógica - Se pone estado en 0
                    nombreSP = "FOUR_SIZONS.ModificacionRol";
                    break;
            }
            
            if (error == 0)
            {
                ejecutarABMRol(nombreSP);
                this.Close();
            }
        }

        public void ejecutarABMRol(string nombreStored)
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
                        con.command.Parameters.Add("@rolname", SqlDbType.NVarChar).Value = txt_nombreRol.Text;
                        con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;

                        con.openConection();
                        con.command.ExecuteNonQuery();
                        con.closeConection();

                        con.strQuery = "FOUR_SIZONS.altaRolxFunc";

                        for (int i = 0; i < lb_func_usralta.Items.Count; i++)
                        {
                            con.execute();
                            con.command.CommandType = CommandType.StoredProcedure;

                            con.command.Parameters.Add("@rolname", SqlDbType.NVarChar).Value = txt_nombreRol.Text;
                            con.command.Parameters.Add("@func", SqlDbType.NVarChar).Value = lb_func_usralta.Items[i].ToString();

                            con.openConection();
                            con.command.ExecuteNonQuery();
                            con.closeConection();
                        }
                    }else{
                        con.command.Parameters.Add("@rolname", SqlDbType.NVarChar).Value = txt_nombreRol.Text;
                        con.command.Parameters.Add("@codigo", SqlDbType.NVarChar).Value = rol;
                        
                        if (modoABM == "UPD")
                        {
                            con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;

                            con.openConection();
                            con.command.ExecuteNonQuery();
                            con.closeConection();

                            con.strQuery = "FOUR_SIZONS.modificacionRolxFunc";

                            for (int i = 0; i < lb_func_usralta.Items.Count; i++)
                            {
                                con.execute();
                                con.command.CommandType = CommandType.StoredProcedure;

                                con.command.Parameters.Add("@rolname", SqlDbType.NVarChar).Value = txt_nombreRol.Text;
                                con.command.Parameters.Add("@func", SqlDbType.NVarChar).Value = lb_func_usralta.Items[i].ToString();
                                con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;

                                con.openConection();
                                con.command.ExecuteNonQuery();
                                con.closeConection();
                            }

                            for (int i = 0; i < lb_func_usrbaja.Items.Count; i++)
                            {
                                con.execute();
                                con.command.CommandType = CommandType.StoredProcedure;

                                MessageBox.Show(lb_func_usrbaja.Items[i].ToString());

                                con.command.Parameters.Add("@rolname", SqlDbType.NVarChar).Value = txt_nombreRol.Text;
                                con.command.Parameters.Add("@func", SqlDbType.NVarChar).Value = lb_func_usrbaja.Items[i].ToString();
                                con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;

                                con.openConection();
                                con.command.ExecuteNonQuery();
                                con.closeConection();
                            }

                        }else{
                            con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;
                        }

                        con.openConection();
                        con.command.ExecuteNonQuery();
                        con.closeConection();
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

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_func_usralta.Items.Count; i++)
            {
                MessageBox.Show(lb_func_usralta.Items[i].ToString());
            }
        }
    }
}
