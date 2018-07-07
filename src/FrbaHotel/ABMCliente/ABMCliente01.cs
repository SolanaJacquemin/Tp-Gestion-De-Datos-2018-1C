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

namespace FrbaHotel.AbmCliente
{
    public partial class ABMCliente01 : Form
    {
        public decimal dgv_cliente_ID;
        public int index;

        public ABMCliente01()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            cb_tipo_doc.DropDownStyle = ComboBoxStyle.DropDownList;

            dgv_Clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Clientes.Rows.Clear();

            iniciarGrilla();
            refrescarGrid();

        }

        public void iniciarGrilla() 
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT TOP 100 Cliente_Codigo, Cliente_Nombre, Cliente_Apellido, " +
                                "Cliente_TipoDoc, Cliente_NumDoc, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, " +
                                " Cliente_Mail, Cliente_Nacionalidad, Cliente_Fecha_Nac, Cliente_Puntos, " +
                                "Cliente_Estado, Cliente_Consistente " +
                                "FROM FOUR_SIZONS.Cliente ORDER BY Cliente_Codigo";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado clientes. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Clientes.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
            con.lector.GetString(2), con.lector.GetString(3), con.lector.GetDecimal(4), con.lector.GetString(5),
            con.lector.GetDecimal(6), con.lector.GetDecimal(7), con.lector.GetString(8), con.lector.GetString(9),
            con.lector.GetString(10), con.lector.GetDateTime(11), con.lector.GetDecimal(12), con.lector.GetBoolean(13), con.lector.GetBoolean(14)});

            while (con.reader())
            {
                dgv_Clientes.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
                con.lector.GetString(2), con.lector.GetString(3), con.lector.GetDecimal(4), con.lector.GetString(5),
                con.lector.GetDecimal(6), con.lector.GetDecimal(7), con.lector.GetString(8), con.lector.GetString(9),
                con.lector.GetString(10), con.lector.GetDateTime(11), con.lector.GetDecimal(12), con.lector.GetBoolean(13), 
                con.lector.GetBoolean(14)});
            }
            
            con.closeConection();
        }

        public void limpiar()
        {
            dgv_Clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Clientes.Rows.Clear();
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_mail.Text = "";
            cb_tipo_doc.Items.Clear();
            dgv_Clientes.Rows.Clear();
            iniciarGrilla();
            refrescarGrid();
        }

        private void buscar()
        {
            dgv_Clientes.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT TOP 100 Cliente_Codigo, Cliente_Nombre, Cliente_Apellido, " +
                                "Cliente_TipoDoc, Cliente_NumDoc, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, " +
                                " Cliente_Mail, Cliente_Nacionalidad, Cliente_Fecha_Nac, Cliente_Puntos, " +
                                "Cliente_Estado, Cliente_Consistente FROM FOUR_SIZONS.Cliente WHERE 1=1 ";
            if (txt_nombre.Text != "")
                con.strQuery = con.strQuery + "AND Cliente_Nombre like '%" + txt_nombre.Text + "%' ";
            if (txt_apellido.Text != "")
                con.strQuery = con.strQuery + "AND Cliente_Apellido like '%" + txt_apellido.Text + "%' ";
            if (txt_mail.Text != "")
                con.strQuery = con.strQuery + "AND Cliente_Mail like '%" + txt_mail.Text + "%' ";
            if (txt_nro_doc.Text != "")
                con.strQuery = con.strQuery + "AND Cliente_NumDoc =" + txt_nro_doc.Text;
            if (cb_tipo_doc.Text != "")
                con.strQuery = con.strQuery + "AND Cliente_TipoDoc like '%" + cb_tipo_doc.Text + "%' ";
                con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado clientes. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Clientes.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
                con.lector.GetString(2), con.lector.GetString(3), con.lector.GetDecimal(4), con.lector.GetString(5),
                con.lector.GetDecimal(6), con.lector.GetDecimal(7), con.lector.GetString(8), con.lector.GetString(9),
                con.lector.GetString(10), con.lector.GetDateTime(11), con.lector.GetDecimal(12), con.lector.GetBoolean(13), 
                con.lector.GetBoolean(14)});

            while (con.reader())
            {
                dgv_Clientes.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
                con.lector.GetString(2), con.lector.GetString(3), con.lector.GetDecimal(4), con.lector.GetString(5),
                con.lector.GetDecimal(6), con.lector.GetDecimal(7), con.lector.GetString(8), con.lector.GetString(9),
                con.lector.GetString(10), con.lector.GetDateTime(11), con.lector.GetDecimal(12), con.lector.GetBoolean(13), 
                con.lector.GetBoolean(14)});
            }

            dgv_Clientes.ClearSelection();
            foreach (DataGridViewRow row in dgv_Clientes.Rows)
                if (Convert.ToBoolean(row.Cells[13].Value) == false)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            con.closeConection();
            //dgv_Clientes.Rows.Clear();
            //refrescarGrid();
        } 
          
        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();    
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {         
            string modo = "INS";
            this.Hide();
            ABMCliente02 formABMCliente02 = new ABMCliente02(modo, dgv_cliente_ID);
            formABMCliente02.ShowDialog();
            this.Show();
            limpiar();
            this.refrescarGrid();
             
        }
        
        private void btn_baja_Click(object sender, EventArgs e)
        {
            
            if (dgv_Clientes.SelectedRows.Count > 0)
            {
                string modo = "DLT";
                this.Hide();
                ABMCliente02 formABMCliente02 = new ABMCliente02(modo, dgv_cliente_ID);
                formABMCliente02.ShowDialog();
                this.Show();
                this.limpiar();
                this.refrescarGrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btn_Modificacion_Click(object sender, EventArgs e)
        {
            if (dgv_Clientes.SelectedRows.Count > 0)
            {
                string modo = "UPD";
                this.Hide();
                ABMCliente02 formABMCliente02 = new ABMCliente02(modo, dgv_cliente_ID);
                formABMCliente02.ShowDialog();
                this.Show();
                limpiar();
                this.refrescarGrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ABMCliente01_Load(object sender, EventArgs e)
        {
            refrescarGrid();
        }

        private void refrescarGrid()
        {
            dgv_Clientes.ClearSelection();
            foreach (DataGridViewRow row in dgv_Clientes.Rows)
                if (Convert.ToBoolean(row.Cells[13].Value) == false)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
        }

        private void dgv_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_Clientes.Rows[index];
            dgv_cliente_ID = Convert.ToDecimal(selectedRow.Cells[0].Value.ToString());
        }
    }
}