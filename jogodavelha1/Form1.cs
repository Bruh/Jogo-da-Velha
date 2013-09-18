using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodavelha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btok_Click(object sender, EventArgs e)
        {
            jogo jogar = new jogo();
            jogar.ShowDialog();
            this.Close();


        }

        private void textBoxjog1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {     
             
        }

        private void radioButtonjo1X_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonjo1X.Checked)
            {
                label8.Text = textBoxjog1.Text + ", você será X";
                label5.Text = textBoxjog2.Text+", você será O";
            }
            
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonjog1O_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonjog1O.Checked)
            {
                label8.Text = textBoxjog1.Text + ", você será O";
                label5.Text = textBoxjog2.Text + ", você será X";
            }
        }

       
    }
}
