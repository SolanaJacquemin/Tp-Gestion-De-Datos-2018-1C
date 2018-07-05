namespace FrbaHotel.Prompts
{
    partial class PromptRoles
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
            this.txt_rolid = new System.Windows.Forms.TextBox();
            this.dgvRolesPrompt = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rolnombre = new System.Windows.Forms.TextBox();
            this.txt_aux_rolnombre = new System.Windows.Forms.TextBox();
            this.txt_aux_rolid = new System.Windows.Forms.TextBox();
            this.Rol_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesPrompt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_rolid
            // 
            this.txt_rolid.Location = new System.Drawing.Point(62, 17);
            this.txt_rolid.Name = "txt_rolid";
            this.txt_rolid.Size = new System.Drawing.Size(100, 20);
            this.txt_rolid.TabIndex = 0;
            // 
            // dgvRolesPrompt
            // 
            this.dgvRolesPrompt.AllowUserToAddRows = false;
            this.dgvRolesPrompt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolesPrompt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rol_Codigo,
            this.Rol_Nombre});
            this.dgvRolesPrompt.Location = new System.Drawing.Point(12, 92);
            this.dgvRolesPrompt.Name = "dgvRolesPrompt";
            this.dgvRolesPrompt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRolesPrompt.Size = new System.Drawing.Size(271, 209);
            this.dgvRolesPrompt.TabIndex = 8;
            this.dgvRolesPrompt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotelesPrompt_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_rolnombre);
            this.groupBox1.Controls.Add(this.txt_rolid);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
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
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rol Id.";
            // 
            // txt_rolnombre
            // 
            this.txt_rolnombre.Location = new System.Drawing.Point(62, 43);
            this.txt_rolnombre.Name = "txt_rolnombre";
            this.txt_rolnombre.Size = new System.Drawing.Size(192, 20);
            this.txt_rolnombre.TabIndex = 1;
            // 
            // txt_aux_rolnombre
            // 
            this.txt_aux_rolnombre.Location = new System.Drawing.Point(82, 333);
            this.txt_aux_rolnombre.Name = "txt_aux_rolnombre";
            this.txt_aux_rolnombre.Size = new System.Drawing.Size(100, 20);
            this.txt_aux_rolnombre.TabIndex = 10;
            // 
            // txt_aux_rolid
            // 
            this.txt_aux_rolid.Location = new System.Drawing.Point(82, 307);
            this.txt_aux_rolid.Name = "txt_aux_rolid";
            this.txt_aux_rolid.Size = new System.Drawing.Size(100, 20);
            this.txt_aux_rolid.TabIndex = 11;
            // 
            // Rol_Codigo
            // 
            this.Rol_Codigo.HeaderText = "Rol ID";
            this.Rol_Codigo.Name = "Rol_Codigo";
            this.Rol_Codigo.ReadOnly = true;
            // 
            // Rol_Nombre
            // 
            this.Rol_Nombre.HeaderText = "Nombre";
            this.Rol_Nombre.Name = "Rol_Nombre";
            this.Rol_Nombre.ReadOnly = true;
            // 
            // PromptRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 305);
            this.Controls.Add(this.dgvRolesPrompt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_aux_rolnombre);
            this.Controls.Add(this.txt_aux_rolid);
            this.Name = "PromptRoles";
            this.Text = "PromptRoles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesPrompt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_rolid;
        private System.Windows.Forms.DataGridView dgvRolesPrompt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_rolnombre;
        private System.Windows.Forms.TextBox txt_aux_rolnombre;
        private System.Windows.Forms.TextBox txt_aux_rolid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol_Nombre;
    }
}