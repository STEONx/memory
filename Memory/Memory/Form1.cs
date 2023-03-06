using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;



namespace Memory
{
    public partial class Form1 : Form
    {
        Time_wait g = new Time_wait();
        List<int> BL = new List<int>();
        ArrayList images = new ArrayList();
        int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
        Image last = null;
        Image N2 = null;

        Bitmap kk = new Bitmap(@"C:\Users\LeonS\OneDrive\Programieren\C#\Übungen\Memory\Memory\1400.jpg");
        int score = 0;
        int moves = 0;
        Bitmap red = new Bitmap(@"C:\Users\LeonS\OneDrive\Programieren\C#\Übungen\Memory\Memory\pictures\s-l400.jpg");
        
        public Form1()
        {
            InitializeComponent();
        }
        int card = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

            Bitmap p1 = new Bitmap(@"C:\Users\LeonS\OneDrive\Programieren\C#\Übungen\Memory\Memory\pictures\220.05.038_stern_gelb_mit_rahmen_wei_ - Copy.jpg");

            Bitmap p2 = new Bitmap(@"C:\Users\LeonS\OneDrive\Programieren\C#\Übungen\Memory\Memory\pictures\61z4qVdq3+L._AC_SX425_.jpg");
            Bitmap p3 = new Bitmap(@"C:\Users\LeonS\OneDrive\Programieren\C#\Übungen\Memory\Memory\pictures\b287b62f-0001-0004-0000-000001390438_w1280_r1.77_fpx53.75_fpy50.jpg");
            Bitmap p4 = new Bitmap(@"C:\Users\LeonS\OneDrive\Programieren\C#\Übungen\Memory\Memory\pictures\Elias stuhl.jpg");

            Bitmap p5 = new Bitmap(@"C:\Users\LeonS\OneDrive\Programieren\C#\Übungen\Memory\Memory\pictures\Evo8DgsWYAQ8fXT.png");
            Bitmap p6 = new Bitmap(@"C:\Users\LeonS\OneDrive\Programieren\C#\Übungen\Memory\Memory\pictures\mitsubishi-l300-l-01.jpg");
            Bitmap p7 = new Bitmap(@"C:\Users\LeonS\OneDrive\Programieren\C#\Übungen\Memory\Memory\pictures\moenchshof_radler_a-frei_20x0.5.jpg");
            Bitmap p8 = new Bitmap(@"C:\Users\LeonS\OneDrive\Programieren\C#\Übungen\Memory\Memory\pictures\Niklas Krauss Bk Bild.jpg");
            
            Bitmap p9 = new Bitmap(@"C:\Users\LeonS\OneDrive\Programieren\C#\Übungen\Memory\Memory\pictures\Noah.jpg");
            Bitmap p10= new Bitmap(@"C:\Users\LeonS\OneDrive\Programieren\C#\Übungen\Memory\Memory\pictures\Paul Bank.jpg");
            Bitmap p11 = new Bitmap(@"C:\Users\LeonS\OneDrive\Programieren\C#\Übungen\Memory\Memory\pictures\Screenshot 2020-12-31 233538.png");
            Bitmap p12 = new Bitmap(@"C:\Users\LeonS\OneDrive\Programieren\C#\Übungen\Memory\Memory\pictures\Screenshot-gdfgdfg-50-91.jpg");

            images.Add(p1);
            images.Add(p2);

            images.Add(p3);
            images.Add(p4);
            images.Add(p5);
            images.Add(p6);

            images.Add(p7);
            images.Add(p8);
            images.Add(p9);
            images.Add(p10);
            images.Add(p11);
            images.Add(p12);
            images.Add(p1);
            images.Add(p2);

            images.Add(p3);
            images.Add(p4);
            images.Add(p5);
            images.Add(p6);

            images.Add(p7);
            images.Add(p8);
            images.Add(p9);
            images.Add(p10);
            images.Add(p11);
            images.Add(p12);
            arr = suffle(arr);


        }
        private int[] suffle(int[] arr)
        {
            Random rand = new Random();
            arr = arr.OrderBy(x => rand.Next()).ToArray();
            return arr;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            

            int i = 0;
            score = 0;
            moves = 0;
            card = 0;
            arr =suffle(arr);
            


            //b.Image = (Image)images[arr[i]];

            foreach (PictureBox b in panel1.Controls)
            {
                if (i < arr.Length)
                {
                    b.Image = kk;
                    i++;
                }
            }









        }
        static void foreach_()
        {
            

        }

        private  void pictureBox1_Click(object sender, EventArgs e)
        {
            
            card++;
            pictureBox1.Image = (Image)images[arr[0]];
            N2 = (Image)images[arr[0]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }
            
            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();
                
                
                
                
                
                



                if (pictureBox1.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image ==last && N2==b.Image)|| b.Image == red )
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }
                        
                        
                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[0]];

            }
            




        }

        private  void pictureBox2_Click(object sender, EventArgs e)
        {

            card++;
            pictureBox2.Image = (Image)images[arr[1]];
            N2 = (Image)images[arr[1]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox2.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[1]];

            }


        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox3.Image = (Image)images[arr[2]];
            N2 = (Image)images[arr[2]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox3.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[2]];

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox4.Image = (Image)images[arr[3]];
            N2 = (Image)images[arr[3]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox4.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[3]];

            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox5.Image = (Image)images[arr[4]];
            N2 = (Image)images[arr[4]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox5.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[4]];

            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox6.Image = (Image)images[arr[5]];
            N2 = (Image)images[arr[5]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox6.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[5]];

            }

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox12.Image = (Image)images[arr[11]];
            N2 = (Image)images[arr[11]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox12.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[11]];

            }

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox11.Image = (Image)images[arr[10]];
            N2 = (Image)images[arr[10]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox11.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }


            }
            else if (card == 1)
            {
                last = (Image)images[arr[10]];

            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox10.Image = (Image)images[arr[9]];
            N2 = (Image)images[arr[9]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox10.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[9]];

            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox9.Image = (Image)images[arr[8]];
            N2 = (Image)images[arr[8]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox9.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[8]];

            }


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox8.Image = (Image)images[arr[7]];
            N2 = (Image)images[arr[7]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox8.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[7]];

            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox7.Image = (Image)images[arr[6]];
            N2 = (Image)images[arr[6]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox7.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[6]];

            }

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox18.Image = (Image)images[arr[17]];
            N2 = (Image)images[arr[17]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox18.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[17]];

            }

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox17.Image = (Image)images[arr[16]];
            N2 = (Image)images[arr[16]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox17.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[16]];

            }

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox16.Image = (Image)images[arr[15]];
            N2 = (Image)images[arr[15]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox16.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[15]];

            }

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox15.Image = (Image)images[arr[14]];
            N2 = (Image)images[arr[14]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox15.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[14]];

            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox14.Image = (Image)images[arr[13]];
            N2 = (Image)images[arr[13]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox14.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[13]];

            }

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox13.Image = (Image)images[arr[12]];
            N2 = (Image)images[arr[12]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox13.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                            {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[12]];

            }


        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox24.Image = (Image)images[arr[23]];
            N2 = (Image)images[arr[23]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox24.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[23]];

            }

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox23.Image = (Image)images[arr[22]];
            System.Threading.Thread.Sleep(4);
            N2 = (Image)images[arr[22]];
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox23.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[22]];

            }

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox22.Image = (Image)images[arr[21]];
            N2 = (Image)images[arr[21]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox22.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }


            }
            else if (card == 1)
            {
                last = (Image)images[arr[21]];

            }

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox21.Image = (Image)images[arr[20]];
            System.Threading.Thread.Sleep(4);
            N2 = (Image)images[arr[20]];
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox21.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[20]];

            }

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox20.Image = (Image)images[arr[19]];
            N2 = (Image)images[arr[19]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox20.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[19]];

            }

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            card++;
            pictureBox19.Image = (Image)images[arr[18]];
            N2 = (Image)images[arr[18]];
            System.Threading.Thread.Sleep(4);
            if (card == 3)
            {
                card = 1;
            }

            if (card == 2)
            {
                moves++;
                label2.Text = moves.ToString();
                g.ShowDialog();









                if (pictureBox19.Image == last)
                {
                    score += 1;
                    label3.Text = score.ToString();

                }
                System.Threading.Thread.Sleep(250);
                int i = 0;
                foreach (PictureBox b in panel1.Controls)
                {
                    if (i < arr.Length)
                    {
                        if ((b.Image == last && N2 == b.Image) || b.Image == red)
                        {
                            b.Image = red;

                        }
                        else
                        {
                            b.Image = kk;

                        }


                        i++;
                    }
                }
            }
            else if (card == 1)
            {
                last = (Image)images[arr[18]];

            }

        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
   


}


