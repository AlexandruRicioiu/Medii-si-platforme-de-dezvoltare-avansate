using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    internal class PlayerTurn
    {
        public string PlayerX, Player0;
        public bool Turn = true;
        Button[] button;


        public void SelectPlayer(Button button, Label name)
        {
            if(Turn)
            {
                button.Text = "X";
                name.Text = "Turn: Player 0";
                Turn = false;
            }
            else
            {
                button.Text = "0";
                Turn = true;
                name.Text = "Turn: Player X";
            }
            
        }
    }
}
