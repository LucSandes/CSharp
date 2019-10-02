namespace SistemaControleFinanceiro
{
    partial class telaPrincipal
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
            this.botaoSair = new System.Windows.Forms.Button();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.botaoConta = new System.Windows.Forms.Button();
            this.textoConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoSair
            // 
            this.botaoSair.BackColor = System.Drawing.SystemColors.ControlText;
            this.botaoSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoSair.Location = new System.Drawing.Point(105, 105);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(50, 23);
            this.botaoSair.TabIndex = 0;
            this.botaoSair.Text = "Sair";
            this.botaoSair.UseVisualStyleBackColor = false;
            this.botaoSair.Click += new System.EventHandler(this.BotaoSair_Click);
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(170, 95);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(75, 23);
            this.botaoSaque.TabIndex = 1;
            this.botaoSaque.Text = "Saque";
            this.botaoSaque.UseVisualStyleBackColor = true;
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.Location = new System.Drawing.Point(12, 95);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(75, 23);
            this.botaoDeposito.TabIndex = 2;
            this.botaoDeposito.Text = "Deposito";
            this.botaoDeposito.UseVisualStyleBackColor = true;
            // 
            // botaoConta
            // 
            this.botaoConta.Location = new System.Drawing.Point(170, 52);
            this.botaoConta.Name = "botaoConta";
            this.botaoConta.Size = new System.Drawing.Size(75, 24);
            this.botaoConta.TabIndex = 3;
            this.botaoConta.Text = "Conta";
            this.botaoConta.UseVisualStyleBackColor = true;
            this.botaoConta.Click += new System.EventHandler(this.Button3_Click);
            // 
            // textoConta
            // 
            this.textoConta.Location = new System.Drawing.Point(12, 55);
            this.textoConta.Name = "textoConta";
            this.textoConta.Size = new System.Drawing.Size(143, 20);
            this.textoConta.TabIndex = 4;
            this.textoConta.TextChanged += new System.EventHandler(this.TextoConta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Escolha o que deseja fazer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome da Conta";
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 130);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoConta);
            this.Controls.Add(this.botaoConta);
            this.Controls.Add(this.botaoDeposito);
            this.Controls.Add(this.botaoSaque);
            this.Controls.Add(this.botaoSair);
            this.Name = "telaPrincipal";
            this.Text = "telaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.Button botaoConta;
        private System.Windows.Forms.TextBox textoConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}