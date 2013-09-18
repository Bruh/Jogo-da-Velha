namespace jogodavelha1
{
    partial class jogo
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
            this.label6 = new System.Windows.Forms.Label();
            this.panelplacar = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxjog1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxjog2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paneljogo = new System.Windows.Forms.Panel();
            this.but11 = new System.Windows.Forms.Button();
            this.but13 = new System.Windows.Forms.Button();
            this.but21 = new System.Windows.Forms.Button();
            this.but31 = new System.Windows.Forms.Button();
            this.but23 = new System.Windows.Forms.Button();
            this.but12 = new System.Windows.Forms.Button();
            this.but22 = new System.Windows.Forms.Button();
            this.but33 = new System.Windows.Forms.Button();
            this.but32 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelplacar.SuspendLayout();
            this.paneljogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 36);
            this.label6.TabIndex = 16;
            this.label6.Text = "X é sua vez de jogar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelplacar
            // 
            this.panelplacar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelplacar.Controls.Add(this.label5);
            this.panelplacar.Controls.Add(this.textBoxjog1);
            this.panelplacar.Controls.Add(this.textBox1);
            this.panelplacar.Controls.Add(this.textBoxjog2);
            this.panelplacar.Controls.Add(this.label4);
            this.panelplacar.Controls.Add(this.label3);
            this.panelplacar.Location = new System.Drawing.Point(21, 80);
            this.panelplacar.Name = "panelplacar";
            this.panelplacar.Size = new System.Drawing.Size(330, 42);
            this.panelplacar.TabIndex = 15;
            this.panelplacar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelplacar_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Velha:";
            // 
            // textBoxjog1
            // 
            this.textBoxjog1.Location = new System.Drawing.Point(80, 8);
            this.textBoxjog1.Multiline = true;
            this.textBoxjog1.Name = "textBoxjog1";
            this.textBoxjog1.Size = new System.Drawing.Size(36, 22);
            this.textBoxjog1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBoxjog2
            // 
            this.textBoxjog2.Location = new System.Drawing.Point(195, 7);
            this.textBoxjog2.Multiline = true;
            this.textBoxjog2.Name = "textBoxjog2";
            this.textBoxjog2.Size = new System.Drawing.Size(36, 22);
            this.textBoxjog2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jogador 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jogador 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Placar:";
            // 
            // paneljogo
            // 
            this.paneljogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneljogo.Controls.Add(this.but11);
            this.paneljogo.Controls.Add(this.but13);
            this.paneljogo.Controls.Add(this.but21);
            this.paneljogo.Controls.Add(this.but31);
            this.paneljogo.Controls.Add(this.but23);
            this.paneljogo.Controls.Add(this.but12);
            this.paneljogo.Controls.Add(this.but22);
            this.paneljogo.Controls.Add(this.but33);
            this.paneljogo.Controls.Add(this.but32);
            this.paneljogo.Location = new System.Drawing.Point(48, 185);
            this.paneljogo.Name = "paneljogo";
            this.paneljogo.Size = new System.Drawing.Size(276, 279);
            this.paneljogo.TabIndex = 13;
            // 
            // but11
            // 
            this.but11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but11.ForeColor = System.Drawing.Color.Black;
            this.but11.Location = new System.Drawing.Point(3, 3);
            this.but11.Name = "but11";
            this.but11.Size = new System.Drawing.Size(84, 82);
            this.but11.TabIndex = 0;
            this.but11.UseVisualStyleBackColor = true;
            // 
            // but13
            // 
            this.but13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but13.ForeColor = System.Drawing.Color.Black;
            this.but13.Location = new System.Drawing.Point(183, 3);
            this.but13.Name = "but13";
            this.but13.Size = new System.Drawing.Size(84, 82);
            this.but13.TabIndex = 0;
            this.but13.UseVisualStyleBackColor = true;
            // 
            // but21
            // 
            this.but21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but21.ForeColor = System.Drawing.Color.Black;
            this.but21.Location = new System.Drawing.Point(3, 101);
            this.but21.Name = "but21";
            this.but21.Size = new System.Drawing.Size(84, 82);
            this.but21.TabIndex = 0;
            this.but21.UseVisualStyleBackColor = true;
            // 
            // but31
            // 
            this.but31.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but31.ForeColor = System.Drawing.Color.Black;
            this.but31.Location = new System.Drawing.Point(3, 193);
            this.but31.Name = "but31";
            this.but31.Size = new System.Drawing.Size(84, 82);
            this.but31.TabIndex = 0;
            this.but31.UseVisualStyleBackColor = true;
            // 
            // but23
            // 
            this.but23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but23.ForeColor = System.Drawing.Color.Black;
            this.but23.Location = new System.Drawing.Point(183, 99);
            this.but23.Name = "but23";
            this.but23.Size = new System.Drawing.Size(84, 82);
            this.but23.TabIndex = 0;
            this.but23.UseVisualStyleBackColor = true;
            // 
            // but12
            // 
            this.but12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but12.ForeColor = System.Drawing.Color.Black;
            this.but12.Location = new System.Drawing.Point(93, 3);
            this.but12.Name = "but12";
            this.but12.Size = new System.Drawing.Size(84, 82);
            this.but12.TabIndex = 0;
            this.but12.UseVisualStyleBackColor = true;
            // 
            // but22
            // 
            this.but22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but22.ForeColor = System.Drawing.Color.Black;
            this.but22.Location = new System.Drawing.Point(93, 99);
            this.but22.Name = "but22";
            this.but22.Size = new System.Drawing.Size(84, 82);
            this.but22.TabIndex = 0;
            this.but22.UseVisualStyleBackColor = true;
            // 
            // but33
            // 
            this.but33.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but33.ForeColor = System.Drawing.Color.Black;
            this.but33.Location = new System.Drawing.Point(183, 193);
            this.but33.Name = "but33";
            this.but33.Size = new System.Drawing.Size(84, 82);
            this.but33.TabIndex = 0;
            this.but33.UseVisualStyleBackColor = true;
            // 
            // but32
            // 
            this.but32.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but32.ForeColor = System.Drawing.Color.Black;
            this.but32.Location = new System.Drawing.Point(93, 193);
            this.but32.Name = "but32";
            this.but32.Size = new System.Drawing.Size(84, 82);
            this.but32.TabIndex = 0;
            this.but32.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(65, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Jogo da Velha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 481);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelplacar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paneljogo);
            this.Controls.Add(this.label1);
            this.Name = "jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.Load += new System.EventHandler(this.Clic);
            this.panelplacar.ResumeLayout(false);
            this.panelplacar.PerformLayout();
            this.paneljogo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelplacar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxjog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxjog2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel paneljogo;
        private System.Windows.Forms.Button but11;
        private System.Windows.Forms.Button but13;
        private System.Windows.Forms.Button but21;
        private System.Windows.Forms.Button but31;
        private System.Windows.Forms.Button but23;
        private System.Windows.Forms.Button but12;
        private System.Windows.Forms.Button but22;
        private System.Windows.Forms.Button but33;
        private System.Windows.Forms.Button but32;
        private System.Windows.Forms.Label label1;


    }
}