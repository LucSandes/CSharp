namespace CShp_MAC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnIncluirDados = new System.Windows.Forms.Button();
            this.btnLocalizarDados = new System.Windows.Forms.Button();
            this.btnExibirDados = new System.Windows.Forms.Button();
            this.btnExcluirDados = new System.Windows.Forms.Button();
            this.btnCriarTabela = new System.Windows.Forms.Button();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.btnCriarBancoDados = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 437);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 278);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(70, 395);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(348, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(70, 367);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(348, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(70, 338);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(108, 20);
            this.txtID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEncerrar);
            this.panel2.Controls.Add(this.btnIncluirDados);
            this.panel2.Controls.Add(this.btnLocalizarDados);
            this.panel2.Controls.Add(this.btnExibirDados);
            this.panel2.Controls.Add(this.btnExcluirDados);
            this.panel2.Controls.Add(this.btnCriarTabela);
            this.panel2.Controls.Add(this.btnAtualizarDados);
            this.panel2.Controls.Add(this.btnCriarBancoDados);
            this.panel2.Location = new System.Drawing.Point(12, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 191);
            this.panel2.TabIndex = 1;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(594, 111);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(91, 65);
            this.btnEncerrar.TabIndex = 7;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.BtnEncerrar_Click);
            // 
            // btnIncluirDados
            // 
            this.btnIncluirDados.Location = new System.Drawing.Point(594, 26);
            this.btnIncluirDados.Name = "btnIncluirDados";
            this.btnIncluirDados.Size = new System.Drawing.Size(91, 65);
            this.btnIncluirDados.TabIndex = 6;
            this.btnIncluirDados.Text = "Incluir Dados";
            this.btnIncluirDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluirDados.UseVisualStyleBackColor = true;
            this.btnIncluirDados.Click += new System.EventHandler(this.btnIncluirDados_Click);
            // 
            // btnLocalizarDados
            // 
            this.btnLocalizarDados.Location = new System.Drawing.Point(413, 111);
            this.btnLocalizarDados.Name = "btnLocalizarDados";
            this.btnLocalizarDados.Size = new System.Drawing.Size(91, 65);
            this.btnLocalizarDados.TabIndex = 5;
            this.btnLocalizarDados.Text = "Localizar Dados";
            this.btnLocalizarDados.UseVisualStyleBackColor = true;
            this.btnLocalizarDados.Click += new System.EventHandler(this.BtnLocalizarDados_Click);
            // 
            // btnExibirDados
            // 
            this.btnExibirDados.Location = new System.Drawing.Point(413, 26);
            this.btnExibirDados.Name = "btnExibirDados";
            this.btnExibirDados.Size = new System.Drawing.Size(91, 65);
            this.btnExibirDados.TabIndex = 4;
            this.btnExibirDados.Text = "Exibir Dados";
            this.btnExibirDados.UseVisualStyleBackColor = true;
            this.btnExibirDados.Click += new System.EventHandler(this.BtnExibirDados_Click);
            // 
            // btnExcluirDados
            // 
            this.btnExcluirDados.Location = new System.Drawing.Point(207, 111);
            this.btnExcluirDados.Name = "btnExcluirDados";
            this.btnExcluirDados.Size = new System.Drawing.Size(91, 65);
            this.btnExcluirDados.TabIndex = 3;
            this.btnExcluirDados.Text = "Excluir Dados";
            this.btnExcluirDados.UseVisualStyleBackColor = true;
            this.btnExcluirDados.Click += new System.EventHandler(this.BtnExcluirDados_Click);
            // 
            // btnCriarTabela
            // 
            this.btnCriarTabela.Location = new System.Drawing.Point(207, 26);
            this.btnCriarTabela.Name = "btnCriarTabela";
            this.btnCriarTabela.Size = new System.Drawing.Size(91, 65);
            this.btnCriarTabela.TabIndex = 2;
            this.btnCriarTabela.Text = "Criar Tabela";
            this.btnCriarTabela.UseVisualStyleBackColor = true;
            this.btnCriarTabela.Click += new System.EventHandler(this.BtnCriarTabela_Click);
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.Location = new System.Drawing.Point(23, 111);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(91, 65);
            this.btnAtualizarDados.TabIndex = 1;
            this.btnAtualizarDados.Text = "Atualizar Dados";
            this.btnAtualizarDados.UseVisualStyleBackColor = true;
            this.btnAtualizarDados.Click += new System.EventHandler(this.BtnAtualizarDados_Click);
            // 
            // btnCriarBancoDados
            // 
            this.btnCriarBancoDados.Location = new System.Drawing.Point(23, 26);
            this.btnCriarBancoDados.Name = "btnCriarBancoDados";
            this.btnCriarBancoDados.Size = new System.Drawing.Size(91, 65);
            this.btnCriarBancoDados.TabIndex = 0;
            this.btnCriarBancoDados.Text = "Criar Banco de Dados";
            this.btnCriarBancoDados.UseVisualStyleBackColor = true;
            this.btnCriarBancoDados.Click += new System.EventHandler(this.BtnCriarBancoDados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnIncluirDados;
        private System.Windows.Forms.Button btnLocalizarDados;
        private System.Windows.Forms.Button btnExibirDados;
        private System.Windows.Forms.Button btnExcluirDados;
        private System.Windows.Forms.Button btnCriarTabela;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.Button btnCriarBancoDados;
    }
}

