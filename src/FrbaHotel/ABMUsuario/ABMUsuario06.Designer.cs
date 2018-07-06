namespace FrbaHotel.ABMUsuario
{
    partial class ABMUsuario06
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btn_promptUsu = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_rol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(274, 87);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 33;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(10, 87);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 34;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8F);
            this.label8.Location = new System.Drawing.Point(16, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "FRBA Hoteles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(2, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "FOUR SIZONS";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Calibri", 15F);
            this.labelTitulo.Location = new System.Drawing.Point(129, 18);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(158, 24);
            this.labelTitulo.TabIndex = 30;
            this.labelTitulo.Text = "Título de Pantalla";
            // 
            // btn_promptUsu
            // 
            this.btn_promptUsu.Location = new System.Drawing.Point(323, 56);
            this.btn_promptUsu.Name = "btn_promptUsu";
            this.btn_promptUsu.Size = new System.Drawing.Size(26, 23);
            this.btn_promptUsu.TabIndex = 29;
            this.btn_promptUsu.Text = "...";
            this.btn_promptUsu.UseVisualStyleBackColor = true;
            this.btn_promptUsu.Click += new System.EventHandler(this.btn_promptUsu_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Rol";
            // 
            // txt_rol
            // 
            this.txt_rol.Location = new System.Drawing.Point(54, 58);
            this.txt_rol.Name = "txt_rol";
            this.txt_rol.Size = new System.Drawing.Size(263, 20);
            this.txt_rol.TabIndex = 28;
            // 
            // ABMUsuario06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 116);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btn_promptUsu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_rol);
            this.Name = "ABMUsuario06";
            this.Text = "ABMUsuario06";
            this.Load += new System.EventHandler(this.ABMUsuario06_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btn_promptUsu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_rol;
    }
}