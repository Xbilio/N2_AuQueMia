namespace Mestre_Detalhe
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.grpMestre = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.edAno = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDetalhe = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGravaPedido = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalEntradas = new System.Windows.Forms.Label();
            this.lblTotalSaidas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpMestre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edAno)).BeginInit();
            this.grpDetalhe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMestre
            // 
            this.grpMestre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grpMestre.Controls.Add(this.label4);
            this.grpMestre.Controls.Add(this.cbMes);
            this.grpMestre.Controls.Add(this.edAno);
            this.grpMestre.Controls.Add(this.label3);
            this.grpMestre.Controls.Add(this.cbEmpresa);
            this.grpMestre.Controls.Add(this.label2);
            this.grpMestre.Controls.Add(this.txtId);
            this.grpMestre.Controls.Add(this.label1);
            this.grpMestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMestre.Location = new System.Drawing.Point(12, 36);
            this.grpMestre.Name = "grpMestre";
            this.grpMestre.Size = new System.Drawing.Size(656, 76);
            this.grpMestre.TabIndex = 0;
            this.grpMestre.TabStop = false;
            this.grpMestre.Text = "Mestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mês";
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMes.Location = new System.Drawing.Point(393, 41);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 21);
            this.cbMes.TabIndex = 10;
            // 
            // edAno
            // 
            this.edAno.Location = new System.Drawing.Point(535, 42);
            this.edAno.Maximum = new decimal(new int[] {
            2060,
            0,
            0,
            0});
            this.edAno.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.edAno.Name = "edAno";
            this.edAno.Size = new System.Drawing.Size(65, 20);
            this.edAno.TabIndex = 9;
            this.edAno.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ano";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(89, 41);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(286, 21);
            this.cbEmpresa.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empresa";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(9, 41);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(52, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // grpDetalhe
            // 
            this.grpDetalhe.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpDetalhe.Controls.Add(this.dataGridView1);
            this.grpDetalhe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDetalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetalhe.Location = new System.Drawing.Point(12, 127);
            this.grpDetalhe.Name = "grpDetalhe";
            this.grpDetalhe.Size = new System.Drawing.Size(656, 195);
            this.grpDetalhe.TabIndex = 1;
            this.grpDetalhe.TabStop = false;
            this.grpDetalhe.Text = "Detalhe";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // btnGravaPedido
            // 
            this.btnGravaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravaPedido.Image = global::Mestre_Detalhe.Properties.Resources._1415687018_sc_save;
            this.btnGravaPedido.Location = new System.Drawing.Point(265, 328);
            this.btnGravaPedido.Name = "btnGravaPedido";
            this.btnGravaPedido.Size = new System.Drawing.Size(140, 29);
            this.btnGravaPedido.TabIndex = 2;
            this.btnGravaPedido.Text = "   Gravar ";
            this.btnGravaPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravaPedido.UseVisualStyleBackColor = true;
            this.btnGravaPedido.Click += new System.EventHandler(this.btnGravaPedido_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total de entradas:";
            // 
            // lblTotalEntradas
            // 
            this.lblTotalEntradas.AutoSize = true;
            this.lblTotalEntradas.Location = new System.Drawing.Point(611, 328);
            this.lblTotalEntradas.Name = "lblTotalEntradas";
            this.lblTotalEntradas.Size = new System.Drawing.Size(13, 13);
            this.lblTotalEntradas.TabIndex = 4;
            this.lblTotalEntradas.Text = "0";
            // 
            // lblTotalSaidas
            // 
            this.lblTotalSaidas.AutoSize = true;
            this.lblTotalSaidas.Location = new System.Drawing.Point(611, 344);
            this.lblTotalSaidas.Name = "lblTotalSaidas";
            this.lblTotalSaidas.Size = new System.Drawing.Size(13, 13);
            this.lblTotalSaidas.TabIndex = 6;
            this.lblTotalSaidas.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total de saídas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 366);
            this.Controls.Add(this.lblTotalSaidas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalEntradas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGravaPedido);
            this.Controls.Add(this.grpDetalhe);
            this.Controls.Add(this.grpMestre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluxo de caixa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMestre.ResumeLayout(false);
            this.grpMestre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edAno)).EndInit();
            this.grpDetalhe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDetalhe;
        private System.Windows.Forms.Button btnGravaPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.NumericUpDown edAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalEntradas;
        private System.Windows.Forms.Label lblTotalSaidas;
        private System.Windows.Forms.Label label7;
    }
}

