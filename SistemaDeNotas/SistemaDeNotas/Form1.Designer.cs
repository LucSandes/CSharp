namespace SistemaDeNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.botaoLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoSair = new System.Windows.Forms.Button();
            this.botaoAlunos = new System.Windows.Forms.Button();
            this.botaoProfessores = new System.Windows.Forms.Button();
            this.botaoFuncionarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoLogin
            // 
            this.botaoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLogin.Location = new System.Drawing.Point(66, 144);
            this.botaoLogin.Name = "botaoLogin";
            this.botaoLogin.Size = new System.Drawing.Size(75, 23);
            this.botaoLogin.TabIndex = 0;
            this.botaoLogin.Text = "Login ADM";
            this.botaoLogin.UseVisualStyleBackColor = true;
            this.botaoLogin.Click += new System.EventHandler(this.BotaoLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Notas";
            // 
            // botaoSair
            // 
            this.botaoSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSair.Location = new System.Drawing.Point(174, 144);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(75, 23);
            this.botaoSair.TabIndex = 2;
            this.botaoSair.Text = "Sair";
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.BotaoSair_Click);
            // 
            // botaoAlunos
            // 
            this.botaoAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAlunos.Location = new System.Drawing.Point(12, 93);
            this.botaoAlunos.Name = "botaoAlunos";
            this.botaoAlunos.Size = new System.Drawing.Size(75, 23);
            this.botaoAlunos.TabIndex = 3;
            this.botaoAlunos.Text = "Alunos";
            this.botaoAlunos.UseVisualStyleBackColor = true;
            this.botaoAlunos.Click += new System.EventHandler(this.BotaoAlunos_Click);
            // 
            // botaoProfessores
            // 
            this.botaoProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoProfessores.Location = new System.Drawing.Point(114, 82);
            this.botaoProfessores.Name = "botaoProfessores";
            this.botaoProfessores.Size = new System.Drawing.Size(75, 45);
            this.botaoProfessores.TabIndex = 4;
            this.botaoProfessores.Text = "Professores e Direção";
            this.botaoProfessores.UseVisualStyleBackColor = true;
            this.botaoProfessores.Click += new System.EventHandler(this.BotaoProfessores_Click);
            // 
            // botaoFuncionarios
            // 
            this.botaoFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFuncionarios.Location = new System.Drawing.Point(208, 93);
            this.botaoFuncionarios.Name = "botaoFuncionarios";
            this.botaoFuncionarios.Size = new System.Drawing.Size(75, 23);
            this.botaoFuncionarios.TabIndex = 5;
            this.botaoFuncionarios.Text = "Funcionários";
            this.botaoFuncionarios.UseVisualStyleBackColor = true;
            this.botaoFuncionarios.Click += new System.EventHandler(this.BotaoFuncionarios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::SistemaDeNotas.Properties.Resources.tenor;
            this.ClientSize = new System.Drawing.Size(295, 189);
            this.Controls.Add(this.botaoFuncionarios);
            this.Controls.Add(this.botaoProfessores);
            this.Controls.Add(this.botaoAlunos);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button botaoAlunos;
        private System.Windows.Forms.Button botaoProfessores;
        private System.Windows.Forms.Button botaoFuncionarios;
    }
}

