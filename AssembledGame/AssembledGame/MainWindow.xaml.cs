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
using System.Windows.Threading;

namespace AssembledGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd = new Random();
        private int tickCounter = 10;
        private DispatcherTimer timer;
        private int rndNumber = 10;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += timertick;
            timer.Start();
            Button.Click += Button_Click;
            ChooseLevel.Click += ChooseLevel_Click;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rndNumber = rnd.Next(10, 99);
            string sym = rndNumber.ToString();
            if (sym[0] == sym[1])
            {
                timer.Stop();
                Level2 lvl2 = new Level2();
                lvl2.Show();
                Level1.Close();
            }
        }
        private void timertick(object sender, EventArgs e)
        {
            if (tickCounter > 0)
            {
                tickCounter--;
                TimerBlockDown.Text = String.Format("00:0{0}:{1}", tickCounter / 60, tickCounter % 60);
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Гуляй братишка");
            }
        }
        private void ChooseLevel_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            switch (tbChoose.Text)
            {
                case "2":
                    Level2 lvl2 = new Level2();
                    lvl2.Show();
                    Level1.Close();
                    break;
                case "3":
                    Level3 lvl3 = new Level3();
                    lvl3.Show();
                    Level1.Close();
                    break;
                case "4":
                    Level4 lvl4 = new Level4();
                    lvl4.Show();
                    Level1.Close();
                    break;
                case "5":
                    Level5 lvl5 = new Level5();
                    lvl5.Show();
                    Level1.Close();
                    break;
                case "6":
                    Level6 lvl6 = new Level6();
                    lvl6.Show();
                    Level1.Close();
                    break;
                case "7":
                    Level7 lvl7 = new Level7();
                    lvl7.Show();
                    Level1.Close();
                    break;
                case "8":
                    Level8 lvl8 = new Level8();
                    lvl8.Show();
                    Level1.Close();
                    break;
            }
        }
    }
}
