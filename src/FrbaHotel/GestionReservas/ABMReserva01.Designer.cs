namespace FrbaHotel.GestionReservas
{
    partial class ABMReserva01
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
            this.boton_modificar = new System.Windows.Forms.Button();
            this.boton_cancelar = new System.Windows.Forms.Button();
            this.boton_generar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_conFecha = new System.Windows.Forms.CheckBox();
            this.dt_fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dt_fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.l_hasta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_desde = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_reservaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Reservas = new System.Windows.Forms.DataGridView();
            this.Reserva_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserva_Fecha_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserva_Fecha_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserva_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Nombre_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserva_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(569, 371);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(89, 23);
            this.btn_volver.TabIndex = 9;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8F);
            this.label8.Location = new System.Drawing.Point(22, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "FRBA Hoteles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "FOUR SIZONS";
            // 
            // boton_modificar
            // 
            this.boton_modificar.Location = new System.Drawing.Point(569, 179);
            this.boton_modificar.Name = "boton_modificar";
            this.boton_modificar.Size = new System.Drawing.Size(89, 23);
            this.boton_modificar.TabIndex = 7;
            this.boton_modificar.Text = "Modificar";
            this.boton_modificar.UseVisualStyleBackColor = true;
            this.boton_modificar.Click += new System.EventHandler(this.boton_modificar_Click);
            // 
            // boton_cancelar
            // 
            this.boton_cancelar.Location = new System.Drawing.Point(569, 208);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.Size = new System.Drawing.Size(89, 23);
            this.boton_cancelar.TabIndex = 8;
            this.boton_cancelar.Text = "Cancelar";
            this.boton_cancelar.UseVisualStyleBackColor = true;
            this.boton_cancelar.Click += new System.EventHandler(this.boton_cancelar_Click);
            // 
            // boton_generar
            // 
            this.boton_generar.Location = new System.Drawing.Point(569, 150);
            this.boton_generar.Name = "boton_generar";
            this.boton_generar.Size = new System.Drawing.Size(89, 23);
            this.boton_generar.TabIndex = 6;
            this.boton_generar.Text = "Generar";
            this.boton_generar.UseVisualStyleBackColor = true;
            this.boton_generar.Click += new System.EventHandler(this.boton_generar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_conFecha);
            this.groupBox1.Controls.Add(this.dt_fechaHasta);
            this.groupBox1.Controls.Add(this.dt_fechaDesde);
            this.groupBox1.Controls.Add(this.l_hasta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.l_desde);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_reservaId);
            this.groupBox1.Location = new System.Drawing.Point(25, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 76);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // chk_conFecha
            // 
            this.chk_conFecha.AutoSize = true;
            this.chk_conFecha.Location = new System.Drawing.Point(204, 11);
            this.chk_conFecha.Name = "chk_conFecha";
            this.chk_conFecha.Size = new System.Drawing.Size(110, 17);
            this.chk_conFecha.TabIndex = 1;
            this.chk_conFecha.Text = "Buscar con fecha";
            this.chk_conFecha.UseVisualStyleBackColor = true;
            // 
            // dt_fechaHasta
            // 
            this.dt_fechaHasta.Location = new System.Drawing.Point(405, 34);
            this.dt_fechaHasta.Name = "dt_fechaHasta";
            this.dt_fechaHasta.Size = new System.Drawing.Size(94, 20);
            this.dt_fechaHasta.TabIndex = 3;
            // 
            // dt_fechaDesde
            // 
            this.dt_fechaDesde.Location = new System.Drawing.Point(245, 34);
            this.dt_fechaDesde.Name = "dt_fechaDesde";
            this.dt_fechaDesde.Size = new System.Drawing.Size(94, 20);
            this.dt_fechaDesde.TabIndex = 2;
            // 
            // l_hasta
            // 
            this.l_hasta.AutoSize = true;
            this.l_hasta.Location = new System.Drawing.Point(364, 37);
            this.l_hasta.Name = "l_hasta";
            this.l_hasta.Size = new System.Drawing.Size(35, 13);
            this.l_hasta.TabIndex = 2;
            this.l_hasta.Text = "Hasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Reserva Id";
            // 
            // l_desde
            // 
            this.l_desde.AutoSize = true;
            this.l_desde.Location = new System.Drawing.Point(201, 38);
            this.l_desde.Name = "l_desde";
            this.l_desde.Size = new System.Drawing.Size(38, 13);
            this.l_desde.TabIndex = 2;
            this.l_desde.Text = "Desde";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(544, 44);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(89, 23);
            this.btn_limpiar.TabIndex = 5;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(544, 15);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(89, 23);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_reservaId
            // 
            this.txt_reservaId.Location = new System.Drawing.Point(102, 34);
            this.txt_reservaId.Name = "txt_reservaId";
            this.txt_reservaId.Size = new System.Drawing.Size(64, 20);
            this.txt_reservaId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.Location = new System.Drawing.Point(246, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gestión de Reservas";
            // 
            // dgv_Reservas
            // 
            this.dgv_Reservas.AllowUserToAddRows = false;
            this.dgv_Reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reserva_Codigo,
            this.Reserva_Fecha_Inicio,
            this.Reserva_Fecha_Fin,
            this.Reserva_Precio,
            this.Hotel_Nombre,
            this.Cliente_Nombre_Apellido,
            this.Reserva_Estado});
            this.dgv_Reservas.Location = new System.Drawing.Point(25, 150);
            this.dgv_Reservas.Name = "dgv_Reservas";
            this.dgv_Reservas.Size = new System.Drawing.Size(519, 244);
            this.dgv_Reservas.TabIndex = 14;
            this.dgv_Reservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Reservas_CellClick);
            // 
            // Reserva_Codigo
            // 
            this.Reserva_Codigo.HeaderText = "Reserva Código";
            this.Reserva_Codigo.Name = "Reserva_Codigo";
            this.Reserva_Codigo.ReadOnly = true;
            // 
            // Reserva_Fecha_Inicio
            // 
            this.Reserva_Fecha_Inicio.HeaderText = "Fecha Desde";
            this.Reserva_Fecha_Inicio.Name = "Reserva_Fecha_Inicio";
            this.Reserva_Fecha_Inicio.ReadOnly = true;
            // 
            // Reserva_Fecha_Fin
            // 
            this.Reserva_Fecha_Fin.HeaderText = "Fecha Hasta";
            this.Reserva_Fecha_Fin.Name = "Reserva_Fecha_Fin";
            this.Reserva_Fecha_Fin.ReadOnly = true;
            // 
            // Reserva_Precio
            // 
            this.Reserva_Precio.HeaderText = "Precio";
            this.Reserva_Precio.Name = "Reserva_Precio";
            this.Reserva_Precio.ReadOnly = true;
            // 
            // Hotel_Nombre
            // 
            this.Hotel_Nombre.HeaderText = "Hotel";
            this.Hotel_Nombre.Name = "Hotel_Nombre";
            this.Hotel_Nombre.ReadOnly = true;
            // 
            // Cliente_Nombre_Apellido
            // 
            this.Cliente_Nombre_Apellido.HeaderText = "Nombre y Apellido";
            this.Cliente_Nombre_Apellido.Name = "Cliente_Nombre_Apellido";
            this.Cliente_Nombre_Apellido.ReadOnly = true;
            // 
            // Reserva_Estado
            // 
            this.Reserva_Estado.HeaderText = "Estado";
            this.Reserva_Estado.Name = "Reserva_Estado";
            this.Reserva_Estado.ReadOnly = true;
            // 
            // ABMReserva01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 408);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boton_modificar);
            this.Controls.Add(this.boton_cancelar);
            this.Controls.Add(this.boton_generar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Reservas);
            this.Name = "ABMReserva01";
            this.Text = "ABMReserva01";
            this.Load += new System.EventHandler(this.ABMReserva01_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button boton_modificar;
        private System.Windows.Forms.Button boton_cancelar;
        private System.Windows.Forms.Button boton_generar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_hasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_desde;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_reservaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Reservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva_Fecha_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva_Fecha_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Nombre_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva_Estado;
        private System.Windows.Forms.DateTimePicker dt_fechaHasta;
        private System.Windows.Forms.DateTimePicker dt_fechaDesde;
        private System.Windows.Forms.CheckBox chk_conFecha;
    }
}