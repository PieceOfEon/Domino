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
        Random random = new Random();
        List<Border> bon = new List<Border>();
        List<Bone> snake = new List<Bone>();
        List<Border> player1 = new List<Border>();
        List<Border> player2 = new List<Border>();
        bool b = true;
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

            

            bon.Add(zero_zero);//1
            bon.Add(zero_one);//2
            bon.Add(zero_two);//3
            bon.Add(zero_third);//4
            bon.Add(zero_four);//5
            bon.Add(zero_five);//6
            bon.Add(zero_six);//7

            bon.Add(one_one);//8
            bon.Add(one_two);//9
            bon.Add(one_third);//10
            bon.Add(one_four);//11
            bon.Add(one_five);//12
            bon.Add(one_six);//13

            bon.Add(two_two);//14
            bon.Add(two_third);//15
            bon.Add(two_four);//16
            bon.Add(two_five);//17
            bon.Add(two_six);//18

            bon.Add(third_third);//19
            bon.Add(third_four);//20
            bon.Add(third_five);//21
            bon.Add(third_six);//22

            bon.Add(four_four);//23
            bon.Add(four_five);//24
            bon.Add(four_six);//25

            bon.Add(five_five);//26
            bon.Add(five_six);//27

            bon.Add(six_six);//28

            
            


            this.DataContext=bon;
            rand();
            rand2();
            //MessageBox.Show(Convert.ToString(bon[5].y));
        }

        private void rand()
        {
            for(int i=0; i < bon.Count; i++)
            {
                bon[i].Visibility = Visibility.Hidden;
            }

            for (int i = player1.Count; i < 7; i++)
            {
                int a = random.Next(0, bon.Count);
                player1.Add(bon[a]);
                player1[i].Visibility = Visibility.Visible;
                bon.Remove(bon[a]);
               
            }

            for(int i = 0; i < 7; i++)
            {
                player1[i].Margin = new Thickness(120 + (i * 120), 0, 0, -450);
            }
        }

        private void rand2()
        {
            for (int i = 0; i < bon.Count; i++)
            {
                bon[i].Visibility = Visibility.Hidden;
            }

            for (int i = player2.Count; i < 7; i++)
            {
                int b = random.Next(0, bon.Count);
                player2.Add(bon[b]);
                player2[i].Visibility = Visibility.Visible;
                bon.Remove(bon[b]);
            }

            for (int i = 0; i < 7; i++)
            {
                player2[i].Margin = new Thickness(120 + (i * 120), 0, 0, -600);
            }
        }

        private void borderplayer()
        {
            if(borderP1.IsVisible)
            {
                borderP1.Visibility = Visibility.Hidden;
                borderP2.Visibility = Visibility.Visible;
            }
            else
            {
                borderP1.Visibility = Visibility.Visible;
                borderP2.Visibility = Visibility.Hidden;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (borderP1.IsVisible)
            {
                rand();
            }
            else
            {
                rand2();
            }
        }
        private void zero_zero_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("0", "0"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                borderplayer();
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void zero_one_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("0", "1"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                       
                        a = 0;
                        a += 180;
                        zero_one.RenderTransform = new RotateTransform(a);
                        zero_one.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("1", "0"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            zero_one.RenderTransform = new RotateTransform(a);
                            zero_one.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("1", "0"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        zero_one.RenderTransform = new RotateTransform(a);
                        zero_one.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("1", "0"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        zero_one.RenderTransform = new RotateTransform(a);
                        zero_one.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("1", "0"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        zero_one.RenderTransform = new RotateTransform(a);
                        zero_one.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("1", "0"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void zero_two_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("0", "2"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        zero_two.RenderTransform = new RotateTransform(a);
                        zero_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("2", "0"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                   
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            zero_two.RenderTransform = new RotateTransform(a);
                            zero_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("2", "0"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        zero_two.RenderTransform = new RotateTransform(a);
                        zero_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("2", "0"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        zero_two.RenderTransform = new RotateTransform(a);
                        zero_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("2", "0"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        zero_two.RenderTransform = new RotateTransform(a);
                        zero_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("2", "0"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void zero_third_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("0", "3"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        zero_third.RenderTransform = new RotateTransform(a);
                        zero_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("3", "0"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {
                            a = 0;
                            if (kol==9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            
                            a += 180;
                            zero_third.RenderTransform = new RotateTransform(a);
                            zero_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("3", "0"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        zero_third.RenderTransform = new RotateTransform(a);
                        zero_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("3", "0"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        zero_third.RenderTransform = new RotateTransform(a);
                        zero_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("3", "0"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        zero_third.RenderTransform = new RotateTransform(a);
                        zero_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("3", "0"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void zero_four_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("0", "4"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        zero_four.RenderTransform = new RotateTransform(a);
                        zero_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "0"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            zero_four.RenderTransform = new RotateTransform(a);
                            zero_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("4", "0"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        zero_four.RenderTransform = new RotateTransform(a);
                        zero_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "0"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        zero_four.RenderTransform = new RotateTransform(a);
                        zero_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "0"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        zero_four.RenderTransform = new RotateTransform(a);
                        zero_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "0"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void zero_five_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("0", "5"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        zero_five.RenderTransform = new RotateTransform(a);
                        zero_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "0"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            zero_five.RenderTransform = new RotateTransform(a);
                            zero_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("5", "0"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        zero_five.RenderTransform = new RotateTransform(a);
                        zero_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "0"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        zero_five.RenderTransform = new RotateTransform(a);
                        zero_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "0"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        zero_five.RenderTransform = new RotateTransform(a);
                        zero_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "0"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void zero_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("0", "6"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                       
                        a = 0;
                        a += 180;
                        zero_six.RenderTransform = new RotateTransform(a);
                        zero_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "0"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            zero_six.RenderTransform = new RotateTransform(a);
                            zero_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("6", "0"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        zero_six.RenderTransform = new RotateTransform(a);
                        zero_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "0"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        zero_six.RenderTransform = new RotateTransform(a);
                        zero_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "0"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        zero_six.RenderTransform = new RotateTransform(a);
                        zero_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "0"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void one_one_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("1", "1"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void one_two_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("1", "2"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        one_two.RenderTransform = new RotateTransform(a);
                        one_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("2", "1"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            one_two.RenderTransform = new RotateTransform(a);
                            one_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("2", "1"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        one_two.RenderTransform = new RotateTransform(a);
                        one_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("2", "1"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        one_two.RenderTransform = new RotateTransform(a);
                        one_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("2", "1"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        one_two.RenderTransform = new RotateTransform(a);
                        one_two.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("2", "1"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void one_third_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("1", "3"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        one_third.RenderTransform = new RotateTransform(a);
                        one_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("3", "1"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            one_third.RenderTransform = new RotateTransform(a);
                            one_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("3", "1"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        one_third.RenderTransform = new RotateTransform(a);
                        one_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("3", "1"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        one_third.RenderTransform = new RotateTransform(a);
                        one_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("3", "1"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        one_third.RenderTransform = new RotateTransform(a);
                        one_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("3", "1"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void one_four_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("1", "4"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        one_four.RenderTransform = new RotateTransform(a);
                        one_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "1"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            one_four.RenderTransform = new RotateTransform(a);
                            one_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("4", "1"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        one_four.RenderTransform = new RotateTransform(a);
                        one_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "1"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        one_four.RenderTransform = new RotateTransform(a);
                        one_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "1"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        one_four.RenderTransform = new RotateTransform(a);
                        one_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "1"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void one_five_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("1", "5"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        one_five.RenderTransform = new RotateTransform(a);
                        one_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "1"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            one_five.RenderTransform = new RotateTransform(a);
                            one_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("5", "1"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        one_five.RenderTransform = new RotateTransform(a);
                        one_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "1"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        one_five.RenderTransform = new RotateTransform(a);
                        one_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "1"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        one_five.RenderTransform = new RotateTransform(a);
                        one_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "1"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void one_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("1", "6"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        one_six.RenderTransform = new RotateTransform(a);
                        one_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "1"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                   
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            one_six.RenderTransform = new RotateTransform(a);
                            one_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("6", "1"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        one_six.RenderTransform = new RotateTransform(a);
                        one_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "1"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        one_six.RenderTransform = new RotateTransform(a);
                        one_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "1"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        one_six.RenderTransform = new RotateTransform(a);
                        one_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "1"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void two_two_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("2", "2"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void two_third_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("2", "3"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        two_third.RenderTransform = new RotateTransform(a);
                        two_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("3", "2"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            two_third.RenderTransform = new RotateTransform(a);
                            two_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("3", "2"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        two_third.RenderTransform = new RotateTransform(a);
                        two_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("3", "2"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        two_third.RenderTransform = new RotateTransform(a);
                        two_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("3", "2"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        two_third.RenderTransform = new RotateTransform(a);
                        two_third.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("3", "2"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void two_four_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("2", "4"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {
                        
                        a = 0;
                        a += 180;
                        two_four.RenderTransform = new RotateTransform(a);
                        two_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "2"));
                    }
                }
                else if (snake.Count >= 3)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            two_four.RenderTransform = new RotateTransform(a);
                            two_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("4", "2"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        two_four.RenderTransform = new RotateTransform(a);
                        two_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "2"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        two_four.RenderTransform = new RotateTransform(a);
                        two_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "2"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        two_four.RenderTransform = new RotateTransform(a);
                        two_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "2"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void two_five_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("2", "5"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                       
                        a = 0;
                        a += 180;
                        two_five.RenderTransform = new RotateTransform(a);
                        two_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "2"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            
                            a += 180;
                            two_five.RenderTransform = new RotateTransform(a);
                            two_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("5", "2"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        two_five.RenderTransform = new RotateTransform(a);
                        two_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "2"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        two_five.RenderTransform = new RotateTransform(a);
                        two_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "2"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        two_five.RenderTransform = new RotateTransform(a);
                        two_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "2"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void two_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("2", "6"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        two_six.RenderTransform = new RotateTransform(a);
                        two_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "2"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            else if (kol2 < 7 && kol2 > 0)
                            {
                                k1 += 200;
                                k2 -= 80;
                            }
                            a += 180;
                            two_six.RenderTransform = new RotateTransform(a);
                            two_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("6", "2"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        else if (kol2 < 7 && kol2 > 0)
                        {
                            k1 += 200;
                            k2 -= 80;
                        }
                        a += 180;
                        two_six.RenderTransform = new RotateTransform(a);
                        two_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "2"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        two_six.RenderTransform = new RotateTransform(a);
                        two_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "2"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        two_six.RenderTransform = new RotateTransform(a);
                        two_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "2"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }

        }

        private void third_third_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("3", "3"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void third_four_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("3", "4"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        third_four.RenderTransform = new RotateTransform(a);
                        third_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "3"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            third_four.RenderTransform = new RotateTransform(a);
                            third_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("4", "3"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        third_four.RenderTransform = new RotateTransform(a);
                        third_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "3"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        third_four.RenderTransform = new RotateTransform(a);
                        third_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "3"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        third_four.RenderTransform = new RotateTransform(a);
                        third_four.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("4", "3"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void third_five_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("3", "5"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count -2].x || snake.Count>10 && snake[snake.Count-1].y== snake[snake.Count -2].x ||  snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        a = 0;
                        a += 180;
                        third_five.RenderTransform = new RotateTransform(a);
                        third_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "3"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            third_five.RenderTransform = new RotateTransform(a);
                            third_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("5", "3"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        third_five.RenderTransform = new RotateTransform(a);
                        third_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "3"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        third_five.RenderTransform = new RotateTransform(a);
                        third_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "3"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        third_five.RenderTransform = new RotateTransform(a);
                        third_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "3"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void third_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("3", "6"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        third_six.RenderTransform = new RotateTransform(a);
                        third_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "3"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                   
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            third_six.RenderTransform = new RotateTransform(a);
                            third_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("6", "3"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        third_six.RenderTransform = new RotateTransform(a);
                        third_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "3"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        third_six.RenderTransform = new RotateTransform(a);
                        third_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "3"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        third_six.RenderTransform = new RotateTransform(a);
                        third_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "3"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void four_four_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("4", "4"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }

        private void four_five_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("4", "5"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        four_five.RenderTransform = new RotateTransform(a);
                        four_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "4"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            four_five.RenderTransform = new RotateTransform(a);
                            four_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("5", "4"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        four_five.RenderTransform = new RotateTransform(a);
                        four_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "4"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        four_five.RenderTransform = new RotateTransform(a);
                        four_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "4"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        four_five.RenderTransform = new RotateTransform(a);
                        four_five.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("5", "4"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }

        }

        private void four_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("4", "6"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        four_six.RenderTransform = new RotateTransform(a);
                        four_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "4"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count < 10)
                {
                    
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {

                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            a += 180;
                            four_six.RenderTransform = new RotateTransform(a);
                            four_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("6", "4"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        a += 180;
                        four_six.RenderTransform = new RotateTransform(a);
                        four_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "4"));
                    }
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        four_six.RenderTransform = new RotateTransform(a);
                        four_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "4"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 200;
                        k2 -= 80;
                        a += 180;
                        four_six.RenderTransform = new RotateTransform(a);
                        four_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "4"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }

        }
        private void five_five_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("5", "5"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                borderplayer();

            }
            else if(snake.Count==1)
            {
                return;
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }

        }
        private void five_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("5", "6"));
            if (snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x == snake[snake.Count - 2].y && snake[snake.Count - 1].x != snake[snake.Count - 2].x || snake[snake.Count - 1].y == snake[snake.Count - 2].y && snake[snake.Count - 1].y != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                        
                        a = 0;
                        a += 180;
                        five_six.RenderTransform = new RotateTransform(a);
                        five_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "5"));
                    }
                }
                else if (snake.Count >= 3 && snake.Count<10)
                {
                   
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].y)
                    {
                        if (snake[snake.Count - 3].y == snake[snake.Count - 2].y)
                        {
                            a = 0;
                            if (kol == 9)
                            {
                                a += 90;
                                k1 -= 140;
                                k2 -= 200;
                            }
                            //else if (kol2 <= 7 && kol2 > 0)
                            //{
                            //    k1 += 200;
                            //    k2 -= 80;
                            //}
                            a += 180;
                            five_six.RenderTransform = new RotateTransform(a);
                            five_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                            snake.Remove(snake[snake.Count - 1]);
                            snake.Add(new Bone("6", "5"));
                        }
                    }
                    else if (snake[snake.Count - 2].y == snake[snake.Count - 1].y)
                    {

                        a = 0;
                        if (kol == 9)
                        {
                            a += 90;
                            k1 -= 140;
                            k2 -= 200;
                        }
                        //else if (kol2 <= 7 && kol2 > 0)
                        //{
                        //    k1 += 200;
                        //    k2 -= 80;
                        //}
                        a += 180;
                        five_six.RenderTransform = new RotateTransform(a);
                        five_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "5"));
                    }
                   
                }
                else if (snake.Count == 10)
                {
                    if (snake[snake.Count - 2].y == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 100;
                        a += 180;
                        five_six.RenderTransform = new RotateTransform(a);
                        five_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "5"));
                    }
                }
                else if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 2].x == snake[snake.Count - 1].x)
                    {
                        a = 0;
                        k1 += 100;
                        
                        a += 180;
                        five_six.RenderTransform = new RotateTransform(a);
                        five_six.Margin = new Thickness(k1 + (kolUni * 100), 0, 0, k2);
                        snake.Remove(snake[snake.Count - 1]);
                        snake.Add(new Bone("6", "5"));
                    }
                }
                borderplayer();
            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }
        }
        private void six_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            kolUni = 0;
            k1 = 0;
            k2 = 0;
            snake.Add(new Bone("6", "6"));
            if(snake.Count > 10 && snake[snake.Count - 1].x == snake[snake.Count - 2].x || snake.Count > 10 && snake[snake.Count - 1].y == snake[snake.Count - 2].x || snake.Count == 1 || snake.Count>=2 && snake[snake.Count-2].y == snake[snake.Count - 1].y || snake.Count >= 2 && snake[snake.Count - 2].y == snake[snake.Count - 1].x)
            {
                if (snake.Count > 10 && snake.Count < 17)
                {
                    if (snake[snake.Count - 1].x != snake[snake.Count - 2].x)
                    {
                        snake.Remove(snake[snake.Count - 1]);
                        return;
                    }
                }
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
                borderplayer();

            }
            else
            {
                snake.Remove(snake[snake.Count - 1]);
                //snake.Add(new Bone("6", "6"));
                return;
            }

            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            borderplayer();
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
