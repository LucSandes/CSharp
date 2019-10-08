namespace JogoDaForca
{
    partial class formJogoDaForca
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
            this.painelJogo = new System.Windows.Forms.Panel();
            this.botaoStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textoPalavraSecreta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textoTotalTentativas = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tentativasRestantes = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.botaoOK = new System.Windows.Forms.Button();
            this.textoLetra = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textoDicas = new System.Windows.Forms.Label();
            this.painelGameOver = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.letrasDigitadas = new System.Windows.Forms.TextBox();
            this.painelJogo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.painelGameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelJogo
            // 
            this.painelJogo.Controls.Add(this.groupBox5);
            this.painelJogo.Controls.Add(this.groupBox4);
            this.painelJogo.Controls.Add(this.groupBox3);
            this.painelJogo.Controls.Add(this.groupBox2);
            this.painelJogo.Controls.Add(this.groupBox1);
            this.painelJogo.Controls.Add(this.textoPalavraSecreta);
            this.painelJogo.Controls.Add(this.label1);
            this.painelJogo.Location = new System.Drawing.Point(12, 12);
            this.painelJogo.Name = "painelJogo";
            this.painelJogo.Size = new System.Drawing.Size(761, 361);
            this.painelJogo.TabIndex = 0;
            this.painelJogo.Visible = false;
            this.painelJogo.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelJogo_Paint);
            // 
            // botaoStart
            // 
            this.botaoStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoStart.Location = new System.Drawing.Point(12, 379);
            this.botaoStart.Name = "botaoStart";
            this.botaoStart.Size = new System.Drawing.Size(761, 54);
            this.botaoStart.TabIndex = 1;
            this.botaoStart.Text = "Start";
            this.botaoStart.UseVisualStyleBackColor = true;
            this.botaoStart.Click += new System.EventHandler(this.BotaoStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifique a palavra:";
            // 
            // textoPalavraSecreta
            // 
            this.textoPalavraSecreta.Enabled = false;
            this.textoPalavraSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoPalavraSecreta.Location = new System.Drawing.Point(24, 46);
            this.textoPalavraSecreta.Name = "textoPalavraSecreta";
            this.textoPalavraSecreta.Size = new System.Drawing.Size(725, 31);
            this.textoPalavraSecreta.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textoTotalTentativas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(465, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total de Tentativas:";
            // 
            // textoTotalTentativas
            // 
            this.textoTotalTentativas.AutoSize = true;
            this.textoTotalTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTotalTentativas.Location = new System.Drawing.Point(126, 44);
            this.textoTotalTentativas.Name = "textoTotalTentativas";
            this.textoTotalTentativas.Size = new System.Drawing.Size(30, 31);
            this.textoTotalTentativas.TabIndex = 0;
            this.textoTotalTentativas.Text = "5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tentativasRestantes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(465, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tentativas restantes:";
            // 
            // tentativasRestantes
            // 
            this.tentativasRestantes.AutoSize = true;
            this.tentativasRestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tentativasRestantes.Location = new System.Drawing.Point(126, 44);
            this.tentativasRestantes.Name = "tentativasRestantes";
            this.tentativasRestantes.Size = new System.Drawing.Size(30, 31);
            this.tentativasRestantes.TabIndex = 0;
            this.tentativasRestantes.Text = "5";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textoLetra);
            this.groupBox3.Controls.Add(this.botaoOK);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(77, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 67);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Escolha uma letra:";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // botaoOK
            // 
            this.botaoOK.Location = new System.Drawing.Point(106, 31);
            this.botaoOK.Name = "botaoOK";
            this.botaoOK.Size = new System.Drawing.Size(75, 32);
            this.botaoOK.TabIndex = 0;
            this.botaoOK.Text = "OK";
            this.botaoOK.UseVisualStyleBackColor = true;
            this.botaoOK.Click += new System.EventHandler(this.BotaoOK_Click);
            // 
            // textoLetra
            // 
            this.textoLetra.Location = new System.Drawing.Point(15, 31);
            this.textoLetra.MaxLength = 1;
            this.textoLetra.Name = "textoLetra";
            this.textoLetra.Size = new System.Drawing.Size(68, 32);
            this.textoLetra.TabIndex = 1;
            this.textoLetra.TextChanged += new System.EventHandler(this.TextoLetra_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textoDicas);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(24, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(435, 94);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dicas:";
            // 
            // textoDicas
            // 
            this.textoDicas.AutoSize = true;
            this.textoDicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDicas.Location = new System.Drawing.Point(18, 45);
            this.textoDicas.Name = "textoDicas";
            this.textoDicas.Size = new System.Drawing.Size(323, 31);
            this.textoDicas.TabIndex = 0;
            this.textoDicas.Text = "Dica que será mostrada";
            // 
            // painelGameOver
            // 
            this.painelGameOver.Controls.Add(this.pictureBox1);
            this.painelGameOver.Location = new System.Drawing.Point(12, 461);
            this.painelGameOver.Name = "painelGameOver";
            this.painelGameOver.Size = new System.Drawing.Size(761, 361);
            this.painelGameOver.TabIndex = 5;
            this.painelGameOver.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JogoDaForca.Properties.Resources.gameover;
            this.pictureBox1.Location = new System.Drawing.Point(3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.letrasDigitadas);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(22, 222);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(437, 63);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Letras digitadas";
            // 
            // letrasDigitadas
            // 
            this.letrasDigitadas.Enabled = false;
            this.letrasDigitadas.Location = new System.Drawing.Point(6, 25);
            this.letrasDigitadas.Name = "letrasDigitadas";
            this.letrasDigitadas.Size = new System.Drawing.Size(425, 32);
            this.letrasDigitadas.TabIndex = 0;
            // 
            // formJogoDaForca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 834);
            this.Controls.Add(this.painelGameOver);
            this.Controls.Add(this.botaoStart);
            this.Controls.Add(this.painelJogo);
            this.Name = "formJogoDaForca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Forca";
            this.painelJogo.ResumeLayout(false);
            this.painelJogo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.painelGameOver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelJogo;
        private System.Windows.Forms.Button botaoStart;
        private System.Windows.Forms.TextBox textoPalavraSecreta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textoLetra;
        private System.Windows.Forms.Button botaoOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label tentativasRestantes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label textoTotalTentativas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label textoDicas;
        private System.Windows.Forms.Panel painelGameOver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox letrasDigitadas;
    }
}

