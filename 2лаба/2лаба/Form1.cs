using System.Windows.Forms;

namespace _2лаба
{
    public partial class Form1 : Form
    {
        char WHO = 'O';
        short movement = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void rosette12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buuton_click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            if (WHO == 'O')
            {
                bt.BackColor = Color.Pink;
                bt.Text = "O";
                if (b1_1.Text == b1_2.Text && b1_2.Text == b1_3.Text && b1_3.Text != "" ||
                   b2_1.Text == b2_2.Text && b2_2.Text == b2_3.Text && b2_3.Text != "" ||
                   b3_1.Text == b3_2.Text && b3_2.Text == b3_3.Text && b3_3.Text != "" ||
                   b1_1.Text == b2_2.Text && b2_2.Text == b3_3.Text && b3_3.Text != "" ||
                   b3_1.Text == b2_2.Text && b2_2.Text == b1_3.Text && b3_1.Text != "" ||
                   b1_1.Text == b2_1.Text && b2_1.Text == b3_1.Text && b3_1.Text != "" ||
                   b1_2.Text == b2_2.Text && b2_2.Text == b3_2.Text && b3_2.Text != "" ||
                   b1_3.Text == b2_3.Text && b2_3.Text == b3_3.Text && b3_3.Text != ""
                   )
                {
                    MessageBox.Show($"Переможець - {WHO} !");
                }
                else if (movement == 8)
                {
                    MessageBox.Show("Кінець");
                }
                else
                {
                    WHO = 'X';
                    movement++;
                }
            }
            else if (WHO == 'X')
            {
                bt.BackColor = Color.Blue;
                bt.Text = "X";
                if (b1_1.Text == b1_2.Text && b1_2.Text == b1_3.Text && b1_3.Text != "" ||
                   b2_1.Text == b2_2.Text && b2_2.Text == b2_3.Text && b2_3.Text != "" ||
                   b3_1.Text == b3_2.Text && b3_2.Text == b3_3.Text && b3_3.Text != "" ||
                   b1_1.Text == b2_2.Text && b2_2.Text == b3_3.Text && b3_3.Text != "" ||
                   b3_1.Text == b2_2.Text && b2_2.Text == b1_3.Text && b3_1.Text != "" ||
                   b1_1.Text == b2_1.Text && b2_1.Text == b3_1.Text && b3_1.Text != "" ||
                   b1_2.Text == b2_2.Text && b2_2.Text == b3_2.Text && b3_2.Text != "" ||
                   b1_3.Text == b2_3.Text && b2_3.Text == b3_3.Text && b3_3.Text != ""
                   )
                {
                    MessageBox.Show($"Переможець - {WHO} !");
                }
                else if (movement == 8)
                {
                    MessageBox.Show("Кінець");
                }
                else
                {
                    WHO = 'O';
                    movement++;
                }
            }
        }
        private void b1_1_Click(object sender, EventArgs e)
        {
            buuton_click(sender, e);
        }

        private void b1_2_Click(object sender, EventArgs e)
        {
            buuton_click(sender, e);
        }
        private void b1_3_Click(object sender, EventArgs e)
        {
            buuton_click(sender, e);
        }

        private void b2_1_Click(object sender, EventArgs e)
        {
            buuton_click(sender, e);
        }

        private void b2_2_Click(object sender, EventArgs e)
        {
            buuton_click(sender, e);
        }

        private void b2_3_Click(object sender, EventArgs e)
        {
            buuton_click(sender, e);
        }

        private void b3_1_Click(object sender, EventArgs e)
        {
            buuton_click(sender, e);
        }

        private void b3_2_Click(object sender, EventArgs e)
        {
            buuton_click(sender, e);
        }

        private void b3_3_Click(object sender, EventArgs e)
        {
            buuton_click(sender, e);
        }

        private void новаГраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WHO = 'O';
            movement = 0;

            b1_1.Enabled = true; b1_1.Text = ""; b1_1.BackColor = Color.Black;
            b1_2.Enabled = true; b1_2.Text = ""; b1_2.BackColor = Color.Black;
            b1_3.Enabled = true; b1_3.Text = ""; b1_3.BackColor = Color.Black;

            b2_1.Enabled = true; b2_1.Text = ""; b2_1.BackColor = Color.Black;
            b2_2.Enabled = true; b2_2.Text = ""; b2_2.BackColor = Color.Black;
            b2_3.Enabled = true; b2_3.Text = ""; b2_3.BackColor = Color.Black;

            b3_1.Enabled = true; b3_1.Text = ""; b3_1.BackColor = Color.Black;
            b3_2.Enabled = true; b3_2.Text = ""; b3_2.BackColor = Color.Black;
            b3_3.Enabled = true; b3_3.Text = ""; b3_3.BackColor = Color.Black;
        }


        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
