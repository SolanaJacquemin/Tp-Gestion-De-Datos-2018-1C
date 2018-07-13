namespace FrbaHotel.Prompts
{
    partial class PromptRegimenes
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
            this.dgvRegimenPrompt = new System.Windows.Forms.DataGridView();
            this.Regimen_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regimen_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_regimenid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_regimennombre = new System.Windows.Forms.TextBox();
            this.txt_aux_regimennombre = new System.Windows.Forms.TextBox();
            this.txt_aux_regimenid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegimenPrompt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegimenPrompt
            // 
            this.dgvRegimenPrompt.AllowUserToAddRows = false;
            this.dgvRegimenPrompt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegimenPrompt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Regimen_Codigo,
            this.Regimen_Descripcion});
            this.dgvRegimenPrompt.Location = new System.Drawing.Point(12, 95);
            this.dgvRegimenPrompt.Name = "dgvRegimenPrompt";
            this.dgvRegimenPrompt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRegimenPrompt.Size = new System.Drawing.Size(271, 209);
            this.dgvRegimenPrompt.TabIndex = 8;
            this.dgvRegimenPrompt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegimenPrompt_CellClick);
            // 
            // Regimen_Codigo
            // 
            this.Regimen_Codigo.HeaderText = "Id";
            this.Regimen_Codigo.Name = "Regimen_Codigo";
            this.Regimen_Codigo.ReadOnly = true;
            // 
            // Regimen_Descripcion
            // 
            this.Regimen_Descripcion.HeaderText = "Descripción";
            this.Regimen_Descripcion.Name = "Regimen_Descripcion";
            this.Regimen_Descripcion.ReadOnly = true;
            // 
            // txt_regimenid
            // 
            this.txt_regimenid.Location = new System.Drawing.Point(62, 17);
            this.txt_regimenid.Name = "txt_regimenid";
            this.txt_regimenid.Size = new System.Drawing.Size(100, 20);
            this.txt_regimenid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_regimennombre);
            this.groupBox1.Controls.Add(this.txt_regimenid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 77);
            this.groupBox1.TabIndex = 9;
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
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desc.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rég. ID";
            // 
            // txt_regimennombre
            // 
            this.txt_regimennombre.Location = new System.Drawing.Point(62, 43);
            this.txt_regimennombre.Name = "txt_regimennombre";
            this.txt_regimennombre.Size = new System.Drawing.Size(192, 20);
            this.txt_regimennombre.TabIndex = 1;
            // 
            // txt_aux_regimennombre
            // 
            this.txt_aux_regimennombre.Location = new System.Drawing.Point(82, 336);
            this.txt_aux_regimennombre.Name = "txt_aux_regimennombre";
            this.txt_aux_regimennombre.Size = new System.Drawing.Size(100, 20);
            this.txt_aux_regimennombre.TabIndex = 10;
            // 
            // txt_aux_regimenid
            // 
            this.txt_aux_regimenid.Location = new System.Drawing.Point(82, 310);
            this.txt_aux_regimenid.Name = "txt_aux_regimenid";
            this.txt_aux_regimenid.Size = new System.Drawing.Size(100, 20);
            this.txt_aux_regimenid.TabIndex = 11;
            // 
            // PromptRegimenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 309);
            this.Controls.Add(this.dgvRegimenPrompt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_aux_regimennombre);
            this.Controls.Add(this.txt_aux_regimenid);
            this.Name = "PromptRegimenes";
            this.Text = "PromptRegimenes";
            this.Load += new System.EventHandler(this.PromptRegimenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegimenPrompt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegimenPrompt;
        private System.Windows.Forms.TextBox txt_regimenid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_regimennombre;
        private System.Windows.Forms.TextBox txt_aux_regimennombre;
        private System.Windows.Forms.TextBox txt_aux_regimenid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regimen_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regimen_Descripcion;
    }
}