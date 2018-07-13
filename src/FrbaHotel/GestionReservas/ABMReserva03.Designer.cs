namespace FrbaHotel.GestionReservas
{
    partial class ABMReserva03
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
            this.btn_regimen = new System.Windows.Forms.Button();
            this.btn_hotel = new System.Windows.Forms.Button();
            this.dt_fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.cb_tipoHabitacion = new System.Windows.Forms.ComboBox();
            this.dt_fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_hotel = new System.Windows.Forms.TextBox();
            this.txt_regimen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_reservaID = new System.Windows.Forms.TextBox();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boton_aceptar = new System.Windows.Forms.Button();
            this.boton_volver = new System.Windows.Forms.Button();
            this.txt_cantHab = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_costoTotal = new System.Windows.Forms.TextBox();
            this.btn_disponibilidad = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fecCambio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_regimen
            // 
            this.btn_regimen.Location = new System.Drawing.Point(224, 194);
            this.btn_regimen.Name = "btn_regimen";
            this.btn_regimen.Size = new System.Drawing.Size(25, 23);
            this.btn_regimen.TabIndex = 45;
            this.btn_regimen.Text = "...";
            this.btn_regimen.UseVisualStyleBackColor = true;
            this.btn_regimen.Click += new System.EventHandler(this.btn_regimen_Click);
            // 
            // btn_hotel
            // 
            this.btn_hotel.Location = new System.Drawing.Point(453, 196);
            this.btn_hotel.Name = "btn_hotel";
            this.btn_hotel.Size = new System.Drawing.Size(25, 23);
            this.btn_hotel.TabIndex = 44;
            this.btn_hotel.Text = "...";
            this.btn_hotel.UseVisualStyleBackColor = true;
            this.btn_hotel.Click += new System.EventHandler(this.btn_hotel_Click);
            // 
            // dt_fechaHasta
            // 
            this.dt_fechaHasta.Location = new System.Drawing.Point(360, 165);
            this.dt_fechaHasta.Name = "dt_fechaHasta";
            this.dt_fechaHasta.Size = new System.Drawing.Size(99, 20);
            this.dt_fechaHasta.TabIndex = 3;
            // 
            // cb_tipoHabitacion
            // 
            this.cb_tipoHabitacion.FormattingEnabled = true;
            this.cb_tipoHabitacion.Location = new System.Drawing.Point(131, 130);
            this.cb_tipoHabitacion.Name = "cb_tipoHabitacion";
            this.cb_tipoHabitacion.Size = new System.Drawing.Size(120, 21);
            this.cb_tipoHabitacion.TabIndex = 1;
            // 
            // dt_fechaDesde
            // 
            this.dt_fechaDesde.Location = new System.Drawing.Point(131, 167);
            this.dt_fechaDesde.Name = "dt_fechaDesde";
            this.dt_fechaDesde.Size = new System.Drawing.Size(94, 20);
            this.dt_fechaDesde.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8F);
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "FRBA Hoteles";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F);
            this.label11.Location = new System.Drawing.Point(4, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 19);
            this.label11.TabIndex = 41;
            this.label11.Text = "FOUR SIZONS";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(320, 201);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Hotel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Tipo de Régimen";
            // 
            // txt_hotel
            // 
            this.txt_hotel.Location = new System.Drawing.Point(359, 197);
            this.txt_hotel.Name = "txt_hotel";
            this.txt_hotel.Size = new System.Drawing.Size(94, 20);
            this.txt_hotel.TabIndex = 5;
            // 
            // txt_regimen
            // 
            this.txt_regimen.Location = new System.Drawing.Point(130, 196);
            this.txt_regimen.Name = "txt_regimen";
            this.txt_regimen.Size = new System.Drawing.Size(94, 20);
            this.txt_regimen.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tipo de Habitación";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(287, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Fecha Hasta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Fecha Desde";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Calibri", 20F);
            this.labelTitulo.Location = new System.Drawing.Point(89, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(350, 33);
            this.labelTitulo.TabIndex = 31;
            this.labelTitulo.Text = "Título Pantalla";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Código Reserva";
            // 
            // txt_reservaID
            // 
            this.txt_reservaID.Location = new System.Drawing.Point(131, 98);
            this.txt_reservaID.Name = "txt_reservaID";
            this.txt_reservaID.Size = new System.Drawing.Size(99, 20);
            this.txt_reservaID.TabIndex = 0;
            // 
            // txt_detalle
            // 
            this.txt_detalle.Location = new System.Drawing.Point(131, 234);
            this.txt_detalle.Multiline = true;
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(349, 63);
            this.txt_detalle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Motivos";
            // 
            // boton_aceptar
            // 
            this.boton_aceptar.Location = new System.Drawing.Point(322, 338);
            this.boton_aceptar.Name = "boton_aceptar";
            this.boton_aceptar.Size = new System.Drawing.Size(75, 23);
            this.boton_aceptar.TabIndex = 7;
            this.boton_aceptar.Text = "Aceptar";
            this.boton_aceptar.UseVisualStyleBackColor = true;
            this.boton_aceptar.Click += new System.EventHandler(this.boton_aceptar_Click);
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(403, 338);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 8;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // txt_cantHab
            // 
            this.txt_cantHab.Location = new System.Drawing.Point(359, 130);
            this.txt_cantHab.Name = "txt_cantHab";
            this.txt_cantHab.Size = new System.Drawing.Size(100, 20);
            this.txt_cantHab.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Cant. Habitaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Costo Total";
            // 
            // txt_costoTotal
            // 
            this.txt_costoTotal.Location = new System.Drawing.Point(359, 98);
            this.txt_costoTotal.Name = "txt_costoTotal";
            this.txt_costoTotal.Size = new System.Drawing.Size(100, 20);
            this.txt_costoTotal.TabIndex = 0;
            // 
            // btn_disponibilidad
            // 
            this.btn_disponibilidad.Location = new System.Drawing.Point(147, 338);
            this.btn_disponibilidad.Name = "btn_disponibilidad";
            this.btn_disponibilidad.Size = new System.Drawing.Size(169, 23);
            this.btn_disponibilidad.TabIndex = 46;
            this.btn_disponibilidad.Text = "Verificar Disponibilidad";
            this.btn_disponibilidad.UseVisualStyleBackColor = true;
            this.btn_disponibilidad.Click += new System.EventHandler(this.btn_disponibilidad_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Usuario";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(130, 65);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Fecha Cambio";
            // 
            // txt_fecCambio
            // 
            this.txt_fecCambio.Location = new System.Drawing.Point(359, 65);
            this.txt_fecCambio.Name = "txt_fecCambio";
            this.txt_fecCambio.Size = new System.Drawing.Size(100, 20);
            this.txt_fecCambio.TabIndex = 48;
            // 
            // ABMReserva03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 373);
            this.Controls.Add(this.txt_fecCambio);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_disponibilidad);
            this.Controls.Add(this.boton_aceptar);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.btn_regimen);
            this.Controls.Add(this.btn_hotel);
            this.Controls.Add(this.dt_fechaHasta);
            this.Controls.Add(this.cb_tipoHabitacion);
            this.Controls.Add(this.dt_fechaDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_detalle);
            this.Controls.Add(this.txt_hotel);
            this.Controls.Add(this.txt_regimen);
            this.Controls.Add(this.txt_costoTotal);
            this.Controls.Add(this.txt_cantHab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_reservaID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitulo);
            this.Name = "ABMReserva03";
            this.Text = "ABMReserva03";
            this.Load += new System.EventHandler(this.ABMReserva03_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regimen;
        private System.Windows.Forms.Button btn_hotel;
        private System.Windows.Forms.DateTimePicker dt_fechaHasta;
        private System.Windows.Forms.ComboBox cb_tipoHabitacion;
        private System.Windows.Forms.DateTimePicker dt_fechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_hotel;
        private System.Windows.Forms.TextBox txt_regimen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_reservaID;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boton_aceptar;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.TextBox txt_cantHab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_costoTotal;
        private System.Windows.Forms.Button btn_disponibilidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fecCambio;
    }
}