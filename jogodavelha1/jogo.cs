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
    public partial class jogo : Form
    {
        public jogo()
        {
            InitializeComponent();
            but11.Click += new EventHandler(Clic);
            but12.Click += new EventHandler(Clic);
            but13.Click += new EventHandler(Clic);
            but21.Click += new EventHandler(Clic);
            but22.Click += new EventHandler(Clic);
            but23.Click += new EventHandler(Clic);
            but31.Click += new EventHandler(Clic);
            but32.Click += new EventHandler(Clic);
            but33.Click += new EventHandler(Clic);

        }
        bool Vez;

        private void Clic (object sender, EventArgs e)
        {
            Button Bton = ((Button)sender);
            
            if (Bton.Text == "")
            {
                if (Vez)
                {
                    Bton.ForeColor = Color.BlueViolet;
                    Bton.Text = "X";
                    label6.ForeColor = Color.BlueViolet ;
                    label6.Text = textBoxjog2.Text + "é sua vez!";
                    Vez = false;                
                }
                   
                else
                {
                    Bton.ForeColor = Color.Pink;
                    Bton.Text = "O";
                    label6.ForeColor = Color.Pink;
                    label6.Text = textBoxjog1.Text + "é sua vez!";
                    Vez = true;

                }
            }

            //Horizontal
            if (but11.Text == but12.Text && but11.Text == but13.Text && but11.Text  != "")
            {
                paneljogo.Enabled = false;
                MessageBox.Show("O" +Bton.Text+ " é o vencedor");
            }else if (but21.Text == but22.Text && but21.Text == but23.Text && but21.Text  != "")
            {
                paneljogo.Enabled = false;
                MessageBox.Show("O" + Bton.Text + " é o vencedor");
            }else if (but31.Text == but32.Text && but31.Text == but33.Text && but31.Text  != "")
            {
                paneljogo.Enabled = false;
                MessageBox.Show("O" + Bton.Text + " é o vencedor");
            }

            //diagonal
            else if (but11.Text == but22.Text && but11.Text == but33.Text && but11.Text  != "")
            {
                paneljogo.Enabled = false;
                MessageBox.Show("O" + Bton.Text + " é o vencedor");
            }else if (but13.Text == but22.Text && but13.Text == but31.Text && but13.Text  != "")
            {
                paneljogo.Enabled = false;
                MessageBox.Show("O" + Bton.Text + " é o vencedor");
            }
            
            //Vertical
            else if (but11.Text == but21.Text && but11.Text == but31.Text && but11.Text  != "")
            {
                paneljogo.Enabled = false;
                MessageBox.Show("O" + Bton.Text + " é o vencedor");
            }else if (but12.Text == but22.Text && but12.Text == but32.Text && but12.Text  != "")
            {
                paneljogo.Enabled = false;
                MessageBox.Show("O" + Bton.Text + " é o vencedor");
            }else if (but13.Text == but23.Text && but13.Text == but33.Text && but13.Text  != "")
            {
                paneljogo.Enabled = false;
                MessageBox.Show("O" + Bton.Text + " é o vencedor");
            }else if (but11.Text == but12.Text && but11.Text == but13.Text && but11.Text  != "")
            {
                paneljogo.Enabled = false;
                MessageBox.Show("O" + Bton.Text + " é o vencedor");
            }
        }

        private void panelplacar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
