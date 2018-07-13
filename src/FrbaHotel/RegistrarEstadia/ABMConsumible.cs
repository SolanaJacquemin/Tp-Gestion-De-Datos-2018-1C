using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class ABMConsumible : Form
    {
        public static string modoABM;
        public decimal consumible;
        public decimal error;
        public decimal estadia;
        public string nombreSP;
        public bool valido;

        public ABMConsumible(string modo, decimal estadiaID, decimal consumibleID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelTitulo.AutoSize = false;

            modoABM = modo;
            consumible = consumibleID;
            estadia = estadiaID;

            switch (modoABM)
            {

                case "INS":
                    labelTitulo.Text = "Agregar Consumible";
                    break;
                case "UPD":
                    labelTitulo.Text = "Modificar Consumible";
                    break;
                case "DLT":
                    labelTitulo.Text = "Eliminar Consumible";
                    break;
            }

            Conexion con = new Conexion();
            con.strQuery = "SELECT Consumible_Descripcion FROM FOUR_SIZONS.Consumible";
            con.executeQuery();
            while (con.reader())
            {
                cb_consumibles.Items.Add(con.lector.GetString(0));
            }
            con.closeConection();

        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool verificarCampos()
        {
            if (txt_cantidad.Text == "") valido = false;
            if (cb_consumibles.Text == "") valido = false;

            return valido;
        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            error = 0;
            verificarCampos();
            if (error == 0)
            {
                switch (modoABM)
                {
                    case "INS":
                        nombreSP = "FOUR_SIZONS.RegistrarConsXest";
                        break;

                    case "UPD":
                        nombreSP = "FOUR_SIZONS.bajaModifConsXestadia";
                        break;

                    case "DLT":
                        nombreSP = "FOUR_SIZONS.bajaModifConsXestadia";
                        break;
                }
                ejecutarABMConsumible(nombreSP);
                if (error == 0)
                {
                    this.Close();
                }
            }
        }

        public void ejecutarABMConsumible(string nombreStored)
        {
            try
            {
                Conexion con = new Conexion();
                con.strQuery = nombreSP;
                con.execute();
                con.command.CommandType = CommandType.StoredProcedure;

                con.command.Parameters.Add("@estadia", SqlDbType.Decimal).Value = estadia;
                con.command.Parameters.Add("@consumible", SqlDbType.NVarChar).Value = cb_consumibles.Text;
                con.command.Parameters.Add("@cant", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_cantidad.Text);

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

        private void ABMConsumible_Load(object sender, EventArgs e)
        {
            if (modoABM != "INS")
            {
                Conexion con = new Conexion();
                con.strQuery = "SELECT C.Consumible_Descripcion, EC.estXcons_cantidad FROM FOUR_SIZONS.Consumible C" +
                               " JOIN FOUR_SIZONS.EstadiaXConsumible EC ON EC.Consumible_Codigo = C.Consumible_Codigo" +
                               " WHERE C.Consumible_Codigo = " + consumible + " AND EC.Estadia_Codigo = " + estadia;
                con.executeQuery();

                if (con.reader())
                {
                    cb_consumibles.Text = con.lector.GetString(0);
                    txt_cantidad.Text = con.lector.GetDecimal(1).ToString();
                }

                con.closeConection();

                cb_consumibles.Enabled = false;
                if(modoABM == "DLT")
                {
                    txt_cantidad.Enabled = false;
                }
            }
        }
    }
}
