namespace FrbaHotel.RegistrarEstadia
{
    partial class ABMTarjeta
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
            this.dt_fecha_venc = new System.Windows.Forms.DateTimePicker();
            this.cb_marcaTarj = new System.Windows.Forms.ComboBox();
            this.boton_confirmar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigoTarj = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_titular = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Calibri", 20F);
            this.labelTitulo.Location = new System.Drawing.Point(38, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(350, 33);
            this.labelTitulo.TabIndex = 67;
            this.labelTitulo.Text = "Título de pantalla";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dt_fecha_venc
            // 
            this.dt_fecha_venc.Location = new System.Drawing.Point(116, 53);
            this.dt_fecha_venc.Name = "dt_fecha_venc";
            this.dt_fecha_venc.Size = new System.Drawing.Size(181, 20);
            this.dt_fecha_venc.TabIndex = 51;
            // 
            // cb_marcaTarj
            // 
            this.cb_marcaTarj.FormattingEnabled = true;
            this.cb_marcaTarj.Items.AddRange(new object[] {
            "Visa",
            "Master Card"});
            this.cb_marcaTarj.Location = new System.Drawing.Point(116, 131);
            this.cb_marcaTarj.Name = "cb_marcaTarj";
            this.cb_marcaTarj.Size = new System.Drawing.Size(126, 21);
            this.cb_marcaTarj.TabIndex = 50;
            // 
            // boton_confirmar
            // 
            this.boton_confirmar.Location = new System.Drawing.Point(18, 242);
            this.boton_confirmar.Name = "boton_confirmar";
            this.boton_confirmar.Size = new System.Drawing.Size(89, 23);
            this.boton_confirmar.TabIndex = 63;
            this.boton_confirmar.Text = "Confirmar";
            this.boton_confirmar.UseVisualStyleBackColor = true;
            this.boton_confirmar.Click += new System.EventHandler(this.boton_confirmar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Titular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Vencimiento";
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(280, 242);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(89, 23);
            this.btn_volver.TabIndex = 64;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(5, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 62;
            this.label9.Text = "FOUR SIZONS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Número";
            // 
            // txt_codigoTarj
            // 
            this.txt_codigoTarj.Location = new System.Drawing.Point(116, 79);
            this.txt_codigoTarj.MaxLength = 3;
            this.txt_codigoTarj.Name = "txt_codigoTarj";
            this.txt_codigoTarj.Size = new System.Drawing.Size(35, 20);
            this.txt_codigoTarj.TabIndex = 42;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(116, 27);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(181, 20);
            this.txt_numero.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_fecha_venc);
            this.groupBox1.Controls.Add(this.cb_marcaTarj);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_titular);
            this.groupBox1.Controls.Add(this.txt_codigoTarj);
            this.groupBox1.Controls.Add(this.txt_numero);
            this.groupBox1.Location = new System.Drawing.Point(18, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 161);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Tarjeta";
            // 
            // txt_titular
            // 
            this.txt_titular.Location = new System.Drawing.Point(116, 105);
            this.txt_titular.Name = "txt_titular";
            this.txt_titular.Size = new System.Drawing.Size(181, 20);
            this.txt_titular.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8F);
            this.label8.Location = new System.Drawing.Point(15, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "FRBA Hoteles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Todos los campos son obligatorios.";
            // 
            // ABMTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 268);
            this.Controls.Add(this.boton_confirmar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTitulo);
            this.Name = "ABMTarjeta";
            this.Text = "ABMTarjeta";
            this.Load += new System.EventHandler(this.ABMTarjeta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DateTimePicker dt_fecha_venc;
        private System.Windows.Forms.ComboBox cb_marcaTarj;
        private System.Windows.Forms.Button boton_confirmar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigoTarj;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_titular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}