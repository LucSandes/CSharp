namespace SistemaDeNotas
{
    partial class telaLoginAlunos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textoRa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoSenhaAluno = new System.Windows.Forms.TextBox();
            this.botaoLoginAluno = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "LOGIN ALUNOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "RA";
            // 
            // textoRa
            // 
            this.textoRa.ForeColor = System.Drawing.Color.Black;
            this.textoRa.Location = new System.Drawing.Point(63, 70);
            this.textoRa.Name = "textoRa";
            this.textoRa.Size = new System.Drawing.Size(111, 20);
            this.textoRa.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Senha";
            // 
            // textoSenhaAluno
            // 
            this.textoSenhaAluno.ForeColor = System.Drawing.Color.Black;
            this.textoSenhaAluno.Location = new System.Drawing.Point(63, 105);
            this.textoSenhaAluno.Name = "textoSenhaAluno";
            this.textoSenhaAluno.Size = new System.Drawing.Size(111, 20);
            this.textoSenhaAluno.TabIndex = 15;
            this.textoSenhaAluno.TextChanged += new System.EventHandler(this.TextoSenhaAluno_TextChanged);
            // 
            // botaoLoginAluno
            // 
            this.botaoLoginAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLoginAluno.ForeColor = System.Drawing.Color.Black;
            this.botaoLoginAluno.Location = new System.Drawing.Point(99, 154);
            this.botaoLoginAluno.Name = "botaoLoginAluno";
            this.botaoLoginAluno.Size = new System.Drawing.Size(75, 23);
            this.botaoLoginAluno.TabIndex = 16;
            this.botaoLoginAluno.Text = "Login";
            this.botaoLoginAluno.UseVisualStyleBackColor = true;
            this.botaoLoginAluno.Click += new System.EventHandler(this.botaoLoginAluno_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(12, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // telaLoginAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(212, 200);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botaoLoginAluno);
            this.Controls.Add(this.textoSenhaAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoRa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaLoginAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaLoginAlunos";
            this.Load += new System.EventHandler(this.TelaLoginAlunos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoRa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoSenhaAluno;
        private System.Windows.Forms.Button botaoLoginAluno;
        private System.Windows.Forms.Button button2;
    }
}