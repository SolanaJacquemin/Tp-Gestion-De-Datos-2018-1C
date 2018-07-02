namespace FrbaHotel.PantallaPrincipal
{
    partial class PantallaPrincipal01
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_reservas = new System.Windows.Forms.Button();
            this.btn_listado = new System.Windows.Forms.Button();
            this.btn_estadias = new System.Windows.Forms.Button();
            this.btn_habitaciones = new System.Windows.Forms.Button();
            this.btn_hoteles = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_roles = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOUR SIZONS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F);
            this.label4.Location = new System.Drawing.Point(120, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pantalla Principal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_reservas);
            this.groupBox2.Controls.Add(this.btn_listado);
            this.groupBox2.Controls.Add(this.btn_estadias);
            this.groupBox2.Controls.Add(this.btn_habitaciones);
            this.groupBox2.Controls.Add(this.btn_hoteles);
            this.groupBox2.Controls.Add(this.btn_clientes);
            this.groupBox2.Controls.Add(this.btn_usuarios);
            this.groupBox2.Controls.Add(this.btn_roles);
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menú de Opciones";
            // 
            // btn_reservas
            // 
            this.btn_reservas.Location = new System.Drawing.Point(224, 95);
            this.btn_reservas.Name = "btn_reservas";
            this.btn_reservas.Size = new System.Drawing.Size(123, 23);
            this.btn_reservas.TabIndex = 6;
            this.btn_reservas.Text = "Gestión de Reservas";
            this.btn_reservas.UseVisualStyleBackColor = true;
            this.btn_reservas.Click += new System.EventHandler(this.btn_reservas_Click);
            // 
            // btn_listado
            // 
            this.btn_listado.Location = new System.Drawing.Point(224, 124);
            this.btn_listado.Name = "btn_listado";
            this.btn_listado.Size = new System.Drawing.Size(123, 23);
            this.btn_listado.TabIndex = 7;
            this.btn_listado.Text = "Listado Estadístico";
            this.btn_listado.UseVisualStyleBackColor = true;
            this.btn_listado.Click += new System.EventHandler(this.btn_listado_Click);
            // 
            // btn_estadias
            // 
            this.btn_estadias.Location = new System.Drawing.Point(77, 124);
            this.btn_estadias.Name = "btn_estadias";
            this.btn_estadias.Size = new System.Drawing.Size(123, 23);
            this.btn_estadias.TabIndex = 3;
            this.btn_estadias.Text = "Gestión de Estadías";
            this.btn_estadias.UseVisualStyleBackColor = true;
            this.btn_estadias.Click += new System.EventHandler(this.btn_estadias_Click);
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.Location = new System.Drawing.Point(224, 66);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.Size = new System.Drawing.Size(123, 23);
            this.btn_habitaciones.TabIndex = 5;
            this.btn_habitaciones.Text = "ABM de Habitaciones";
            this.btn_habitaciones.UseVisualStyleBackColor = true;
            this.btn_habitaciones.Click += new System.EventHandler(this.btn_habitaciones_Click);
            // 
            // btn_hoteles
            // 
            this.btn_hoteles.Location = new System.Drawing.Point(224, 37);
            this.btn_hoteles.Name = "btn_hoteles";
            this.btn_hoteles.Size = new System.Drawing.Size(123, 23);
            this.btn_hoteles.TabIndex = 4;
            this.btn_hoteles.Text = "ABM de Hoteles";
            this.btn_hoteles.UseVisualStyleBackColor = true;
            this.btn_hoteles.Click += new System.EventHandler(this.btn_hoteles_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.Location = new System.Drawing.Point(77, 95);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(123, 23);
            this.btn_clientes.TabIndex = 2;
            this.btn_clientes.Text = "ABM de Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Location = new System.Drawing.Point(77, 66);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(123, 23);
            this.btn_usuarios.TabIndex = 1;
            this.btn_usuarios.Text = "ABM de Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // btn_roles
            // 
            this.btn_roles.Location = new System.Drawing.Point(77, 37);
            this.btn_roles.Name = "btn_roles";
            this.btn_roles.Size = new System.Drawing.Size(123, 23);
            this.btn_roles.TabIndex = 0;
            this.btn_roles.Text = "ABM de Roles";
            this.btn_roles.UseVisualStyleBackColor = true;
            this.btn_roles.Click += new System.EventHandler(this.btn_roles_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "FOUR SIZONS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 8F);
            this.label6.Location = new System.Drawing.Point(22, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "FRBA Hoteles";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(364, 248);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // PantallaPrincipal01
            // 
            this.ClientSize = new System.Drawing.Size(451, 283);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "PantallaPrincipal01";
            this.Load += new System.EventHandler(this.PantallaPrincipal01_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_reservas;
        private System.Windows.Forms.Button btn_listado;
        private System.Windows.Forms.Button btn_estadias;
        private System.Windows.Forms.Button btn_habitaciones;
        private System.Windows.Forms.Button btn_hoteles;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_roles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_salir;
        /*private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;


        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button boton_abm_usuarios;
        private System.Windows.Forms.Button boton_abm_clientes;
        private System.Windows.Forms.Button boton_salir;*/
    }
}