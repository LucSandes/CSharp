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
            this.label1 = new System.Windows.Forms.Label();
            this.botaoSair = new System.Windows.Forms.Button();
            this.botaoAlunos = new System.Windows.Forms.Button();
            this.botaoProfessores = new System.Windows.Forms.Button();
            this.botaoFuncionarios = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Notas";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // botaoSair
            // 
            this.botaoSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSair.Location = new System.Drawing.Point(345, 93);
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
            this.botaoProfessores.Location = new System.Drawing.Point(124, 82);
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
            this.botaoFuncionarios.Location = new System.Drawing.Point(234, 93);
            this.botaoFuncionarios.Name = "botaoFuncionarios";
            this.botaoFuncionarios.Size = new System.Drawing.Size(75, 23);
            this.botaoFuncionarios.TabIndex = 5;
            this.botaoFuncionarios.Text = "Funcionários";
            this.botaoFuncionarios.UseVisualStyleBackColor = true;
            this.botaoFuncionarios.Click += new System.EventHandler(this.BotaoFuncionarios_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaDeNotas.Properties.Resources.keys_icon;
            this.pictureBox2.Location = new System.Drawing.Point(357, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaDeNotas.Properties.Resources.korganizer_icon;
            this.pictureBox1.Location = new System.Drawing.Point(262, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(433, 140);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botaoFuncionarios);
            this.Controls.Add(this.botaoProfessores);
            this.Controls.Add(this.botaoAlunos);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button botaoAlunos;
        private System.Windows.Forms.Button botaoProfessores;
        private System.Windows.Forms.Button botaoFuncionarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

