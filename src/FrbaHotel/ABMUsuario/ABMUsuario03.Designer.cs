namespace FrbaHotel.ABMUsuario
{
    partial class ABMUsuario03
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
            this.btn_promptUsu = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_hotel = new System.Windows.Forms.TextBox();
            this.dgv_Hoteles = new System.Windows.Forms.DataGridView();
            this.Hotel_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_promptUsu
            // 
            this.btn_promptUsu.Location = new System.Drawing.Point(296, 62);
            this.btn_promptUsu.Name = "btn_promptUsu";
            this.btn_promptUsu.Size = new System.Drawing.Size(26, 23);
            this.btn_promptUsu.TabIndex = 17;
            this.btn_promptUsu.Text = "...";
            this.btn_promptUsu.UseVisualStyleBackColor = true;
            this.btn_promptUsu.Click += new System.EventHandler(this.btn_promptUsu_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Hotel";
            // 
            // txt_hotel
            // 
            this.txt_hotel.Location = new System.Drawing.Point(65, 64);
            this.txt_hotel.Name = "txt_hotel";
            this.txt_hotel.Size = new System.Drawing.Size(225, 20);
            this.txt_hotel.TabIndex = 16;
            // 
            // dgv_Hoteles
            // 
            this.dgv_Hoteles.AllowUserToAddRows = false;
            this.dgv_Hoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hoteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hotel_Codigo,
            this.Hotel_Nombre});
            this.dgv_Hoteles.Location = new System.Drawing.Point(30, 107);
            this.dgv_Hoteles.Name = "dgv_Hoteles";
            this.dgv_Hoteles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_Hoteles.Size = new System.Drawing.Size(292, 167);
            this.dgv_Hoteles.TabIndex = 18;
            // 
            // Hotel_Codigo
            // 
            this.Hotel_Codigo.HeaderText = "Hotel ID";
            this.Hotel_Codigo.Name = "Hotel_Codigo";
            this.Hotel_Codigo.ReadOnly = true;
            // 
            // Hotel_Nombre
            // 
            this.Hotel_Nombre.HeaderText = "Nombre";
            this.Hotel_Nombre.Name = "Hotel_Nombre";
            this.Hotel_Nombre.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8F);
            this.label8.Location = new System.Drawing.Point(26, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "FRBA Hoteles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "FOUR SIZONS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.Location = new System.Drawing.Point(148, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hoteles del Usuario";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(328, 107);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 22;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ABMUsuario03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 281);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Hoteles);
            this.Controls.Add(this.btn_promptUsu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_hotel);
            this.Name = "ABMUsuario03";
            this.Text = "ABMUsuario03";
            this.Load += new System.EventHandler(this.ABMUsuario03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoteles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_promptUsu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_hotel;
        private System.Windows.Forms.DataGridView dgv_Hoteles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button button2;
    }
}