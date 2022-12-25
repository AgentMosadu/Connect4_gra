using System.Drawing;
using System.Media;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Connect4
{
    public partial class Form1 : Form
    {   
        
        List<Coin>[] columns = new List<Coin>[7];
        int player = 1;
        bool redWin = false;
        bool yellowWin = false;

        public Form1()
        {
            columns[0] = new List<Coin>();
            columns[1] = new List<Coin>();
            columns[2] = new List<Coin>();
            columns[3] = new List<Coin>();
            columns[4] = new List<Coin>();
            columns[5] = new List<Coin>();
            columns[6] = new List<Coin>();


            InitializeComponent();
        }


        public void checkWinInLines()
        {
            for (int a=0; a < 4; a++)
            {
                for (int i=0; i <6; i++)
                {
                    if (columns[a].Count >= i + 1 && columns[a][i].color == Color.Red &&
                        columns[a+1].Count >= i + 1 && columns[a+1][i].color == Color.Red &&
                        columns[a+2].Count >= i + 1 && columns[a+2][i].color == Color.Red &&
                        columns[a+3].Count >= i + 1  && columns[a+3][i].color == Color.Red )
                    {
                        redWin = true;
                    }
                }
            }
        }
        public void checkWinInColumns()
        {
            
            for (int a = 0; a < 7; a++)
            {
                if (columns[a].Count >= 4)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (
                            columns[a].Count>=i+1 && columns[a][i].color == Color.Red &&
                            columns[a].Count >= i+2 && columns[a][i+1].color == Color.Red &&
                            columns[a].Count >= i + 3 && columns[a][i + 2].color == Color.Red &&
                            columns[a].Count >= i + 4 && columns[a][i + 3].color == Color.Red)
                        {
                            redWin = true;
                        }
                        if (
                            columns[a].Count >= i + 1 && columns[a][i].color == Color.Yellow &&
                            columns[a].Count >= i + 2 && columns[a][i + 1].color == Color.Yellow &&
                            columns[a].Count >= i + 3 && columns[a][i + 2].color == Color.Yellow &&
                            columns[a].Count >= i + 4 && columns[a][i + 3].color == Color.Yellow)
                        {
                            yellowWin = true;
                        }

                    }
 
                }
            }
        }

        public void Win()
        {
            if (redWin == true)
            {
                MessageBox.Show("Red won");
                redWin = false;
                
                for (int i = 0; i < 7; i++)
                {

                    columns[i].Clear();
                    player = 1;
                    pictureBox1.Refresh();

                }
            }
            if (yellowWin == true)
            {
                MessageBox.Show("Yellow won");
                
                yellowWin = false;
                
                for (int i = 0; i < 7; i++)
                {

                    columns[i].Clear();
                    player = 1;
                    pictureBox1.Refresh();

                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // dodawanie ¿etownów
        public void AddRedCoin1()
        {
            columns[0].Add(new Coin(Color.Red));
            checkWinInColumns();
            checkWinInLines();
            pictureBox1.Refresh();
            Win();
            pictureBox1.Refresh();
        }

        public void AddYellowCoin1()
        {
            columns[0].Add(new Coin(Color.Yellow));
            checkWinInColumns();
            checkWinInLines();
            pictureBox1.Refresh();
            Win();
            pictureBox1.Refresh();
        }

        public void AddRedCoin2()
        {
            columns[1].Add(new Coin(Color.Red));
            checkWinInColumns();
            checkWinInLines();
            pictureBox1.Refresh();
            Win();
            pictureBox1.Refresh();
        }

        public void AddYellowCoin2()
        {
            columns[1].Add(new Coin(Color.Yellow));
            checkWinInColumns();
            checkWinInLines();
            pictureBox1.Refresh();
            Win();
            pictureBox1.Refresh();
        }
        public void AddRedCoin3()
        {
            columns[2].Add(new Coin(Color.Red));
            checkWinInColumns();
            checkWinInLines();
            pictureBox1.Refresh();
            Win();
            pictureBox1.Refresh();
        }

        public void AddYellowCoin3()
        {
            columns[2].Add(new Coin(Color.Yellow));
            checkWinInColumns();
            checkWinInLines();
            pictureBox1.Refresh();
            Win();
            pictureBox1.Refresh();
        }
        public void AddRedCoin4()
        {
            columns[3].Add(new Coin(Color.Red));
            checkWinInColumns();
            checkWinInLines();
            pictureBox1.Refresh();
            Win();
            pictureBox1.Refresh();
        }

        public void AddYellowCoin4()
        {
            columns[3].Add(new Coin(Color.Yellow));
            checkWinInColumns();
            checkWinInLines();
            pictureBox1.Refresh();
            Win();
            pictureBox1.Refresh();
        }
        public void AddRedCoin5()
        {
            columns[4].Add(new Coin(Color.Red));
            checkWinInColumns();
            checkWinInLines();
            pictureBox1.Refresh();
            Win();
            pictureBox1.Refresh();
        }

        public void AddYellowCoin5()
        {
            columns[4].Add(new Coin(Color.Yellow));
            checkWinInColumns();
            checkWinInLines();
            pictureBox1.Refresh();
            Win();
            pictureBox1.Refresh();
        }
        public void AddRedCoin6()
        {
            columns[5].Add(new Coin(Color.Red));
            checkWinInColumns();
            checkWinInLines();
            pictureBox1.Refresh();
            Win();
            pictureBox1.Refresh();
        }

        public void AddYellowCoin6()
        {
            columns[5].Add(new Coin(Color.Yellow));
            checkWinInColumns();
            checkWinInLines();
            pictureBox1.Refresh();
            Win();
            pictureBox1.Refresh();
        }
        public void AddRedCoin7()
        {
            columns[6].Add(new Coin(Color.Red));
            checkWinInColumns();
            checkWinInLines();
            pictureBox1.Refresh();
            Win();
            pictureBox1.Refresh();
        }

        public void AddYellowCoin7()
        {
            columns[6].Add(new Coin(Color.Yellow));
            checkWinInColumns();
            checkWinInLines();
            pictureBox1.Refresh();
            Win();
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //rysowanie siatki
            g.DrawRectangle(new Pen(Color.Black, 10), 0, 0, 729, 629);

            for (int i = 0; i <= 6; i++)
            {
                g.DrawLine(new Pen(Color.Black, 5), 0, (i * pictureBox1.Height / 6), 730, (i * pictureBox1.Height / 6));
            }

            for (int i = 0; i <= 7; i++)
            {
                g.DrawLine(new Pen(Color.Black, 5), (i * pictureBox1.Width / 7), 0, (i * pictureBox1.Width / 7), 630);
            }

            

            //rysowanie column
            for (int a = 0; a < 7; a++)
            {
                for (int i = 0; i < columns[a].Count; i++)
                {
                    Coin coin = columns[a][i];
                    Brush brush = new SolidBrush(coin.color);
                    g.FillEllipse(brush, 5+a*105, (5 - i) * 105, 100, 100);

                }
            }


            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                AddRedCoin1();
                player = 2;
            }

            else
            {
                AddYellowCoin1();
                player = 1;
            }
            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                AddRedCoin2();
                player = 2;
            }

            else
            {
                AddYellowCoin2();
                player = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                AddRedCoin3();
                player = 2;
            }

            else
            {
                AddYellowCoin3();
                player = 1;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                AddRedCoin4();
                player = 2;
            }

            else
            {
                AddYellowCoin4();
                player = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                AddRedCoin5();
                player = 2;
            }

            else
            {
                AddYellowCoin5();
                player = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                AddRedCoin6();
                player = 2;
            }

            else
            {
                AddYellowCoin6();
                player = 1;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                AddRedCoin7();
                player = 2;
            }

            else
            {
                AddYellowCoin7();
                player = 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                
                columns[i].Clear();
                player = 1;
                pictureBox1.Refresh();

            }
        }
    }
}