namespace SistemaDeNotas
{
    partial class telaMenuAdm
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
            this.botaoMedia = new System.Windows.Forms.Button();
            this.botaoTelaAlunos = new System.Windows.Forms.Button();
            this.botaoTelaProfessores = new System.Windows.Forms.Button();
            this.botaoTelaDisciplinas = new System.Windows.Forms.Button();
            this.botaoTelaFuncionarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoSair
            // 
            this.botaoSair.Location = new System.Drawing.Point(202, 83);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(91, 23);
            this.botaoSair.TabIndex = 0;
            this.botaoSair.Text = "Voltar pro Login";
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.BotaoSair_Click);
            // 
            // botaoMedia
            // 
            this.botaoMedia.Location = new System.Drawing.Point(409, 22);
            this.botaoMedia.Name = "botaoMedia";
            this.botaoMedia.Size = new System.Drawing.Size(75, 51);
            this.botaoMedia.TabIndex = 1;
            this.botaoMedia.Text = "Calcular Média";
            this.botaoMedia.UseVisualStyleBackColor = true;
            this.botaoMedia.Click += new System.EventHandler(this.BotaoMedia_Click);
            // 
            // botaoTelaAlunos
            // 
            this.botaoTelaAlunos.Location = new System.Drawing.Point(7, 36);
            this.botaoTelaAlunos.Name = "botaoTelaAlunos";
            this.botaoTelaAlunos.Size = new System.Drawing.Size(75, 23);
            this.botaoTelaAlunos.TabIndex = 2;
            this.botaoTelaAlunos.Text = "Alunos";
            this.botaoTelaAlunos.UseVisualStyleBackColor = true;
            this.botaoTelaAlunos.Click += new System.EventHandler(this.botaoTelaAlunos_Click);
            // 
            // botaoTelaProfessores
            // 
            this.botaoTelaProfessores.Location = new System.Drawing.Point(111, 36);
            this.botaoTelaProfessores.Name = "botaoTelaProfessores";
            this.botaoTelaProfessores.Size = new System.Drawing.Size(75, 23);
            this.botaoTelaProfessores.TabIndex = 3;
            this.botaoTelaProfessores.Text = "Professores";
            this.botaoTelaProfessores.UseVisualStyleBackColor = true;
            this.botaoTelaProfessores.Click += new System.EventHandler(this.botaoTelaProfessores_Click);
            // 
            // botaoTelaDisciplinas
            // 
            this.botaoTelaDisciplinas.Location = new System.Drawing.Point(218, 36);
            this.botaoTelaDisciplinas.Name = "botaoTelaDisciplinas";
            this.botaoTelaDisciplinas.Size = new System.Drawing.Size(75, 23);
            this.botaoTelaDisciplinas.TabIndex = 4;
            this.botaoTelaDisciplinas.Text = "Disciplinas";
            this.botaoTelaDisciplinas.UseVisualStyleBackColor = true;
            this.botaoTelaDisciplinas.Click += new System.EventHandler(this.BotaoTelaDisciplinas_Click);
            // 
            // botaoTelaFuncionarios
            // 
            this.botaoTelaFuncionarios.Location = new System.Drawing.Point(313, 36);
            this.botaoTelaFuncionarios.Name = "botaoTelaFuncionarios";
            this.botaoTelaFuncionarios.Size = new System.Drawing.Size(75, 23);
            this.botaoTelaFuncionarios.TabIndex = 5;
            this.botaoTelaFuncionarios.Text = "Funcionários";
            this.botaoTelaFuncionarios.UseVisualStyleBackColor = true;
            this.botaoTelaFuncionarios.Click += new System.EventHandler(this.BotaoTelaFuncionarios_Click);
            // 
            // telaMenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(501, 121);
            this.Controls.Add(this.botaoTelaFuncionarios);
            this.Controls.Add(this.botaoTelaDisciplinas);
            this.Controls.Add(this.botaoTelaProfessores);
            this.Controls.Add(this.botaoTelaAlunos);
            this.Controls.Add(this.botaoMedia);
            this.Controls.Add(this.botaoSair);
            this.Name = "telaMenuAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button botaoMedia;
        private System.Windows.Forms.Button botaoTelaAlunos;
        private System.Windows.Forms.Button botaoTelaProfessores;
        private System.Windows.Forms.Button botaoTelaDisciplinas;
        private System.Windows.Forms.Button botaoTelaFuncionarios;
    }
}