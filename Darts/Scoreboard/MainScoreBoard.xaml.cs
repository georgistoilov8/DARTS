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
//......................................
using System.Text.RegularExpressions;
using System.ComponentModel;
using DartsLib;

namespace Scoreboard
{
    public partial class MainScoreBoard : Window
    {
        static bool Player1Turn = true, Player1First = true, onFirstThrow = true;
        int currentThrow, currentScore;

        public MainScoreBoard()
        {
            InitializeComponent();
            Player1Legs.Content = "0";
            Player1Sets.Content = "0";
            Player1Avr.Content = "0";
            Player2Legs.Content = "0";
            Player2Sets.Content = "0";
            Player2Avr.Content = "0";
        }

        void Button_Click(object sender, RoutedEventArgs e)
        {
            if (onFirstThrow == true)
            {
                if (Player1First == true)
                {
                    Player1Turn = true;
                }
                else
                {
                    Player1Turn = false;
                }
            }

            onFirstThrow = false;
            currentThrow = ScoreBoard.validate(CurrentNumber.Text);
            if (currentThrow != -1)
            {
                if (Player1Turn == true)
                {
                    currentScore = ScoreBoard.calcScore(Player1Score, currentThrow);
                    ScoreBoard.addThrow(ThrowList1, currentThrow, FindResource("Throw"));
                }
                else if(Player1Turn == false)
                {
                    currentScore = ScoreBoard.calcScore(Player2Score, currentThrow);
                    ScoreBoard.addThrow(ThrowList2, currentThrow, FindResource("Throw"));
                }

                if(currentScore == 0)
                {
                    ScoreBoard.resetBoard(Player1Score, Player2Score);
                    ScoreBoard.cleanLists(ThrowList1, ThrowList2);
                    if (Player1Turn)
                    {
                        ScoreBoard.calcLegsAndSets(Player1Legs, Player1Sets);
                    }
                    else
                    {
                        ScoreBoard.calcLegsAndSets(Player2Legs, Player2Sets);
                    }
                    Player1First = !Player1First;
                    onFirstThrow = true;
                }
                Player1Turn = !Player1Turn;
                CurrentNumber.Text = "";
                ScoreBoard.switchTurn(Player1ThrowTurn, Player2ThrowFirst, Player1Turn);
            }
        
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
