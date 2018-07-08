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
    public partial class ABMRol01 : Form
    {
        public string dgv_Roles_Id;
        public int index;
        public bool estado;

        public ABMRol01()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            dgv_Roles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dgv_Roles.Rows.Clear();
            iniciarGrilla();

        }

        public void iniciarGrilla()
        {
            Conexion con = new Conexion();
            con.strQuery = "SELECT * FROM FOUR_SIZONS.Rol ORDER BY Rol_Codigo";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado roles. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Roles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
            con.lector.GetBoolean(2)});

            while (con.reader())
            {
                dgv_Roles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
            con.lector.GetBoolean(2)});
            }
            con.closeConection();
        }

        private void buscar()
        {
            dgv_Roles.Rows.Clear();            

            Conexion con = new Conexion();
            con.strQuery = "SELECT * FROM FOUR_SIZONS.Rol WHERE 1=1 ";
            if (txt_codigo.Text != "")
                con.strQuery = con.strQuery + "AND Rol_Codigo = " + txt_codigo.Text;
            if (txt_nombre.Text != "")
                con.strQuery = con.strQuery + "AND Rol_Nombre like '%" + txt_nombre.Text + "%' ";
            con.strQuery = con.strQuery + "ORDER BY Rol_Codigo";
            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("No se han encontrado roles. Revise los criterios de búsqueda", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgv_Roles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
            con.lector.GetBoolean(2)});

            while (con.reader())
            {
                dgv_Roles.Rows.Add(new Object[] { con.lector.GetDecimal(0), con.lector.GetString(1),
            con.lector.GetBoolean(2)});
            }
            con.closeConection();
        }

        public void dgv_Roles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_Roles.Rows[index];
            dgv_Roles_Id = selectedRow.Cells[0].Value.ToString();
            estado = Convert.ToBoolean(selectedRow.Cells[2].Value);
        }

        private void refrescarGrid()
        {
            dgv_Roles.ClearSelection();
            foreach (DataGridViewRow row in dgv_Roles.Rows)
                if (Convert.ToBoolean(row.Cells[2].Value) == false)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
        }

        private void ABMRol01_Load(object sender, EventArgs e)
        {
            refrescarGrid();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void boton_alta_Click(object sender, EventArgs e)
        {
            string modo = "INS";
            this.Hide();
            ABMRol02 formABMRol02 = new ABMRol02(modo, txt_codigo.Text);
            formABMRol02.ShowDialog();
            this.Show();
            this.buscar();
            this.refrescarGrid();
        }

        private void boton_baja_Click(object sender, EventArgs e)
        {
            if (dgv_Roles.SelectedRows.Count > 0 && estado==true)
            {
                string modo = "DLT";
                this.Hide();
                ABMRol02 formABMRol02 = new ABMRol02(modo, dgv_Roles_Id);
                formABMRol02.ShowDialog();
                this.Show();
                this.buscar();
                this.refrescarGrid();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rol que se encuentre habilitado de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boton_modificacion_Click(object sender, EventArgs e)
        {
            if (dgv_Roles.SelectedRows.Count > 0)
            {    
                if(estado==false)
                {
                    if (MessageBox.Show("El rol se encuentra inhabilitado, desea darle de alta?", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string modo = "UPD";
                        this.Hide();
                        ABMRol02 formABMRol02 = new ABMRol02(modo, dgv_Roles_Id);
                        formABMRol02.ShowDialog();
                        this.Show();
                        this.buscar();
                        this.refrescarGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol de la grilla", "FOUR SIZONS - FRBA Hoteles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            dgv_Roles.Rows.Clear();
            iniciarGrilla();
            refrescarGrid();
        }

    }
}
