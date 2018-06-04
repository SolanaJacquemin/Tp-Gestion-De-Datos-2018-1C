namespace FrbaHotel.ABMUsuario
{
    partial class ABMUsuarioPrompt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuarioid = new System.Windows.Forms.TextBox();
            this.dgvUsuariosPrompt = new System.Windows.Forms.DataGridView();
            this.Usuario_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_aux_userid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosPrompt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_usuarioid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 42);
            this.groupBox1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario Id.";
            // 
            // txt_usuarioid
            // 
            this.txt_usuarioid.Location = new System.Drawing.Point(70, 16);
            this.txt_usuarioid.Name = "txt_usuarioid";
            this.txt_usuarioid.Size = new System.Drawing.Size(100, 20);
            this.txt_usuarioid.TabIndex = 0;
            // 
            // dgvUsuariosPrompt
            // 
            this.dgvUsuariosPrompt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosPrompt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario_ID,
            this.Usuario_Apellido});
            this.dgvUsuariosPrompt.Location = new System.Drawing.Point(21, 60);
            this.dgvUsuariosPrompt.Name = "dgvUsuariosPrompt";
            this.dgvUsuariosPrompt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvUsuariosPrompt.Size = new System.Drawing.Size(245, 209);
            this.dgvUsuariosPrompt.TabIndex = 1;
            this.dgvUsuariosPrompt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosPrompt_CellContentClick);
            // 
            // Usuario_ID
            // 
            this.Usuario_ID.HeaderText = "ID Usuario";
            this.Usuario_ID.Name = "Usuario_ID";
            this.Usuario_ID.ReadOnly = true;
            // 
            // Usuario_Apellido
            // 
            this.Usuario_Apellido.HeaderText = "Apellido";
            this.Usuario_Apellido.Name = "Usuario_Apellido";
            this.Usuario_Apellido.ReadOnly = true;
            // 
            // txt_aux_userid
            // 
            this.txt_aux_userid.Location = new System.Drawing.Point(82, 275);
            this.txt_aux_userid.Name = "txt_aux_userid";
            this.txt_aux_userid.Size = new System.Drawing.Size(100, 20);
            this.txt_aux_userid.TabIndex = 0;
            // 
            // ABMUsuarioPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 301);
            this.Controls.Add(this.dgvUsuariosPrompt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_aux_userid);
            this.Name = "ABMUsuarioPrompt";
            this.Text = "ABMUsuarioPrompt";
            this.Load += new System.EventHandler(this.ABMUsuarioPrompt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosPrompt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_usuarioid;
        private System.Windows.Forms.DataGridView dgvUsuariosPrompt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Apellido;
        private System.Windows.Forms.TextBox txt_aux_userid;
    }
}