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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.gb_Titulo = new System.Windows.Forms.GroupBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_CodReserva = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.txt_CodReserva = new System.Windows.Forms.TextBox();
            this.dt_Fecha = new System.Windows.Forms.DateTimePicker();
            this.gb_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8F);
            this.label8.Location = new System.Drawing.Point(22, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "FRBA Hoteles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "FOUR SIZONS";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Calibri", 15F);
            this.lbl_Titulo.Location = new System.Drawing.Point(217, 19);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(59, 24);
            this.lbl_Titulo.TabIndex = 20;
            this.lbl_Titulo.Text = "Titulo";
            // 
            // gb_Titulo
            // 
            this.gb_Titulo.Controls.Add(this.dt_Fecha);
            this.gb_Titulo.Controls.Add(this.txt_CodReserva);
            this.gb_Titulo.Controls.Add(this.txt_Usuario);
            this.gb_Titulo.Controls.Add(this.lbl_Fecha);
            this.gb_Titulo.Controls.Add(this.lbl_Usuario);
            this.gb_Titulo.Controls.Add(this.lbl_CodReserva);
            this.gb_Titulo.Location = new System.Drawing.Point(25, 61);
            this.gb_Titulo.Name = "gb_Titulo";
            this.gb_Titulo.Size = new System.Drawing.Size(418, 148);
            this.gb_Titulo.TabIndex = 23;
            this.gb_Titulo.TabStop = false;
            this.gb_Titulo.Text = "titulo";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(130, 98);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_Usuario.TabIndex = 1;
            // 
            // lbl_CodReserva
            // 
            this.lbl_CodReserva.AutoSize = true;
            this.lbl_CodReserva.Location = new System.Drawing.Point(31, 28);
            this.lbl_CodReserva.Name = "lbl_CodReserva";
            this.lbl_CodReserva.Size = new System.Drawing.Size(93, 13);
            this.lbl_CodReserva.TabIndex = 0;
            this.lbl_CodReserva.Text = "Código de reserva";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(34, 226);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 24;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(464, 226);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 26;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(31, 101);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(57, 13);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "ID Usuario";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(31, 66);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_Fecha.TabIndex = 0;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // txt_CodReserva
            // 
            this.txt_CodReserva.Location = new System.Drawing.Point(130, 25);
            this.txt_CodReserva.Name = "txt_CodReserva";
            this.txt_CodReserva.Size = new System.Drawing.Size(100, 20);
            this.txt_CodReserva.TabIndex = 1;
            // 
            // dt_Fecha
            // 
            this.dt_Fecha.Location = new System.Drawing.Point(130, 60);
            this.dt_Fecha.Name = "dt_Fecha";
            this.dt_Fecha.Size = new System.Drawing.Size(200, 20);
            this.dt_Fecha.TabIndex = 27;
            // 
            // RegistrarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 265);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.gb_Titulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "RegistrarEstadia";
            this.Text = "RegistrarEstadia";
            this.Load += new System.EventHandler(this.RegistrarEstadia_Load);
            this.gb_Titulo.ResumeLayout(false);
            this.gb_Titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.GroupBox gb_Titulo;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label lbl_CodReserva;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.TextBox txt_CodReserva;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.DateTimePicker dt_Fecha;
    }
}