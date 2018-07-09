namespace FrbaHotel.RegistrarEstadia
{
    partial class RegistrarConsumible
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
            this.boton_volver = new System.Windows.Forms.Button();
            this.boton_aceptar = new System.Windows.Forms.Button();
            this.txt_Estadia = new System.Windows.Forms.TextBox();
            this.lbl_Estadia = new System.Windows.Forms.Label();
            this.txt_CodReserva = new System.Windows.Forms.TextBox();
            this.lbl_CodReserva = new System.Windows.Forms.Label();
            this.gb_DatosEstadia = new System.Windows.Forms.GroupBox();
            this.btn_descontar = new System.Windows.Forms.Button();
            this.dgv_consumibles = new System.Windows.Forms.DataGridView();
            this.Consumible_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumible_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumible_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumible_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gb_DatosEstadia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consumibles)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(527, 324);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 35;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // boton_aceptar
            // 
            this.boton_aceptar.Location = new System.Drawing.Point(18, 324);
            this.boton_aceptar.Name = "boton_aceptar";
            this.boton_aceptar.Size = new System.Drawing.Size(75, 23);
            this.boton_aceptar.TabIndex = 36;
            this.boton_aceptar.Text = "Aceptar";
            this.boton_aceptar.UseVisualStyleBackColor = true;
            this.boton_aceptar.Click += new System.EventHandler(this.boton_aceptar_Click);
            // 
            // txt_Estadia
            // 
            this.txt_Estadia.Location = new System.Drawing.Point(65, 33);
            this.txt_Estadia.Name = "txt_Estadia";
            this.txt_Estadia.Size = new System.Drawing.Size(100, 20);
            this.txt_Estadia.TabIndex = 1;
            // 
            // lbl_Estadia
            // 
            this.lbl_Estadia.AutoSize = true;
            this.lbl_Estadia.Location = new System.Drawing.Point(15, 36);
            this.lbl_Estadia.Name = "lbl_Estadia";
            this.lbl_Estadia.Size = new System.Drawing.Size(44, 13);
            this.lbl_Estadia.TabIndex = 0;
            this.lbl_Estadia.Text = "Estadía";
            // 
            // txt_CodReserva
            // 
            this.txt_CodReserva.Location = new System.Drawing.Point(234, 33);
            this.txt_CodReserva.Name = "txt_CodReserva";
            this.txt_CodReserva.Size = new System.Drawing.Size(100, 20);
            this.txt_CodReserva.TabIndex = 4;
            // 
            // lbl_CodReserva
            // 
            this.lbl_CodReserva.AutoSize = true;
            this.lbl_CodReserva.Location = new System.Drawing.Point(181, 36);
            this.lbl_CodReserva.Name = "lbl_CodReserva";
            this.lbl_CodReserva.Size = new System.Drawing.Size(47, 13);
            this.lbl_CodReserva.TabIndex = 3;
            this.lbl_CodReserva.Text = "Reserva";
            // 
            // gb_DatosEstadia
            // 
            this.gb_DatosEstadia.Controls.Add(this.btn_descontar);
            this.gb_DatosEstadia.Controls.Add(this.dgv_consumibles);
            this.gb_DatosEstadia.Controls.Add(this.btn_agregar);
            this.gb_DatosEstadia.Controls.Add(this.txt_CodReserva);
            this.gb_DatosEstadia.Controls.Add(this.lbl_CodReserva);
            this.gb_DatosEstadia.Controls.Add(this.txt_Estadia);
            this.gb_DatosEstadia.Controls.Add(this.lbl_Estadia);
            this.gb_DatosEstadia.Location = new System.Drawing.Point(18, 55);
            this.gb_DatosEstadia.Name = "gb_DatosEstadia";
            this.gb_DatosEstadia.Size = new System.Drawing.Size(584, 263);
            this.gb_DatosEstadia.TabIndex = 34;
            this.gb_DatosEstadia.TabStop = false;
            // 
            // btn_descontar
            // 
            this.btn_descontar.Location = new System.Drawing.Point(479, 96);
            this.btn_descontar.Name = "btn_descontar";
            this.btn_descontar.Size = new System.Drawing.Size(93, 23);
            this.btn_descontar.TabIndex = 16;
            this.btn_descontar.Text = "Descontar";
            this.btn_descontar.UseVisualStyleBackColor = true;
            this.btn_descontar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // dgv_consumibles
            // 
            this.dgv_consumibles.AllowUserToAddRows = false;
            this.dgv_consumibles.AllowUserToDeleteRows = false;
            this.dgv_consumibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consumibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Consumible_Codigo,
            this.Consumible_Descripcion,
            this.Consumible_Precio,
            this.Consumible_Cantidad});
            this.dgv_consumibles.Location = new System.Drawing.Point(18, 69);
            this.dgv_consumibles.MultiSelect = false;
            this.dgv_consumibles.Name = "dgv_consumibles";
            this.dgv_consumibles.ReadOnly = true;
            this.dgv_consumibles.Size = new System.Drawing.Size(454, 184);
            this.dgv_consumibles.TabIndex = 15;
            this.dgv_consumibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consumibles_CellClick);
            // 
            // Consumible_Codigo
            // 
            this.Consumible_Codigo.HeaderText = "Código Consumible";
            this.Consumible_Codigo.Name = "Consumible_Codigo";
            this.Consumible_Codigo.ReadOnly = true;
            // 
            // Consumible_Descripcion
            // 
            this.Consumible_Descripcion.HeaderText = "Descripción";
            this.Consumible_Descripcion.Name = "Consumible_Descripcion";
            this.Consumible_Descripcion.ReadOnly = true;
            // 
            // Consumible_Precio
            // 
            this.Consumible_Precio.HeaderText = "Precio";
            this.Consumible_Precio.Name = "Consumible_Precio";
            this.Consumible_Precio.ReadOnly = true;
            // 
            // Consumible_Cantidad
            // 
            this.Consumible_Cantidad.HeaderText = "Cantidad";
            this.Consumible_Cantidad.Name = "Consumible_Cantidad";
            this.Consumible_Cantidad.ReadOnly = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(478, 69);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(94, 23);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(5, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "FOUR SIZONS";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Calibri", 15F);
            this.lbl_Titulo.Location = new System.Drawing.Point(234, 19);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(196, 24);
            this.lbl_Titulo.TabIndex = 31;
            this.lbl_Titulo.Text = "Registrar Consumibles";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8F);
            this.label8.Location = new System.Drawing.Point(15, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "FRBA Hoteles";
            // 
            // RegistrarConsumible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 356);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.boton_aceptar);
            this.Controls.Add(this.gb_DatosEstadia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.label8);
            this.Name = "RegistrarConsumible";
            this.Text = "RegistrarConsumible";
            this.Load += new System.EventHandler(this.RegistrarConsumible_Load);
            this.gb_DatosEstadia.ResumeLayout(false);
            this.gb_DatosEstadia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consumibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Button boton_aceptar;
        private System.Windows.Forms.TextBox txt_Estadia;
        private System.Windows.Forms.Label lbl_Estadia;
        private System.Windows.Forms.TextBox txt_CodReserva;
        private System.Windows.Forms.Label lbl_CodReserva;
        private System.Windows.Forms.GroupBox gb_DatosEstadia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgv_consumibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumible_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumible_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumible_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumible_Cantidad;
        private System.Windows.Forms.Button btn_descontar;
    }
}