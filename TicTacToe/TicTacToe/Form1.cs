using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        private PlayerTurn game;
        private GameLogic gameLogic;

        public TicTacToe()
        {
            InitializeComponent();
            game = new PlayerTurn();
            gameLogic = new GameLogic(new Button[9] {box1, box2, box3, box4, box5, box6, box7, box8, box9,}, GameS);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
                gameLogic.CheckWinner();
            }
        }

        private void box1_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if(clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
                gameLogic.CheckWinner();
            }
        }

        private void box2_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
                gameLogic.CheckWinner();
            }
        }

        private void box3_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
                gameLogic.CheckWinner();
            }
        }

        private void box4_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
                gameLogic.CheckWinner();
            }
        }

        private void box6_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
                gameLogic.CheckWinner();
            }
        }

        private void box7_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
                gameLogic.CheckWinner();
            }
        }

        private void box8_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
                gameLogic.CheckWinner();
            }
        }

        private void box9_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
                gameLogic.CheckWinner();
            }
        }
    }
}
