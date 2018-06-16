namespace FrbaHotel.ABMHabitacion
{
    partial class ABMHabitacion01
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.boton_modificacion = new System.Windows.Forms.Button();
            this.boton_baja = new System.Windows.Forms.Button();
            this.boton_alta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_promptUsu = new System.Windows.Forms.Button();
            this.cb_tipoFrente = new System.Windows.Forms.ComboBox();
            this.cb_tipohab = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_nro_hab = new System.Windows.Forms.TextBox();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.txt_nombre_hotel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Habitaciones = new System.Windows.Forms.DataGridView();
            this.Hotel_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotel_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitacion_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitacion_piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitacion_tipo_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitacion_frente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitacion_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Habitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(573, 362);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(89, 23);
            this.btn_volver.TabIndex = 20;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8F);
            this.label8.Location = new System.Drawing.Point(26, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "FRBA Hoteles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(16, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "FOUR SIZONS";
            // 
            // boton_modificacion
            // 
            this.boton_modificacion.Location = new System.Drawing.Point(573, 199);
            this.boton_modificacion.Name = "boton_modificacion";
            this.boton_modificacion.Size = new System.Drawing.Size(89, 23);
            this.boton_modificacion.TabIndex = 19;
            this.boton_modificacion.Text = "Modificación";
            this.boton_modificacion.UseVisualStyleBackColor = true;
            this.boton_modificacion.Click += new System.EventHandler(this.boton_modificacion_Click);
            // 
            // boton_baja
            // 
            this.boton_baja.Location = new System.Drawing.Point(573, 170);
            this.boton_baja.Name = "boton_baja";
            this.boton_baja.Size = new System.Drawing.Size(89, 23);
            this.boton_baja.TabIndex = 18;
            this.boton_baja.Text = "Baja";
            this.boton_baja.UseVisualStyleBackColor = true;
            this.boton_baja.Click += new System.EventHandler(this.boton_baja_Click);
            // 
            // boton_alta
            // 
            this.boton_alta.Location = new System.Drawing.Point(573, 141);
            this.boton_alta.Name = "boton_alta";
            this.boton_alta.Size = new System.Drawing.Size(89, 23);
            this.boton_alta.TabIndex = 17;
            this.boton_alta.Text = "Alta";
            this.boton_alta.UseVisualStyleBackColor = true;
            this.boton_alta.Click += new System.EventHandler(this.boton_alta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_promptUsu);
            this.groupBox1.Controls.Add(this.cb_tipoFrente);
            this.groupBox1.Controls.Add(this.cb_tipohab);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_nro_hab);
            this.groupBox1.Controls.Add(this.txt_piso);
            this.groupBox1.Controls.Add(this.txt_nombre_hotel);
            this.groupBox1.Location = new System.Drawing.Point(29, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 87);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // btn_promptUsu
            // 
            this.btn_promptUsu.Location = new System.Drawing.Point(211, 17);
            this.btn_promptUsu.Name = "btn_promptUsu";
            this.btn_promptUsu.Size = new System.Drawing.Size(26, 23);
            this.btn_promptUsu.TabIndex = 36;
            this.btn_promptUsu.Text = "...";
            this.btn_promptUsu.UseVisualStyleBackColor = true;
            // 
            // cb_tipoFrente
            // 
            this.cb_tipoFrente.FormattingEnabled = true;
            this.cb_tipoFrente.Location = new System.Drawing.Point(198, 48);
            this.cb_tipoFrente.Name = "cb_tipoFrente";
            this.cb_tipoFrente.Size = new System.Drawing.Size(78, 21);
            this.cb_tipoFrente.TabIndex = 3;
            // 
            // cb_tipohab
            // 
            this.cb_tipohab.FormattingEnabled = true;
            this.cb_tipohab.Location = new System.Drawing.Point(60, 48);
            this.cb_tipohab.Name = "cb_tipohab";
            this.cb_tipohab.Size = new System.Drawing.Size(78, 21);
            this.cb_tipohab.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nro. Hab.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Piso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Frente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Hab.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hotel";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(544, 46);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(89, 23);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(544, 16);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(89, 23);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_nro_hab
            // 
            this.txt_nro_hab.Location = new System.Drawing.Point(407, 20);
            this.txt_nro_hab.Name = "txt_nro_hab";
            this.txt_nro_hab.Size = new System.Drawing.Size(60, 20);
            this.txt_nro_hab.TabIndex = 2;
            this.txt_nro_hab.TextChanged += new System.EventHandler(this.txt_apellido_TextChanged);
            // 
            // txt_piso
            // 
            this.txt_piso.Location = new System.Drawing.Point(282, 19);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(60, 20);
            this.txt_piso.TabIndex = 2;
            this.txt_piso.TextChanged += new System.EventHandler(this.txt_apellido_TextChanged);
            // 
            // txt_nombre_hotel
            // 
            this.txt_nombre_hotel.Location = new System.Drawing.Point(60, 19);
            this.txt_nombre_hotel.Name = "txt_nombre_hotel";
            this.txt_nombre_hotel.Size = new System.Drawing.Size(145, 20);
            this.txt_nombre_hotel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Habitaciones";
            // 
            // dgv_Habitaciones
            // 
            this.dgv_Habitaciones.AllowUserToAddRows = false;
            this.dgv_Habitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Habitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hotel_Nombre,
            this.hotel_codigo,
            this.habitacion_codigo,
            this.habitacion_piso,
            this.habitacion_tipo_codigo,
            this.habitacion_frente,
            this.habitacion_estado});
            this.dgv_Habitaciones.Location = new System.Drawing.Point(29, 141);
            this.dgv_Habitaciones.Name = "dgv_Habitaciones";
            this.dgv_Habitaciones.Size = new System.Drawing.Size(519, 244);
            this.dgv_Habitaciones.TabIndex = 14;
            this.dgv_Habitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Habitaciones_CellClick);
            // 
            // Hotel_Nombre
            // 
            this.Hotel_Nombre.HeaderText = "Hotel";
            this.Hotel_Nombre.Name = "Hotel_Nombre";
            this.Hotel_Nombre.ReadOnly = true;
            // 
            // hotel_codigo
            // 
            this.hotel_codigo.HeaderText = "Hotel Código";
            this.hotel_codigo.Name = "hotel_codigo";
            // 
            // habitacion_codigo
            // 
            this.habitacion_codigo.HeaderText = "Nro de Habitación";
            this.habitacion_codigo.Name = "habitacion_codigo";
            // 
            // habitacion_piso
            // 
            this.habitacion_piso.HeaderText = "Piso";
            this.habitacion_piso.Name = "habitacion_piso";
            // 
            // habitacion_tipo_codigo
            // 
            this.habitacion_tipo_codigo.HeaderText = "Tipo de Habitación";
            this.habitacion_tipo_codigo.Name = "habitacion_tipo_codigo";
            // 
            // habitacion_frente
            // 
            this.habitacion_frente.HeaderText = "Frente";
            this.habitacion_frente.Name = "habitacion_frente";
            // 
            // habitacion_estado
            // 
            this.habitacion_estado.HeaderText = "Estado";
            this.habitacion_estado.Name = "habitacion_estado";
            // 
            // ABMHabitacion01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 397);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boton_modificacion);
            this.Controls.Add(this.boton_baja);
            this.Controls.Add(this.boton_alta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Habitaciones);
            this.Name = "ABMHabitacion01";
            this.Text = "ABMHotel01";
            this.Load += new System.EventHandler(this.ABMHabitacion01_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Habitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button boton_modificacion;
        private System.Windows.Forms.Button boton_baja;
        private System.Windows.Forms.Button boton_alta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_tipohab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.TextBox txt_nombre_hotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Habitaciones;
        private System.Windows.Forms.ComboBox cb_tipoFrente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nro_hab;
        private System.Windows.Forms.Button btn_promptUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotel_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitacion_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitacion_piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitacion_tipo_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitacion_frente;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitacion_estado;
    }
}