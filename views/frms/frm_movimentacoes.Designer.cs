namespace projeto2023.views.frms
{
    partial class movimentacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movimentacoes));
            this.pnl_movimentacoes = new System.Windows.Forms.Panel();
            this.btn_estoque = new System.Windows.Forms.Button();
            this.lbl_voltar = new System.Windows.Forms.Label();
            this.btn_Categorias = new System.Windows.Forms.Button();
            this.btn_Transacoes = new System.Windows.Forms.Button();
            this.btn_contas = new System.Windows.Forms.Button();
            this.btn_Fechamento = new System.Windows.Forms.Button();
            this.btn_SangriaCaixa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pctb_cadastros = new System.Windows.Forms.PictureBox();
            this.pnl_movimentacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_cadastros)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_movimentacoes
            // 
            this.pnl_movimentacoes.Controls.Add(this.btn_estoque);
            this.pnl_movimentacoes.Controls.Add(this.lbl_voltar);
            this.pnl_movimentacoes.Controls.Add(this.btn_Categorias);
            this.pnl_movimentacoes.Controls.Add(this.btn_Transacoes);
            this.pnl_movimentacoes.Controls.Add(this.btn_contas);
            this.pnl_movimentacoes.Controls.Add(this.btn_Fechamento);
            this.pnl_movimentacoes.Controls.Add(this.btn_SangriaCaixa);
            this.pnl_movimentacoes.Location = new System.Drawing.Point(30, 71);
            this.pnl_movimentacoes.Name = "pnl_movimentacoes";
            this.pnl_movimentacoes.Size = new System.Drawing.Size(955, 623);
            this.pnl_movimentacoes.TabIndex = 4;
            // 
            // btn_estoque
            // 
            this.btn_estoque.Image = global::projeto2023.Properties.Resources.menu_btnEstoque;
            this.btn_estoque.Location = new System.Drawing.Point(697, 369);
            this.btn_estoque.Name = "btn_estoque";
            this.btn_estoque.Size = new System.Drawing.Size(210, 136);
            this.btn_estoque.TabIndex = 19;
            this.btn_estoque.Text = "ESTOQUE";
            this.btn_estoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_estoque.UseVisualStyleBackColor = true;
            this.btn_estoque.Click += new System.EventHandler(this.btn_estoque_Click);
            // 
            // lbl_voltar
            // 
            this.lbl_voltar.AutoSize = true;
            this.lbl_voltar.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_voltar.Location = new System.Drawing.Point(3, 596);
            this.lbl_voltar.Name = "lbl_voltar";
            this.lbl_voltar.Size = new System.Drawing.Size(90, 22);
            this.lbl_voltar.TabIndex = 14;
            this.lbl_voltar.Text = "VOLTAR";
            this.lbl_voltar.Click += new System.EventHandler(this.lbl_voltar_Click);
            // 
            // btn_Categorias
            // 
            this.btn_Categorias.Image = global::projeto2023.Properties.Resources.menu_btnEstoque;
            this.btn_Categorias.Location = new System.Drawing.Point(388, 369);
            this.btn_Categorias.Name = "btn_Categorias";
            this.btn_Categorias.Size = new System.Drawing.Size(210, 136);
            this.btn_Categorias.TabIndex = 18;
            this.btn_Categorias.Text = "CATEGORIAS";
            this.btn_Categorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Categorias.UseVisualStyleBackColor = true;
            this.btn_Categorias.Click += new System.EventHandler(this.btn_Categorias_Click);
            // 
            // btn_Transacoes
            // 
            this.btn_Transacoes.Image = global::projeto2023.Properties.Resources.menu_btnFornecedor;
            this.btn_Transacoes.Location = new System.Drawing.Point(696, 158);
            this.btn_Transacoes.Name = "btn_Transacoes";
            this.btn_Transacoes.Size = new System.Drawing.Size(211, 136);
            this.btn_Transacoes.TabIndex = 17;
            this.btn_Transacoes.Text = "TRANSAÇÕES";
            this.btn_Transacoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Transacoes.UseVisualStyleBackColor = true;
            this.btn_Transacoes.Click += new System.EventHandler(this.btn_Transacoes_Click);
            // 
            // btn_contas
            // 
            this.btn_contas.Image = global::projeto2023.Properties.Resources.menu_btnCliente;
            this.btn_contas.Location = new System.Drawing.Point(70, 369);
            this.btn_contas.Name = "btn_contas";
            this.btn_contas.Size = new System.Drawing.Size(210, 136);
            this.btn_contas.TabIndex = 14;
            this.btn_contas.Text = "CONTAS";
            this.btn_contas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_contas.UseVisualStyleBackColor = true;
            this.btn_contas.Click += new System.EventHandler(this.btn_contas_Click);
            // 
            // btn_Fechamento
            // 
            this.btn_Fechamento.Image = global::projeto2023.Properties.Resources.menu_btnListaProntos;
            this.btn_Fechamento.Location = new System.Drawing.Point(69, 158);
            this.btn_Fechamento.Name = "btn_Fechamento";
            this.btn_Fechamento.Size = new System.Drawing.Size(211, 136);
            this.btn_Fechamento.TabIndex = 16;
            this.btn_Fechamento.Text = "FECHAMENTO";
            this.btn_Fechamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Fechamento.UseVisualStyleBackColor = true;
            this.btn_Fechamento.Click += new System.EventHandler(this.btn_Fechamento_Click);
            // 
            // btn_SangriaCaixa
            // 
            this.btn_SangriaCaixa.Image = global::projeto2023.Properties.Resources.menu_btnCliente;
            this.btn_SangriaCaixa.Location = new System.Drawing.Point(388, 158);
            this.btn_SangriaCaixa.Name = "btn_SangriaCaixa";
            this.btn_SangriaCaixa.Size = new System.Drawing.Size(210, 136);
            this.btn_SangriaCaixa.TabIndex = 15;
            this.btn_SangriaCaixa.Text = "SANGRIA";
            this.btn_SangriaCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SangriaCaixa.UseVisualStyleBackColor = true;
            this.btn_SangriaCaixa.Click += new System.EventHandler(this.btn_SangriaCaixa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 56);
            this.label1.TabIndex = 19;
            this.label1.Text = "Movimentações";
            // 
            // pctb_cadastros
            // 
            this.pctb_cadastros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctb_cadastros.Image = global::projeto2023.Properties.Resources.logo;
            this.pctb_cadastros.Location = new System.Drawing.Point(1005, 288);
            this.pctb_cadastros.Name = "pctb_cadastros";
            this.pctb_cadastros.Size = new System.Drawing.Size(292, 309);
            this.pctb_cadastros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb_cadastros.TabIndex = 13;
            this.pctb_cadastros.TabStop = false;
            // 
            // movimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1333, 711);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctb_cadastros);
            this.Controls.Add(this.pnl_movimentacoes);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "movimentacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentações Gerasi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_movimentacoes.ResumeLayout(false);
            this.pnl_movimentacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_cadastros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_movimentacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Categorias;
        private System.Windows.Forms.Button btn_Transacoes;
        private System.Windows.Forms.Button btn_Fechamento;
        private System.Windows.Forms.Button btn_SangriaCaixa;
        private System.Windows.Forms.Button btn_contas;
        private System.Windows.Forms.PictureBox pctb_cadastros;
        private System.Windows.Forms.Label lbl_voltar;
        private System.Windows.Forms.Button btn_estoque;
    }
}