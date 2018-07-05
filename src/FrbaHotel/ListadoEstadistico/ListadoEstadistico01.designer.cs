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
            this.cb_Trimestre = new System.Windows.Forms.ComboBox();
            this.cb_TipoListado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Anio = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Listado
            // 
            this.dgv_Listado.AllowUserToAddRows = false;
            this.dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listado.Location = new System.Drawing.Point(39, 173);
            this.dgv_Listado.Name = "dgv_Listado";
            this.dgv_Listado.Size = new System.Drawing.Size(360, 248);
            this.dgv_Listado.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Trimestre);
            this.groupBox1.Controls.Add(this.cb_TipoListado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Anio);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // cb_Trimestre
            // 
            this.cb_Trimestre.FormattingEnabled = true;
            this.cb_Trimestre.Location = new System.Drawing.Point(176, 56);
            this.cb_Trimestre.Name = "cb_Trimestre";
            this.cb_Trimestre.Size = new System.Drawing.Size(64, 21);
            this.cb_Trimestre.TabIndex = 2;
            // 
            // cb_TipoListado
            // 
            this.cb_TipoListado.FormattingEnabled = true;
            this.cb_TipoListado.Location = new System.Drawing.Point(46, 25);
            this.cb_TipoListado.Name = "cb_TipoListado";
            this.cb_TipoListado.Size = new System.Drawing.Size(353, 21);
            this.cb_TipoListado.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Listado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trimestre";
            // 
            // txt_Anio
            // 
            this.txt_Anio.Location = new System.Drawing.Point(46, 56);
            this.txt_Anio.Name = "txt_Anio";
            this.txt_Anio.Size = new System.Drawing.Size(64, 20);
            this.txt_Anio.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(39, 427);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(89, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(310, 427);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(89, 23);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F);
            this.label4.Location = new System.Drawing.Point(77, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Listados Estadísticos";
            // 
            // ListadoEstadistico01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 455);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_Listado);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_salir);
            this.Name = "ListadoEstadistico01";
            this.Text = "Listado Estadístico";
            this.Load += new System.EventHandler(this.ListadoEstadistico01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Listado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_TipoListado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_Anio;
        private System.Windows.Forms.ComboBox cb_Trimestre;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label4;
    }
}