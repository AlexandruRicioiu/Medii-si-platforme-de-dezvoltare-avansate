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
        public int PlayerX, Player0;
        Button[] button;
        Label label;


        GameLogic()
        {
            if (button[1].Text == button[2].Text && button[2].Text == button[3].Text) 
            {
                Console.WriteLine("A castigat x");
            }
            else if(button[4].Text == button[5].Text && button[5].Text == button[6].Text)
            {

            }
            else if(button[7].Text == button[8].Text && button[8].Text == button[9].Text) 
            {

            }
            else if(button[1].Text == button[5].Text && button[5].Text == button[9].Text)
            {

            }
            else if(button[3].Text == button[5].Text && button[5].Text == button[7].Text)
            {

            }
            else
            {

            }
         
        }


    }
}
