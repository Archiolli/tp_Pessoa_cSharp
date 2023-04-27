namespace ParaCasa1
{
    partial class LivroUIL
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.Feminino = new System.Windows.Forms.RadioButton();
            this.txtidade = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(66, 17);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(68, 20);
            this.txtcod.TabIndex = 1;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(66, 43);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(206, 20);
            this.txtnome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Idade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sexo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(102, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Ler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Location = new System.Drawing.Point(66, 100);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(73, 17);
            this.Masculino.TabIndex = 14;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = true;
            this.Masculino.CheckedChanged += new System.EventHandler(this.Masculino_CheckedChanged);
            // 
            // Feminino
            // 
            this.Feminino.AutoSize = true;
            this.Feminino.Location = new System.Drawing.Point(67, 121);
            this.Feminino.Name = "Feminino";
            this.Feminino.Size = new System.Drawing.Size(67, 17);
            this.Feminino.TabIndex = 15;
            this.Feminino.TabStop = true;
            this.Feminino.Text = "Feminino";
            this.Feminino.UseVisualStyleBackColor = true;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(66, 69);
            this.txtidade.Mask = ">0<00";
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(30, 20);
            this.txtidade.TabIndex = 16;
            this.txtidade.ValidatingType = typeof(int);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(194, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Excluir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // LivroUIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 250);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.Feminino);
            this.Controls.Add(this.Masculino);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label1);
            this.Name = "LivroUIL";
            this.Text = "CADASTRO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadLivrosUIL_FormClosing);
            this.Load += new System.EventHandler(this.CadLivrosUIL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton Masculino;
        private System.Windows.Forms.RadioButton Feminino;
        private System.Windows.Forms.MaskedTextBox txtidade;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

