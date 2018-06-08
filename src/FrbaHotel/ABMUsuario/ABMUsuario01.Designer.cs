namespace FrbaHotel.ABMUsuario
{
    partial class ABMUsuario01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_promptUsu = new System.Windows.Forms.Button();
            this.cb_tipodoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_nrodoc = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.boton_alta = new System.Windows.Forms.Button();
            this.boton_baja = new System.Windows.Forms.Button();
            this.boton_modificacion = new System.Windows.Forms.Button();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.Usuario_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_Nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Falla_Log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.Location = new System.Drawing.Point(286, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_promptUsu);
            this.groupBox1.Controls.Add(this.cb_tipodoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Controls.Add(this.txt_nrodoc);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.txt_Id);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Location = new System.Drawing.Point(25, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            //this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_promptUsu
            // 
            this.btn_promptUsu.Location = new System.Drawing.Point(173, 16);
            this.btn_promptUsu.Name = "btn_promptUsu";
            this.btn_promptUsu.Size = new System.Drawing.Size(26, 23);
            this.btn_promptUsu.TabIndex = 0;
            this.btn_promptUsu.Text = "...";
            this.btn_promptUsu.UseVisualStyleBackColor = true;
            this.btn_promptUsu.Click += new System.EventHandler(this.btn_promptUsu_Click);
            // 
            // cb_tipodoc
            // 
            this.cb_tipodoc.FormattingEnabled = true;
            this.cb_tipodoc.Location = new System.Drawing.Point(60, 79);
            this.cb_tipodoc.Name = "cb_tipodoc";
            this.cb_tipodoc.Size = new System.Drawing.Size(78, 21);
            this.cb_tipodoc.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nro. Doc.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Doc.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(558, 51);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(558, 22);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(365, 80);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(154, 20);
            this.txt_mail.TabIndex = 5;
            // 
            // txt_nrodoc
            // 
            this.txt_nrodoc.Location = new System.Drawing.Point(211, 81);
            this.txt_nrodoc.Name = "txt_nrodoc";
            this.txt_nrodoc.Size = new System.Drawing.Size(113, 20);
            this.txt_nrodoc.TabIndex = 4;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(319, 50);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(200, 20);
            this.txt_apellido.TabIndex = 2;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(60, 19);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(107, 20);
            this.txt_Id.TabIndex = 0;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(60, 50);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(191, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // boton_alta
            // 
            this.boton_alta.Location = new System.Drawing.Point(569, 183);
            this.boton_alta.Name = "boton_alta";
            this.boton_alta.Size = new System.Drawing.Size(89, 23);
            this.boton_alta.TabIndex = 8;
            this.boton_alta.Text = "Alta";
            this.boton_alta.UseVisualStyleBackColor = true;
            this.boton_alta.Click += new System.EventHandler(this.boton_alta_Click);
            // 
            // boton_baja
            // 
            this.boton_baja.Location = new System.Drawing.Point(569, 212);
            this.boton_baja.Name = "boton_baja";
            this.boton_baja.Size = new System.Drawing.Size(89, 23);
            this.boton_baja.TabIndex = 9;
            this.boton_baja.Text = "Baja";
            this.boton_baja.UseVisualStyleBackColor = true;
            this.boton_baja.Click += new System.EventHandler(this.boton_baja_Click);
            // 
            // boton_modificacion
            // 
            this.boton_modificacion.Location = new System.Drawing.Point(569, 241);
            this.boton_modificacion.Name = "boton_modificacion";
            this.boton_modificacion.Size = new System.Drawing.Size(89, 23);
            this.boton_modificacion.TabIndex = 10;
            this.boton_modificacion.Text = "Modificación";
            this.boton_modificacion.UseVisualStyleBackColor = true;
            this.boton_modificacion.Click += new System.EventHandler(this.boton_modificacion_Click);
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario_ID,
            this.Usuario_Password,
            this.Usuario_Nombre,
            this.Apellido,
            this.Tipo_Doc,
            this.Nro_Doc,
            this.Telefono,
            this.Direccion,
            this.Fec_Nac,
            this.Usuario_Mail,
            this.Estado,
            this.Falla_Log});
            this.dgv_Usuarios.Location = new System.Drawing.Point(25, 183);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.Size = new System.Drawing.Size(519, 244);
            this.dgv_Usuarios.TabIndex = 2;

            // 
            // Usuario_ID
            // 
            this.Usuario_ID.HeaderText = "Usuario_ID";
            this.Usuario_ID.Name = "Usuario_ID";
            this.Usuario_ID.ReadOnly = true;
            // 
            // Usuario_Password
            // 
            this.Usuario_Password.HeaderText = "Password";
            this.Usuario_Password.Name = "Usuario_Password";
            this.Usuario_Password.ReadOnly = true;
            // 
            // Usuario_Nombre
            // 
            this.Usuario_Nombre.HeaderText = "Nombre";
            this.Usuario_Nombre.Name = "Usuario_Nombre";
            this.Usuario_Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Tipo_Doc
            // 
            this.Tipo_Doc.HeaderText = "Tipo Documento";
            this.Tipo_Doc.Name = "Tipo_Doc";
            this.Tipo_Doc.ReadOnly = true;
            // 
            // Nro_Doc
            // 
            this.Nro_Doc.HeaderText = "Nro. Documento";
            this.Nro_Doc.Name = "Nro_Doc";
            this.Nro_Doc.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Fec_Nac
            // 
            this.Fec_Nac.HeaderText = "Fecha Nacimiento";
            this.Fec_Nac.Name = "Fec_Nac";
            this.Fec_Nac.ReadOnly = true;
            // 
            // Usuario_Mail
            // 
            this.Usuario_Mail.HeaderText = "Mail";
            this.Usuario_Mail.Name = "Usuario_Mail";
            this.Usuario_Mail.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Falla_Log
            // 
            this.Falla_Log.HeaderText = "Intentos de Acceso Erroneos";
            this.Falla_Log.Name = "Falla_Log";
            this.Falla_Log.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8F);
            this.label8.Location = new System.Drawing.Point(22, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "FRBA Hoteles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "FOUR SIZONS";
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(569, 404);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(89, 23);
            this.btn_volver.TabIndex = 11;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // ABMUsuario01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 439);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boton_modificacion);
            this.Controls.Add(this.boton_baja);
            this.Controls.Add(this.boton_alta);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ABMUsuario01";
            this.Text = "ABMUsuario01";
            this.Load += new System.EventHandler(this.ABMUsuario01_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_nrodoc;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button boton_alta;
        private System.Windows.Forms.Button boton_baja;
        private System.Windows.Forms.Button boton_modificacion;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_Nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Falla_Log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ComboBox cb_tipodoc;
        private System.Windows.Forms.Button btn_promptUsu;
    }
}