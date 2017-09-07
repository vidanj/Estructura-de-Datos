namespace estdat
{
    partial class AbstractDataType_Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lblTextbox = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.dGVElementos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectElement = new System.Windows.Forms.Label();
            this.lblDataType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVElementos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(100, 12);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(139, 20);
            this.txtElemento.TabIndex = 0;
            this.txtElemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtElemento_KeyDown);
            // 
            // lblTextbox
            // 
            this.lblTextbox.AutoSize = true;
            this.lblTextbox.Location = new System.Drawing.Point(12, 15);
            this.lblTextbox.Name = "lblTextbox";
            this.lblTextbox.Size = new System.Drawing.Size(84, 13);
            this.lblTextbox.TabIndex = 1;
            this.lblTextbox.Text = "Elemento [0,0] =";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(315, 10);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(405, 12);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // dGVElementos
            // 
            this.dGVElementos.AllowUserToAddRows = false;
            this.dGVElementos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVElementos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGVElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVElementos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dGVElementos.Location = new System.Drawing.Point(15, 232);
            this.dGVElementos.Name = "dGVElementos";
            this.dGVElementos.ReadOnly = true;
            this.dGVElementos.RowHeadersWidth = 50;
            this.dGVElementos.Size = new System.Drawing.Size(375, 150);
            this.dGVElementos.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column1.HeaderText = "0";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column2.HeaderText = "1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column3.HeaderText = "2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Location = new System.Drawing.Point(245, 17);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(0, 13);
            this.lblDataType.TabIndex = 6;
            // 
            // AbstractDataType_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 394);
            this.Controls.Add(this.lblDataType);
            this.Controls.Add(this.lblSelectElement);
            this.Controls.Add(this.dGVElementos);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.lblTextbox);
            this.Controls.Add(this.txtElemento);
            this.Name = "AbstractDataType_Form2";
            this.Text = "Datos Abstractos - Practica 1";
            this.Load += new System.EventHandler(this.AbstractDataType_Form2_Load);
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
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}