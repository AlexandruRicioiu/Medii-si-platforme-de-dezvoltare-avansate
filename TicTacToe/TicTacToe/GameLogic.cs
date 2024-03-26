using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    internal class GameLogic : PlayerTurn 
    {
        Button[] button;
        Label label;

        public GameLogic(Button[] button, Label label)
        {
            this.button = button;
            this.label = label;
        }

        public void CheckWinner()
        {
            int buttonsWithText = 0;

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
            else if (button[0].Text == button[4].Text && button[4].Text == button[8].Text)
            {
                label.Text = "The winner is: " + button[0].Text;
            }
            else if (button[2].Text == button[4].Text && button[4].Text == button[6].Text)
            {
                label.Text = "The winner is: " + button[2].Text;
            }
            else
            {
                foreach (Button btn in button)
                {
                    if (!string.IsNullOrEmpty(btn.Text)) 
                    {
                        buttonsWithText++;
                    }
                }

                if (buttonsWithText == 9)
                {
                    label.Text = "Draw";
                }
            }
        }
    }
}
