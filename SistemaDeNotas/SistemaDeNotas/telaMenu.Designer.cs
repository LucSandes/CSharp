namespace SistemaDeNotas
{
    partial class telaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaMenu));
            this.botaoSair = new System.Windows.Forms.Button();
            this.botaoMedia = new System.Windows.Forms.Button();
            this.botaoAlunos = new System.Windows.Forms.Button();
            this.botaoProfessores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoSair
            // 
            this.botaoSair.Location = new System.Drawing.Point(161, 104);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(75, 23);
            this.botaoSair.TabIndex = 0;
            this.botaoSair.Text = "Sair";
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.BotaoSair_Click);
            // 
            // botaoMedia
            // 
            this.botaoMedia.Location = new System.Drawing.Point(321, 42);
            this.botaoMedia.Name = "botaoMedia";
            this.botaoMedia.Size = new System.Drawing.Size(75, 51);
            this.botaoMedia.TabIndex = 1;
            this.botaoMedia.Text = "Calcular Média";
            this.botaoMedia.UseVisualStyleBackColor = true;
            this.botaoMedia.Click += new System.EventHandler(this.BotaoMedia_Click);
            // 
            // botaoAlunos
            // 
            this.botaoAlunos.Location = new System.Drawing.Point(12, 56);
            this.botaoAlunos.Name = "botaoAlunos";
            this.botaoAlunos.Size = new System.Drawing.Size(75, 23);
            this.botaoAlunos.TabIndex = 2;
            this.botaoAlunos.Text = "Alunos";
            this.botaoAlunos.UseVisualStyleBackColor = true;
            this.botaoAlunos.Click += new System.EventHandler(this.BotaoAlunos_Click);
            // 
            // botaoProfessores
            // 
            this.botaoProfessores.Location = new System.Drawing.Point(116, 56);
            this.botaoProfessores.Name = "botaoProfessores";
            this.botaoProfessores.Size = new System.Drawing.Size(75, 23);
            this.botaoProfessores.TabIndex = 3;
            this.botaoProfessores.Text = "Professores";
            this.botaoProfessores.UseVisualStyleBackColor = true;
            this.botaoProfessores.Click += new System.EventHandler(this.BotaoProfessores_Click);
            // 
            // telaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(408, 139);
            this.Controls.Add(this.botaoProfessores);
            this.Controls.Add(this.botaoAlunos);
            this.Controls.Add(this.botaoMedia);
            this.Controls.Add(this.botaoSair);
            this.Name = "telaMenu";
            this.Text = "telaMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button botaoMedia;
        private System.Windows.Forms.Button botaoAlunos;
        private System.Windows.Forms.Button botaoProfessores;
    }
}