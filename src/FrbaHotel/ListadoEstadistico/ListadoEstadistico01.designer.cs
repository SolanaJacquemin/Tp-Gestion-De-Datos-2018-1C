namespace FrbaHotel.ListadoEstadistico
{
    partial class ListadoEstadistico01
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
            this.dgv_Listado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_TipoListado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_Anio = new System.Windows.Forms.TextBox();
            this.cb_Trimestre = new System.Windows.Forms.ComboBox();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Listado
            // 
            this.dgv_Listado.AllowUserToAddRows = false;
            this.dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listado.Location = new System.Drawing.Point(12, 104);
            this.dgv_Listado.Name = "dgv_Listado";
            this.dgv_Listado.Size = new System.Drawing.Size(654, 287);
            this.dgv_Listado.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Trimestre);
            this.groupBox1.Controls.Add(this.cb_TipoListado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_Anio);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // cb_TipoListado
            // 
            this.cb_TipoListado.FormattingEnabled = true;
            this.cb_TipoListado.Location = new System.Drawing.Point(366, 26);
            this.cb_TipoListado.Name = "cb_TipoListado";
            this.cb_TipoListado.Size = new System.Drawing.Size(78, 21);
            this.cb_TipoListado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Listado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trimestre";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(550, 25);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(89, 23);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(461, 25);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(89, 23);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_Anio
            // 
            this.txt_Anio.Location = new System.Drawing.Point(47, 25);
            this.txt_Anio.Name = "txt_Anio";
            this.txt_Anio.Size = new System.Drawing.Size(64, 20);
            this.txt_Anio.TabIndex = 0;
            // 
            // cb_Trimestre
            // 
            this.cb_Trimestre.FormattingEnabled = true;
            this.cb_Trimestre.Location = new System.Drawing.Point(184, 24);
            this.cb_Trimestre.Name = "cb_Trimestre";
            this.cb_Trimestre.Size = new System.Drawing.Size(78, 21);
            this.cb_Trimestre.TabIndex = 3;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(577, 410);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(89, 23);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // ListadoEstadistico01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 445);
            this.Controls.Add(this.dgv_Listado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_salir);
            this.Name = "ListadoEstadistico01";
            this.Text = "Listado Estadístico";
            this.Load += new System.EventHandler(this.ListadoEstadistico01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Listado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_TipoListado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_Anio;
        private System.Windows.Forms.ComboBox cb_Trimestre;
        private System.Windows.Forms.Button btn_salir;
    }
}