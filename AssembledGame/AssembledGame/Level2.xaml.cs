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
    /// <summary>
    /// Логика взаимодействия для Level2.xaml
    /// </summary>
    public partial class Level2 : Window
    {
        private int answerFlag = 1;
        public Level2()
        {
            InitializeComponent();
            AnswerBox.TextChanged += AnswerBox_TextChanged;
        }

        private void AnswerBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (answerFlag)
            {
                case 1:
                    AskLabel.Content = "Корень из 225?";
                    if (AnswerBox.Text == "15")
                    {
                        answerFlag = 2;
                        AnswerBox.Text = "";
                    }
                    break;
                case 2:
                    AskLabel.Content = "Сколько ног у сороконожки?";
                    if (AnswerBox.Text == "много")
                    {
                        answerFlag = 3;
                        AnswerBox.Text = "";
                    }
                    break;
                case 3:
                    AskLabel.Content = "Сколько лет длилась столетняя война?";
                    if (AnswerBox.Text == "116")
                    {
                        Level3 lvl3 = new Level3();
                        lvl3.Show();
                        LevelTwo.Close();
                        AnswerBox.Text = "";
                    }
                    break;
            }
        }
    }
}
