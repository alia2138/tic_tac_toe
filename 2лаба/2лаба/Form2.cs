using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _2лаба
{
    public partial class Form2 : Form
    {
        short movement = 0;
        Random rnd = new Random();

        public Form2()
        {
            InitializeComponent();

            // Автоматично підключаємо Click для ВСІХ кнопок b1_1 ... b3_3
            foreach (Button bt in Controls.OfType<Button>())
                if (bt.Name.StartsWith("b"))
                    bt.Click += buuton_click;
        }

        private void buuton_click(object sender, EventArgs e)
        {
            // ❗ Захист від NullReference
            if (sender is not Button bt)
                return; // Якщо клікнули НЕ по кнопці — виходимо

            if (bt.Text != "")
                return; // Кнопка вже натиснута

            // --- ХІД ЛЮДИНИ ---
            PlayerMove(bt);
            if (CheckWin()) return;

            // --- ХІД AI ---
            AIMove();
            CheckWin();
        }

        // ==================== ХІД ГРАВЦЯ ====================
        void PlayerMove(Button bt)
        {
            bt.Enabled = false;
            bt.Text = "O";
            bt.BackColor = Color.Pink;
            movement++;
        }

        // ==================== ХІД AI ====================
        void AIMove()
        {
            List<Button> free = GetFreeButtons();
            if (free.Count == 0) return;

            Button move = free[rnd.Next(free.Count)];

            move.Enabled = false;
            move.Text = "X";
            move.BackColor = Color.LightBlue;

            movement++;
        }

        // ==================== ОТРИМАТИ ВСІ ВІЛЬНІ КНОПКИ ====================
        List<Button> GetFreeButtons()
        {
            return Controls
                .OfType<Button>()
                .Where(b => b.Name.StartsWith("b") && b.Text == "")
                .ToList();
        }

        // ==================== ПЕРЕВІРКА ПЕРЕМОГИ ====================
        bool CheckWin()
        {
            string[,] field = {
                { b1_1.Text, b1_2.Text, b1_3.Text },
                { b2_1.Text, b2_2.Text, b2_3.Text },
                { b3_1.Text, b3_2.Text, b3_3.Text }
            };

            int[][] lines = new int[][]
            {
                new []{0,0, 0,1, 0,2},
                new []{1,0, 1,1, 1,2},
                new []{2,0, 2,1, 2,2},

                new []{0,0, 1,0, 2,0},
                new []{0,1, 1,1, 2,1},
                new []{0,2, 1,2, 2,2},

                new []{0,0, 1,1, 2,2},
                new []{0,2, 1,1, 2,0}
            };

            foreach (var line in lines)
            {
                string a = field[line[0], line[1]];
                string b = field[line[2], line[3]];
                string c = field[line[4], line[5]];

                if (a != "" && a == b && b == c)
                {
                    MessageBox.Show($"Переможець: {a}");
                    DisableAll();
                    return true;
                }
            }

            if (movement == 9)
            {
                MessageBox.Show("Нічия!");
                return true;
            }

            return false;
        }

        // ==================== ВІДКЛЮЧИТИ ВСІ ====================
        void DisableAll()
        {
            foreach (var b in Controls.OfType<Button>())
                if (b.Name.StartsWith("b"))
                    b.Enabled = false;
        }

        // ==================== НОВА ГРА ====================
        private void новаГраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movement = 0;

            foreach (Button bt in Controls.OfType<Button>())
            {
                if (bt.Name.StartsWith("b"))
                {
                    bt.Enabled = true;
                    bt.Text = "";
                    bt.BackColor = Color.Black;
                }
            }
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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

        private void Form2_Load(object sender, EventArgs e)
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
    }
}
