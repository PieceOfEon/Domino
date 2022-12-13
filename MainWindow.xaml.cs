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
        int a = 0;
        int kol = 0;
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
        }

        private void five_six_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (a >= 360)
            { a = 0; }
            a += 90;
            five_six.RenderTransform = new RotateTransform(a);
        }

        //private void five_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    if(e.ButtonState==MouseButtonState.Pressed)
        //    {
        //        Left = e.GetPosition(this).X;
        //        Top = e.GetPosition(this).Y;
        //    }
        //    //five_six.RenderTransform = new MatrixTransform(0, 0,0,0, e.GetPosition(this).X, e.GetPosition(this).Y);
        //    //if (e.LeftButton == MouseButtonState.Pressed)
        //    //{
        //    //    Left =e.GetPosition(this).X;
        //    //    Top = e.GetPosition(this).Y;
        //    //    //MouseEventArgs mea = new MouseEventArgs(MouseDevice mouse, int timestamp, StylusDevice stylusDevice);
        //    //    //Point p = e.GetPosition(this);
        //    //    //MessageBox.Show("Margin=" + five_six.Margin.ToString());
        //    //    //five_six.Margin = new Thickness(p.X, 0, 0, p.Y);
        //    //    //MessageBox.Show("PX=" + p.X.ToString(), "PY=" + p.Y.ToString());
        //    //    //MessageBox.Show("Margin=" + five_six.Margin.ToString());
        //    //    //MessageBox.Show(e.GetPosition(this).X.ToString(), e.GetPosition(this).Y.ToString());
        //    //}
        //}

        private int m_dragIndx;
        bool m_inMouseMove;

        private void five_six_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            //if (!m_inMouseMove)
            //{
            //    m_inMouseMove = true;
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                ++m_dragIndx;

                DragDrop.DoDragDrop(five_six, m_dragIndx, DragDropEffects.All);
                e.Handled = true;
                if (e.LeftButton==MouseButtonState.Released)
                {

                    ALBE.Content = five_six.Margin.ToString();
                    five_six.Margin = new Thickness(0, 0, 0, 0);


                    Point p = e.GetPosition(this);

                    five_six.Margin = new Thickness(p.X, 0, 0, p.Y-1);

                    ALBE.Content += "\n" +five_six.Margin.ToString() +"\n P.X =" + p.X +" P.Y =" + p.Y;
                   


                }
                }
            
            //}

        }

        private void five_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            five_six.Margin = new Thickness(120+(kol*100), 0, 0, 550);
            kol++;
            
        }

        private void six_six_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            six_six.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
            kol++;
        }

        private void five_five_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
            five_five.Margin = new Thickness(120 + (kol * 100), 0, 0, 550);
            kol++;
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
