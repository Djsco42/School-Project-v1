﻿using System;
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
using System.Windows.Media.Animation;
using System.Security.Policy;
using System.Net.NetworkInformation;
using System.Timers;
using System.Windows.Threading;
using System.Threading;
using System.IO;
using System.Reflection.Emit;

namespace School_Project_v1
{
    public partial class MainWindow : Window
    {
        int i = 0;
        private bool IsR = false; 
        private int Pg= 0;
        private Storyboard Enter1StoryBoard;
        private DispatcherTimer T;
        private DispatcherTimer Pg2C;
        private DispatcherTimer Ctimer;
        private DispatcherTimer Rtimer;
        private DispatcherTimer Ptimer;

        private Dictionary<Image, string> imageFolders = new Dictionary<Image, string>();
        private Dictionary<Image, int> currentImageIndexes = new Dictionary<Image, int>();

        private string[] BimageFiles;
        private int BcurrentIndex;


        public MainWindow()
        {
            InitializeComponent();

            BcurrentIndex = 0;
            BimageFiles = Directory.GetFiles(@"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Bloopers\", "*.png");

            Rtimer = new DispatcherTimer();
            Rtimer.Tick += Rtimer_Tick;
            Rtimer.Interval = TimeSpan.FromMilliseconds(1000);

            Ctimer = new DispatcherTimer();
            Ctimer.Tick += CTimer_Tick;
            Ctimer.Interval = TimeSpan.FromMilliseconds(2000);

            T = new DispatcherTimer();
            T.Interval = TimeSpan.FromMilliseconds(2000);
            T.Tick += T_Tick;

            Pg2C = new DispatcherTimer();
            Pg2C.Interval=TimeSpan.FromMilliseconds(1100);
            Pg2C.Tick += Pg2C_Tick;

            Ptimer = new DispatcherTimer();
            Ptimer.Tick += Ptimer_Tick;
            Ptimer.Interval = TimeSpan.FromMilliseconds(1200);

            

            DoubleAnimation Enter1Ani = new DoubleAnimation();
            Enter1Ani.From = 0.0;
            Enter1Ani.To = 1.0;
            Enter1Ani.Duration = new Duration(TimeSpan.FromMilliseconds(1500));
            Storyboard.SetTargetName(Enter1Ani, Enter1.Name);
            Storyboard.SetTargetProperty(Enter1Ani, new PropertyPath(TextBlock.OpacityProperty));
            Enter1StoryBoard = new Storyboard();
            Enter1StoryBoard.AutoReverse = true;
            Enter1StoryBoard.RepeatBehavior = RepeatBehavior.Forever;
            Enter1StoryBoard.Children.Add(Enter1Ani);

            HotKey None = new HotKey();
            HotKey Esc = new HotKey();
            HotKey H = new HotKey();
            HotKey None2 = new HotKey();
            HotKey None3 = new HotKey();
            HotKey Z = new HotKey();
            Z.Key = "Z";
            Z.Action = "Closes the Application";
            None.Key = " ";
            None.Action = " ";
            Esc.Key = "Esc";
            Esc.Action = "Resizes the Window";
            H.Key = "H";
            H.Action = "Brings up this Page";
            b.Items.Add(None);
            b.Items.Add(Esc);
            b.Items.Add(Z);
            b.Items.Add(H);


            // Add image folders and current image indexes for each Image control
            imageFolders.Add(Amalia, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Amalia\");
            currentImageIndexes.Add(Amalia, 0);

            imageFolders.Add(Alex, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Alex\");
            currentImageIndexes.Add(Alex, 0);

            imageFolders.Add(Amaya, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Amaya\");
            currentImageIndexes.Add(Amaya, 0);

            imageFolders.Add(Colton, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Colton\");
            currentImageIndexes.Add(Colton, 0);

            imageFolders.Add(Finn, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Finn\");
            currentImageIndexes.Add(Finn, 0);

            imageFolders.Add(Giuliana, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Giuliana\");
            currentImageIndexes.Add(Giuliana, 0);

            imageFolders.Add(Grant, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Grant\");
            currentImageIndexes.Add(Grant, 0);

            imageFolders.Add(Jasmin, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Jasmin\");
            currentImageIndexes.Add(Jasmin, 0);

            imageFolders.Add(Miles, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Miles\");
            currentImageIndexes.Add(Miles, 0);

            imageFolders.Add(Noah, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Noah\");
            currentImageIndexes.Add(Noah, 0);

            imageFolders.Add(Olivia, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Olivia\");
            currentImageIndexes.Add(Olivia, 0);

            imageFolders.Add(Sariah, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Sariah\");
            currentImageIndexes.Add(Sariah, 0);

            imageFolders.Add(Tristian, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Tristian\");
            currentImageIndexes.Add(Tristian, 0);



        }

        private void myWindow_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.Key == Key.Escape)
            {
                i++;
                if (i < 2)
                {
                    Application.Current.MainWindow = this;
                    this.Width = 420;
                    this.Height = 420;
                    this.WindowState = WindowState.Normal;
                    this.WindowStyle = WindowStyle.ToolWindow;
                }

                else
                {
                    this.WindowState = WindowState.Maximized;
                    this.WindowStyle = WindowStyle.None;
                    i= 0;
                }
            }

            if(e.Key== Key.Z) 
            { 
                Application.Current.Shutdown();
            }

            if (e.Key == Key.Enter)
            {
                Pg++;
                if (Pg == 1)
                {

                    Pg1.Visibility = Visibility.Collapsed;
                    Pg2.Visibility = Visibility.Visible;
                    Enter1StoryBoard.Stop();
                    Enter1.Visibility= Visibility.Collapsed;

                    T.Start();

                    Ani.Fade(Pg2, 0, 1, 3000);
                }

                if (Pg == 2)
                {
                    Enter1StoryBoard.Stop();
                    Enter1.Visibility = Visibility.Collapsed;
                    Pg2.Visibility= Visibility.Collapsed;
                    Pg3.Visibility= Visibility.Visible;
                    T.Start();

                    Ani.Fade(Pg3, 0, 1, 3000);
                }
                if(Pg == 3)
                {
                    Enter1StoryBoard.Stop();
                    Enter1.Visibility = Visibility.Collapsed;
                    Pg3.Visibility = Visibility.Collapsed;
                    Pg4.Visibility= Visibility.Visible;
                    Ani.Fade(Pg4, 0, 1, 1000);
                    Ctimer.Start();
                    Rtimer.Start();


                }

                if(Pg == 4)
                {

                    Ctimer.Stop();
                    Rtimer.Stop();
                    Ani.Fade(Pg4, 1, 0, 1000);
                    Enter1.Visibility = Visibility.Collapsed;
                    Ptimer.Start();
                }
            }
            if(e.Key == Key.H) 
            {
                if (Pg2.Visibility == Visibility.Collapsed)
                {
                    Pg2.Visibility = Visibility.Visible;
                    Ani.Fade(Pg2, 0, 1, 900);
                    Pg2.Margin = new Thickness(0, 0, 0, 0);
                    a.Text = "APPLICATION HOTKEYS";
                }
                else
                {
                    if (a.Text == "APPLICATION HOTKEYS")
                    {
                        Ani.Fade(Pg2, 1, 0, 1000);
                        Pg2C.Start(); 
                    }

                }

            }
        }
        private void Pg2C_Tick(object sender, EventArgs e)
        {
            Pg2.Visibility = Visibility.Collapsed;
            Pg2C.Stop();
        }
        private void T_Tick(object sender, EventArgs e)
        {
            Enter1.Visibility= Visibility.Visible;
            Enter1StoryBoard.Begin(this);
            T.Stop();
        }

        private void Ptimer_Tick(object sender, EventArgs e)
        {
            if(Pg4.Visibility == Visibility.Visible) { 
            Pg4.Visibility = Visibility.Collapsed;
                Pg5.Visibility = Visibility.Visible;
                Ani.Fade(Pg5, 0, 1, 1000);
            }

            if (BimageFiles.Length > 0)
            {
                if (BcurrentIndex >= BimageFiles.Length)
                {
                    BcurrentIndex = 0; // Reset index to cycle back to the first image
                }

                string BimagePath = BimageFiles[BcurrentIndex];
                LoadImage(BimagePath);
                BcurrentIndex++;
            }
        }

        private void LoadImage(string BimagePath)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(BimagePath);
            bitmap.EndInit();
            BL.Source = bitmap;
        }
    




        private void CTimer_Tick(object sender, EventArgs e)
        {
            foreach (var imageFolder in imageFolders)
            {
                Image image = imageFolder.Key;
                string folderPath = imageFolder.Value;
                int currentImageIndex = currentImageIndexes[image];

                // Get a list of all image files in the specified folder
                var imageFiles = Directory.GetFiles(folderPath, "*.png");

                // Check if imageFiles array is not empty before attempting to access an element at the specified index
                if (imageFiles.Length > 0)
                {
                    if (currentImageIndex < imageFiles.Length)
                    {
                        // Set the source of the Image control to the next image file
                        image.Source = new BitmapImage(new Uri(imageFiles[currentImageIndex]));

                        // Increment the current image index and wrap around to the beginning of the array if it exceeds the array size
                        currentImageIndexes[image] = (currentImageIndex + 1) % imageFiles.Length;

                       // if (image == Jasmin && currentImageIndex == 2)
                        //{
                        //    Jasmin.Height = 160;
                        //    Jasmin.Width = 190;
                        //}
                    }
                }
            }
        }
        public class HotKey
        {
            public string Key { get; set; }
            public string Action { get; set; }

        }
        private void myWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Enter1StoryBoard.Begin(this, true);
        }

        private void Rtimer_Tick(object sender, EventArgs e)
        {
            if (IsR)
            {

                Alex.LayoutTransform = new RotateTransform(10);
                Amaya.LayoutTransform = new RotateTransform(10);
                Colton.LayoutTransform = new RotateTransform(10);
                Finn.LayoutTransform = new RotateTransform(10);
                Giuliana.LayoutTransform = new RotateTransform(10);
                Grant.LayoutTransform = new RotateTransform(10);
                Jasmin.LayoutTransform = new RotateTransform(-10);
                Miles.LayoutTransform = new RotateTransform(10);
                Noah.LayoutTransform = new RotateTransform(10);
                Olivia.LayoutTransform = new RotateTransform(10);
                Sariah.LayoutTransform = new RotateTransform(-10);
                Tristian.LayoutTransform = new RotateTransform(10);
                Amalia.LayoutTransform = new RotateTransform(-10);

                IsR = false;

            }

            else
            {
                Alex.LayoutTransform = new RotateTransform(-5);
                Amaya.LayoutTransform = new RotateTransform(-5);
                Colton.LayoutTransform = new RotateTransform(-5);
                Finn.LayoutTransform = new RotateTransform(-5);
                Giuliana.LayoutTransform = new RotateTransform(-5);
                Grant.LayoutTransform = new RotateTransform(-5);
                Jasmin.LayoutTransform = new RotateTransform(5);
                Miles.LayoutTransform = new RotateTransform(-5);
                Noah.LayoutTransform = new RotateTransform(-5);
                Olivia.LayoutTransform = new RotateTransform(-5);
                Sariah.LayoutTransform = new RotateTransform(5);
                Tristian.LayoutTransform = new RotateTransform(-5);
                Amalia.LayoutTransform = new RotateTransform(5);

                IsR = true;
            }
        }

    }
public static class Ani
    {
        public static void Fade(UIElement element, double from, double to, int durationMilliseconds)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = from;
            animation.To = to;
            animation.Duration = TimeSpan.FromMilliseconds(durationMilliseconds);

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            Storyboard.SetTarget(animation, element);
            Storyboard.SetTargetProperty(animation, new PropertyPath(UIElement.OpacityProperty));

            storyboard.Begin();
        }
    }


}
