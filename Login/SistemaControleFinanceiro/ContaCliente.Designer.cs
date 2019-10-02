namespace SistemaControleFinanceiro
{
    partial class ContaCliente
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
            this.textoNomeCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textoSaldoCC = new System.Windows.Forms.TextBox();
            this.boolEmprestimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textoCPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textoNomeCC
            // 
            this.textoNomeCC.Location = new System.Drawing.Point(87, 17);
            this.textoNomeCC.Name = "textoNomeCC";
            this.textoNomeCC.Size = new System.Drawing.Size(100, 20);
            this.textoNomeCC.TabIndex = 1;
            this.textoNomeCC.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saldo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pode pedir emprestimo?";
            // 
            // textoSaldoCC
            // 
            this.textoSaldoCC.Location = new System.Drawing.Point(87, 104);
            this.textoSaldoCC.Name = "textoSaldoCC";
            this.textoSaldoCC.Size = new System.Drawing.Size(100, 20);
            this.textoSaldoCC.TabIndex = 4;
            // 
            // boolEmprestimo
            // 
            this.boolEmprestimo.Location = new System.Drawing.Point(148, 150);
            this.boolEmprestimo.Name = "boolEmprestimo";
            this.boolEmprestimo.Size = new System.Drawing.Size(29, 20);
            this.boolEmprestimo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF:";
            // 
            // textoCPF
            // 
            this.textoCPF.Location = new System.Drawing.Point(87, 63);
            this.textoCPF.Name = "textoCPF";
            this.textoCPF.Size = new System.Drawing.Size(100, 20);
            this.textoCPF.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "R$";
            // 
            // ContaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 182);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textoCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boolEmprestimo);
            this.Controls.Add(this.textoSaldoCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoNomeCC);
            this.Controls.Add(this.label1);
            this.Name = "ContaCliente";
            this.Text = "ContaCliente";
            this.Load += new System.EventHandler(this.NotaALuno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoNomeCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoSaldoCC;
        private System.Windows.Forms.TextBox boolEmprestimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoCPF;
        private System.Windows.Forms.Label label5;
    }
}