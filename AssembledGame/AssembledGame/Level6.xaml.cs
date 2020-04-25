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
using System.Windows.Shapes;
using System.Threading;

namespace AssembledGame
{
    public partial class Level6 : Window
    {
        public Level6()
        {
            InitializeComponent();
            RightChoose.Click += RightChoose_Click;
        }
        private void RightChoose_Click(object sender, RoutedEventArgs e)
        {
            Level7 lvl7 = new Level7();
            lvl7.Show();
            LevelSix.Close();
        }
    }
}
