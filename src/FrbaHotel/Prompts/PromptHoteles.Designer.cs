namespace FrbaHotel.Prompts
{
    partial class PromptHoteles
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
            this.txt_hotelid = new System.Windows.Forms.TextBox();
            this.dgvHotelesPrompt = new System.Windows.Forms.DataGridView();
            this.Hotel_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_hotelnombre = new System.Windows.Forms.TextBox();
            this.txt_aux_hotelid = new System.Windows.Forms.TextBox();
            this.txt_aux_hotelnombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelesPrompt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_hotelid
            // 
            this.txt_hotelid.Location = new System.Drawing.Point(62, 17);
            this.txt_hotelid.Name = "txt_hotelid";
            this.txt_hotelid.Size = new System.Drawing.Size(100, 20);
            this.txt_hotelid.TabIndex = 0;
            // 
            // dgvHotelesPrompt
            // 
            this.dgvHotelesPrompt.AllowUserToAddRows = false;
            this.dgvHotelesPrompt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotelesPrompt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hotel_Codigo,
            this.Hotel_Nombre});
            this.dgvHotelesPrompt.Location = new System.Drawing.Point(2, 85);
            this.dgvHotelesPrompt.Name = "dgvHotelesPrompt";
            this.dgvHotelesPrompt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvHotelesPrompt.Size = new System.Drawing.Size(271, 209);
            this.dgvHotelesPrompt.TabIndex = 3;
            this.dgvHotelesPrompt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotelesPrompt_CellClick);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_hotelnombre);
            this.groupBox1.Controls.Add(this.txt_hotelid);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 77);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(179, 13);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel Id.";
            // 
            // txt_hotelnombre
            // 
            this.txt_hotelnombre.Location = new System.Drawing.Point(62, 43);
            this.txt_hotelnombre.Name = "txt_hotelnombre";
            this.txt_hotelnombre.Size = new System.Drawing.Size(192, 20);
            this.txt_hotelnombre.TabIndex = 1;
            // 
            // txt_aux_hotelid
            // 
            this.txt_aux_hotelid.Location = new System.Drawing.Point(72, 300);
            this.txt_aux_hotelid.Name = "txt_aux_hotelid";
            this.txt_aux_hotelid.Size = new System.Drawing.Size(100, 20);
            this.txt_aux_hotelid.TabIndex = 7;
            // 
            // txt_aux_hotelnombre
            // 
            this.txt_aux_hotelnombre.Location = new System.Drawing.Point(72, 326);
            this.txt_aux_hotelnombre.Name = "txt_aux_hotelnombre";
            this.txt_aux_hotelnombre.Size = new System.Drawing.Size(100, 20);
            this.txt_aux_hotelnombre.TabIndex = 7;
            // 
            // PromptHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 295);
            this.Controls.Add(this.dgvHotelesPrompt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_aux_hotelnombre);
            this.Controls.Add(this.txt_aux_hotelid);
            this.Name = "PromptHoteles";
            this.Text = "PromptHotel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelesPrompt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_hotelid;
        private System.Windows.Forms.DataGridView dgvHotelesPrompt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_hotelnombre;
        private System.Windows.Forms.TextBox txt_aux_hotelid;
        private System.Windows.Forms.TextBox txt_aux_hotelnombre;
    }
}