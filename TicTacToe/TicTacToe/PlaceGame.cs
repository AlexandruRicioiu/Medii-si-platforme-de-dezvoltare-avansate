using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    internal class PlaceGame
    {
        public int PlayerX, Player0;
        public bool Turn = true;
        Button[] button;


        public void SelectPlayer(Button button)
        {
            if(Turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "0";
            }
            Turn = false;
        }
    }
}
