using System;

namespace N2_AuQueMia.Forms
{
    public partial class FormPrincipal
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::N2_AuQueMia.Properties.Resources._5cancel__2_;
            this.btnCancelar.Location = new System.Drawing.Point(226, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 45);
            this.btnCancelar.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnCancelar, "Desfaz as alterações feitas");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Image = global::N2_AuQueMia.Properties.Resources.Nav_First;
            this.btnPrimeiro.Location = new System.Drawing.Point(277, 284);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(45, 45);
            this.btnPrimeiro.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnPrimeiro, "Primeiro cliente");
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = global::N2_AuQueMia.Properties.Resources.Nav_Previous;
            this.btnAnterior.Location = new System.Drawing.Point(328, 284);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(45, 45);
            this.btnAnterior.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnAnterior, "Cliente anterior");
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Image = global::N2_AuQueMia.Properties.Resources.Nav_Next;
            this.btnProximo.Location = new System.Drawing.Point(379, 284);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(45, 45);
            this.btnProximo.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnProximo, "Próximo cliente");
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = global::N2_AuQueMia.Properties.Resources.Nav_Last;
            this.btnUltimo.Location = new System.Drawing.Point(430, 284);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(45, 45);
            this.btnUltimo.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnUltimo, "Último cliente");
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Image = global::N2_AuQueMia.Properties.Resources._1new__2_;
            this.btnMais.Location = new System.Drawing.Point(22, 284);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(45, 45);
            this.btnMais.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnMais, "Criar novo");
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::N2_AuQueMia.Properties.Resources._2edit;
            this.btnAlterar.Location = new System.Drawing.Point(73, 284);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(45, 45);
            this.btnAlterar.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnAlterar, "Editar um existente");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::N2_AuQueMia.Properties.Resources._3remove;
            this.btnExcluir.Location = new System.Drawing.Point(124, 284);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 45);
            this.btnExcluir.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnExcluir, "Remover um cliente");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::N2_AuQueMia.Properties.Resources._4add;
            this.btnGravar.Location = new System.Drawing.Point(175, 284);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(45, 45);
            this.btnGravar.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnGravar, "Salvar dados do cliente");
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(22, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(32, 20);
            this.txtId.TabIndex = 25;
            this.toolTip1.SetToolTip(this.txtId, "Código de cliente");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "ID";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(170, 20);
            this.txtNome.TabIndex = 26;
            this.toolTip1.SetToolTip(this.txtNome, "Nome do cliente");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 346);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Name = "FormPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}