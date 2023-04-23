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
using System.Windows.Media.Animation;
using System.Security.Policy;
using System.Net.NetworkInformation;
using System.Timers;
using System.Windows.Threading;
using System.Threading;
using System.IO;

namespace School_Project_v1
{
    public partial class MainWindow : Window
    {
        int i = 0;
        private int Pg= 0;
        private Storyboard Enter1StoryBoard;
        private DispatcherTimer T;
        private DispatcherTimer Pg2C;

        public MainWindow()
        {
            InitializeComponent();

            T = new DispatcherTimer();
            T.Interval = TimeSpan.FromMilliseconds(2000);
            T.Tick += T_Tick;

            Pg2C = new DispatcherTimer();
            Pg2C.Interval=TimeSpan.FromMilliseconds(1100);
            Pg2C.Tick += Pg2C_Tick;

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

                    this.Pg1.Visibility = Visibility.Collapsed;
                    this.Pg2.Visibility = Visibility.Visible;
                    Enter1StoryBoard.Stop();
                    this.Enter1.Visibility= Visibility.Collapsed;

                    T.Start();

                    Ani.Fade(Pg2, 0, 1, 3000);
                }

                if (Pg == 2)
                {
                    Enter1StoryBoard.Stop();
                    this.Enter1.Visibility = Visibility.Collapsed;
                    this.Pg2.Visibility= Visibility.Collapsed;
                    this.Pg3.Visibility= Visibility.Visible;
                    T.Start();

                    Ani.Fade(Pg3, 0, 1, 3000);
                }
                if(Pg == 3)
                {
                    Enter1StoryBoard.Stop();
                    this.Enter1.Visibility = Visibility.Collapsed;
                    this.Pg3.Visibility = Visibility.Collapsed;
                    this.Pg4.Visibility= Visibility.Visible;
                    Ani.Fade(Pg4, 0, 1, 2000);
                    RotateImage(Alex, 10, 1200);
                    CycleImagesNew(Alex, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Alex\", 2000);

                    RotateImage(Amaya, 10, 1200);
                    CycleImagesNew(Amaya, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Amaya\", 2000);

                    RotateImage(Colton, 10, 1200);
                    CycleImagesNew(Colton, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Colton\", 2000);

                    RotateImage(Finn, 10, 1200);
                    CycleImagesNew(Finn, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Finn\", 2000);

                    RotateImage(Giuliana, 10, 1200);
                    CycleImagesNew(Giuliana, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Giuliana\", 2000);

                    RotateImage(Grant, 10, 1200);
                    CycleImagesNew(Grant, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Grant\", 2000);

                    RotateImage(Jasmin, 10, 1200);
                    CycleImagesNew(Jasmin, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Jasmin\", 2000);

                    RotateImage(Miles, 10, 1200);
                    CycleImagesNew(Miles, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Miles\", 2000);

                    RotateImage(Noah, 10, 1200);
                    CycleImagesNew(Noah, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Noah\", 2000);

                    RotateImage(Olivia, 10, 1200);
                    CycleImagesNew(Olivia, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Olivia\", 2000);

                    RotateImage(Sariah, 10, 1200);
                    CycleImagesNew(Sariah, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Sariah\", 2000);

                    RotateImage(Tristian, 10, 1200);
                    CycleImagesNew(Tristian, @"C:\Users\lills\OneDrive\Desktop\School Project v1\School Project v1\Pics\Tristian\", 2000);

                }
            }
            if(e.Key == Key.H) 
            {
                if (Pg2.Visibility == Visibility.Collapsed)
                {
                    this.Pg2.Visibility = Visibility.Visible;
                    Ani.Fade(Pg2, 0, 1, 900);
                    this.Pg2.Margin = new Thickness(0, 0, 0, 0);
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
            this.Pg2.Visibility = Visibility.Collapsed;
            Pg2C.Stop();
        }
        private void T_Tick(object sender, EventArgs e)
        {
            this.Enter1.Visibility= Visibility.Visible;
            Enter1StoryBoard.Begin(this);
            T.Stop();
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
        public void RotateImage(Image image, double angle, int intervalMilliseconds)
        {
            // Save the original image transform
            var originalTransform = image.LayoutTransform;

            // Create a DispatcherTimer object with the specified interval
            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(intervalMilliseconds);

            // Subscribe to the Tick event of the timer and rotate the Image
            bool isRotated = false;
            timer.Tick += (sender, e) =>
            {
                if (!isRotated)
                {
                    // Rotate the image by the specified angle
                    image.LayoutTransform = new RotateTransform(angle);
                    isRotated = true;
                }
                else
                {
                    // Set the image back to its original rotation
                    image.LayoutTransform = originalTransform;
                    isRotated = false;
                }
            };

            // Start the timer
            timer.Start();
        }
        public void CycleImagesNew(Image image, string folderPath, int intervalMilliseconds)
        {
            // Get a list of all image files in the specified folder
            var imageFiles = Directory.GetFiles(folderPath, "*.png");

            // Create a counter variable to keep track of the current image index
            int currentImageIndex = 0;

            // Create a DispatcherTimer object with the specified interval
            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(intervalMilliseconds);

            // Subscribe to the Tick event of the timer and update the Image source
            timer.Tick += (sender, e) =>
            {
                // Check if imageFiles array is not empty before attempting to access an element at the specified index
                if (imageFiles.Length > 0)
                {
                    // Set the source of the Image control to the next image file
                    image.Source = new BitmapImage(new Uri(imageFiles[currentImageIndex]));

                    if (currentImageIndex == 0)
                    {
                        image.Width = 300;
                        image.Height = 250;
                    }
                    else
                    {
                        image.Width = 255;
                        image.Height = 160;
                    }
                    // Increment the current image index and wrap around to the beginning of the array if it exceeds the array size
                    currentImageIndex = (currentImageIndex + 1) % imageFiles.Length;
                }
            };

            // Start the timer ree e e e
            timer.Start();
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
