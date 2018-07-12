using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Prompts
{
    public partial class PromptUsuarios : Form
    {
        public decimal hotel;
        public PromptUsuarios(decimal hotelID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txt_aux_hotelid.Visible = false;
            dgvUsuariosPrompt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            hotel = hotelID;
            dgvUsuariosPrompt.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Usuario_ID, Usuario_Apellido " +
                           "FROM FOUR_SIZONS.Usuario ORDER BY Usuario_ID";

            if (hotel == 0)
            {

                con.strQuery = "SELECT Usuario_ID, Usuario_Nombre, Usuario_Apellido, " +
                                "Usuario_TipoDoc, Usuario_NroDoc, Usuario_Telefono, Usuario_Direccion, " +
                                "Usuario_Fec_Nac, Usuario_Mail, Usuario_Estado, Usuario_FallaLog " +
                                "FROM FOUR_SIZONS.Usuario ORDER BY Usuario_ID";
            }
            else
            {
                con.strQuery = "SELECT U.Usuario_ID, U.Usuario_Nombre, U.Usuario_Apellido, U.Usuario_TipoDoc, U.Usuario_NroDoc, U.Usuario_Telefono, U.Usuario_Direccion, U.Usuario_Fec_Nac, U.Usuario_Mail, U.Usuario_Estado, U.Usuario_FallaLog " +
                "FROM FOUR_SIZONS.Usuario U JOIN FOUR_SIZONS.UsuarioXHotel UH ON UH.Usuario_ID = U.Usuario_ID";
                if (hotel != 0)
                {
                    con.strQuery = con.strQuery + " WHERE Hotel_Codigo = " + hotel;
                }
                con.strQuery = con.strQuery + " ORDER BY U.Usuario_ID ";
            }





            con.executeQuery();
            if (!con.reader())
            {
                MessageBox.Show("La busqueda no produjo resultados");
                con.strQuery = "";
                con.closeConection();
                //return;
            }

            dgvUsuariosPrompt.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgvUsuariosPrompt.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1) });
            }
            con.closeConection();
        }

        private void PromptUsuarios_Load(object sender, EventArgs e)
        {

        }

        public TextBox TextBox1
        {
            get
            {
                return txt_aux_hotelid;
            }
        }

        private void dgvUsuariosPrompt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0) 
            {
                DataGridViewRow selectedRow = dgvUsuariosPrompt.Rows[index];
                string dgv_usuario_ID = selectedRow.Cells[0].Value.ToString();
                txt_aux_hotelid.Text = dgv_usuario_ID;
            }
            this.Hide();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgvUsuariosPrompt.Rows.Clear();

            Conexion con = new Conexion();
            con.strQuery = "SELECT Usuario_ID, Usuario_Apellido FROM FOUR_SIZONS.Usuario WHERE 1=1";
            if (txt_usuarioid.Text != "")
                con.strQuery = con.strQuery + " AND Usuario_ID like '%" + txt_usuarioid.Text + "%' ";
            con.strQuery = con.strQuery + "ORDER BY Usuario_ID";
            con.executeQuery();

            if (!con.reader())
            {
                MessageBox.Show("La busqueda no produjo resultados");
                con.strQuery = "";
                con.closeConection();
                return;
            }

            dgvUsuariosPrompt.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1) });

            while (con.reader())
            {
                dgvUsuariosPrompt.Rows.Add(new Object[] { con.lector.GetString(0), con.lector.GetString(1) });
            }

            con.closeConection();
        }
    }
}
