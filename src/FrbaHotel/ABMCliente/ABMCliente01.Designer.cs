namespace FrbaHotel.AbmCliente
{
    partial class ABMCliente01
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
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.Cliente_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_NumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Dom_Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Nro_calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Fecha_Nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Consistente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_volver_Click = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_tipo_doc = new System.Windows.Forms.ComboBox();
            this.txt_nro_doc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_alta = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_buscar_Click = new System.Windows.Forms.Button();
            this.btn_limpiar_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
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
            this.label8.TabIndex = 18;
            this.label8.Text = "FRBA Hoteles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "FOUR SIZONS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.Location = new System.Drawing.Point(305, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Clientes";
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente_Codigo,
            this.Cliente_Nombre,
            this.Cliente_Apellido,
            this.Cliente_TipoDoc,
            this.Cliente_NumDoc,
            this.Cliente_Dom_Calle,
            this.Cliente_Nro_calle,
            this.Cliente_Piso,
            this.Cliente_Depto,
            this.Cliente_Mail,
            this.Cliente_Nacionalidad,
            this.Cliente_Fecha_Nac,
            this.Cliente_Puntos,
            this.Cliente_Estado,
            this.Cliente_Consistente});
            this.dgv_Clientes.Location = new System.Drawing.Point(25, 258);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.Size = new System.Drawing.Size(516, 141);
            this.dgv_Clientes.TabIndex = 21;
            // 
            // Cliente_Codigo
            // 
            this.Cliente_Codigo.HeaderText = "Codigo";
            this.Cliente_Codigo.Name = "Cliente_Codigo";
            // 
            // Cliente_Nombre
            // 
            this.Cliente_Nombre.HeaderText = "Nombre";
            this.Cliente_Nombre.Name = "Cliente_Nombre";
            // 
            // Cliente_Apellido
            // 
            this.Cliente_Apellido.HeaderText = "Apellido";
            this.Cliente_Apellido.Name = "Cliente_Apellido";
            // 
            // Cliente_TipoDoc
            // 
            this.Cliente_TipoDoc.HeaderText = "Tipo Doc.";
            this.Cliente_TipoDoc.Name = "Cliente_TipoDoc";
            // 
            // Cliente_NumDoc
            // 
            this.Cliente_NumDoc.HeaderText = "Nro. Doc.";
            this.Cliente_NumDoc.Name = "Cliente_NumDoc";
            // 
            // Cliente_Dom_Calle
            // 
            this.Cliente_Dom_Calle.HeaderText = "Dom. Calle";
            this.Cliente_Dom_Calle.Name = "Cliente_Dom_Calle";
            // 
            // Cliente_Nro_calle
            // 
            this.Cliente_Nro_calle.HeaderText = "Nro. Calle";
            this.Cliente_Nro_calle.Name = "Cliente_Nro_calle";
            // 
            // Cliente_Piso
            // 
            this.Cliente_Piso.HeaderText = "Piso";
            this.Cliente_Piso.Name = "Cliente_Piso";
            // 
            // Cliente_Depto
            // 
            this.Cliente_Depto.HeaderText = "Depto";
            this.Cliente_Depto.Name = "Cliente_Depto";
            // 
            // Cliente_Mail
            // 
            this.Cliente_Mail.HeaderText = "Mail";
            this.Cliente_Mail.Name = "Cliente_Mail";
            // 
            // Cliente_Nacionalidad
            // 
            this.Cliente_Nacionalidad.HeaderText = "Nacionalidad";
            this.Cliente_Nacionalidad.Name = "Cliente_Nacionalidad";
            // 
            // Cliente_Fecha_Nac
            // 
            this.Cliente_Fecha_Nac.HeaderText = "Fecha Nac.";
            this.Cliente_Fecha_Nac.Name = "Cliente_Fecha_Nac";
            // 
            // Cliente_Puntos
            // 
            this.Cliente_Puntos.HeaderText = "Puntos";
            this.Cliente_Puntos.Name = "Cliente_Puntos";
            // 
            // Cliente_Estado
            // 
            this.Cliente_Estado.HeaderText = "Estado";
            this.Cliente_Estado.Name = "Cliente_Estado";
            // 
            // Cliente_Consistente
            // 
            this.Cliente_Consistente.HeaderText = "Consistente";
            this.Cliente_Consistente.Name = "Cliente_Consistente";
            // 
            // btn_volver_Click
            // 
            this.btn_volver_Click.Location = new System.Drawing.Point(588, 376);
            this.btn_volver_Click.Name = "btn_volver_Click";
            this.btn_volver_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_volver_Click.TabIndex = 23;
            this.btn_volver_Click.Text = "Volver";
            this.btn_volver_Click.UseVisualStyleBackColor = true;
            this.btn_volver_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_tipo_doc);
            this.groupBox1.Controls.Add(this.txt_nro_doc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Location = new System.Drawing.Point(25, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 168);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // cb_tipo_doc
            // 
            this.cb_tipo_doc.FormattingEnabled = true;
            this.cb_tipo_doc.Items.AddRange(new object[] {
            "DNI",
            "CUIL",
            "CUIT",
            "LE",
            "LC",
            "PASSP"});
            this.cb_tipo_doc.Location = new System.Drawing.Point(340, 53);
            this.cb_tipo_doc.Name = "cb_tipo_doc";
            this.cb_tipo_doc.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo_doc.TabIndex = 36;
            this.cb_tipo_doc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_nro_doc
            // 
            this.txt_nro_doc.Location = new System.Drawing.Point(340, 95);
            this.txt_nro_doc.Name = "txt_nro_doc";
            this.txt_nro_doc.Size = new System.Drawing.Size(121, 20);
            this.txt_nro_doc.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nro. Doc.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tipo Doc.";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(85, 115);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(123, 20);
            this.txt_mail.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(85, 75);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(123, 20);
            this.txt_apellido.TabIndex = 30;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(85, 37);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(123, 20);
            this.txt_nombre.TabIndex = 29;
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(588, 258);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(75, 23);
            this.btn_alta.TabIndex = 0;
            this.btn_alta.Text = "Alta";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(588, 287);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(75, 23);
            this.btn_baja.TabIndex = 25;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(588, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Modificación";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_buscar_Click
            // 
            this.btn_buscar_Click.Location = new System.Drawing.Point(588, 115);
            this.btn_buscar_Click.Name = "btn_buscar_Click";
            this.btn_buscar_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_Click.TabIndex = 27;
            this.btn_buscar_Click.Text = "Buscar";
            this.btn_buscar_Click.UseVisualStyleBackColor = true;
            this.btn_buscar_Click.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_limpiar_Click
            // 
            this.btn_limpiar_Click.Location = new System.Drawing.Point(588, 144);
            this.btn_limpiar_Click.Name = "btn_limpiar_Click";
            this.btn_limpiar_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar_Click.TabIndex = 28;
            this.btn_limpiar_Click.Text = "Limpiar";
            this.btn_limpiar_Click.UseVisualStyleBackColor = true;
            this.btn_limpiar_Click.Click += new System.EventHandler(this.button5_Click);
            // 
            // ABMCliente01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 411);
            this.Controls.Add(this.btn_limpiar_Click);
            this.Controls.Add(this.btn_buscar_Click);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_volver_Click);
            this.Controls.Add(this.dgv_Clientes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "ABMCliente01";
            this.Text = "ABMCliente01";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.Button btn_volver_Click;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_NumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Dom_Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Nro_calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Depto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Fecha_Nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Consistente;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_buscar_Click;
        private System.Windows.Forms.Button btn_limpiar_Click;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_tipo_doc;
        private System.Windows.Forms.TextBox txt_nro_doc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}