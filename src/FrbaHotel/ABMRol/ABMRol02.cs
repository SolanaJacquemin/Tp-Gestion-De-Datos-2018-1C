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
        public string func1;
        public string func2;
        public bool repeValido;
        public int i;

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
                    break;
                case "DLT":
                    labelTitulo.Text = "Baja de Rol";
                    txt_nombreRol.Enabled = false;
                    lb_func.Enabled = false;
                    lb_func_usralta.Enabled = false;
                    btn_agregar.Enabled = false;
                    btn_agregarTodo.Enabled = false;
                    btn_eliminar.Enabled = false;
                    btn_eliminarTodo.Enabled = false;
                    txt_estado.Enabled = false;
                    lbl_obligacion.Visible = false;
                    break;
                case "UPD":
                    labelTitulo.Text = "Modificación de Rol";
                    txt_estado.Visible = false;
                    lEstado.Visible = false;
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
                MessageBox.Show("No se han encontrado roles. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                error = 0;
                string func1 = lb_func.SelectedItem.ToString();
                string func2;
                for (int i = 0; i < lb_func_usralta.Items.Count; i++)
                {
                    func2 = lb_func_usralta.Items[i].ToString();
                    if (func1 == func2)
                    {
                        error = 1;
                    }
                        
                }
                if (error == 0) 
                {
                    lb_func_usralta.Items.Add(lb_func.SelectedItem);
                }
                else
                {
                    MessageBox.Show("La funcionalidad " + func1 + " ya ha sido agregada en la lista", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No hay ítem seleccionado", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("No hay ítem seleccionado", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_agregarTodo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_func.Items.Count; i++)
            {
                //lb_func_usralta.Items.Add(lb_func.Items[i].ToString());
            
                error = 0;
                string func1 = lb_func.Items[i].ToString();
                string func2;
                for (int j = 0; j < lb_func_usralta.Items.Count; j++)
                {
                    if (error != 1)
                    {
                        func2 = lb_func_usralta.Items[j].ToString();
                        if (func1 == func2)
                        {
                            error = 1;
                        }
                    }
                    else 
                    {
                        break;
                    }  
                }
                if (error == 0) 
                {
                    lb_func_usralta.Items.Add(func1);
                }
                else
                {
                    MessageBox.Show("La funcionalidad " + func1 + " ya ha sido agregada en la lista", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
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
            if(lb_func_usralta.Items.Count==0) altaValida =false;
            return altaValida;
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


          public bool verificarRepetidos()
          {
              repeValido=true;
              for (i = 0; i < lb_func_usralta.Items.Count; i++)
              {
                    func1 = lb_func_usralta.Items[i].ToString();
                    for (int j =0;j<lb_func_usralta.Items.Count;j++)
                        {
                            func2 = lb_func_usralta.Items[j].ToString();
                            if( func1==func2 && i !=j ) return false;
                        }
              }
              return repeValido;
          }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {

            if (modoABM != "DLT")
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
                }
                if (verificarRepetidos() == false)
                {
                    error = 1;
                    MessageBox.Show("Por favor, un rol no puede tener más de una vez la misma funcionalidad", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
          
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
                // se agrega el código en un try / catch para poder capturar los errores
                try
                {
                    // se crea un nuevo conector, se asigna el nombre del stored y con execute se crea el nuevo comando sql
                    Conexion con = new Conexion();
                    con.strQuery = nombreStored;
                    con.execute();
                    con.command.CommandType = CommandType.StoredProcedure;
                    // se agregan los parámetros para agregar el rol
                    if (modoABM == "INS")
                    {
                        // se agregan los parámetros al stored procedure
                        con.command.Parameters.Add("@rolname", SqlDbType.NVarChar).Value = txt_nombreRol.Text;
                        con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;

                        con.openConection();
                        con.command.ExecuteNonQuery();
                        con.closeConection();

                        con.strQuery = "FOUR_SIZONS.altaRolxFunc";
                        // Se generan llamadas sucesivas para ingresar las funcionalidades del rol
                        for (int i = 0; i < lb_func_usralta.Items.Count; i++)
                        {
                            con.execute();
                            con.command.CommandType = CommandType.StoredProcedure;
                            // se agregan los parámetros al stored procedure
                            con.command.Parameters.Add("@rolname", SqlDbType.NVarChar).Value = txt_nombreRol.Text;
                            con.command.Parameters.Add("@func", SqlDbType.NVarChar).Value = lb_func_usralta.Items[i].ToString();
                            // se abre la conexión con la base de datos, se ejecuta y se cierra
                            con.openConection();
                            con.command.ExecuteNonQuery();
                            con.closeConection();
                        }
                    }else{
                        // en caso de modificar el nombre se llama al sp correspondiente
                        con.command.Parameters.Add("@rolname", SqlDbType.NVarChar).Value = txt_nombreRol.Text;
                        con.command.Parameters.Add("@codigo", SqlDbType.NVarChar).Value = rol;
                        // luego dependiendo del modo se agregan o se quitan funcionalidades del rol
                        if (modoABM == "UPD")
                        {
                            con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;
                            // se abre la conexión con la base de datos, se ejecuta y se cierra
                            con.openConection();
                            con.command.ExecuteNonQuery();
                            con.closeConection();

                            con.strQuery = "FOUR_SIZONS.modificacionRolxFunc";
                            // Se generan llamadas sucesivas para modificar las funcionalidades del rol
                            for (int i = 0; i < lb_func_usralta.Items.Count; i++)
                            {
                                con.execute();
                                con.command.CommandType = CommandType.StoredProcedure;
                                // se agregan los parámetros al stored procedure
                                con.command.Parameters.Add("@rolname", SqlDbType.NVarChar).Value = txt_nombreRol.Text;
                                con.command.Parameters.Add("@func", SqlDbType.NVarChar).Value = lb_func_usralta.Items[i].ToString();
                                con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 1;
                                // se abre la conexión con la base de datos, se ejecuta y se cierra
                                con.openConection();
                                con.command.ExecuteNonQuery();
                                con.closeConection();
                            }
                            // Se generan llamadas sucesivas para dar de baja las funcionalidades del rol
                            for (int i = 0; i < lb_func_usrbaja.Items.Count; i++)
                            {
                                con.execute();
                                con.command.CommandType = CommandType.StoredProcedure;
                                // se agregan los parámetros al stored procedure
                                con.command.Parameters.Add("@rolname", SqlDbType.NVarChar).Value = txt_nombreRol.Text;
                                con.command.Parameters.Add("@func", SqlDbType.NVarChar).Value = lb_func_usrbaja.Items[i].ToString();
                                con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;
                                // se abre la conexión con la base de datos, se ejecuta y se cierra
                                con.openConection();
                                con.command.ExecuteNonQuery();
                                con.closeConection();
                            }

                        }else{
                            con.command.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;
                        }
                        // se abre la conexión con la base de datos, se ejecuta y se cierra
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
                this.Show();
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
