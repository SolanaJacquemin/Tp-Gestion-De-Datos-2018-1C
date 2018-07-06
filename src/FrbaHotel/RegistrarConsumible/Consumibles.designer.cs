namespace FrbaHotel.RegistrarConsumible
{
    partial class Consumibles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.gb_DatosEstadia = new System.Windows.Forms.GroupBox();
            this.txt_CodReserva = new System.Windows.Forms.TextBox();
            this.lbl_CodReserva = new System.Windows.Forms.Label();
            this.dgv_Estadia = new System.Windows.Forms.DataGridView();
            this.Estadia_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserva_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadia_FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadia_FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadia_CantNoches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadia_DiasRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadia_PreXNoche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_OUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitacion_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadia_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Estadia = new System.Windows.Forms.TextBox();
            this.lbl_Estadia = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.boton_volver = new System.Windows.Forms.Button();
            this.boton_aceptar = new System.Windows.Forms.Button();
            this.lbl_consumible = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.cb_consumibles = new System.Windows.Forms.ComboBox();
            this.cb_cantidad = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_DatosEstadia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estadia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8F);
            this.label8.Location = new System.Drawing.Point(22, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "FRBA Hoteles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "FOUR SIZONS";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Calibri", 15F);
            this.lbl_Titulo.Location = new System.Drawing.Point(193, 19);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(196, 24);
            this.lbl_Titulo.TabIndex = 12;
            this.lbl_Titulo.Text = "Registrar Consumibles";
            // 
            // gb_DatosEstadia
            // 
            this.gb_DatosEstadia.Controls.Add(this.txt_CodReserva);
            this.gb_DatosEstadia.Controls.Add(this.lbl_CodReserva);
            this.gb_DatosEstadia.Controls.Add(this.dgv_Estadia);
            this.gb_DatosEstadia.Controls.Add(this.txt_Estadia);
            this.gb_DatosEstadia.Controls.Add(this.lbl_Estadia);
            this.gb_DatosEstadia.Controls.Add(this.btn_Buscar);
            this.gb_DatosEstadia.Controls.Add(this.btn_Limpiar);
            this.gb_DatosEstadia.Location = new System.Drawing.Point(25, 69);
            this.gb_DatosEstadia.Name = "gb_DatosEstadia";
            this.gb_DatosEstadia.Size = new System.Drawing.Size(579, 263);
            this.gb_DatosEstadia.TabIndex = 15;
            this.gb_DatosEstadia.TabStop = false;
            this.gb_DatosEstadia.Text = "Datos de la estadía";
            // 
            // txt_CodReserva
            // 
            this.txt_CodReserva.Location = new System.Drawing.Point(356, 33);
            this.txt_CodReserva.Name = "txt_CodReserva";
            this.txt_CodReserva.Size = new System.Drawing.Size(100, 20);
            this.txt_CodReserva.TabIndex = 4;
            // 
            // lbl_CodReserva
            // 
            this.lbl_CodReserva.AutoSize = true;
            this.lbl_CodReserva.Location = new System.Drawing.Point(255, 36);
            this.lbl_CodReserva.Name = "lbl_CodReserva";
            this.lbl_CodReserva.Size = new System.Drawing.Size(98, 13);
            this.lbl_CodReserva.TabIndex = 3;
            this.lbl_CodReserva.Text = "Código de Reserva";
            // 
            // dgv_Estadia
            // 
            this.dgv_Estadia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Estadia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estadia_Codigo,
            this.Reserva_Codigo,
            this.Estadia_FechaInicio,
            this.Estadia_FechaFin,
            this.Estadia_CantNoches,
            this.Estadia_DiasRest,
            this.Estadia_PreXNoche,
            this.Usuario_ID,
            this.Usuario_OUT,
            this.Habitacion_Numero,
            this.Hotel_Codigo,
            this.Estadia_Estado});
            this.dgv_Estadia.Location = new System.Drawing.Point(34, 69);
            this.dgv_Estadia.Name = "dgv_Estadia";
            this.dgv_Estadia.Size = new System.Drawing.Size(438, 168);
            this.dgv_Estadia.TabIndex = 0;
            // 
            // Estadia_Codigo
            // 
            this.Estadia_Codigo.HeaderText = "Código de Estadía";
            this.Estadia_Codigo.Name = "Estadia_Codigo";
            // 
            // Reserva_Codigo
            // 
            this.Reserva_Codigo.HeaderText = "Código de Reserva";
            this.Reserva_Codigo.Name = "Reserva_Codigo";
            // 
            // Estadia_FechaInicio
            // 
            this.Estadia_FechaInicio.HeaderText = "Fecha de inicio";
            this.Estadia_FechaInicio.Name = "Estadia_FechaInicio";
            // 
            // Estadia_FechaFin
            // 
            this.Estadia_FechaFin.HeaderText = "Fecha de egreso";
            this.Estadia_FechaFin.Name = "Estadia_FechaFin";
            // 
            // Estadia_CantNoches
            // 
            this.Estadia_CantNoches.HeaderText = "Cantidad de noches";
            this.Estadia_CantNoches.Name = "Estadia_CantNoches";
            // 
            // Estadia_DiasRest
            // 
            this.Estadia_DiasRest.HeaderText = "Dias Restantes";
            this.Estadia_DiasRest.Name = "Estadia_DiasRest";
            // 
            // Estadia_PreXNoche
            // 
            this.Estadia_PreXNoche.HeaderText = "Precio por noche";
            this.Estadia_PreXNoche.Name = "Estadia_PreXNoche";
            // 
            // Usuario_ID
            // 
            this.Usuario_ID.HeaderText = "Usuario Check-in";
            this.Usuario_ID.Name = "Usuario_ID";
            // 
            // Usuario_OUT
            // 
            this.Usuario_OUT.HeaderText = "Usuario Check-out";
            this.Usuario_OUT.Name = "Usuario_OUT";
            // 
            // Habitacion_Numero
            // 
            this.Habitacion_Numero.HeaderText = "Número de habitación";
            this.Habitacion_Numero.Name = "Habitacion_Numero";
            // 
            // Hotel_Codigo
            // 
            this.Hotel_Codigo.HeaderText = "Código de hotel";
            this.Hotel_Codigo.Name = "Hotel_Codigo";
            // 
            // Estadia_Estado
            // 
            this.Estadia_Estado.HeaderText = "Estado";
            this.Estadia_Estado.Name = "Estadia_Estado";
            // 
            // txt_Estadia
            // 
            this.txt_Estadia.Location = new System.Drawing.Point(132, 33);
            this.txt_Estadia.Name = "txt_Estadia";
            this.txt_Estadia.Size = new System.Drawing.Size(100, 20);
            this.txt_Estadia.TabIndex = 1;
            // 
            // lbl_Estadia
            // 
            this.lbl_Estadia.AutoSize = true;
            this.lbl_Estadia.Location = new System.Drawing.Point(31, 36);
            this.lbl_Estadia.Name = "lbl_Estadia";
            this.lbl_Estadia.Size = new System.Drawing.Size(95, 13);
            this.lbl_Estadia.TabIndex = 0;
            this.lbl_Estadia.Text = "Código de Estadía";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(488, 187);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click_1);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(488, 216);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 2;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click_1);
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(513, 435);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 25;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // boton_aceptar
            // 
            this.boton_aceptar.Location = new System.Drawing.Point(34, 435);
            this.boton_aceptar.Name = "boton_aceptar";
            this.boton_aceptar.Size = new System.Drawing.Size(75, 23);
            this.boton_aceptar.TabIndex = 26;
            this.boton_aceptar.Text = "Aceptar";
            this.boton_aceptar.UseVisualStyleBackColor = true;
            this.boton_aceptar.Click += new System.EventHandler(this.boton_aceptar_Click_1);
            // 
            // lbl_consumible
            // 
            this.lbl_consumible.AutoSize = true;
            this.lbl_consumible.Location = new System.Drawing.Point(49, 36);
            this.lbl_consumible.Name = "lbl_consumible";
            this.lbl_consumible.Size = new System.Drawing.Size(61, 13);
            this.lbl_consumible.TabIndex = 28;
            this.lbl_consumible.Text = "Consumible";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(266, 36);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_cantidad.TabIndex = 28;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // cb_consumibles
            // 
            this.cb_consumibles.FormattingEnabled = true;
            this.cb_consumibles.Items.AddRange(new object[] {
            "Coca Cola",
            "Whisky",
            "Bonbones",
            "Agua Mineral"});
            this.cb_consumibles.Location = new System.Drawing.Point(116, 33);
            this.cb_consumibles.Name = "cb_consumibles";
            this.cb_consumibles.Size = new System.Drawing.Size(121, 21);
            this.cb_consumibles.TabIndex = 29;
            // 
            // cb_cantidad
            // 
            this.cb_cantidad.FormattingEnabled = true;
            this.cb_cantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cb_cantidad.Location = new System.Drawing.Point(321, 33);
            this.cb_cantidad.Name = "cb_cantidad";
            this.cb_cantidad.Size = new System.Drawing.Size(121, 21);
            this.cb_cantidad.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_consumibles);
            this.groupBox1.Controls.Add(this.cb_cantidad);
            this.groupBox1.Controls.Add(this.lbl_consumible);
            this.groupBox1.Controls.Add(this.lbl_cantidad);
            this.groupBox1.Location = new System.Drawing.Point(25, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 81);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Consumibles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 470);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.boton_aceptar);
            this.Controls.Add(this.gb_DatosEstadia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_DatosEstadia.ResumeLayout(false);
            this.gb_DatosEstadia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estadia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.GroupBox gb_DatosEstadia;
        private System.Windows.Forms.DataGridView dgv_Estadia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadia_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadia_FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadia_FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadia_CantNoches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadia_DiasRest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadia_PreXNoche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_OUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitacion_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadia_Estado;
        private System.Windows.Forms.TextBox txt_Estadia;
        private System.Windows.Forms.Label lbl_Estadia;
        private System.Windows.Forms.TextBox txt_CodReserva;
        private System.Windows.Forms.Label lbl_CodReserva;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Button boton_aceptar;
        private System.Windows.Forms.Label lbl_consumible;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.ComboBox cb_consumibles;
        private System.Windows.Forms.ComboBox cb_cantidad;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}