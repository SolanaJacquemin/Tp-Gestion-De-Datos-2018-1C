﻿namespace FrbaHotel.RegistrarEstadia
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
            this.gb_Titulo = new System.Windows.Forms.GroupBox();
            this.dt_fechaSalida = new System.Windows.Forms.DateTimePicker();
            this.cb_medioPago = new System.Windows.Forms.ComboBox();
            this.txt_hotel = new System.Windows.Forms.TextBox();
            this.txt_estadia = new System.Windows.Forms.TextBox();
            this.txt_CodReserva = new System.Windows.Forms.TextBox();
            this.l_medioPago = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_estadia = new System.Windows.Forms.Label();
            this.lbl_CodReserva = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_camposObligatorios = new System.Windows.Forms.Label();
            this.btn_factura = new System.Windows.Forms.Button();
            this.btn_tarjeta = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btn_regClientes = new System.Windows.Forms.Button();
            this.gb_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(16, 215);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(100, 23);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // gb_Titulo
            // 
            this.gb_Titulo.Controls.Add(this.dt_fechaSalida);
            this.gb_Titulo.Controls.Add(this.cb_medioPago);
            this.gb_Titulo.Controls.Add(this.txt_hotel);
            this.gb_Titulo.Controls.Add(this.txt_estadia);
            this.gb_Titulo.Controls.Add(this.txt_CodReserva);
            this.gb_Titulo.Controls.Add(this.l_medioPago);
            this.gb_Titulo.Controls.Add(this.label3);
            this.gb_Titulo.Controls.Add(this.label2);
            this.gb_Titulo.Controls.Add(this.lbl_estadia);
            this.gb_Titulo.Controls.Add(this.lbl_CodReserva);
            this.gb_Titulo.Location = new System.Drawing.Point(16, 61);
            this.gb_Titulo.Name = "gb_Titulo";
            this.gb_Titulo.Size = new System.Drawing.Size(494, 127);
            this.gb_Titulo.TabIndex = 1;
            this.gb_Titulo.TabStop = false;
            // 
            // dt_fechaSalida
            // 
            this.dt_fechaSalida.Location = new System.Drawing.Point(346, 49);
            this.dt_fechaSalida.Name = "dt_fechaSalida";
            this.dt_fechaSalida.Size = new System.Drawing.Size(121, 20);
            this.dt_fechaSalida.TabIndex = 31;
            // 
            // cb_medioPago
            // 
            this.cb_medioPago.FormattingEnabled = true;
            this.cb_medioPago.Location = new System.Drawing.Point(109, 90);
            this.cb_medioPago.Name = "cb_medioPago";
            this.cb_medioPago.Size = new System.Drawing.Size(121, 21);
            this.cb_medioPago.TabIndex = 30;
            this.cb_medioPago.SelectedIndexChanged += new System.EventHandler(this.cb_medioPago_SelectedIndexChanged);
            // 
            // txt_hotel
            // 
            this.txt_hotel.Location = new System.Drawing.Point(109, 52);
            this.txt_hotel.Name = "txt_hotel";
            this.txt_hotel.Size = new System.Drawing.Size(121, 20);
            this.txt_hotel.TabIndex = 3;
            // 
            // txt_estadia
            // 
            this.txt_estadia.Location = new System.Drawing.Point(346, 16);
            this.txt_estadia.Name = "txt_estadia";
            this.txt_estadia.Size = new System.Drawing.Size(121, 20);
            this.txt_estadia.TabIndex = 3;
            // 
            // txt_CodReserva
            // 
            this.txt_CodReserva.Location = new System.Drawing.Point(109, 16);
            this.txt_CodReserva.Name = "txt_CodReserva";
            this.txt_CodReserva.Size = new System.Drawing.Size(121, 20);
            this.txt_CodReserva.TabIndex = 3;
            // 
            // l_medioPago
            // 
            this.l_medioPago.AutoSize = true;
            this.l_medioPago.Location = new System.Drawing.Point(27, 93);
            this.l_medioPago.Name = "l_medioPago";
            this.l_medioPago.Size = new System.Drawing.Size(78, 13);
            this.l_medioPago.TabIndex = 2;
            this.l_medioPago.Text = "Medio de pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Salida";
            // 
            // lbl_estadia
            // 
            this.lbl_estadia.AutoSize = true;
            this.lbl_estadia.Location = new System.Drawing.Point(247, 19);
            this.lbl_estadia.Name = "lbl_estadia";
            this.lbl_estadia.Size = new System.Drawing.Size(95, 13);
            this.lbl_estadia.TabIndex = 2;
            this.lbl_estadia.Text = "Código de Estadía";
            // 
            // lbl_CodReserva
            // 
            this.lbl_CodReserva.AutoSize = true;
            this.lbl_CodReserva.Location = new System.Drawing.Point(7, 19);
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
            // lbl_camposObligatorios
            // 
            this.lbl_camposObligatorios.AutoSize = true;
            this.lbl_camposObligatorios.Location = new System.Drawing.Point(13, 191);
            this.lbl_camposObligatorios.Name = "lbl_camposObligatorios";
            this.lbl_camposObligatorios.Size = new System.Drawing.Size(172, 13);
            this.lbl_camposObligatorios.TabIndex = 45;
            this.lbl_camposObligatorios.Text = "Todos los campos son obligatorios.";
            // 
            // btn_factura
            // 
            this.btn_factura.Location = new System.Drawing.Point(410, 215);
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.Size = new System.Drawing.Size(100, 23);
            this.btn_factura.TabIndex = 46;
            this.btn_factura.Text = "Facturar";
            this.btn_factura.UseVisualStyleBackColor = true;
            this.btn_factura.Click += new System.EventHandler(this.btn_factura_Click);
            // 
            // btn_tarjeta
            // 
            this.btn_tarjeta.Location = new System.Drawing.Point(304, 215);
            this.btn_tarjeta.Name = "btn_tarjeta";
            this.btn_tarjeta.Size = new System.Drawing.Size(100, 23);
            this.btn_tarjeta.TabIndex = 46;
            this.btn_tarjeta.Text = "Agregar Tarjeta";
            this.btn_tarjeta.UseVisualStyleBackColor = true;
            this.btn_tarjeta.Click += new System.EventHandler(this.btn_tarjeta_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Calibri", 20F);
            this.labelTitulo.Location = new System.Drawing.Point(115, 12);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(350, 33);
            this.labelTitulo.TabIndex = 53;
            this.labelTitulo.Text = "Título de pantalla";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_regClientes
            // 
            this.btn_regClientes.Location = new System.Drawing.Point(125, 215);
            this.btn_regClientes.Name = "btn_regClientes";
            this.btn_regClientes.Size = new System.Drawing.Size(100, 23);
            this.btn_regClientes.TabIndex = 54;
            this.btn_regClientes.Text = "Registrar Clientes";
            this.btn_regClientes.UseVisualStyleBackColor = true;
            this.btn_regClientes.Click += new System.EventHandler(this.btn_regClientes_Click);
            // 
            // RegistrarEstadia
            // 
            this.ClientSize = new System.Drawing.Size(530, 244);
            this.Controls.Add(this.btn_regClientes);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btn_tarjeta);
            this.Controls.Add(this.btn_factura);
            this.Controls.Add(this.lbl_camposObligatorios);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gb_Titulo);
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
        private System.Windows.Forms.GroupBox gb_Titulo;
        private System.Windows.Forms.TextBox txt_CodReserva;
        private System.Windows.Forms.Label lbl_CodReserva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label l_medioPago;
        private System.Windows.Forms.Label lbl_camposObligatorios;
        private System.Windows.Forms.Button btn_factura;
        private System.Windows.Forms.Button btn_tarjeta;
        private System.Windows.Forms.TextBox txt_hotel;
        private System.Windows.Forms.TextBox txt_estadia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_estadia;
        private System.Windows.Forms.ComboBox cb_medioPago;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btn_regClientes;
        private System.Windows.Forms.DateTimePicker dt_fechaSalida;
        private System.Windows.Forms.Label label2;
    }
}