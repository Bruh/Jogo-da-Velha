namespace jogodavelha1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btsair = new System.Windows.Forms.Button();
            this.btok = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxjog2 = new System.Windows.Forms.TextBox();
            this.radioButtonjog1O = new System.Windows.Forms.RadioButton();
            this.radioButtonjo1X = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxjog1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btsair
            // 
            this.btsair.Location = new System.Drawing.Point(233, 211);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(48, 23);
            this.btsair.TabIndex = 40;
            this.btsair.Text = "&Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // btok
            // 
            this.btok.Location = new System.Drawing.Point(178, 211);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(46, 23);
            this.btok.TabIndex = 39;
            this.btok.Text = "&Jogar";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Nome do jogador 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(59, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 26);
            this.label7.TabIndex = 37;
            // 
            // textBoxjog2
            // 
            this.textBoxjog2.Location = new System.Drawing.Point(197, 78);
            this.textBoxjog2.Name = "textBoxjog2";
            this.textBoxjog2.Size = new System.Drawing.Size(88, 20);
            this.textBoxjog2.TabIndex = 36;
            // 
            // radioButtonjog1O
            // 
            this.radioButtonjog1O.AutoSize = true;
            this.radioButtonjog1O.Location = new System.Drawing.Point(197, 145);
            this.radioButtonjog1O.Name = "radioButtonjog1O";
            this.radioButtonjog1O.Size = new System.Drawing.Size(33, 17);
            this.radioButtonjog1O.TabIndex = 35;
            this.radioButtonjog1O.TabStop = true;
            this.radioButtonjog1O.Text = "O";
            this.radioButtonjog1O.UseVisualStyleBackColor = true;
            this.radioButtonjog1O.CheckedChanged += new System.EventHandler(this.radioButtonjog1O_CheckedChanged);
            // 
            // radioButtonjo1X
            // 
            this.radioButtonjo1X.AutoSize = true;
            this.radioButtonjo1X.Location = new System.Drawing.Point(197, 122);
            this.radioButtonjo1X.Name = "radioButtonjo1X";
            this.radioButtonjo1X.Size = new System.Drawing.Size(32, 17);
            this.radioButtonjo1X.TabIndex = 34;
            this.radioButtonjo1X.TabStop = true;
            this.radioButtonjo1X.Text = "X";
            this.radioButtonjo1X.UseVisualStyleBackColor = true;
            this.radioButtonjo1X.CheckedChanged += new System.EventHandler(this.radioButtonjo1X_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Jogador 1, com que quer jogar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Informe o nome do jogador 1:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxjog1
            // 
            this.textBoxjog1.Location = new System.Drawing.Point(197, 53);
            this.textBoxjog1.Name = "textBoxjog1";
            this.textBoxjog1.Size = new System.Drawing.Size(88, 20);
            this.textBoxjog1.TabIndex = 31;
            this.textBoxjog1.TextChanged += new System.EventHandler(this.textBoxjog1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Escolha a sua opção:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(86, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(18, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "       ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(18, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "       ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 250);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxjog2);
            this.Controls.Add(this.radioButtonjog1O);
            this.Controls.Add(this.radioButtonjo1X);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxjog1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha a sua Opção";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxjog2;
        private System.Windows.Forms.RadioButton radioButtonjog1O;
        private System.Windows.Forms.RadioButton radioButtonjo1X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxjog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}

