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
using System.Text.RegularExpressions;

namespace DartsLib
{
    public class ScoreBoard
    {
        static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9.-]+");
            return !regex.IsMatch(text);
        }

        public static int validate(string Number)
        {
            int score = 0;
            if (IsTextAllowed(Number))
            {
                score = Int32.Parse(Number);
                if (score < 0 || score > 180)
                {
                    MessageBox.Show("Невалиден резултат");
                    return -1;
                }
            }
            else
            {
                return -1;
            }
            return score;
        }

        public static int calcScore(Label Score, int Throw)
        {
            int score = Int32.Parse(Score.Content.ToString());
            score -= Throw;
            if(score < 0)
            {
                MessageBox.Show("Резултатът е по-голям!");
                return -1;
            }
            Score.Content = score.ToString();
            return score;
        }

        public static void addThrow(StackPanel List, int Throw, object style)
        {
            Label l = new Label();
            l.Style = style as Style;
            l.Content = Throw.ToString();
            List.Children.Add(l);
        }

        public static void resetBoard(Label Score1, Label Score2)
        {
            Score1.Content = "501";
            Score2.Content = "501";
        }

        public static void cleanLists(StackPanel List1, StackPanel List2)
        {
            while(List1.Children.Count > 0)
            {
                List1.Children.RemoveAt(List1.Children.Count - 1);
            }
            while (List2.Children.Count > 0)
            {
                List2.Children.RemoveAt(List2.Children.Count - 1);
            }
        }

        public static void calcLegsAndSets(Label Legs, Label Sets)
        {
            int sets = 0;
            int legs = Int32.Parse(Legs.Content.ToString());
            legs++;
            if(legs == 2)
            {
                legs = 0;
                sets = Int32.Parse(Sets.Content.ToString());
                sets++;
            }                              
            Legs.Content = legs.ToString();
            Sets.Content = sets.ToString();
        }

        public static void switchTurn(Label TurnBox1, Label TurnBox2, bool turn)
        {
            if (turn)
            {
                TurnBox1.Background = Brushes.Gold;
                TurnBox2.Background = Brushes.DarkGreen;
            }
            else
            {
                TurnBox2.Background = Brushes.Gold;
                TurnBox1.Background = Brushes.DarkGreen;
            }
        }
    }
}
