namespace FrbaHotel.RegistrarEstadia
{
    partial class RegistrarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.gb_busqueda = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.check_mail = new System.Windows.Forms.CheckBox();
            this.check_doc = new System.Windows.Forms.CheckBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_numDoc = new System.Windows.Forms.TextBox();
            this.cb_tipoDoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gb_datos = new System.Windows.Forms.GroupBox();
            this.btn_vovler = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_depto = new System.Windows.Forms.TextBox();
            this.txt_nroCalle = new System.Windows.Forms.TextBox();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_busqueda.SuspendLayout();
            this.gb_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8F);
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "FRBA Hoteles";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F);
            this.label11.Location = new System.Drawing.Point(-1, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 19);
            this.label11.TabIndex = 27;
            this.label11.Text = "FOUR SIZONS";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Calibri", 20F);
            this.labelTitulo.Location = new System.Drawing.Point(84, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(318, 33);
            this.labelTitulo.TabIndex = 25;
            this.labelTitulo.Text = "Registrar Cliente";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_busqueda
            // 
            this.gb_busqueda.Controls.Add(this.btn_buscar);
            this.gb_busqueda.Controls.Add(this.check_mail);
            this.gb_busqueda.Controls.Add(this.check_doc);
            this.gb_busqueda.Controls.Add(this.txt_mail);
            this.gb_busqueda.Controls.Add(this.txt_numDoc);
            this.gb_busqueda.Controls.Add(this.cb_tipoDoc);
            this.gb_busqueda.Controls.Add(this.label5);
            this.gb_busqueda.Controls.Add(this.label23);
            this.gb_busqueda.Controls.Add(this.label17);
            this.gb_busqueda.Controls.Add(this.label13);
            this.gb_busqueda.Location = new System.Drawing.Point(12, 61);
            this.gb_busqueda.Name = "gb_busqueda";
            this.gb_busqueda.Size = new System.Drawing.Size(517, 125);
            this.gb_busqueda.TabIndex = 28;
            this.gb_busqueda.TabStop = false;
            this.gb_busqueda.Text = "Búsqueda del cliente";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(388, 92);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(91, 23);
            this.btn_buscar.TabIndex = 37;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // check_mail
            // 
            this.check_mail.AutoSize = true;
            this.check_mail.Location = new System.Drawing.Point(388, 67);
            this.check_mail.Name = "check_mail";
            this.check_mail.Size = new System.Drawing.Size(45, 17);
            this.check_mail.TabIndex = 36;
            this.check_mail.Text = "Mail";
            this.check_mail.UseVisualStyleBackColor = true;
            this.check_mail.CheckedChanged += new System.EventHandler(this.check_mail_CheckedChanged);
            // 
            // check_doc
            // 
            this.check_doc.AutoSize = true;
            this.check_doc.Location = new System.Drawing.Point(388, 44);
            this.check_doc.Name = "check_doc";
            this.check_doc.Size = new System.Drawing.Size(81, 17);
            this.check_doc.TabIndex = 36;
            this.check_doc.Text = "Documento";
            this.check_doc.UseVisualStyleBackColor = true;
            this.check_doc.CheckedChanged += new System.EventHandler(this.check_doc_CheckedChanged);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(133, 92);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(216, 20);
            this.txt_mail.TabIndex = 35;
            // 
            // txt_numDoc
            // 
            this.txt_numDoc.Location = new System.Drawing.Point(133, 61);
            this.txt_numDoc.Name = "txt_numDoc";
            this.txt_numDoc.Size = new System.Drawing.Size(121, 20);
            this.txt_numDoc.TabIndex = 35;
            // 
            // cb_tipoDoc
            // 
            this.cb_tipoDoc.FormattingEnabled = true;
            this.cb_tipoDoc.Location = new System.Drawing.Point(133, 31);
            this.cb_tipoDoc.Name = "cb_tipoDoc";
            this.cb_tipoDoc.Size = new System.Drawing.Size(121, 21);
            this.cb_tipoDoc.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nro. de Documento";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(375, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(126, 13);
            this.label23.TabIndex = 31;
            this.label23.Text = "Elija un tipo de búsqueda";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Tipo Documento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(90, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Mail";
            // 
            // gb_datos
            // 
            this.gb_datos.Controls.Add(this.btn_aceptar);
            this.gb_datos.Controls.Add(this.txt_depto);
            this.gb_datos.Controls.Add(this.txt_nroCalle);
            this.gb_datos.Controls.Add(this.txt_pais);
            this.gb_datos.Controls.Add(this.txt_ciudad);
            this.gb_datos.Controls.Add(this.txt_telefono);
            this.gb_datos.Controls.Add(this.txt_piso);
            this.gb_datos.Controls.Add(this.txt_calle);
            this.gb_datos.Controls.Add(this.txt_apellido);
            this.gb_datos.Controls.Add(this.txt_nombre);
            this.gb_datos.Controls.Add(this.label12);
            this.gb_datos.Controls.Add(this.label10);
            this.gb_datos.Controls.Add(this.label9);
            this.gb_datos.Controls.Add(this.label8);
            this.gb_datos.Controls.Add(this.label7);
            this.gb_datos.Controls.Add(this.label6);
            this.gb_datos.Controls.Add(this.label4);
            this.gb_datos.Controls.Add(this.label3);
            this.gb_datos.Controls.Add(this.label2);
            this.gb_datos.Location = new System.Drawing.Point(12, 192);
            this.gb_datos.Name = "gb_datos";
            this.gb_datos.Size = new System.Drawing.Size(517, 253);
            this.gb_datos.TabIndex = 28;
            this.gb_datos.TabStop = false;
            this.gb_datos.Text = "Datos del cliente";
            // 
            // btn_vovler
            // 
            this.btn_vovler.Location = new System.Drawing.Point(448, 451);
            this.btn_vovler.Name = "btn_vovler";
            this.btn_vovler.Size = new System.Drawing.Size(75, 23);
            this.btn_vovler.TabIndex = 2;
            this.btn_vovler.Text = "Volver";
            this.btn_vovler.UseVisualStyleBackColor = true;
            this.btn_vovler.Click += new System.EventHandler(this.btn_vovler_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(436, 211);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_depto
            // 
            this.txt_depto.Location = new System.Drawing.Point(262, 120);
            this.txt_depto.Name = "txt_depto";
            this.txt_depto.Size = new System.Drawing.Size(87, 20);
            this.txt_depto.TabIndex = 1;
            // 
            // txt_nroCalle
            // 
            this.txt_nroCalle.Location = new System.Drawing.Point(279, 87);
            this.txt_nroCalle.Name = "txt_nroCalle";
            this.txt_nroCalle.Size = new System.Drawing.Size(70, 20);
            this.txt_nroCalle.TabIndex = 1;
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(133, 211);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(216, 20);
            this.txt_pais.TabIndex = 1;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(133, 181);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(216, 20);
            this.txt_ciudad.TabIndex = 1;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(133, 152);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(216, 20);
            this.txt_telefono.TabIndex = 1;
            // 
            // txt_piso
            // 
            this.txt_piso.Location = new System.Drawing.Point(133, 120);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(72, 20);
            this.txt_piso.TabIndex = 1;
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(133, 87);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(72, 20);
            this.txt_calle.TabIndex = 1;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(133, 61);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(216, 20);
            this.txt_apellido.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(133, 34);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(216, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Depto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nro. Calle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "País";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Piso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Calle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 481);
            this.Controls.Add(this.btn_vovler);
            this.Controls.Add(this.gb_datos);
            this.Controls.Add(this.gb_busqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelTitulo);
            this.Name = "RegistrarCliente";
            this.Text = "RegistrarClientes";
            this.Load += new System.EventHandler(this.RegistrarCliente_Load);
            this.gb_busqueda.ResumeLayout(false);
            this.gb_busqueda.PerformLayout();
            this.gb_datos.ResumeLayout(false);
            this.gb_datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox gb_busqueda;
        private System.Windows.Forms.GroupBox gb_datos;
        private System.Windows.Forms.CheckBox check_mail;
        private System.Windows.Forms.CheckBox check_doc;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_numDoc;
        private System.Windows.Forms.ComboBox cb_tipoDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_vovler;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_depto;
        private System.Windows.Forms.TextBox txt_nroCalle;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}