using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe
{
    public interface Observer
    {
        void Update(bool turn, string playerName);
    }

    internal class PlayerTurn
    {
        private List<Observer> observers = new List<Observer>();
        public bool Turn { get; private set; } = true;
        public string PlayerX { get; set; } = "Player X";
        public string Player0 { get; set; } = "Player 0";

        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void SelectPlayer(Button button)
        {
            if (Turn)
            {
                button.Text = "X";
                NotifyObservers(Player0);
                Turn = false;
            }
            else
            {
                button.Text = "0";
                NotifyObservers(PlayerX);
                Turn = true;
            }
            NotifyTurnLabel();
        }


        private void NotifyTurnLabel()
        {
            foreach (var observer in observers)
            {
                if (observer is Observer)
                {
                    observer.Update(Turn, Turn ? PlayerX : Player0);
                }
            }
        }

        private void NotifyObservers(string playerName)
        {
            foreach (var observer in observers)
            {
                observer.Update(Turn, playerName);
            }
        }

    }
}
