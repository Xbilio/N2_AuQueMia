namespace N2_AuQueMia.Forms
{
    partial class FormControleAnimais
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxResp = new System.Windows.Forms.ComboBox();
            this.dtGrdAnimais = new System.Windows.Forms.DataGridView();
            this.btnResp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Responsável";
            // 
            // cbxResp
            // 
            this.cbxResp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResp.FormattingEnabled = true;
            this.cbxResp.Location = new System.Drawing.Point(15, 25);
            this.cbxResp.Name = "cbxResp";
            this.cbxResp.Size = new System.Drawing.Size(257, 21);
            this.cbxResp.TabIndex = 1;
            this.cbxResp.SelectedIndexChanged += new System.EventHandler(this.cbxResp_SelectedIndexChanged);
            // 
            // dtGrdAnimais
            // 
            this.dtGrdAnimais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdAnimais.Location = new System.Drawing.Point(15, 52);
            this.dtGrdAnimais.Name = "dtGrdAnimais";
            this.dtGrdAnimais.Size = new System.Drawing.Size(981, 280);
            this.dtGrdAnimais.TabIndex = 2;
            // 
            // btnResp
            // 
            this.btnResp.Location = new System.Drawing.Point(278, 23);
            this.btnResp.Name = "btnResp";
            this.btnResp.Size = new System.Drawing.Size(131, 23);
            this.btnResp.TabIndex = 3;
            this.btnResp.Text = "Pesquisar Responsável";
            this.btnResp.UseVisualStyleBackColor = true;
            this.btnResp.Click += new System.EventHandler(this.btnResp_Click);
            // 
            // FormControleAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 344);
            this.Controls.Add(this.btnResp);
            this.Controls.Add(this.dtGrdAnimais);
            this.Controls.Add(this.cbxResp);
            this.Controls.Add(this.label1);
            this.Name = "FormControleAnimais";
            this.Text = "FormControleAnimais";
            this.Load += new System.EventHandler(this.FormControleAnimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdAnimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxResp;
        private System.Windows.Forms.DataGridView dtGrdAnimais;
        private System.Windows.Forms.Button btnResp;
    }
}