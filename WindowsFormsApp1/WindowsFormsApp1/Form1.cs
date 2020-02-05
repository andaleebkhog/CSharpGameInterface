using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Lines
        Point l_Start;
        Point l_End;
        Color l_Colorr;
        Pen l_Pen;

        //Words
        char w_Word;
        Font w_Font;
        Brush w_Brushh;
        Color w_Color;
        PointF w_Start;
        //
        int flag;
        int wLen;
        string randomWord;
        char[] wordsInput;
        int countLen;
        int countReguess;
        //

        public Form1()
        {
            InitializeComponent();

            label1.Visible = false;
            //Lines
            l_Start = new Point(240, 184);
            l_End = new Point(260, 184);
            l_Colorr = Color.Black;
            l_Pen = new Pen(l_Colorr, 5);
            wordsInput = new char[30];
            //Words
            w_Word = ' ';
            w_Font = new Font("Arial", 25);
            w_Color = Color.Black;
            w_Brushh = new SolidBrush(w_Color);
            w_Start = new PointF(240, 160);



        }
        public void Display_dashes()
        {
            Graphics g = this.CreateGraphics();
            countReguess = 0;
            for (int i = 0; i < wLen; i++)
            {
                if (flag == 1)
                {
                    if (Array.Exists(wordsInput, elem => elem == randomWord[i]))
                    {
                        w_Word = randomWord[i];
                        g.DrawString(w_Word.ToString(), w_Font, w_Brushh, w_Start);

                        if (countReguess == 0 && w_Word == randomWord[wLen - 1])
                        {
                            label1.Visible = true;
                            foreach (Control cnt in this.Controls)
                            {
                                cnt.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        g.DrawLine(l_Pen, l_Start, l_End);
                        countReguess = 1;
                    }
                        l_Start.X += 30;
                        l_End.X += 30;
                        w_Start.X += 30;
                }
                else
                {
                    g.DrawLine(l_Pen, l_Start, l_End);
                    l_Start.X += 30;
                    l_End.X += 30;
                }
            }
            l_Start = new Point(240, 184);
            l_End = new Point(260, 184);
            w_Start = new PointF(240, 160);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Display_dashes();
        }

        private void button1_Click(object sender, EventArgs e) //Education Category
        {

            string[] allLines = File.ReadAllLines("Education.txt"); 
            Random random = new Random();
            randomWord = allLines[random.Next(allLines.Length)];
            wLen = randomWord.Length;
            wordsInput = new char[30];
            countLen = 0;
            flag = 0;
            countReguess = 0;
            Invalidate();
        }
        private void button28_Click(object sender, EventArgs e) //Fruits Category
        {
            string[] allLines = File.ReadAllLines("Fruits.txt");
            Random rnd1 = new Random();
            Random random = new Random();
            randomWord = allLines[random.Next(allLines.Length)];
            wLen = randomWord.Length;
            wordsInput = new char[30];
            countLen = 0;
            flag = 0;
            countReguess = 0;
            Invalidate();
        }
        private void button29_Click(object sender, EventArgs e) //Sport Category
        {
            string[] allLines = File.ReadAllLines("Sports.txt");
            Random rnd1 = new Random();
            Random random = new Random();
            randomWord = allLines[random.Next(allLines.Length)];
            wLen = randomWord.Length;
            wordsInput = new char[30];
            countLen = 0;
            flag = 0;
            countReguess = 0;
            Invalidate();
        }
        //---------------------------//
        //alphabets clicks

        private void button2_Click(object sender, EventArgs e)
        { //a
            countLen++;
            wordsInput[countLen] = 'a';
            if (randomWord.IndexOf('a') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {//b
            countLen++;
            wordsInput[countLen] = 'b';
            if (randomWord.IndexOf('b') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;

        }

        private void button4_Click(object sender, EventArgs e)
        {//c
            countLen++;
            wordsInput[countLen] = 'c';
            if (randomWord.IndexOf('c') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //d
            countLen++;
            wordsInput[countLen] = 'd';
            if (randomWord.IndexOf('d') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //e
            countLen++;
            wordsInput[countLen] = 'e';
            if (randomWord.IndexOf('e') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //f
            countLen++;
            wordsInput[countLen] = 'f';
            if (randomWord.IndexOf('f') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //g
            countLen++;
            wordsInput[countLen] = 'g';
            if (randomWord.IndexOf('g') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //h
            countLen++;
            wordsInput[countLen] = 'h';
            if (randomWord.IndexOf('h') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //i
            countLen++;
            wordsInput[countLen] = 'i';
            if (randomWord.IndexOf('i') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //j
            countLen++;
            wordsInput[countLen] = 'j';
            if (randomWord.IndexOf('j') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //k
            countLen++;
            wordsInput[countLen] = 'k';
            if (randomWord.IndexOf('k') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //l
            countLen++;
            wordsInput[countLen] = 'l';
            if (randomWord.IndexOf('l') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //m
            countLen++;
            wordsInput[countLen] = 'm';
            if (randomWord.IndexOf('m') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //n
            countLen++;
            wordsInput[countLen] = 'n';
            if (randomWord.IndexOf('n') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //o
            countLen++;
            wordsInput[countLen] = 'o';
            if (randomWord.IndexOf('o') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //p
            countLen++;
            wordsInput[countLen] = 'p';
            if (randomWord.IndexOf('p') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1; ;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //q
            countLen++;
            wordsInput[countLen] = 'q';
            if (randomWord.IndexOf('q') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //r
            countLen++;
            wordsInput[countLen] = 'r';
            if (randomWord.IndexOf('r') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //s
            countLen++;
            wordsInput[countLen] = 's';
            if (randomWord.IndexOf('s') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //t
            countLen++;
            wordsInput[countLen] = 't';
            if (randomWord.IndexOf('t') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }
            private void button22_Click(object sender, EventArgs e)
        {
            //u
            countLen++;
            wordsInput[countLen] = 'u';
            if (randomWord.IndexOf('u') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //v
            countLen++;
            wordsInput[countLen] = 'v';
            if (randomWord.IndexOf('v') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //w
            countLen++;
            wordsInput[countLen] = 'w';
            if (randomWord.IndexOf('w') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //x
            countLen++;
            wordsInput[countLen] = 'x';
            if (randomWord.IndexOf('x') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //y
            countLen++;
            wordsInput[countLen] = 'y';
            if (randomWord.IndexOf('y') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //z
            countLen++;
            wordsInput[countLen] = 'z';
            if (randomWord.IndexOf('z') != -1)
            {
                Invalidate();
            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
            flag = 1;
        }

        
    }
}
