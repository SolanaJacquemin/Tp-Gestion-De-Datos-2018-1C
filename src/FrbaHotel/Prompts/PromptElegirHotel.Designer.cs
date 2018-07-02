namespace FrbaHotel.Prompts
{
    partial class PromptElegirHotel
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
            this.dgvHotelesPrompt = new System.Windows.Forms.DataGridView();
            this.Hotel_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_aux_hotelid = new System.Windows.Forms.TextBox();
            this.txt_aux_hotelnombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelesPrompt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el hotel";
            // 
            // dgvHotelesPrompt
            // 
            this.dgvHotelesPrompt.AllowUserToAddRows = false;
            this.dgvHotelesPrompt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotelesPrompt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hotel_Codigo,
            this.Hotel_Nombre});
            this.dgvHotelesPrompt.Location = new System.Drawing.Point(12, 46);
            this.dgvHotelesPrompt.Name = "dgvHotelesPrompt";
            this.dgvHotelesPrompt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvHotelesPrompt.Size = new System.Drawing.Size(271, 209);
            this.dgvHotelesPrompt.TabIndex = 4;
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
            // txt_aux_hotelid
            // 
            this.txt_aux_hotelid.Location = new System.Drawing.Point(84, 279);
            this.txt_aux_hotelid.Name = "txt_aux_hotelid";
            this.txt_aux_hotelid.Size = new System.Drawing.Size(100, 20);
            this.txt_aux_hotelid.TabIndex = 8;
            // 
            // txt_aux_hotelnombre
            // 
            this.txt_aux_hotelnombre.Location = new System.Drawing.Point(84, 306);
            this.txt_aux_hotelnombre.Name = "txt_aux_hotelnombre";
            this.txt_aux_hotelnombre.Size = new System.Drawing.Size(100, 20);
            this.txt_aux_hotelnombre.TabIndex = 9;
            // 
            // PromptElegirHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 264);
            this.Controls.Add(this.txt_aux_hotelnombre);
            this.Controls.Add(this.txt_aux_hotelid);
            this.Controls.Add(this.dgvHotelesPrompt);
            this.Controls.Add(this.label1);
            this.Name = "PromptElegirHotel";
            this.Text = "PromptElegirHotel";
            this.Load += new System.EventHandler(this.PromptElegirHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelesPrompt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHotelesPrompt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Nombre;
        private System.Windows.Forms.TextBox txt_aux_hotelid;
        private System.Windows.Forms.TextBox txt_aux_hotelnombre;
    }
}