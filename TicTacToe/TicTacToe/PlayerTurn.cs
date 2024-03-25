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
        public bool Turn = true;
        Button[] button;


        public void SelectPlayer(Button button)
        {
            if(Turn)
            {
                button.Text = "X";
                Turn = false;
            }
            else
            {
                button.Text = "0";
                Turn = true;
            }
            
        }
    }
}
