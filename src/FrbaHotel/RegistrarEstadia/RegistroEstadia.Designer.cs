namespace FrbaHotel.RegistrarEstadia
{
    partial class RegistrarEstadia
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
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gb_Titulo = new System.Windows.Forms.GroupBox();
            this.cb_medio = new System.Windows.Forms.ComboBox();
            this.dt_Fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_CodReserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_CodReserva = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_camposObligatorios = new System.Windows.Forms.Label();
            this.btn_factura = new System.Windows.Forms.Button();
            this.btn_tarjeta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_estadia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_hotel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_hab = new System.Windows.Forms.TextBox();
            this.gb_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(23, 441);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // gb_Titulo
            // 
            this.gb_Titulo.Controls.Add(this.cb_medio);
            this.gb_Titulo.Controls.Add(this.dt_Fecha);
            this.gb_Titulo.Controls.Add(this.txt_Usuario);
            this.gb_Titulo.Controls.Add(this.txt_hab);
            this.gb_Titulo.Controls.Add(this.txt_hotel);
            this.gb_Titulo.Controls.Add(this.txt_estadia);
            this.gb_Titulo.Controls.Add(this.txt_CodReserva);
            this.gb_Titulo.Controls.Add(this.label1);
            this.gb_Titulo.Controls.Add(this.label4);
            this.gb_Titulo.Controls.Add(this.label5);
            this.gb_Titulo.Controls.Add(this.label3);
            this.gb_Titulo.Controls.Add(this.label2);
            this.gb_Titulo.Controls.Add(this.lbl_Fecha);
            this.gb_Titulo.Controls.Add(this.lbl_CodReserva);
            this.gb_Titulo.Location = new System.Drawing.Point(32, 88);
            this.gb_Titulo.Name = "gb_Titulo";
            this.gb_Titulo.Size = new System.Drawing.Size(385, 300);
            this.gb_Titulo.TabIndex = 1;
            this.gb_Titulo.TabStop = false;
            this.gb_Titulo.Text = "titulo";
            // 
            // cb_medio
            // 
            this.cb_medio.FormattingEnabled = true;
            this.cb_medio.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cb_medio.Location = new System.Drawing.Point(146, 247);
            this.cb_medio.Name = "cb_medio";
            this.cb_medio.Size = new System.Drawing.Size(121, 21);
            this.cb_medio.TabIndex = 5;
            // 
            // dt_Fecha
            // 
            this.dt_Fecha.Location = new System.Drawing.Point(146, 173);
            this.dt_Fecha.Name = "dt_Fecha";
            this.dt_Fecha.Size = new System.Drawing.Size(200, 20);
            this.dt_Fecha.TabIndex = 4;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(146, 211);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(121, 20);
            this.txt_Usuario.TabIndex = 3;
            // 
            // txt_CodReserva
            // 
            this.txt_CodReserva.Location = new System.Drawing.Point(146, 29);
            this.txt_CodReserva.Name = "txt_CodReserva";
            this.txt_CodReserva.Size = new System.Drawing.Size(121, 20);
            this.txt_CodReserva.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medio de pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID de Usuario";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(42, 173);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_Fecha.TabIndex = 2;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // lbl_CodReserva
            // 
            this.lbl_CodReserva.AutoSize = true;
            this.lbl_CodReserva.Location = new System.Drawing.Point(42, 32);
            this.lbl_CodReserva.Name = "lbl_CodReserva";
            this.lbl_CodReserva.Size = new System.Drawing.Size(98, 13);
            this.lbl_CodReserva.TabIndex = 2;
            this.lbl_CodReserva.Text = "Código de Reserva";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8F);
            this.label8.Location = new System.Drawing.Point(22, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "FRBA Hoteles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "FOUR SIZONS";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Calibri", 15F);
            this.lbl_Titulo.Location = new System.Drawing.Point(258, 19);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(59, 24);
            this.lbl_Titulo.TabIndex = 12;
            this.lbl_Titulo.Text = "Titulo";
            // 
            // lbl_camposObligatorios
            // 
            this.lbl_camposObligatorios.AutoSize = true;
            this.lbl_camposObligatorios.Location = new System.Drawing.Point(29, 409);
            this.lbl_camposObligatorios.Name = "lbl_camposObligatorios";
            this.lbl_camposObligatorios.Size = new System.Drawing.Size(172, 13);
            this.lbl_camposObligatorios.TabIndex = 45;
            this.lbl_camposObligatorios.Text = "Todos los campos son obligatorios.";
            // 
            // btn_factura
            // 
            this.btn_factura.Location = new System.Drawing.Point(457, 110);
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.Size = new System.Drawing.Size(100, 23);
            this.btn_factura.TabIndex = 46;
            this.btn_factura.Text = "Generar Factura";
            this.btn_factura.UseVisualStyleBackColor = true;
            this.btn_factura.Click += new System.EventHandler(this.btn_factura_Click);
            // 
            // btn_tarjeta
            // 
            this.btn_tarjeta.Location = new System.Drawing.Point(457, 150);
            this.btn_tarjeta.Name = "btn_tarjeta";
            this.btn_tarjeta.Size = new System.Drawing.Size(100, 23);
            this.btn_tarjeta.TabIndex = 46;
            this.btn_tarjeta.Text = "Agregar Tarjeta";
            this.btn_tarjeta.UseVisualStyleBackColor = true;
            this.btn_tarjeta.Click += new System.EventHandler(this.btn_tarjeta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de Estadía";
            // 
            // txt_estadia
            // 
            this.txt_estadia.Location = new System.Drawing.Point(146, 64);
            this.txt_estadia.Name = "txt_estadia";
            this.txt_estadia.Size = new System.Drawing.Size(121, 20);
            this.txt_estadia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hotel";
            // 
            // txt_hotel
            // 
            this.txt_hotel.Location = new System.Drawing.Point(146, 100);
            this.txt_hotel.Name = "txt_hotel";
            this.txt_hotel.Size = new System.Drawing.Size(121, 20);
            this.txt_hotel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nro. Habitación";
            // 
            // txt_hab
            // 
            this.txt_hab.Location = new System.Drawing.Point(146, 137);
            this.txt_hab.Name = "txt_hab";
            this.txt_hab.Size = new System.Drawing.Size(121, 20);
            this.txt_hab.TabIndex = 3;
            // 
            // RegistrarEstadia
            // 
            this.ClientSize = new System.Drawing.Size(583, 473);
            this.Controls.Add(this.btn_tarjeta);
            this.Controls.Add(this.btn_factura);
            this.Controls.Add(this.lbl_camposObligatorios);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.gb_Titulo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Aceptar);
            this.Name = "RegistrarEstadia";
            this.Load += new System.EventHandler(this.RegistrarEstadia_Load_1);
            this.gb_Titulo.ResumeLayout(false);
            this.gb_Titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gb_Titulo;
        private System.Windows.Forms.DateTimePicker dt_Fecha;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_CodReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_CodReserva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.ComboBox cb_medio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_camposObligatorios;
        private System.Windows.Forms.Button btn_factura;
        private System.Windows.Forms.Button btn_tarjeta;
        private System.Windows.Forms.TextBox txt_hab;
        private System.Windows.Forms.TextBox txt_hotel;
        private System.Windows.Forms.TextBox txt_estadia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}