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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
<<<<<<< HEAD
            this.painelMenuAdm = new System.Windows.Forms.Panel();
=======
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoSair
            // 
            this.botaoSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.botaoSair.Location = new System.Drawing.Point(14, 99);
=======
            this.botaoSair.Location = new System.Drawing.Point(7, 91);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(118, 23);
            this.botaoSair.TabIndex = 0;
            this.botaoSair.Text = "Fechar";
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.BotaoSair_Click);
            // 
            // botaoMedia
            // 
            this.botaoMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMedia.Location = new System.Drawing.Point(26, 35);
            this.botaoMedia.Name = "botaoMedia";
            this.botaoMedia.Size = new System.Drawing.Size(75, 51);
            this.botaoMedia.TabIndex = 1;
            this.botaoMedia.Text = "Calcular Média";
            this.botaoMedia.UseVisualStyleBackColor = true;
            this.botaoMedia.Click += new System.EventHandler(this.BotaoMedia_Click);
            // 
            // botaoTelaAlunos
            // 
            this.botaoTelaAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoTelaAlunos.Location = new System.Drawing.Point(168, 46);
            this.botaoTelaAlunos.Name = "botaoTelaAlunos";
            this.botaoTelaAlunos.Size = new System.Drawing.Size(74, 40);
            this.botaoTelaAlunos.TabIndex = 2;
            this.botaoTelaAlunos.Text = "Alunos";
            this.botaoTelaAlunos.UseVisualStyleBackColor = true;
            this.botaoTelaAlunos.Click += new System.EventHandler(this.botaoTelaAlunos_Click);
            // 
            // botaoTelaProfessores
            // 
            this.botaoTelaProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoTelaProfessores.Location = new System.Drawing.Point(299, 46);
            this.botaoTelaProfessores.Name = "botaoTelaProfessores";
            this.botaoTelaProfessores.Size = new System.Drawing.Size(85, 40);
            this.botaoTelaProfessores.TabIndex = 3;
            this.botaoTelaProfessores.Text = "Professores";
            this.botaoTelaProfessores.UseVisualStyleBackColor = true;
            this.botaoTelaProfessores.Click += new System.EventHandler(this.botaoTelaProfessores_Click);
            // 
            // botaoTelaDisciplinas
            // 
            this.botaoTelaDisciplinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoTelaDisciplinas.Location = new System.Drawing.Point(435, 46);
            this.botaoTelaDisciplinas.Name = "botaoTelaDisciplinas";
            this.botaoTelaDisciplinas.Size = new System.Drawing.Size(82, 40);
            this.botaoTelaDisciplinas.TabIndex = 4;
            this.botaoTelaDisciplinas.Text = "Disciplinas";
            this.botaoTelaDisciplinas.UseVisualStyleBackColor = true;
            this.botaoTelaDisciplinas.Click += new System.EventHandler(this.BotaoTelaDisciplinas_Click);
            // 
            // botaoTelaFuncionarios
            // 
            this.botaoTelaFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoTelaFuncionarios.Location = new System.Drawing.Point(581, 46);
            this.botaoTelaFuncionarios.Name = "botaoTelaFuncionarios";
            this.botaoTelaFuncionarios.Size = new System.Drawing.Size(90, 40);
            this.botaoTelaFuncionarios.TabIndex = 5;
            this.botaoTelaFuncionarios.Text = "Funcionários";
            this.botaoTelaFuncionarios.UseVisualStyleBackColor = true;
            this.botaoTelaFuncionarios.Click += new System.EventHandler(this.BotaoTelaFuncionarios_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoTelaFuncionarios);
            this.groupBox1.Controls.Add(this.botaoTelaDisciplinas);
            this.groupBox1.Controls.Add(this.botaoTelaProfessores);
            this.groupBox1.Controls.Add(this.botaoTelaAlunos);
            this.groupBox1.Controls.Add(this.botaoMedia);
            this.groupBox1.Controls.Add(this.botaoSair);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.groupBox1.Location = new System.Drawing.Point(103, 9);
=======
            this.groupBox1.Location = new System.Drawing.Point(103, 12);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 135);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha a acão:";
            // 
<<<<<<< HEAD
            // painelMenuAdm
            // 
            this.painelMenuAdm.Location = new System.Drawing.Point(12, 165);
            this.painelMenuAdm.Name = "painelMenuAdm";
            this.painelMenuAdm.Size = new System.Drawing.Size(882, 497);
            this.painelMenuAdm.TabIndex = 7;
            this.painelMenuAdm.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelMenuAdm_Paint);
            // 
=======
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            // telaMenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(905, 681);
            this.Controls.Add(this.painelMenuAdm);
=======
            this.ClientSize = new System.Drawing.Size(905, 159);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaMenuAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaMenu";
            this.Load += new System.EventHandler(this.TelaMenuAdm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button botaoMedia;
        private System.Windows.Forms.Button botaoTelaAlunos;
        private System.Windows.Forms.Button botaoTelaProfessores;
        private System.Windows.Forms.Button botaoTelaDisciplinas;
        private System.Windows.Forms.Button botaoTelaFuncionarios;
        private System.Windows.Forms.GroupBox groupBox1;
<<<<<<< HEAD
        private System.Windows.Forms.Panel painelMenuAdm;
=======
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
    }
}