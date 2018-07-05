namespace FrbaHotel.ABMUsuario
{
    partial class ABMUsuario02
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_fecha_nac = new System.Windows.Forms.DateTimePicker();
            this.cb_tipo_documento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_nro_documento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.boton_aceptar = new System.Windows.Forms.Button();
            this.boton_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_rol = new System.Windows.Forms.ComboBox();
            this.txt_intentoslog = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.l_estado = new System.Windows.Forms.Label();
            this.l_log = new System.Windows.Forms.Label();
            this.btn_aceptar_nuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Calibri", 20F);
            this.labelTitulo.Location = new System.Drawing.Point(70, 12);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(350, 33);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título de pantalla";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(140, 30);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(200, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(140, 60);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(200, 20);
            this.txt_apellido.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_fecha_nac);
            this.groupBox1.Controls.Add(this.cb_tipo_documento);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.txt_nro_documento);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Location = new System.Drawing.Point(25, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 278);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Persona";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dt_fecha_nac
            // 
            this.dt_fecha_nac.Location = new System.Drawing.Point(140, 210);
            this.dt_fecha_nac.Name = "dt_fecha_nac";
            this.dt_fecha_nac.Size = new System.Drawing.Size(113, 20);
            this.dt_fecha_nac.TabIndex = 11;
            this.dt_fecha_nac.Value = new System.DateTime(2018, 6, 3, 0, 0, 0, 0);
            // 
            // cb_tipo_documento
            // 
            this.cb_tipo_documento.FormattingEnabled = true;
            this.cb_tipo_documento.Location = new System.Drawing.Point(140, 90);
            this.cb_tipo_documento.Name = "cb_tipo_documento";
            this.cb_tipo_documento.Size = new System.Drawing.Size(70, 21);
            this.cb_tipo_documento.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fecha Nacimiento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nro. de Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(140, 238);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(200, 20);
            this.txt_mail.TabIndex = 12;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(140, 180);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(200, 20);
            this.txt_direccion.TabIndex = 10;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(140, 150);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(200, 20);
            this.txt_telefono.TabIndex = 9;
            // 
            // txt_nro_documento
            // 
            this.txt_nro_documento.Location = new System.Drawing.Point(140, 120);
            this.txt_nro_documento.Name = "txt_nro_documento";
            this.txt_nro_documento.Size = new System.Drawing.Size(113, 20);
            this.txt_nro_documento.TabIndex = 8;
            this.txt_nro_documento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Usuario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(108, 63);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(112, 20);
            this.txt_usuario.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(108, 93);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(112, 20);
            this.txt_password.TabIndex = 1;
            // 
            // boton_aceptar
            // 
            this.boton_aceptar.Location = new System.Drawing.Point(25, 429);
            this.boton_aceptar.Name = "boton_aceptar";
            this.boton_aceptar.Size = new System.Drawing.Size(75, 23);
            this.boton_aceptar.TabIndex = 13;
            this.boton_aceptar.Text = "Aceptar";
            this.boton_aceptar.UseVisualStyleBackColor = true;
            this.boton_aceptar.Click += new System.EventHandler(this.boton_aceptar_Click);
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(345, 429);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 15;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8F);
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "FRBA Hoteles";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F);
            this.label11.Location = new System.Drawing.Point(12, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "FOUR SIZONS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(261, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Rol";
            // 
            // cb_rol
            // 
            this.cb_rol.FormattingEnabled = true;
            this.cb_rol.Location = new System.Drawing.Point(290, 60);
            this.cb_rol.Name = "cb_rol";
            this.cb_rol.Size = new System.Drawing.Size(121, 21);
            this.cb_rol.TabIndex = 2;
            // 
            // txt_intentoslog
            // 
            this.txt_intentoslog.Location = new System.Drawing.Point(108, 119);
            this.txt_intentoslog.Name = "txt_intentoslog";
            this.txt_intentoslog.Size = new System.Drawing.Size(47, 20);
            this.txt_intentoslog.TabIndex = 4;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(290, 93);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(121, 20);
            this.txt_estado.TabIndex = 3;
            // 
            // l_estado
            // 
            this.l_estado.AutoSize = true;
            this.l_estado.Location = new System.Drawing.Point(244, 96);
            this.l_estado.Name = "l_estado";
            this.l_estado.Size = new System.Drawing.Size(40, 13);
            this.l_estado.TabIndex = 3;
            this.l_estado.Text = "Estado";
            // 
            // l_log
            // 
            this.l_log.AutoSize = true;
            this.l_log.Location = new System.Drawing.Point(21, 122);
            this.l_log.Name = "l_log";
            this.l_log.Size = new System.Drawing.Size(77, 13);
            this.l_log.TabIndex = 3;
            this.l_log.Text = "Intentos de log";
            // 
            // btn_aceptar_nuevo
            // 
            this.btn_aceptar_nuevo.Location = new System.Drawing.Point(101, 429);
            this.btn_aceptar_nuevo.Name = "btn_aceptar_nuevo";
            this.btn_aceptar_nuevo.Size = new System.Drawing.Size(108, 23);
            this.btn_aceptar_nuevo.TabIndex = 14;
            this.btn_aceptar_nuevo.Text = "Aceptar y Nuevo";
            this.btn_aceptar_nuevo.UseVisualStyleBackColor = true;
            this.btn_aceptar_nuevo.Click += new System.EventHandler(this.boton_aceptar_nuevo_Click);
            // 
            // ABMUsuario02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 458);
            this.Controls.Add(this.cb_rol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.btn_aceptar_nuevo);
            this.Controls.Add(this.boton_aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.l_log);
            this.Controls.Add(this.l_estado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_intentoslog);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_usuario);
            this.Name = "ABMUsuario02";
            this.Text = "ABMUsuarios";
            this.Load += new System.EventHandler(this.ABMUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_nro_documento;
        private System.Windows.Forms.DateTimePicker dt_fecha_nac;
        private System.Windows.Forms.ComboBox cb_tipo_documento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button boton_aceptar;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_rol;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_intentoslog;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label l_estado;
        private System.Windows.Forms.Label l_log;
        private System.Windows.Forms.Button btn_aceptar_nuevo;
    }
}