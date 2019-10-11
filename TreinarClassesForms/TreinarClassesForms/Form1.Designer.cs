namespace TreinarClassesForms
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
            this.botaoInstanciarObjeto = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // botaoInstanciarObjeto
            // 
            this.botaoInstanciarObjeto.Location = new System.Drawing.Point(166, 129);
            this.botaoInstanciarObjeto.Name = "botaoInstanciarObjeto";
            this.botaoInstanciarObjeto.Size = new System.Drawing.Size(75, 23);
            this.botaoInstanciarObjeto.TabIndex = 0;
            this.botaoInstanciarObjeto.Text = "Instanciar Objeto";
            this.botaoInstanciarObjeto.UseVisualStyleBackColor = true;
            this.botaoInstanciarObjeto.Click += new System.EventHandler(this.BotaoInstanciarObjeto_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 164);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.botaoInstanciarObjeto);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoInstanciarObjeto;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

