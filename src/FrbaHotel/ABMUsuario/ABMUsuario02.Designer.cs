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
            this.texto_nombre = new System.Windows.Forms.TextBox();
            this.text_apellido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datetime_fecha_nac = new System.Windows.Forms.DateTimePicker();
            this.combo_tipo_documento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_direccion = new System.Windows.Forms.TextBox();
            this.text_telefono = new System.Windows.Forms.TextBox();
            this.text_nro_documento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text_user = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.boton_aceptar = new System.Windows.Forms.Button();
            this.boton_cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Calibri", 20F);
            this.labelTitulo.Location = new System.Drawing.Point(113, 27);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(350, 33);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título de pantalla";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // texto_nombre
            // 
            this.texto_nombre.Location = new System.Drawing.Point(140, 30);
            this.texto_nombre.Name = "texto_nombre";
            this.texto_nombre.Size = new System.Drawing.Size(200, 20);
            this.texto_nombre.TabIndex = 1;
            // 
            // text_apellido
            // 
            this.text_apellido.Location = new System.Drawing.Point(140, 60);
            this.text_apellido.Name = "text_apellido";
            this.text_apellido.Size = new System.Drawing.Size(200, 20);
            this.text_apellido.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datetime_fecha_nac);
            this.groupBox1.Controls.Add(this.combo_tipo_documento);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_direccion);
            this.groupBox1.Controls.Add(this.text_telefono);
            this.groupBox1.Controls.Add(this.text_apellido);
            this.groupBox1.Controls.Add(this.text_nro_documento);
            this.groupBox1.Controls.Add(this.texto_nombre);
            this.groupBox1.Location = new System.Drawing.Point(55, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 242);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Persona";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // datetime_fecha_nac
            // 
            this.datetime_fecha_nac.Location = new System.Drawing.Point(140, 210);
            this.datetime_fecha_nac.Name = "datetime_fecha_nac";
            this.datetime_fecha_nac.Size = new System.Drawing.Size(200, 20);
            this.datetime_fecha_nac.TabIndex = 5;
            // 
            // combo_tipo_documento
            // 
            this.combo_tipo_documento.FormattingEnabled = true;
            this.combo_tipo_documento.Location = new System.Drawing.Point(140, 90);
            this.combo_tipo_documento.Name = "combo_tipo_documento";
            this.combo_tipo_documento.Size = new System.Drawing.Size(200, 21);
            this.combo_tipo_documento.TabIndex = 4;
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
            // text_direccion
            // 
            this.text_direccion.Location = new System.Drawing.Point(140, 180);
            this.text_direccion.Name = "text_direccion";
            this.text_direccion.Size = new System.Drawing.Size(200, 20);
            this.text_direccion.TabIndex = 2;
            // 
            // text_telefono
            // 
            this.text_telefono.Location = new System.Drawing.Point(140, 150);
            this.text_telefono.Name = "text_telefono";
            this.text_telefono.Size = new System.Drawing.Size(200, 20);
            this.text_telefono.TabIndex = 2;
            // 
            // text_nro_documento
            // 
            this.text_nro_documento.Location = new System.Drawing.Point(140, 120);
            this.text_nro_documento.Name = "text_nro_documento";
            this.text_nro_documento.Size = new System.Drawing.Size(200, 20);
            this.text_nro_documento.TabIndex = 1;
            this.text_nro_documento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Usuario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Contraseña";
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(194, 111);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(200, 20);
            this.text_user.TabIndex = 1;
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(194, 141);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(200, 20);
            this.text_password.TabIndex = 1;
            // 
            // boton_aceptar
            // 
            this.boton_aceptar.Location = new System.Drawing.Point(342, 439);
            this.boton_aceptar.Name = "boton_aceptar";
            this.boton_aceptar.Size = new System.Drawing.Size(75, 23);
            this.boton_aceptar.TabIndex = 4;
            this.boton_aceptar.Text = "Aceptar";
            this.boton_aceptar.UseVisualStyleBackColor = true;
            // 
            // boton_cancelar
            // 
            this.boton_cancelar.Location = new System.Drawing.Point(423, 439);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.Size = new System.Drawing.Size(75, 23);
            this.boton_cancelar.TabIndex = 4;
            this.boton_cancelar.Text = "Cancelar";
            this.boton_cancelar.UseVisualStyleBackColor = true;
            // 
            // ABMUsuario02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 474);
            this.Controls.Add(this.boton_cancelar);
            this.Controls.Add(this.boton_aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_user);
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
        private System.Windows.Forms.TextBox texto_nombre;
        private System.Windows.Forms.TextBox text_apellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_telefono;
        private System.Windows.Forms.TextBox text_nro_documento;
        private System.Windows.Forms.DateTimePicker datetime_fecha_nac;
        private System.Windows.Forms.ComboBox combo_tipo_documento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_direccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Button boton_aceptar;
        private System.Windows.Forms.Button boton_cancelar;
    }
}