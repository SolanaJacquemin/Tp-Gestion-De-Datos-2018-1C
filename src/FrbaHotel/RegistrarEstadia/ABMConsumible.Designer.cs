namespace FrbaHotel.RegistrarEstadia
{
    partial class ABMConsumible
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
            this.boton_aceptar = new System.Windows.Forms.Button();
            this.boton_volver = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.cb_consumibles = new System.Windows.Forms.ComboBox();
            this.lbl_consumible = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8F);
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "FRBA Hoteles";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F);
            this.label11.Location = new System.Drawing.Point(15, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 19);
            this.label11.TabIndex = 32;
            this.label11.Text = "FOUR SIZONS";
            // 
            // boton_aceptar
            // 
            this.boton_aceptar.Location = new System.Drawing.Point(19, 114);
            this.boton_aceptar.Name = "boton_aceptar";
            this.boton_aceptar.Size = new System.Drawing.Size(75, 23);
            this.boton_aceptar.TabIndex = 33;
            this.boton_aceptar.Text = "Aceptar";
            this.boton_aceptar.UseVisualStyleBackColor = true;
            this.boton_aceptar.Click += new System.EventHandler(this.boton_aceptar_Click);
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(324, 114);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 34;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Calibri", 20F);
            this.labelTitulo.Location = new System.Drawing.Point(73, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(350, 33);
            this.labelTitulo.TabIndex = 19;
            this.labelTitulo.Text = "Título de pantalla";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_consumibles
            // 
            this.cb_consumibles.FormattingEnabled = true;
            this.cb_consumibles.Location = new System.Drawing.Point(94, 70);
            this.cb_consumibles.Name = "cb_consumibles";
            this.cb_consumibles.Size = new System.Drawing.Size(121, 21);
            this.cb_consumibles.TabIndex = 41;
            // 
            // lbl_consumible
            // 
            this.lbl_consumible.AutoSize = true;
            this.lbl_consumible.Location = new System.Drawing.Point(27, 74);
            this.lbl_consumible.Name = "lbl_consumible";
            this.lbl_consumible.Size = new System.Drawing.Size(61, 13);
            this.lbl_consumible.TabIndex = 39;
            this.lbl_consumible.Text = "Consumible";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(244, 74);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_cantidad.TabIndex = 40;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(299, 71);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 42;
            // 
            // ABMConsumible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 162);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.cb_consumibles);
            this.Controls.Add(this.lbl_consumible);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.boton_aceptar);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.labelTitulo);
            this.Name = "ABMConsumible";
            this.Text = "ABMConsumible";
            this.Load += new System.EventHandler(this.ABMConsumible_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button boton_aceptar;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ComboBox cb_consumibles;
        private System.Windows.Forms.Label lbl_consumible;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_cantidad;
    }
}