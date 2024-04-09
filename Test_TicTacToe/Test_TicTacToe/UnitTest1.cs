using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using TicTacToe;

namespace Test_TicTacToe
{
    [TestClass]
    public class GameLogicTests
    {
        [TestMethod]
        public void CheckWinner_WhenThreeInARow_ShouldTriggerGameWonEvent_1()
        {
            // Arrange
            ThreeInARowStrategy threeInARowStrategy = new ThreeInARowStrategy();
            DiagonalStrategy diagonalStrategy = new DiagonalStrategy();
            GameLogic gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
            bool eventTriggered = false;
            gameLogic.GameWon += (sender, args) => eventTriggered = true;
            Button[] buttons = new Button[9];

            // Act
            // Simulate a winning scenario
            buttons[0] = new Button { Text = "X" };
            buttons[1] = new Button { Text = "X" };
            buttons[2] = new Button { Text = "X" };
            buttons[3] = new Button { Text = "0" };
            buttons[4] = new Button { Text = "X" };
            buttons[5] = new Button { Text = "0" };
            buttons[6] = new Button { Text = "X" };
            buttons[7] = new Button { Text = "X" };
            buttons[8] = new Button { Text = "0" };
            gameLogic.CheckWinner(buttons, new Label());

            // Assert
            Assert.IsTrue(eventTriggered, "GameWon event should have been triggered");
        }

        [TestMethod]
        public void CheckWinner_WhenThreeInARow_ShouldTriggerGameWonEvent_2()
        {
            // Arrange
            ThreeInARowStrategy threeInARowStrategy = new ThreeInARowStrategy();
            DiagonalStrategy diagonalStrategy = new DiagonalStrategy();
            GameLogic gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
            bool eventTriggered = false;
            gameLogic.GameWon += (sender, args) => eventTriggered = true;
            Button[] buttons = new Button[9];

            // Act
            // Simulate a winning scenario
            buttons[0] = new Button { Text = "0" };
            buttons[1] = new Button { Text = "X" };
            buttons[2] = new Button { Text = "0" };
            buttons[3] = new Button { Text = "x" };
            buttons[4] = new Button { Text = "X" };
            buttons[5] = new Button { Text = "x" };
            buttons[6] = new Button { Text = "X" };
            buttons[7] = new Button { Text = "X" };
            buttons[8] = new Button { Text = "0" };
            gameLogic.CheckWinner(buttons, new Label());

            // Assert
            Assert.IsTrue(eventTriggered, "GameWon event should have been triggered");
        }

        [TestMethod]
        public void CheckWinner_WhenThreeInARow_ShouldTriggerGameWonEvent_3()
        {
            // Arrange
            ThreeInARowStrategy threeInARowStrategy = new ThreeInARowStrategy();
            DiagonalStrategy diagonalStrategy = new DiagonalStrategy();
            GameLogic gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
            bool eventTriggered = false;
            gameLogic.GameWon += (sender, args) => eventTriggered = true;
            Button[] buttons = new Button[9];

            // Act
            // Simulate a winning scenario
            buttons[0] = new Button { Text = "0" };
            buttons[1] = new Button { Text = "X" };
            buttons[2] = new Button { Text = "0" };
            buttons[3] = new Button { Text = "0" };
            buttons[4] = new Button { Text = "X" };
            buttons[5] = new Button { Text = "x" };
            buttons[6] = new Button { Text = "0" };
            buttons[7] = new Button { Text = "0" };
            buttons[8] = new Button { Text = "0" };
            gameLogic.CheckWinner(buttons, new Label());

            // Assert
            Assert.IsTrue(eventTriggered, "GameWon event should have been triggered");
        }

    }
}
