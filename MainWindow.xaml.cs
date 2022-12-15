using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Domino
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Bone> bon = new List<Bone>();
        List<Bone> snake = new List<Bone>();
        int a = 0;
        int kol = 0;
        int kol2 = 7;
        int kol3 = 0;
        int kol4 = 5;
        int kolUni = 0;
        int k1 = 0;
        int k2 = 0;
        public MainWindow()
        {
            
            InitializeComponent();

            //five_six.MouseLeftButtonDown += five_six_MouseLeftButtonDown;
            //third.BindingGroup.Items.Add(elem0);
            //MessageBox.Show(Convert.ToString(elem0));

            bon.Add(new Bone("0","0"));//1
            bon.Add(new Bone("0", "1"));//2
            bon.Add(new Bone("0", "2"));//3
            bon.Add(new Bone("0", "3"));//4
            bon.Add(new Bone("0", "4"));//5
            bon.Add(new Bone("0", "5"));//6
            bon.Add(new Bone("0", "6"));//7

            bon.Add(new Bone("1", "1"));//8
            bon.Add(new Bone("1", "2"));//9
            bon.Add(new Bone("1", "3"));//10
            bon.Add(new Bone("1", "4"));//11
            bon.Add(new Bone("1", "5"));//12
            bon.Add(new Bone("1", "6"));//13

            bon.Add(new Bone("2", "2"));//14
            bon.Add(new Bone("2", "3"));//15
            bon.Add(new Bone("2", "4"));//16
            bon.Add(new Bone("2", "5"));//17
            bon.Add(new Bone("2", "6"));//18

            bon.Add(new Bone("3", "3"));//19
            bon.Add(new Bone("3", "4"));//20
            bon.Add(new Bone("3", "5"));//21
            bon.Add(new Bone("3", "6"));//22
            
            bon.Add(new Bone("4", "4"));//23
            bon.Add(new Bone("4", "5"));//24
            bon.Add(new Bone("4", "6"));//25

            bon.Add(new Bone("5", "5"));//26
            bon.Add(new Bone("5", "6"));//27

            bon.Add(new Bone("6", "6"));//28

            
           

            this.DataContext=bon;
            //MessageBox.Show(Convert.ToString(bon[5].y));
        }

        private void five_six_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (a >= 360)
            { a = 0; }
            a += 90;
            five_six.RenderTransform = new RotateTransform(a);
        }

        private void five_six_PreviewMouseMove(object sender, MouseEventArgs e)
        {
  
        }

        private void zero_zero_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("0", "0"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                zero_zero.RenderTransform = new RotateTransform(a);
                zero_zero.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                zero_zero.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                zero_zero.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                zero_zero.RenderTransform = new RotateTransform(a);

                zero_zero.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                zero_zero.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                zero_zero.RenderTransform = new RotateTransform(a);

                zero_zero.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                zero_zero.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                zero_zero.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    zero_zero.RenderTransform = new RotateTransform(a);
                    zero_zero.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        zero_zero.RenderTransform = new RotateTransform(a);
                        zero_zero.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    
                    a = 0;
                    a += 180;
                    zero_zero.RenderTransform = new RotateTransform(a);
                    zero_zero.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void zero_one_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("0", "1"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                zero_one.RenderTransform = new RotateTransform(a);
                zero_one.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                zero_one.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                zero_one.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                zero_one.RenderTransform = new RotateTransform(a);

                zero_one.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                zero_one.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                zero_one.RenderTransform = new RotateTransform(a);

                zero_one.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                zero_one.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                zero_one.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    zero_one.RenderTransform = new RotateTransform(a);
                    zero_one.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        zero_one.RenderTransform = new RotateTransform(a);
                        zero_one.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    zero_one.RenderTransform = new RotateTransform(a);
                    zero_one.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void zero_two_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("0", "2"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                zero_two.RenderTransform = new RotateTransform(a);
                zero_two.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                zero_two.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                zero_two.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                zero_two.RenderTransform = new RotateTransform(a);

                zero_two.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                zero_two.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                zero_two.RenderTransform = new RotateTransform(a);

                zero_two.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                zero_two.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                zero_two.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550-80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    zero_two.RenderTransform = new RotateTransform(a);
                    zero_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {
                        
                        a = 0;
                        a += 180;
                        zero_two.RenderTransform = new RotateTransform(a);
                        zero_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    zero_two.RenderTransform = new RotateTransform(a);
                    zero_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void zero_third_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("0", "3"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                zero_third.RenderTransform = new RotateTransform(a);
                zero_third.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                zero_third.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                zero_third.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                zero_third.RenderTransform = new RotateTransform(a);

                zero_third.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                zero_third.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                zero_third.RenderTransform = new RotateTransform(a);

                zero_third.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                zero_third.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                zero_third.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    zero_third.RenderTransform = new RotateTransform(a);
                    zero_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        zero_third.RenderTransform = new RotateTransform(a);
                        zero_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    zero_third.RenderTransform = new RotateTransform(a);
                    zero_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void zero_four_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("0", "4"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                zero_four.RenderTransform = new RotateTransform(a);
                zero_four.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                zero_four.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                zero_four.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                zero_four.RenderTransform = new RotateTransform(a);

                zero_four.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                zero_four.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                zero_four.RenderTransform = new RotateTransform(a);

                zero_four.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                zero_four.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                zero_four.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    zero_four.RenderTransform = new RotateTransform(a);
                    zero_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        zero_four.RenderTransform = new RotateTransform(a);
                        zero_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    zero_four.RenderTransform = new RotateTransform(a);
                    zero_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void zero_five_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("0", "5"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                zero_five.RenderTransform = new RotateTransform(a);
                zero_five.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                zero_five.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                zero_five.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                zero_five.RenderTransform = new RotateTransform(a);

                zero_five.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                zero_five.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                zero_five.RenderTransform = new RotateTransform(a);

                zero_five.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                zero_five.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                zero_five.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    zero_five.RenderTransform = new RotateTransform(a);
                    zero_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        zero_five.RenderTransform = new RotateTransform(a);
                        zero_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    zero_five.RenderTransform = new RotateTransform(a);
                    zero_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void zero_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("0", "6"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                zero_six.RenderTransform = new RotateTransform(a);
                zero_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                zero_six.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                zero_six.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                zero_six.RenderTransform = new RotateTransform(a);

                zero_six.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                zero_six.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                zero_six.RenderTransform = new RotateTransform(a);

                zero_six.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                zero_six.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                zero_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    zero_six.RenderTransform = new RotateTransform(a);
                    zero_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        zero_six.RenderTransform = new RotateTransform(a);
                        zero_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    zero_six.RenderTransform = new RotateTransform(a);
                    zero_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void one_one_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("1", "1"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                one_one.RenderTransform = new RotateTransform(a);
                one_one.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                one_one.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                one_one.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                one_one.RenderTransform = new RotateTransform(a);

                one_one.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                one_one.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                one_one.RenderTransform = new RotateTransform(a);

                one_one.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                one_one.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                one_one.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    one_one.RenderTransform = new RotateTransform(a);
                    one_one.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        one_one.RenderTransform = new RotateTransform(a);
                        one_one.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    one_one.RenderTransform = new RotateTransform(a);
                    one_one.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void one_two_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("1", "2"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                one_two.RenderTransform = new RotateTransform(a);
                one_two.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                one_two.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                one_two.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                one_two.RenderTransform = new RotateTransform(a);

                one_two.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                one_two.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                one_two.RenderTransform = new RotateTransform(a);

                one_two.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                one_two.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                one_two.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    one_two.RenderTransform = new RotateTransform(a);
                    one_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        one_two.RenderTransform = new RotateTransform(a);
                        one_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    one_two.RenderTransform = new RotateTransform(a);
                    one_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void one_third_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("1", "3"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                one_third.RenderTransform = new RotateTransform(a);
                one_third.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                one_third.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                one_third.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                one_third.RenderTransform = new RotateTransform(a);

                one_third.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                one_third.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                one_third.RenderTransform = new RotateTransform(a);

                one_third.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                one_third.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                one_third.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    one_third.RenderTransform = new RotateTransform(a);
                    one_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        one_third.RenderTransform = new RotateTransform(a);
                        one_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    one_third.RenderTransform = new RotateTransform(a);
                    one_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void one_four_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("1", "4"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                one_four.RenderTransform = new RotateTransform(a);
                one_four.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                one_four.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                one_four.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                one_four.RenderTransform = new RotateTransform(a);

                one_four.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                one_four.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                one_four.RenderTransform = new RotateTransform(a);

                one_four.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                one_four.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                one_four.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    one_four.RenderTransform = new RotateTransform(a);
                    one_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        one_four.RenderTransform = new RotateTransform(a);
                        one_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    one_four.RenderTransform = new RotateTransform(a);
                    one_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void one_five_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("1", "5"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                one_five.RenderTransform = new RotateTransform(a);
                one_five.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                one_five.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                one_five.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                one_five.RenderTransform = new RotateTransform(a);

                one_five.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                one_five.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                one_five.RenderTransform = new RotateTransform(a);

                one_five.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                one_five.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                one_five.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    one_five.RenderTransform = new RotateTransform(a);
                    one_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        one_five.RenderTransform = new RotateTransform(a);
                        one_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    one_five.RenderTransform = new RotateTransform(a);
                    one_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void one_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("1", "6"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                one_six.RenderTransform = new RotateTransform(a);
                one_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                one_six.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                one_six.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                one_six.RenderTransform = new RotateTransform(a);

                one_six.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                one_six.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                one_six.RenderTransform = new RotateTransform(a);

                one_six.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                one_six.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                one_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    one_six.RenderTransform = new RotateTransform(a);
                    one_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        one_six.RenderTransform = new RotateTransform(a);
                        one_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    one_six.RenderTransform = new RotateTransform(a);
                    one_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void two_two_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("2", "2"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                two_two.RenderTransform = new RotateTransform(a);
                two_two.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                two_two.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                two_two.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                two_two.RenderTransform = new RotateTransform(a);

                two_two.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                two_two.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                two_two.RenderTransform = new RotateTransform(a);

                two_two.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                two_two.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                two_two.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    two_two.RenderTransform = new RotateTransform(a);
                    two_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        two_two.RenderTransform = new RotateTransform(a);
                        two_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    two_two.RenderTransform = new RotateTransform(a);
                    two_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void two_third_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("2", "3"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                two_third.RenderTransform = new RotateTransform(a);
                two_third.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                two_third.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                two_third.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                two_third.RenderTransform = new RotateTransform(a);

                two_third.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                two_third.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                two_third.RenderTransform = new RotateTransform(a);

                two_third.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                two_third.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                two_third.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    two_third.RenderTransform = new RotateTransform(a);
                    two_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        two_third.RenderTransform = new RotateTransform(a);
                        two_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    two_third.RenderTransform = new RotateTransform(a);
                    two_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void two_four_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("2", "4"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                two_four.RenderTransform = new RotateTransform(a);
                two_four.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                two_four.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                two_four.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                two_four.RenderTransform = new RotateTransform(a);

                two_four.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                two_four.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                two_four.RenderTransform = new RotateTransform(a);

                two_four.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                two_four.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                two_four.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    two_four.RenderTransform = new RotateTransform(a);
                    two_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        two_four.RenderTransform = new RotateTransform(a);
                        two_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    two_four.RenderTransform = new RotateTransform(a);
                    two_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void two_five_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("2", "5"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                two_five.RenderTransform = new RotateTransform(a);
                two_five.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                two_five.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                two_five.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                two_five.RenderTransform = new RotateTransform(a);

                two_five.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                two_five.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                two_five.RenderTransform = new RotateTransform(a);

                two_five.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                two_five.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                two_five.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    two_five.RenderTransform = new RotateTransform(a);
                    two_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        two_five.RenderTransform = new RotateTransform(a);
                        two_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    two_five.RenderTransform = new RotateTransform(a);
                    two_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void two_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("2", "6"));

            if (kol == 8)
            {

                a = 0;
                a += 90;
                two_six.RenderTransform = new RotateTransform(a);
                two_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                two_six.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                two_six.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                two_six.RenderTransform = new RotateTransform(a);

                two_six.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                two_six.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                two_six.RenderTransform = new RotateTransform(a);

                two_six.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                two_six.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                two_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    two_six.RenderTransform = new RotateTransform(a);
                    two_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        two_six.RenderTransform = new RotateTransform(a);
                        two_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    two_six.RenderTransform = new RotateTransform(a);
                    two_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }

        }

        private void third_third_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("3", "3"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                third_third.RenderTransform = new RotateTransform(a);
                third_third.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                third_third.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                third_third.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                third_third.RenderTransform = new RotateTransform(a);

                third_third.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                third_third.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                third_third.RenderTransform = new RotateTransform(a);

                third_third.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                third_third.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                third_third.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    third_third.RenderTransform = new RotateTransform(a);
                    third_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        third_third.RenderTransform = new RotateTransform(a);
                        third_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    third_third.RenderTransform = new RotateTransform(a);
                    third_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void third_four_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("3", "4"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                third_four.RenderTransform = new RotateTransform(a);
                third_four.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                third_four.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                third_four.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                third_four.RenderTransform = new RotateTransform(a);

                third_four.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                third_four.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                third_four.RenderTransform = new RotateTransform(a);

                third_four.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                third_four.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                third_four.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    third_four.RenderTransform = new RotateTransform(a);
                    third_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        third_four.RenderTransform = new RotateTransform(a);
                        third_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    third_four.RenderTransform = new RotateTransform(a);
                    third_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void third_five_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("3", "5"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                third_five.RenderTransform = new RotateTransform(a);
                third_five.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                third_five.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                third_five.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                third_five.RenderTransform = new RotateTransform(a);

                third_five.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                third_five.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                third_five.RenderTransform = new RotateTransform(a);

                third_five.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                third_five.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                third_five.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    third_five.RenderTransform = new RotateTransform(a);
                    third_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        third_five.RenderTransform = new RotateTransform(a);
                        third_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    third_five.RenderTransform = new RotateTransform(a);
                    third_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void third_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("3", "6"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                third_six.RenderTransform = new RotateTransform(a);
                third_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                third_six.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                third_six.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                third_six.RenderTransform = new RotateTransform(a);

                third_six.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                third_six.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                third_six.RenderTransform = new RotateTransform(a);

                third_six.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                third_six.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                third_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    third_six.RenderTransform = new RotateTransform(a);
                    third_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        third_six.RenderTransform = new RotateTransform(a);
                        third_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    third_six.RenderTransform = new RotateTransform(a);
                    third_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void four_four_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("4", "4"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                four_four.RenderTransform = new RotateTransform(a);
                four_four.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                four_four.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                four_four.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                four_four.RenderTransform = new RotateTransform(a);

                four_four.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                four_four.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                four_four.RenderTransform = new RotateTransform(a);

                four_four.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                four_four.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                four_four.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    four_four.RenderTransform = new RotateTransform(a);
                    four_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        four_four.RenderTransform = new RotateTransform(a);
                        four_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    four_four.RenderTransform = new RotateTransform(a);
                    four_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void four_five_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("4", "5"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                four_five.RenderTransform = new RotateTransform(a);
                four_five.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                four_five.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                four_five.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                four_five.RenderTransform = new RotateTransform(a);

                four_five.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                four_five.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                four_five.RenderTransform = new RotateTransform(a);

                four_five.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                four_five.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                four_five.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    four_five.RenderTransform = new RotateTransform(a);
                    four_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        four_five.RenderTransform = new RotateTransform(a);
                        four_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    four_five.RenderTransform = new RotateTransform(a);
                    four_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }

        private void four_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("4", "6"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                four_six.RenderTransform = new RotateTransform(a);
                four_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                four_six.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                four_six.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                four_six.RenderTransform = new RotateTransform(a);

                four_six.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                four_six.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                four_six.RenderTransform = new RotateTransform(a);

                four_six.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                four_six.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                four_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    four_six.RenderTransform = new RotateTransform(a);
                    four_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        four_six.RenderTransform = new RotateTransform(a);
                        four_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    four_six.RenderTransform = new RotateTransform(a);
                    four_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
        }
        private void five_five_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("5", "5"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                five_five.RenderTransform = new RotateTransform(a);
                five_five.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                five_five.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                five_five.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                five_five.RenderTransform = new RotateTransform(a);

                five_five.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                five_five.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                five_five.RenderTransform = new RotateTransform(a);

                five_five.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                five_five.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                five_five.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    five_five.RenderTransform = new RotateTransform(a);
                    five_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        five_five.RenderTransform = new RotateTransform(a);
                        five_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {

                    a = 0;
                    a += 180;
                    five_five.RenderTransform = new RotateTransform(a);
                    five_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }

        }
        private void five_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("5", "6"));
            if (kol == 8)
            {

                a = 0;
                a += 90;
                five_six.RenderTransform = new RotateTransform(a);
                five_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 470;

            }
            else if (kol == 9)
            {
                kol--;
                kol--;

                five_six.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;

            }
            else if (kol2 < 7 && kol2 > 0)
            {

                five_six.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                kol2--;
                kolUni = kol2;
                k1 = 80;
                k2 = 350;
            }
            else if (kol2 == 0)
            {
                kol2--;
                a = 0;
                a += 90;
                five_six.RenderTransform = new RotateTransform(a);

                five_six.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                kol3++;
                kolUni = kol3;
                k1 = 220;
                k2 = 270;
            }
            else if (kol3 > 0 && kol3 < 7)
            {

                five_six.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                kol3++;
                kolUni = kol3;
                k1 = 120;
                k2 = 150;
            }
            else if (kol3 == 7)
            {
                a = 0;
                a += 90;
                five_six.RenderTransform = new RotateTransform(a);

                five_six.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                kol3++;
                kol4--;
                kolUni = kol3;
                k1 = 120;
                k2 = 70;
            }
            else if (kol4 < 5)
            {

                five_six.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                kol4--;
                kolUni = kol4;
                k1 = 280;
                k2 = -50;
            }
            else
            {

                five_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                kol++;
                kolUni = kol;
                k1 = 120;
                k2 = 550 - 80;
            }

            if (snake.Count < 2)
            {
                return;
            }
            else if (snake.Count == 2)
            {
                if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    a = 0;
                    a += 180;
                    five_six.RenderTransform = new RotateTransform(a);
                    five_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }
            else if (snake.Count >= 3)
            {
                MessageBox.Show(k1 + " " + kolUni + " " + k2);
                if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                {
                    if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                    {

                        a = 0;
                        a += 180;
                        five_six.RenderTransform = new RotateTransform(a);
                        five_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                {
                    MessageBox.Show("5+6");
                    a = 0;
                    a += 180;
                    five_six.RenderTransform = new RotateTransform(a);
                    five_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                }
            }

        }
        private void six_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("6", "6"));
            if(snake.Count>=2 && snake[snake.Count-2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y)
            {
                if (kol == 8)
                {

                    a = 0;
                    a += 90;
                    six_six.RenderTransform = new RotateTransform(a);
                    six_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 470);
                    kol++;
                    kolUni = kol;
                    k1 = 120;
                    k2 = 470;

                }
                else if (kol == 9)
                {
                    kol--;
                    kol--;

                    six_six.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                    kol2--;
                    kolUni = kol2;
                    k1 = 80;
                    k2 = 350;

                }
                else if (kol2 < 7 && kol2 > 0)
                {

                    six_six.Margin = new Thickness(80 + (kol2 * 100), 0, 0, 350);
                    kol2--;
                    kolUni = kol2;
                    k1 = 80;
                    k2 = 350;
                }
                else if (kol2 == 0)
                {
                    kol2--;
                    a = 0;
                    a += 90;
                    six_six.RenderTransform = new RotateTransform(a);

                    six_six.Margin = new Thickness(220 + (kol3 * 100), 0, 0, 270);
                    kol3++;
                    kolUni = kol3;
                    k1 = 220;
                    k2 = 270;
                }
                else if (kol3 > 0 && kol3 < 7)
                {

                    six_six.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 150);
                    kol3++;
                    kolUni = kol3;
                    k1 = 120;
                    k2 = 150;
                }
                else if (kol3 == 7)
                {
                    a = 0;
                    a += 90;
                    six_six.RenderTransform = new RotateTransform(a);

                    six_six.Margin = new Thickness(120 + (kol3 * 100), 0, 0, 70);
                    kol3++;
                    kol4--;
                    kolUni = kol3;
                    k1 = 120;
                    k2 = 70;
                }
                else if (kol4 < 5)
                {

                    six_six.Margin = new Thickness(280 + (kol4 * 100), 0, 0, -50);
                    kol4--;
                    kolUni = kol4;
                    k1 = 280;
                    k2 = -50;
                }
                else
                {

                    six_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
                    kol++;
                    kolUni = kol;
                    k1 = 120;
                    k2 = 550 - 80;
                }

                if (snake.Count < 2)
                {
                    return;
                }
                else if (snake.Count == 2)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {
                        MessageBox.Show(k1 + " " + kolUni + " " + k2);
                        a = 0;
                        a += 180;
                        six_six.RenderTransform = new RotateTransform(a);
                        six_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
                else if (snake.Count >= 3)
                {
                    MessageBox.Show(k1 + " " + kolUni + " " + k2);
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            a += 180;
                            six_six.RenderTransform = new RotateTransform(a);
                            six_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        a += 180;
                        six_six.RenderTransform = new RotateTransform(a);
                        six_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                    }
                }
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }

            

        }

    }
    public class Bone
    {
        
        public Bone(string x, string y)
        {
            this.x = x;
            this.y = y;
        }
        public string x { get; set; }
        public string y { get; set; }

    }
}
