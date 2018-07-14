namespace FrbaHotel.RegistrarEstadia
{
    partial class RegistroClientes
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
            this.btn_registrarCliente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.check_mail = new System.Windows.Forms.CheckBox();
            this.txt_nro_documento = new System.Windows.Forms.TextBox();
            this.check_doc = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_tipoDocumento = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_buscarCliente = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_registrarCliente
            // 
            this.btn_registrarCliente.Location = new System.Drawing.Point(15, 202);
            this.btn_registrarCliente.Name = "btn_registrarCliente";
            this.btn_registrarCliente.Size = new System.Drawing.Size(96, 23);
            this.btn_registrarCliente.TabIndex = 11;
            this.btn_registrarCliente.Text = "Buscar";
            this.btn_registrarCliente.UseVisualStyleBackColor = true;
            this.btn_registrarCliente.Click += new System.EventHandler(this.btn_registrarCliente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(2, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 69;
            this.label9.Text = "FOUR SIZONS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8F);
            this.label8.Location = new System.Drawing.Point(12, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "FRBA Hoteles";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Calibri", 20F);
            this.labelTitulo.Location = new System.Drawing.Point(102, 27);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(350, 33);
            this.labelTitulo.TabIndex = 70;
            this.labelTitulo.Text = "Registrar Clientes";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(414, 202);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 71;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_mail);
            this.groupBox2.Controls.Add(this.check_mail);
            this.groupBox2.Controls.Add(this.txt_nro_documento);
            this.groupBox2.Controls.Add(this.check_doc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cb_tipoDocumento);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btn_buscarCliente);
            this.groupBox2.Location = new System.Drawing.Point(6, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 134);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda del cliente";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(139, 96);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(197, 20);
            this.txt_mail.TabIndex = 12;
            // 
            // check_mail
            // 
            this.check_mail.AutoSize = true;
            this.check_mail.Location = new System.Drawing.Point(352, 67);
            this.check_mail.Name = "check_mail";
            this.check_mail.Size = new System.Drawing.Size(45, 17);
            this.check_mail.TabIndex = 9;
            this.check_mail.Text = "Mail";
            this.check_mail.UseVisualStyleBackColor = true;
            // 
            // txt_nro_documento
            // 
            this.txt_nro_documento.Location = new System.Drawing.Point(139, 65);
            this.txt_nro_documento.Name = "txt_nro_documento";
            this.txt_nro_documento.Size = new System.Drawing.Size(121, 20);
            this.txt_nro_documento.TabIndex = 11;
            // 
            // check_doc
            // 
            this.check_doc.AutoSize = true;
            this.check_doc.Location = new System.Drawing.Point(352, 44);
            this.check_doc.Name = "check_doc";
            this.check_doc.Size = new System.Drawing.Size(115, 17);
            this.check_doc.TabIndex = 8;
            this.check_doc.Text = "Tipo y nro. de doc.";
            this.check_doc.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nro. de Documento";
            // 
            // cb_tipoDocumento
            // 
            this.cb_tipoDocumento.FormattingEnabled = true;
            this.cb_tipoDocumento.Location = new System.Drawing.Point(139, 34);
            this.cb_tipoDocumento.Name = "cb_tipoDocumento";
            this.cb_tipoDocumento.Size = new System.Drawing.Size(95, 21);
            this.cb_tipoDocumento.TabIndex = 10;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(349, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(126, 13);
            this.label23.TabIndex = 28;
            this.label23.Text = "Elija un tipo de búsqueda";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Tipo Documento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(89, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Mail";
            // 
            // btn_buscarCliente
            // 
            this.btn_buscarCliente.Location = new System.Drawing.Point(352, 92);
            this.btn_buscarCliente.Name = "btn_buscarCliente";
            this.btn_buscarCliente.Size = new System.Drawing.Size(96, 27);
            this.btn_buscarCliente.TabIndex = 13;
            this.btn_buscarCliente.Text = "Buscar Cliente";
            this.btn_buscarCliente.UseVisualStyleBackColor = true;
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_registrarCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelTitulo);
            this.Name = "RegistroClientes";
            this.Text = "RegistroClientes";
            this.Load += new System.EventHandler(this.VerificaClientes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registrarCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.CheckBox check_mail;
        private System.Windows.Forms.TextBox txt_nro_documento;
        private System.Windows.Forms.CheckBox check_doc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_tipoDocumento;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_buscarCliente;
    }
}