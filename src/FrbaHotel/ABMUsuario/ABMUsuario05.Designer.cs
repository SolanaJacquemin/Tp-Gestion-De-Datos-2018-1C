namespace FrbaHotel.ABMUsuario
{
    partial class ABMUsuario05
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
            this.dgv_Roles = new System.Windows.Forms.DataGridView();
            this.Roles_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Roles
            // 
            this.dgv_Roles.AllowUserToAddRows = false;
            this.dgv_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Roles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Roles_Codigo,
            this.Rol_Nombre});
            this.dgv_Roles.Location = new System.Drawing.Point(19, 63);
            this.dgv_Roles.Name = "dgv_Roles";
            this.dgv_Roles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_Roles.Size = new System.Drawing.Size(292, 167);
            this.dgv_Roles.TabIndex = 24;
            this.dgv_Roles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Roles_CellClick);
            // 
            // Roles_Codigo
            // 
            this.Roles_Codigo.HeaderText = "Rol ID";
            this.Roles_Codigo.Name = "Roles_Codigo";
            this.Roles_Codigo.ReadOnly = true;
            // 
            // Rol_Nombre
            // 
            this.Rol_Nombre.HeaderText = "Nombre";
            this.Rol_Nombre.Name = "Rol_Nombre";
            this.Rol_Nombre.ReadOnly = true;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(317, 207);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 28;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(317, 63);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 29;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8F);
            this.label8.Location = new System.Drawing.Point(16, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "FRBA Hoteles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(2, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "FOUR SIZONS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.Location = new System.Drawing.Point(128, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Roles del Usuario";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(318, 93);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 30;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.boto_eliminar_Click);
            // 
            // ABMUsuario05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 236);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.dgv_Roles);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "ABMUsuario05";
            this.Text = "ABMUsuario05";
            this.Load += new System.EventHandler(this.ABMUsuario05_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Roles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Roles;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roles_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol_Nombre;
        private System.Windows.Forms.Button btn_eliminar;
    }
}