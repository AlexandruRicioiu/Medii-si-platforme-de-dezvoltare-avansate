using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public interface WinnerCheckingStrategy
    {
        void CheckWinner(Button[] buttons, Label label);
    }

    public class ThreeInARowStrategy : WinnerCheckingStrategy
    {
        public void CheckWinner(Button[] button, Label label)
        {
            if (button[0].Text == button[1].Text && button[1].Text == button[2].Text)
            {
                label.Text = "The winner is: " + button[0].Text;
            }
            else if (button[3].Text == button[4].Text && button[4].Text == button[5].Text)
            {
                label.Text = "The winner is: " + button[3].Text;
            }
            else if (button[6].Text == button[7].Text && button[7].Text == button[8].Text)
            {
                label.Text = "The winner is: " + button[6].Text;
            }
            else if (button[0].Text == button[3].Text && button[3].Text == button[6].Text)
            {
                label.Text = "The winner is: " + button[0].Text;
            }
            else if (button[1].Text == button[4].Text && button[4].Text == button[7].Text)
            {
                label.Text = "The winner is: " + button[1].Text;
            }
            else if (button[2].Text == button[5].Text && button[5].Text == button[8].Text)
            {
                label.Text = "The winner is: " + button[2].Text;
            }
        }
    }
    public class DiagonalStrategy : WinnerCheckingStrategy
    {
        public void CheckWinner(Button[] button, Label label)
        {
             if (button[0].Text == button[4].Text && button[4].Text == button[8].Text)
            {
                label.Text = "The winner is: " + button[0].Text;
            }
            else if (button[2].Text == button[4].Text && button[4].Text == button[6].Text)
            {
                label.Text = "The winner is: " + button[2].Text;
            }
        }
    }

    public class GameLogic
    {
         private WinnerCheckingStrategy _threeInARowStrategy;
         private WinnerCheckingStrategy _diagonalStrategy;
    
         public event EventHandler GameWon;
    
         public GameLogic(WinnerCheckingStrategy threeInARowStrategy, WinnerCheckingStrategy diagonalStrategy)
         {
             _threeInARowStrategy = threeInARowStrategy;
             _diagonalStrategy = diagonalStrategy;
         }
    
         public void CheckWinner(Button[] buttons, Label label)
         {
             _threeInARowStrategy.CheckWinner(buttons, label);
             _diagonalStrategy.CheckWinner(buttons, label);
    
             if (label.Text=="The winner is: X" || label.Text == "The winner is: 0")
             {
                 OnGameWon();
             }
         }
    
         protected virtual void OnGameWon()
         {
             GameWon?.Invoke(this, EventArgs.Empty);
         }
    }
}

