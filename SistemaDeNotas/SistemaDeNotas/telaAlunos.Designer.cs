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
            System.Windows.Forms.TextBox textoCidadeAluno;
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.botaoPesquisarAluno = new System.Windows.Forms.Button();
            this.botaoAdicionarAluno = new System.Windows.Forms.Button();
            this.botaoAlterarAluno = new System.Windows.Forms.Button();
            this.botaoExcluirAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoLimparAluno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textoNomeAluno = new System.Windows.Forms.TextBox();
            this.textoDataNascimentoAluno = new System.Windows.Forms.TextBox();
            this.textoEnderecoAluno = new System.Windows.Forms.TextBox();
            this.textoTelefoneAluno = new System.Windows.Forms.TextBox();
            this.textoEmailAluno = new System.Windows.Forms.TextBox();
            this.textoCursoAluno = new System.Windows.Forms.TextBox();
            this.textoCpfAluno = new System.Windows.Forms.TextBox();
            this.textoEstadoAluno = new System.Windows.Forms.TextBox();
            this.textoDataMatriculaAluno = new System.Windows.Forms.TextBox();
            this.textoRegistroAluno = new System.Windows.Forms.TextBox();
            this.grupoDados = new System.Windows.Forms.GroupBox();
            this.comboAlunos = new System.Windows.Forms.ComboBox();
            textoCidadeAluno = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grupoDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoCidadeAluno
            // 
            textoCidadeAluno.Location = new System.Drawing.Point(432, 50);
            textoCidadeAluno.Name = "textoCidadeAluno";
            textoCidadeAluno.Size = new System.Drawing.Size(272, 20);
            textoCidadeAluno.TabIndex = 26;
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Location = new System.Drawing.Point(13, 13);
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
            this.botaoPesquisarAluno.Location = new System.Drawing.Point(555, 14);
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
            this.botaoAdicionarAluno.Location = new System.Drawing.Point(58, 19);
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
            this.label1.Location = new System.Drawing.Point(105, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do Aluno:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.botaoLimparAluno);
            this.groupBox1.Controls.Add(this.botaoExcluirAluno);
            this.groupBox1.Controls.Add(this.botaoAlterarAluno);
            this.groupBox1.Controls.Add(this.botaoAdicionarAluno);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 57);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "E - mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Curso:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(383, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "CPF:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(383, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(383, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Estado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(383, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Data de Matrícula:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(383, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "RA:";
            // 
            // textoNomeAluno
            // 
            this.textoNomeAluno.Location = new System.Drawing.Point(58, 19);
            this.textoNomeAluno.Name = "textoNomeAluno";
            this.textoNomeAluno.Size = new System.Drawing.Size(319, 20);
            this.textoNomeAluno.TabIndex = 19;
            // 
            // textoDataNascimentoAluno
            // 
            this.textoDataNascimentoAluno.Location = new System.Drawing.Point(146, 50);
            this.textoDataNascimentoAluno.Name = "textoDataNascimentoAluno";
            this.textoDataNascimentoAluno.Size = new System.Drawing.Size(231, 20);
            this.textoDataNascimentoAluno.TabIndex = 20;
            // 
            // textoEnderecoAluno
            // 
            this.textoEnderecoAluno.Location = new System.Drawing.Point(76, 79);
            this.textoEnderecoAluno.Name = "textoEnderecoAluno";
            this.textoEnderecoAluno.Size = new System.Drawing.Size(301, 20);
            this.textoEnderecoAluno.TabIndex = 21;
            // 
            // textoTelefoneAluno
            // 
            this.textoTelefoneAluno.Location = new System.Drawing.Point(81, 111);
            this.textoTelefoneAluno.Name = "textoTelefoneAluno";
            this.textoTelefoneAluno.Size = new System.Drawing.Size(296, 20);
            this.textoTelefoneAluno.TabIndex = 22;
            this.textoTelefoneAluno.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // textoEmailAluno
            // 
            this.textoEmailAluno.Location = new System.Drawing.Point(73, 143);
            this.textoEmailAluno.Name = "textoEmailAluno";
            this.textoEmailAluno.Size = new System.Drawing.Size(304, 20);
            this.textoEmailAluno.TabIndex = 23;
            // 
            // textoCursoAluno
            // 
            this.textoCursoAluno.Location = new System.Drawing.Point(58, 170);
            this.textoCursoAluno.Name = "textoCursoAluno";
            this.textoCursoAluno.Size = new System.Drawing.Size(319, 20);
            this.textoCursoAluno.TabIndex = 24;
            // 
            // textoCpfAluno
            // 
            this.textoCpfAluno.Location = new System.Drawing.Point(417, 19);
            this.textoCpfAluno.Name = "textoCpfAluno";
            this.textoCpfAluno.Size = new System.Drawing.Size(287, 20);
            this.textoCpfAluno.TabIndex = 25;
            // 
            // textoEstadoAluno
            // 
            this.textoEstadoAluno.Location = new System.Drawing.Point(432, 79);
            this.textoEstadoAluno.Name = "textoEstadoAluno";
            this.textoEstadoAluno.Size = new System.Drawing.Size(272, 20);
            this.textoEstadoAluno.TabIndex = 27;
            // 
            // textoDataMatriculaAluno
            // 
            this.textoDataMatriculaAluno.Location = new System.Drawing.Point(503, 111);
            this.textoDataMatriculaAluno.Name = "textoDataMatriculaAluno";
            this.textoDataMatriculaAluno.Size = new System.Drawing.Size(201, 20);
            this.textoDataMatriculaAluno.TabIndex = 28;
            this.textoDataMatriculaAluno.TextChanged += new System.EventHandler(this.TextBox11_TextChanged);
            // 
            // textoRegistroAluno
            // 
            this.textoRegistroAluno.Location = new System.Drawing.Point(417, 143);
            this.textoRegistroAluno.Name = "textoRegistroAluno";
            this.textoRegistroAluno.Size = new System.Drawing.Size(287, 20);
            this.textoRegistroAluno.TabIndex = 29;
            // 
            // grupoDados
            // 
            this.grupoDados.Controls.Add(this.textoRegistroAluno);
            this.grupoDados.Controls.Add(this.textoDataMatriculaAluno);
            this.grupoDados.Controls.Add(this.textoEstadoAluno);
            this.grupoDados.Controls.Add(textoCidadeAluno);
            this.grupoDados.Controls.Add(this.textoCpfAluno);
            this.grupoDados.Controls.Add(this.textoCursoAluno);
            this.grupoDados.Controls.Add(this.textoEmailAluno);
            this.grupoDados.Controls.Add(this.textoTelefoneAluno);
            this.grupoDados.Controls.Add(this.textoEnderecoAluno);
            this.grupoDados.Controls.Add(this.textoDataNascimentoAluno);
            this.grupoDados.Controls.Add(this.textoNomeAluno);
            this.grupoDados.Controls.Add(this.label12);
            this.grupoDados.Controls.Add(this.label11);
            this.grupoDados.Controls.Add(this.label10);
            this.grupoDados.Controls.Add(this.label9);
            this.grupoDados.Controls.Add(this.label8);
            this.grupoDados.Controls.Add(this.label7);
            this.grupoDados.Controls.Add(this.label6);
            this.grupoDados.Controls.Add(this.label5);
            this.grupoDados.Controls.Add(this.label4);
            this.grupoDados.Controls.Add(this.label3);
            this.grupoDados.Controls.Add(this.label2);
            this.grupoDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoDados.ForeColor = System.Drawing.Color.White;
            this.grupoDados.Location = new System.Drawing.Point(13, 102);
            this.grupoDados.Name = "grupoDados";
            this.grupoDados.Size = new System.Drawing.Size(721, 204);
            this.grupoDados.TabIndex = 31;
            this.grupoDados.TabStop = false;
            this.grupoDados.Text = "Dados";
            this.grupoDados.Enter += new System.EventHandler(this.GrupoDados_Enter);
            // 
            // comboAlunos
            // 
            this.comboAlunos.FormattingEnabled = true;
            this.comboAlunos.Location = new System.Drawing.Point(208, 16);
            this.comboAlunos.Name = "comboAlunos";
            this.comboAlunos.Size = new System.Drawing.Size(326, 21);
            this.comboAlunos.TabIndex = 32;
            // 
            // telaAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(747, 346);
            this.Controls.Add(this.comboAlunos);
            this.Controls.Add(this.grupoDados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoPesquisarAluno);
            this.Controls.Add(this.botaoVoltar);
            this.Name = "telaAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaAlunos";
            this.Load += new System.EventHandler(this.TelaAlunos_Load);
            this.groupBox1.ResumeLayout(false);
            this.grupoDados.ResumeLayout(false);
            this.grupoDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Button botaoPesquisarAluno;
        private System.Windows.Forms.Button botaoAdicionarAluno;
        private System.Windows.Forms.Button botaoAlterarAluno;
        private System.Windows.Forms.Button botaoExcluirAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textoNomeAluno;
        private System.Windows.Forms.TextBox textoDataNascimentoAluno;
        private System.Windows.Forms.TextBox textoEnderecoAluno;
        private System.Windows.Forms.TextBox textoTelefoneAluno;
        private System.Windows.Forms.TextBox textoEmailAluno;
        private System.Windows.Forms.TextBox textoCursoAluno;
        private System.Windows.Forms.TextBox textoCpfAluno;
        private System.Windows.Forms.TextBox textoEstadoAluno;
        private System.Windows.Forms.TextBox textoDataMatriculaAluno;
        private System.Windows.Forms.TextBox textoRegistroAluno;
        private System.Windows.Forms.Button botaoLimparAluno;
        private System.Windows.Forms.GroupBox grupoDados;
        private System.Windows.Forms.ComboBox comboAlunos;
    }
}