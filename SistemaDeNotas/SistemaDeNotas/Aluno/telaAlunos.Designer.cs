namespace SistemaDeNotas
{
    partial class telaAlunos
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
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.botaoPesquisarAluno = new System.Windows.Forms.Button();
            this.botaoAdicionarAluno = new System.Windows.Forms.Button();
            this.botaoAlterarAluno = new System.Windows.Forms.Button();
            this.botaoExcluirAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoLimparAluno = new System.Windows.Forms.Button();
            this.comboAlunos = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.ForeColor = System.Drawing.Color.Black;
            this.botaoVoltar.Location = new System.Drawing.Point(17, 84);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(75, 23);
            this.botaoVoltar.TabIndex = 0;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.BotaoVoltar_Click);
            // 
            // botaoPesquisarAluno
            // 
            this.botaoPesquisarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisarAluno.ForeColor = System.Drawing.Color.Black;
            this.botaoPesquisarAluno.Location = new System.Drawing.Point(558, 84);
            this.botaoPesquisarAluno.Name = "botaoPesquisarAluno";
            this.botaoPesquisarAluno.Size = new System.Drawing.Size(75, 23);
            this.botaoPesquisarAluno.TabIndex = 1;
            this.botaoPesquisarAluno.Text = "Pesquisar";
            this.botaoPesquisarAluno.UseVisualStyleBackColor = true;
            this.botaoPesquisarAluno.Click += new System.EventHandler(this.BotaoPesquisarAluno_Click);
            // 
            // botaoAdicionarAluno
            // 
            this.botaoAdicionarAluno.ForeColor = System.Drawing.Color.Black;
            this.botaoAdicionarAluno.Location = new System.Drawing.Point(62, 19);
            this.botaoAdicionarAluno.Name = "botaoAdicionarAluno";
            this.botaoAdicionarAluno.Size = new System.Drawing.Size(75, 23);
            this.botaoAdicionarAluno.TabIndex = 3;
            this.botaoAdicionarAluno.Text = "Adicionar";
            this.botaoAdicionarAluno.UseVisualStyleBackColor = true;
            this.botaoAdicionarAluno.Click += new System.EventHandler(this.BotaoAdicionarAluno_Click);
            // 
            // botaoAlterarAluno
            // 
            this.botaoAlterarAluno.ForeColor = System.Drawing.Color.Black;
            this.botaoAlterarAluno.Location = new System.Drawing.Point(206, 19);
            this.botaoAlterarAluno.Name = "botaoAlterarAluno";
            this.botaoAlterarAluno.Size = new System.Drawing.Size(75, 23);
            this.botaoAlterarAluno.TabIndex = 4;
            this.botaoAlterarAluno.Text = "Alterar";
            this.botaoAlterarAluno.UseVisualStyleBackColor = true;
            this.botaoAlterarAluno.Click += new System.EventHandler(this.BotaoAlterarAluno_Click);
            // 
            // botaoExcluirAluno
            // 
            this.botaoExcluirAluno.ForeColor = System.Drawing.Color.Black;
            this.botaoExcluirAluno.Location = new System.Drawing.Point(374, 19);
            this.botaoExcluirAluno.Name = "botaoExcluirAluno";
            this.botaoExcluirAluno.Size = new System.Drawing.Size(75, 23);
            this.botaoExcluirAluno.TabIndex = 5;
            this.botaoExcluirAluno.Text = "Excluir";
            this.botaoExcluirAluno.UseVisualStyleBackColor = true;
            this.botaoExcluirAluno.Click += new System.EventHandler(this.botaoExcluirAluno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do Aluno:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.comboAlunos);
            this.groupBox1.Controls.Add(this.botaoVoltar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.botaoLimparAluno);
            this.groupBox1.Controls.Add(this.botaoPesquisarAluno);
            this.groupBox1.Controls.Add(this.botaoExcluirAluno);
            this.groupBox1.Controls.Add(this.botaoAlterarAluno);
            this.groupBox1.Controls.Add(this.botaoAdicionarAluno);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha a acão:";
            // 
            // botaoLimparAluno
            // 
            this.botaoLimparAluno.ForeColor = System.Drawing.Color.Black;
            this.botaoLimparAluno.Location = new System.Drawing.Point(520, 19);
            this.botaoLimparAluno.Name = "botaoLimparAluno";
            this.botaoLimparAluno.Size = new System.Drawing.Size(113, 23);
            this.botaoLimparAluno.TabIndex = 6;
            this.botaoLimparAluno.Text = "Limpar Campos";
            this.botaoLimparAluno.UseVisualStyleBackColor = true;
            this.botaoLimparAluno.Click += new System.EventHandler(this.BotaoLimparAluno_Click);
            // 
            // comboAlunos
            // 
            this.comboAlunos.FormattingEnabled = true;
            this.comboAlunos.Location = new System.Drawing.Point(206, 86);
            this.comboAlunos.Name = "comboAlunos";
            this.comboAlunos.Size = new System.Drawing.Size(326, 21);
            this.comboAlunos.TabIndex = 32;
            this.comboAlunos.SelectedIndexChanged += new System.EventHandler(this.ComboAlunos_SelectedIndexChanged);
            // 
            // telaAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(747, 157);
            this.Controls.Add(this.groupBox1);
            this.Name = "telaAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaAlunos";
            this.Load += new System.EventHandler(this.TelaAlunos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Button botaoPesquisarAluno;
        private System.Windows.Forms.Button botaoAdicionarAluno;
        private System.Windows.Forms.Button botaoAlterarAluno;
        private System.Windows.Forms.Button botaoExcluirAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoLimparAluno;
        private System.Windows.Forms.ComboBox comboAlunos;
    }
}