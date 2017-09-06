namespace estdat
{
    partial class Datos_Abstractos__Practica_1_2
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
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lblTextbox = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.dGVElementos = new System.Windows.Forms.DataGridView();
            this.lblSelectElement = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVElementos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(100, 12);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(139, 20);
            this.txtElemento.TabIndex = 0;
            // 
            // lblTextbox
            // 
            this.lblTextbox.AutoSize = true;
            this.lblTextbox.Location = new System.Drawing.Point(12, 15);
            this.lblTextbox.Name = "lblTextbox";
            this.lblTextbox.Size = new System.Drawing.Size(82, 13);
            this.lblTextbox.TabIndex = 1;
            this.lblTextbox.Text = "Elemento [0,0] *";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(259, 10);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(349, 12);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // dGVElementos
            // 
            this.dGVElementos.AllowUserToAddRows = false;
            this.dGVElementos.AllowUserToDeleteRows = false;
            this.dGVElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVElementos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dGVElementos.Location = new System.Drawing.Point(15, 232);
            this.dGVElementos.Name = "dGVElementos";
            this.dGVElementos.ReadOnly = true;
            this.dGVElementos.Size = new System.Drawing.Size(343, 150);
            this.dGVElementos.TabIndex = 4;
            // 
            // lblSelectElement
            // 
            this.lblSelectElement.AutoSize = true;
            this.lblSelectElement.Location = new System.Drawing.Point(12, 102);
            this.lblSelectElement.Name = "lblSelectElement";
            this.lblSelectElement.Size = new System.Drawing.Size(155, 13);
            this.lblSelectElement.TabIndex = 5;
            this.lblSelectElement.Text = "Elemento [0,0]. Seleccionado =\r\n";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Datos_Abstractos__Practica_1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 394);
            this.Controls.Add(this.lblSelectElement);
            this.Controls.Add(this.dGVElementos);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.lblTextbox);
            this.Controls.Add(this.txtElemento);
            this.Name = "Datos_Abstractos__Practica_1_2";
            this.Text = "Datos Abstractos - Practica 1";
            ((System.ComponentModel.ISupportInitialize)(this.dGVElementos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label lblTextbox;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.DataGridView dGVElementos;
        private System.Windows.Forms.Label lblSelectElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}