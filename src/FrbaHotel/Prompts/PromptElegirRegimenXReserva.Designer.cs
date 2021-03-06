﻿namespace FrbaHotel.Prompts
{
    partial class PromptElegirRegimenXReserva
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
            this.Regimen_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regimen_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_aux_regimenpreciototal = new System.Windows.Forms.TextBox();
            this.txt_aux_regimennombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_aux_regimenid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegimenPrompt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegimenPrompt
            // 
            this.dgvRegimenPrompt.AllowUserToAddRows = false;
            this.dgvRegimenPrompt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegimenPrompt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Regimen_ID,
            this.Regimen_Descripcion,
            this.Precio_dia,
            this.Precio_Total});
            this.dgvRegimenPrompt.Location = new System.Drawing.Point(12, 59);
            this.dgvRegimenPrompt.Name = "dgvRegimenPrompt";
            this.dgvRegimenPrompt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRegimenPrompt.Size = new System.Drawing.Size(232, 169);
            this.dgvRegimenPrompt.TabIndex = 9;
            this.dgvRegimenPrompt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegimenPrompt_CellClick);
            // 
            // Regimen_ID
            // 
            this.Regimen_ID.HeaderText = "ID";
            this.Regimen_ID.Name = "Regimen_ID";
            this.Regimen_ID.Visible = false;
            // 
            // Regimen_Descripcion
            // 
            this.Regimen_Descripcion.HeaderText = "Descripción";
            this.Regimen_Descripcion.Name = "Regimen_Descripcion";
            this.Regimen_Descripcion.ReadOnly = true;
            // 
            // Precio_dia
            // 
            this.Precio_dia.HeaderText = "Precio X Día";
            this.Precio_dia.Name = "Precio_dia";
            this.Precio_dia.ReadOnly = true;
            // 
            // Precio_Total
            // 
            this.Precio_Total.HeaderText = "Precio Total";
            this.Precio_Total.Name = "Precio_Total";
            this.Precio_Total.Visible = false;
            // 
            // txt_aux_regimenpreciototal
            // 
            this.txt_aux_regimenpreciototal.Location = new System.Drawing.Point(74, 311);
            this.txt_aux_regimenpreciototal.Name = "txt_aux_regimenpreciototal";
            this.txt_aux_regimenpreciototal.Size = new System.Drawing.Size(100, 20);
            this.txt_aux_regimenpreciototal.TabIndex = 12;
            // 
            // txt_aux_regimennombre
            // 
            this.txt_aux_regimennombre.Location = new System.Drawing.Point(74, 285);
            this.txt_aux_regimennombre.Name = "txt_aux_regimennombre";
            this.txt_aux_regimennombre.Size = new System.Drawing.Size(100, 20);
            this.txt_aux_regimennombre.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(56, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Elija una opción";
            // 
            // txt_aux_regimenid
            // 
            this.txt_aux_regimenid.Location = new System.Drawing.Point(74, 260);
            this.txt_aux_regimenid.Name = "txt_aux_regimenid";
            this.txt_aux_regimenid.Size = new System.Drawing.Size(100, 20);
            this.txt_aux_regimenid.TabIndex = 13;
            // 
            // PromptElegirRegimenXReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_aux_regimenpreciototal);
            this.Controls.Add(this.txt_aux_regimenid);
            this.Controls.Add(this.txt_aux_regimennombre);
            this.Controls.Add(this.dgvRegimenPrompt);
            this.Name = "PromptElegirRegimenXReserva";
            this.Text = "PromptElegirRegimenXReserva";
            this.Load += new System.EventHandler(this.PromptElegirRegimenXReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegimenPrompt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegimenPrompt;
        private System.Windows.Forms.TextBox txt_aux_regimenpreciototal;
        private System.Windows.Forms.TextBox txt_aux_regimennombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_aux_regimenid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regimen_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regimen_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Total;
    }
}