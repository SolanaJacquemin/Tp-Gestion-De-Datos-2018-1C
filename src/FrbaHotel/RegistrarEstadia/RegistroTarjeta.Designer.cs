namespace FrbaHotel.RegistrarEstadia
{
    partial class RegistroTarjeta
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.dgv_tarjetas = new System.Windows.Forms.DataGridView();
            this.tarjeta_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeta_Titular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeta_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeta_Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.lbl_Estadia = new System.Windows.Forms.Label();
            this.boton_volver = new System.Windows.Forms.Button();
            this.gb_DatosEstadia = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tarjetas)).BeginInit();
            this.gb_DatosEstadia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(4, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "FOUR SIZONS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8F);
            this.label8.Location = new System.Drawing.Point(14, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "FRBA Hoteles";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Calibri", 15F);
            this.lbl_Titulo.Location = new System.Drawing.Point(286, 17);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(75, 24);
            this.lbl_Titulo.TabIndex = 37;
            this.lbl_Titulo.Text = "Tarjetas";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(479, 68);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(93, 23);
            this.btn_eliminar.TabIndex = 16;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // dgv_tarjetas
            // 
            this.dgv_tarjetas.AllowUserToAddRows = false;
            this.dgv_tarjetas.AllowUserToDeleteRows = false;
            this.dgv_tarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tarjeta_numero,
            this.Tarjeta_Titular,
            this.Tarjeta_Marca,
            this.Tarjeta_Vencimiento});
            this.dgv_tarjetas.Location = new System.Drawing.Point(18, 39);
            this.dgv_tarjetas.MultiSelect = false;
            this.dgv_tarjetas.Name = "dgv_tarjetas";
            this.dgv_tarjetas.ReadOnly = true;
            this.dgv_tarjetas.Size = new System.Drawing.Size(454, 184);
            this.dgv_tarjetas.TabIndex = 15;
            this.dgv_tarjetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tarjetas_CellClick);
            // 
            // tarjeta_numero
            // 
            this.tarjeta_numero.HeaderText = "Tarjeta Número";
            this.tarjeta_numero.Name = "tarjeta_numero";
            this.tarjeta_numero.ReadOnly = true;
            // 
            // Tarjeta_Titular
            // 
            this.Tarjeta_Titular.HeaderText = "Titular";
            this.Tarjeta_Titular.Name = "Tarjeta_Titular";
            this.Tarjeta_Titular.ReadOnly = true;
            // 
            // Tarjeta_Marca
            // 
            this.Tarjeta_Marca.HeaderText = "Marca";
            this.Tarjeta_Marca.Name = "Tarjeta_Marca";
            this.Tarjeta_Marca.ReadOnly = true;
            // 
            // Tarjeta_Vencimiento
            // 
            this.Tarjeta_Vencimiento.HeaderText = "Vencimiento";
            this.Tarjeta_Vencimiento.Name = "Tarjeta_Vencimiento";
            this.Tarjeta_Vencimiento.ReadOnly = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(478, 39);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(94, 23);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(65, 13);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(217, 20);
            this.txt_cliente.TabIndex = 1;
            // 
            // lbl_Estadia
            // 
            this.lbl_Estadia.AutoSize = true;
            this.lbl_Estadia.Location = new System.Drawing.Point(15, 16);
            this.lbl_Estadia.Name = "lbl_Estadia";
            this.lbl_Estadia.Size = new System.Drawing.Size(39, 13);
            this.lbl_Estadia.TabIndex = 0;
            this.lbl_Estadia.Text = "Cliente";
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(526, 295);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 41;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // gb_DatosEstadia
            // 
            this.gb_DatosEstadia.Controls.Add(this.btn_eliminar);
            this.gb_DatosEstadia.Controls.Add(this.dgv_tarjetas);
            this.gb_DatosEstadia.Controls.Add(this.btn_agregar);
            this.gb_DatosEstadia.Controls.Add(this.txt_cliente);
            this.gb_DatosEstadia.Controls.Add(this.lbl_Estadia);
            this.gb_DatosEstadia.Location = new System.Drawing.Point(17, 55);
            this.gb_DatosEstadia.Name = "gb_DatosEstadia";
            this.gb_DatosEstadia.Size = new System.Drawing.Size(584, 234);
            this.gb_DatosEstadia.TabIndex = 40;
            this.gb_DatosEstadia.TabStop = false;
            // 
            // RegistroTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 324);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.gb_DatosEstadia);
            this.Name = "RegistroTarjeta";
            this.Text = "RegistroTarjeta";
            this.Load += new System.EventHandler(this.RegistroTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tarjetas)).EndInit();
            this.gb_DatosEstadia.ResumeLayout(false);
            this.gb_DatosEstadia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridView dgv_tarjetas;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label lbl_Estadia;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.GroupBox gb_DatosEstadia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjeta_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta_Titular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta_Vencimiento;

    }
}