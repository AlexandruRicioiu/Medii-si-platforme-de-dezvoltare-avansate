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
            gameLogic = new GameLogic();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
            }
        }

        private void box1_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if(clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
            }
        }

        private void box2_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
            }
        }

        private void box3_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
            }
        }

        private void box4_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
            }
        }

        private void box6_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
            }
        }

        private void box7_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
            }
        }

        private void box8_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
            }
        }

        private void box9_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
            }
        }
    }
}
