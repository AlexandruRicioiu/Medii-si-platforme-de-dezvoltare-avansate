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
    public partial class TicTacToe : Form, Observer
    {
        private PlayerTurn game;
        private GameLogic gameLogic;
        private Button[] buttons;

        public TicTacToe()
        {
            InitializeComponent();
            buttons = new Button[9] { box1, box2, box3, box4, box5, box6, box7, box8, box9 };
            game = new PlayerTurn();
            game.RegisterObserver(this);
            gameLogic = new GameLogic(new ThreeInARowStrategy(), new DiagonalStrategy());
            gameLogic.GameFinish += HandleGameFinish;

            foreach (Button button in buttons)
            {
                button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != null && clickedBtn.Text == "")
            {
                game.SelectPlayer(clickedBtn);
                gameLogic.CheckWinner(buttons, Winner);
            }
        }

        private void HandleGameFinish(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to reset the game?", "Game Finish", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (Button button in buttons)
                {
                    button.Text = "";
                }

                Winner.Text = "";
            }
        }

        public void Update(bool turn, string playerName)
        {
            if (turn)
            {
                Turn.Text = $"Turn: {game.PlayerX}";
            }
            else
            {
                Turn.Text = $"Turn: {game.Player0}";
            }
        }
    }
}
