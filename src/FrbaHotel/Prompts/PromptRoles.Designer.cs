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
            this.dgvRolesPrompt = new System.Windows.Forms.DataGridView();
            this.Rol_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_aux_rolnombre = new System.Windows.Forms.TextBox();
            this.txt_aux_rolid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesPrompt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRolesPrompt
            // 
            this.dgvRolesPrompt.AllowUserToAddRows = false;
            this.dgvRolesPrompt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolesPrompt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rol_Codigo,
            this.Rol_Nombre});
            this.dgvRolesPrompt.Location = new System.Drawing.Point(12, 61);
            this.dgvRolesPrompt.Name = "dgvRolesPrompt";
            this.dgvRolesPrompt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRolesPrompt.Size = new System.Drawing.Size(271, 209);
            this.dgvRolesPrompt.TabIndex = 8;
            this.dgvRolesPrompt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotelesPrompt_CellClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.Location = new System.Drawing.Point(67, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione el rol";
            // 
            // PromptRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRolesPrompt);
            this.Controls.Add(this.txt_aux_rolnombre);
            this.Controls.Add(this.txt_aux_rolid);
            this.Name = "PromptRoles";
            this.Text = "PromptRoles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesPrompt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRolesPrompt;
        private System.Windows.Forms.TextBox txt_aux_rolnombre;
        private System.Windows.Forms.TextBox txt_aux_rolid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol_Nombre;
        private System.Windows.Forms.Label label1;
    }
}