namespace FrbaHotel.ABMHotel
{
    partial class ABMHotel01
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_promptUsu = new System.Windows.Forms.Button();
            this.cb_estrellas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Hoteles = new System.Windows.Forms.DataGridView();
            this.Hotel_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Nro_Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_CantEstrella = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Recarga_Estrella = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(569, 431);
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
            // boton_modificacion
            // 
            this.boton_modificacion.Location = new System.Drawing.Point(569, 268);
            this.boton_modificacion.Name = "boton_modificacion";
            this.boton_modificacion.Size = new System.Drawing.Size(89, 23);
            this.boton_modificacion.TabIndex = 19;
            this.boton_modificacion.Text = "Modificación";
            this.boton_modificacion.UseVisualStyleBackColor = true;
            this.boton_modificacion.Click += new System.EventHandler(this.boton_modificacion_Click);
            // 
            // boton_baja
            // 
            this.boton_baja.Location = new System.Drawing.Point(569, 239);
            this.boton_baja.Name = "boton_baja";
            this.boton_baja.Size = new System.Drawing.Size(89, 23);
            this.boton_baja.TabIndex = 18;
            this.boton_baja.Text = "Baja";
            this.boton_baja.UseVisualStyleBackColor = true;
            this.boton_baja.Click += new System.EventHandler(this.boton_baja_Click);
            // 
            // boton_alta
            // 
            this.boton_alta.Location = new System.Drawing.Point(569, 210);
            this.boton_alta.Name = "boton_alta";
            this.boton_alta.Size = new System.Drawing.Size(89, 23);
            this.boton_alta.TabIndex = 17;
            this.boton_alta.Text = "Alta";
            this.boton_alta.UseVisualStyleBackColor = true;
            this.boton_alta.Click += new System.EventHandler(this.boton_alta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_promptUsu);
            this.groupBox1.Controls.Add(this.cb_estrellas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_calle);
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Controls.Add(this.txt_pais);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.txt_ciudad);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Location = new System.Drawing.Point(25, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 138);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_promptUsu
            // 
            this.btn_promptUsu.Location = new System.Drawing.Point(173, 16);
            this.btn_promptUsu.Name = "btn_promptUsu";
            this.btn_promptUsu.Size = new System.Drawing.Size(26, 23);
            this.btn_promptUsu.TabIndex = 0;
            this.btn_promptUsu.Text = "...";
            this.btn_promptUsu.UseVisualStyleBackColor = true;
            // 
            // cb_estrellas
            // 
            this.cb_estrellas.FormattingEnabled = true;
            this.cb_estrellas.Location = new System.Drawing.Point(296, 78);
            this.cb_estrellas.Name = "cb_estrellas";
            this.cb_estrellas.Size = new System.Drawing.Size(78, 21);
            this.cb_estrellas.TabIndex = 3;
            this.cb_estrellas.SelectedIndexChanged += new System.EventHandler(this.cb_estrellas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Teléfono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Calle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "País";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Estrellas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(544, 51);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(89, 23);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(544, 22);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(89, 23);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(60, 74);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(139, 20);
            this.txt_calle.TabIndex = 5;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(60, 45);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(139, 20);
            this.txt_mail.TabIndex = 5;
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(296, 105);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(191, 20);
            this.txt_pais.TabIndex = 4;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(296, 48);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(191, 20);
            this.txt_telefono.TabIndex = 2;
            this.txt_telefono.TextChanged += new System.EventHandler(this.txt_telefono_TextChanged);
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(60, 102);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(139, 20);
            this.txt_ciudad.TabIndex = 0;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(60, 19);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(107, 20);
            this.txt_codigo.TabIndex = 0;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(296, 18);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(191, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.Location = new System.Drawing.Point(286, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hoteles";
            // 
            // dgv_Hoteles
            // 
            this.dgv_Hoteles.AllowUserToAddRows = false;
            this.dgv_Hoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hoteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hotel_Codigo,
            this.Hotel_Nombre,
            this.Hotel_Mail,
            this.Hotel_Telefono,
            this.Hotel_Calle,
            this.Hotel_Nro_Calle,
            this.Hotel_CantEstrella,
            this.Hotel_Recarga_Estrella,
            this.Hotel_Ciudad,
            this.Hotel_Pais,
            this.Hotel_FechaCreacion,
            this.Hotel_Estado});
            this.dgv_Hoteles.Location = new System.Drawing.Point(25, 210);
            this.dgv_Hoteles.Name = "dgv_Hoteles";
            this.dgv_Hoteles.ReadOnly = true;
            this.dgv_Hoteles.Size = new System.Drawing.Size(519, 244);
            this.dgv_Hoteles.TabIndex = 14;
            this.dgv_Hoteles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hoteles_CellClick);
            // 
            // Hotel_Codigo
            // 
            this.Hotel_Codigo.HeaderText = "Codigo";
            this.Hotel_Codigo.Name = "Hotel_Codigo";
            // 
            // Hotel_Nombre
            // 
            this.Hotel_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Hotel_Nombre.HeaderText = "Nombre";
            this.Hotel_Nombre.Name = "Hotel_Nombre";
            this.Hotel_Nombre.Width = 5;
            // 
            // Hotel_Mail
            // 
            this.Hotel_Mail.HeaderText = "Mail";
            this.Hotel_Mail.Name = "Hotel_Mail";
            // 
            // Hotel_Telefono
            // 
            this.Hotel_Telefono.HeaderText = "Telefono";
            this.Hotel_Telefono.Name = "Hotel_Telefono";
            // 
            // Hotel_Calle
            // 
            this.Hotel_Calle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Hotel_Calle.HeaderText = "Calle";
            this.Hotel_Calle.Name = "Hotel_Calle";
            this.Hotel_Calle.Width = 5;
            // 
            // Hotel_Nro_Calle
            // 
            this.Hotel_Nro_Calle.HeaderText = "Nro. Calle";
            this.Hotel_Nro_Calle.Name = "Hotel_Nro_Calle";
            // 
            // Hotel_CantEstrella
            // 
            this.Hotel_CantEstrella.HeaderText = "Cantidad Estrellas";
            this.Hotel_CantEstrella.Name = "Hotel_CantEstrella";
            // 
            // Hotel_Recarga_Estrella
            // 
            this.Hotel_Recarga_Estrella.HeaderText = "Recarga Estrella";
            this.Hotel_Recarga_Estrella.Name = "Hotel_Recarga_Estrella";
            // 
            // Hotel_Ciudad
            // 
            this.Hotel_Ciudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Hotel_Ciudad.HeaderText = "Ciudad";
            this.Hotel_Ciudad.Name = "Hotel_Ciudad";
            this.Hotel_Ciudad.Width = 5;
            // 
            // Hotel_Pais
            // 
            this.Hotel_Pais.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Hotel_Pais.HeaderText = "País";
            this.Hotel_Pais.Name = "Hotel_Pais";
            this.Hotel_Pais.Width = 5;
            // 
            // Hotel_FechaCreacion
            // 
            this.Hotel_FechaCreacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Hotel_FechaCreacion.HeaderText = "Fecha de Creación";
            this.Hotel_FechaCreacion.Name = "Hotel_FechaCreacion";
            this.Hotel_FechaCreacion.Width = 5;
            // 
            // Hotel_Estado
            // 
            this.Hotel_Estado.HeaderText = "Estado";
            this.Hotel_Estado.Name = "Hotel_Estado";
            // 
            // ABMHotel01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 466);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boton_modificacion);
            this.Controls.Add(this.boton_baja);
            this.Controls.Add(this.boton_alta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Hoteles);
            this.Name = "ABMHotel01";
            this.Text = "ABMHotel01";
            this.Load += new System.EventHandler(this.ABMHotel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoteles)).EndInit();
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
        private System.Windows.Forms.Button btn_promptUsu;
        private System.Windows.Forms.ComboBox cb_estrellas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Hoteles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Nro_Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_CantEstrella;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Recarga_Estrella;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Estado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_calle;
    }
}