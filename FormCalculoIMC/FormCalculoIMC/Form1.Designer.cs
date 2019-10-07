namespace FormCalculoIMC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoPeso = new System.Windows.Forms.TextBox();
            this.labelIMC = new System.Windows.Forms.Label();
            this.labelSituacao = new System.Windows.Forms.Label();
            this.calculoIMC = new System.Windows.Forms.Button();
            this.botaoSair = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textoAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura:";
            // 
            // textoPeso
            // 
            this.textoPeso.Location = new System.Drawing.Point(67, 33);
            this.textoPeso.Name = "textoPeso";
            this.textoPeso.Size = new System.Drawing.Size(100, 20);
            this.textoPeso.TabIndex = 2;
            // 
            // labelIMC
            // 
            this.labelIMC.AutoSize = true;
            this.labelIMC.Location = new System.Drawing.Point(300, 36);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(0, 13);
            this.labelIMC.TabIndex = 6;
            // 
            // labelSituacao
            // 
            this.labelSituacao.AutoSize = true;
            this.labelSituacao.Location = new System.Drawing.Point(300, 75);
            this.labelSituacao.Name = "labelSituacao";
            this.labelSituacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSituacao.Size = new System.Drawing.Size(0, 13);
            this.labelSituacao.TabIndex = 7;
            // 
            // calculoIMC
            // 
            this.calculoIMC.Location = new System.Drawing.Point(92, 121);
            this.calculoIMC.Name = "calculoIMC";
            this.calculoIMC.Size = new System.Drawing.Size(75, 23);
            this.calculoIMC.TabIndex = 8;
            this.calculoIMC.Text = "Calcular";
            this.calculoIMC.UseVisualStyleBackColor = true;
            this.calculoIMC.Click += new System.EventHandler(this.CalculoIMC_Click);
            // 
            // botaoSair
            // 
            this.botaoSair.Location = new System.Drawing.Point(249, 121);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(75, 23);
            this.botaoSair.TabIndex = 9;
            this.botaoSair.Text = "Sair";
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.BotaoSair_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Situação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IMC:";
            // 
            // textoAltura
            // 
            this.textoAltura.Location = new System.Drawing.Point(67, 75);
            this.textoAltura.Name = "textoAltura";
            this.textoAltura.Size = new System.Drawing.Size(100, 20);
            this.textoAltura.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 168);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.calculoIMC);
            this.Controls.Add(this.labelSituacao);
            this.Controls.Add(this.labelIMC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoAltura);
            this.Controls.Add(this.textoPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoPeso;
        private System.Windows.Forms.Label labelIMC;
        private System.Windows.Forms.Label labelSituacao;
        private System.Windows.Forms.Button calculoIMC;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoAltura;
    }
}

