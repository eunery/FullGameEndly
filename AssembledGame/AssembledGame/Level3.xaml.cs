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

namespace AssembledGame
{
    public partial class Level3 : Window
    {
        public Level3()
        {
            InitializeComponent();
            AnswerButton.Click += AnswerButton_Click;
        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {

            ComboBoxItem selectedItem = (ComboBoxItem)cbBox.SelectedItem;
            switch (selectedItem.Name)
            {
                case "First":
                    MessageBox.Show("Ты пытался\nхехе");
                    break;
                case "Second":
                    Level4 lvl4 = new Level4();
                    lvl4.Show();
                    LevelThree.Close();
                    break;
                case "Third":
                    MessageBox.Show("Я промолчу");
                    break;
            }
        }
    }
}
