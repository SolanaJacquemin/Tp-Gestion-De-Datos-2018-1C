namespace FrbaHotel.RegistrarEstadia
{
    partial class GestionEstadias
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_CodReserva = new System.Windows.Forms.TextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_codReserva = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.dgv_Reserva = new System.Windows.Forms.DataGridView();
            this.Reserva_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserva_Fecha_Creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserva_Fecha_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserva_Fecha_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserva_Cant_Noches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserva_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regimen_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserva_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_consumibles = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reserva)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8F);
            this.label8.Location = new System.Drawing.Point(32, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "FRBA Hoteles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(22, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "FOUR SIZONS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.Location = new System.Drawing.Point(208, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gestión de Estadías";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_CodReserva);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.lbl_codReserva);
            this.groupBox1.Location = new System.Drawing.Point(26, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 116);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // txt_CodReserva
            // 
            this.txt_CodReserva.Location = new System.Drawing.Point(161, 28);
            this.txt_CodReserva.Name = "txt_CodReserva";
            this.txt_CodReserva.Size = new System.Drawing.Size(100, 20);
            this.txt_CodReserva.TabIndex = 1;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(161, 71);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 13;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(63, 71);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_codReserva
            // 
            this.lbl_codReserva.AutoSize = true;
            this.lbl_codReserva.Location = new System.Drawing.Point(40, 31);
            this.lbl_codReserva.Name = "lbl_codReserva";
            this.lbl_codReserva.Size = new System.Drawing.Size(98, 13);
            this.lbl_codReserva.TabIndex = 0;
            this.lbl_codReserva.Text = "Código de Reserva";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(385, 131);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(125, 23);
            this.btn_Cerrar.TabIndex = 13;
            this.btn_Cerrar.Text = "Realizar Check-Out";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(482, 391);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 13;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Location = new System.Drawing.Point(385, 102);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(125, 23);
            this.btn_Abrir.TabIndex = 13;
            this.btn_Abrir.Text = "Realizar Check-In";
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // dgv_Reserva
            // 
            this.dgv_Reserva.AllowUserToAddRows = false;
            this.dgv_Reserva.AllowUserToDeleteRows = false;
            this.dgv_Reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reserva_Codigo,
            this.Reserva_Fecha_Creacion,
            this.Reserva_Fecha_Inicio,
            this.Reserva_Fecha_Fin,
            this.Reserva_Cant_Noches,
            this.Reserva_Precio,
            this.Usuario_ID,
            this.Hotel_Codigo,
            this.Cliente_Codigo,
            this.Regimen_Codigo,
            this.Reserva_Estado});
            this.dgv_Reserva.Location = new System.Drawing.Point(26, 224);
            this.dgv_Reserva.Name = "dgv_Reserva";
            this.dgv_Reserva.Size = new System.Drawing.Size(531, 150);
            this.dgv_Reserva.TabIndex = 14;
            this.dgv_Reserva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Reserva_CellClick);
            // 
            // Reserva_Codigo
            // 
            this.Reserva_Codigo.HeaderText = "Código de reserva";
            this.Reserva_Codigo.Name = "Reserva_Codigo";
            // 
            // Reserva_Fecha_Creacion
            // 
            this.Reserva_Fecha_Creacion.HeaderText = "Fecha de Creación";
            this.Reserva_Fecha_Creacion.Name = "Reserva_Fecha_Creacion";
            // 
            // Reserva_Fecha_Inicio
            // 
            this.Reserva_Fecha_Inicio.HeaderText = "Fecha Inicio";
            this.Reserva_Fecha_Inicio.Name = "Reserva_Fecha_Inicio";
            // 
            // Reserva_Fecha_Fin
            // 
            this.Reserva_Fecha_Fin.HeaderText = "Fecha Fin";
            this.Reserva_Fecha_Fin.Name = "Reserva_Fecha_Fin";
            // 
            // Reserva_Cant_Noches
            // 
            this.Reserva_Cant_Noches.HeaderText = "Cant. de noches";
            this.Reserva_Cant_Noches.Name = "Reserva_Cant_Noches";
            // 
            // Reserva_Precio
            // 
            this.Reserva_Precio.HeaderText = "Precio";
            this.Reserva_Precio.Name = "Reserva_Precio";
            // 
            // Usuario_ID
            // 
            this.Usuario_ID.HeaderText = "Usuario";
            this.Usuario_ID.Name = "Usuario_ID";
            // 
            // Hotel_Codigo
            // 
            this.Hotel_Codigo.HeaderText = "Hotel";
            this.Hotel_Codigo.Name = "Hotel_Codigo";
            // 
            // Cliente_Codigo
            // 
            this.Cliente_Codigo.HeaderText = "Código de Cliente";
            this.Cliente_Codigo.Name = "Cliente_Codigo";
            // 
            // Regimen_Codigo
            // 
            this.Regimen_Codigo.HeaderText = "Código de Régimen";
            this.Regimen_Codigo.Name = "Regimen_Codigo";
            // 
            // Reserva_Estado
            // 
            this.Reserva_Estado.HeaderText = "Estado";
            this.Reserva_Estado.Name = "Reserva_Estado";
            // 
            // btn_consumibles
            // 
            this.btn_consumibles.Location = new System.Drawing.Point(385, 160);
            this.btn_consumibles.Name = "btn_consumibles";
            this.btn_consumibles.Size = new System.Drawing.Size(125, 23);
            this.btn_consumibles.TabIndex = 13;
            this.btn_consumibles.Text = "Registrar Consumible";
            this.btn_consumibles.UseVisualStyleBackColor = true;
            this.btn_consumibles.Click += new System.EventHandler(this.btn_consumibles_Click);
            // 
            // GestionEstadias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 426);
            this.Controls.Add(this.dgv_Reserva);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_consumibles);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Abrir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "GestionEstadias";
            this.Text = "GestionEstadias";
            this.Load += new System.EventHandler(this.GestionEstadia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.DataGridView dgv_Reserva;
        private System.Windows.Forms.TextBox txt_CodReserva;
        private System.Windows.Forms.Label lbl_codReserva;
        private System.Windows.Forms.Button btn_consumibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva_Fecha_Creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva_Fecha_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva_Fecha_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva_Cant_Noches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regimen_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva_Estado;
    }
}