namespace SistemaDeNotas.Aluno
{
    partial class telaMenuAluno
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
            this.botaoMedia = new System.Windows.Forms.Button();
            this.comboCursos = new System.Windows.Forms.ComboBox();
            this.botaoPesquisarCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboProfessores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // botaoMedia
            // 
            this.botaoMedia.Location = new System.Drawing.Point(669, 12);
            this.botaoMedia.Name = "botaoMedia";
            this.botaoMedia.Size = new System.Drawing.Size(75, 51);
            this.botaoMedia.TabIndex = 2;
            this.botaoMedia.Text = "Calcular Média";
            this.botaoMedia.UseVisualStyleBackColor = true;
            this.botaoMedia.Click += new System.EventHandler(this.BotaoMedia_Click);
            // 
            // comboCursos
            // 
            this.comboCursos.FormattingEnabled = true;
            this.comboCursos.Location = new System.Drawing.Point(63, 61);
            this.comboCursos.Name = "comboCursos";
            this.comboCursos.Size = new System.Drawing.Size(219, 21);
            this.comboCursos.TabIndex = 3;
            // 
            // botaoPesquisarCurso
            // 
            this.botaoPesquisarCurso.Location = new System.Drawing.Point(293, 61);
            this.botaoPesquisarCurso.Name = "botaoPesquisarCurso";
            this.botaoPesquisarCurso.Size = new System.Drawing.Size(75, 23);
            this.botaoPesquisarCurso.TabIndex = 4;
            this.botaoPesquisarCurso.Text = "Pesquisar Curso";
            this.botaoPesquisarCurso.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cursos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Professores:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pesquisar Curso";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboProfessores
            // 
            this.comboProfessores.FormattingEnabled = true;
            this.comboProfessores.Location = new System.Drawing.Point(94, 107);
            this.comboProfessores.Name = "comboProfessores";
            this.comboProfessores.Size = new System.Drawing.Size(188, 21);
            this.comboProfessores.TabIndex = 6;
            // 
            // telaMenuAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(756, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboProfessores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoPesquisarCurso);
            this.Controls.Add(this.comboCursos);
            this.Controls.Add(this.botaoMedia);
            this.Name = "telaMenuAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaMenuAluno";
            this.Load += new System.EventHandler(this.TelaMenuAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoMedia;
        private System.Windows.Forms.ComboBox comboCursos;
        private System.Windows.Forms.Button botaoPesquisarCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboProfessores;
    }
}