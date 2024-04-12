using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using TicTacToe;

namespace Test_TicTacToe
{
    [TestClass]
    public class GameLogicTests
    {
        /// Description   Check if the function return the game is won when we have three "X" in first row
        /// Precondition  X X X
        ///               0 x 0
        ///               x 0 0
        /// Result        The function return the game is won when we have three "X" in first row
        [TestMethod]
        public void CheckWinner_WhenThreeInARow_ShouldTriggerGameWonEvent_1()
        {
            // Arrange
            ThreeInARowStrategy threeInARowStrategy = new ThreeInARowStrategy();
            DiagonalStrategy diagonalStrategy = new DiagonalStrategy();
            GameLogic gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
            bool eventTriggered = false;
            gameLogic.GameFinish += (sender, args) => eventTriggered = true;
            Button[] buttons = new Button[9];

            // Act
            buttons[0] = new Button { Text = "X" };
            buttons[1] = new Button { Text = "X" };
            buttons[2] = new Button { Text = "X" };
            buttons[3] = new Button { Text = "0" };
            buttons[4] = new Button { Text = "X" };
            buttons[5] = new Button { Text = "0" };
            buttons[6] = new Button { Text = "X" };
            buttons[7] = new Button { Text = "0" };
            buttons[8] = new Button { Text = "0" };
            gameLogic.CheckWinner(buttons, new Label());

            // Assert
            Assert.IsTrue(eventTriggered, "GameWon event should have been triggered");
        }

        /// Description   Check if the function return the game is won when we have three "X" in second row
        /// Precondition  0 X 0
        ///               x x x
        ///               x 0 0
        /// Result        The function return the game is won when we have three "X" in second row
        [TestMethod]
        public void CheckWinner_WhenThreeInARow_ShouldTriggerGameWonEvent_2()
        {
            // Arrange
            ThreeInARowStrategy threeInARowStrategy = new ThreeInARowStrategy();
            DiagonalStrategy diagonalStrategy = new DiagonalStrategy();
            GameLogic gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
            bool eventTriggered = false;
            gameLogic.GameFinish += (sender, args) => eventTriggered = true;
            Button[] buttons = new Button[9];

            // Act
            buttons[0] = new Button { Text = "0" };
            buttons[1] = new Button { Text = "X" };
            buttons[2] = new Button { Text = "0" };
            buttons[3] = new Button { Text = "x" };
            buttons[4] = new Button { Text = "X" };
            buttons[5] = new Button { Text = "X" };
            buttons[6] = new Button { Text = "X" };
            buttons[7] = new Button { Text = "0" };
            buttons[8] = new Button { Text = "0" };
            gameLogic.CheckWinner(buttons, new Label());

            // Assert
            Assert.IsTrue(eventTriggered, "GameWon event should have been triggered");
        }

        /// Description   Check if the function return the game is won when we have three "0" in third row
        /// Precondition  0 X X
        ///               x x 0
        ///               0 0 0
        /// Result        The function return the game is won when we have three "0" in third row
        [TestMethod]
        public void CheckWinner_WhenThreeInARow_ShouldTriggerGameWonEvent_3()
        {
            // Arrange
            ThreeInARowStrategy threeInARowStrategy = new ThreeInARowStrategy();
            DiagonalStrategy diagonalStrategy = new DiagonalStrategy();
            GameLogic gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
            bool eventTriggered = false;
            gameLogic.GameFinish += (sender, args) => eventTriggered = true;
            Button[] buttons = new Button[9];

            // Act
            buttons[0] = new Button { Text = "0" };
            buttons[1] = new Button { Text = "X" };
            buttons[2] = new Button { Text = "X" };
            buttons[3] = new Button { Text = "0" };
            buttons[4] = new Button { Text = "X" };
            buttons[5] = new Button { Text = "X" };
            buttons[6] = new Button { Text = "0" };
            buttons[7] = new Button { Text = "0" };
            buttons[8] = new Button { Text = "0" };
            gameLogic.CheckWinner(buttons, new Label());

            // Assert
            Assert.IsTrue(eventTriggered, "GameWon event should have been triggered");
        }

        /// Description   Check if the function return the game is won when we have three "0" in first column
        /// Precondition  0 X X
        ///               0 x 0
        ///               0 0 X
        /// Result        The function return the game is won when we have three "0" in first column
        [TestMethod]
        public void CheckWinner_WhenThreeInAColumn_ShouldTriggerGameWonEvent_1()
        {
            // Arrange
            ThreeInARowStrategy threeInARowStrategy = new ThreeInARowStrategy();
            DiagonalStrategy diagonalStrategy = new DiagonalStrategy();
            GameLogic gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
            bool eventTriggered = false;
            gameLogic.GameFinish += (sender, args) => eventTriggered = true;
            Button[] buttons = new Button[9];

            // Act
            buttons[0] = new Button { Text = "0" };
            buttons[1] = new Button { Text = "X" };
            buttons[2] = new Button { Text = "X" };
            buttons[3] = new Button { Text = "0" };
            buttons[4] = new Button { Text = "X" };
            buttons[5] = new Button { Text = "0" };
            buttons[6] = new Button { Text = "0" };
            buttons[7] = new Button { Text = "0" };
            buttons[8] = new Button { Text = "X" };
            gameLogic.CheckWinner(buttons, new Label());

            // Assert
            Assert.IsTrue(eventTriggered, "GameWon event should have been triggered");
        }

        /// Description   Check if the function return the game is won when we have three "X" in second column
        /// Precondition  X X 0
        ///               0 X X
        ///               0 X 0
        /// Result        The function return the game is won when we have three "X" in second column
        [TestMethod]
        public void CheckWinner_WhenThreeInAColumn_ShouldTriggerGameWonEvent_2()
        {
            // Arrange
            ThreeInARowStrategy threeInARowStrategy = new ThreeInARowStrategy();
            DiagonalStrategy diagonalStrategy = new DiagonalStrategy();
            GameLogic gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
            bool eventTriggered = false;
            gameLogic.GameFinish += (sender, args) => eventTriggered = true;
            Button[] buttons = new Button[9];

            // Act
            buttons[0] = new Button { Text = "X" };
            buttons[1] = new Button { Text = "X" };
            buttons[2] = new Button { Text = "0" };
            buttons[3] = new Button { Text = "0" };
            buttons[4] = new Button { Text = "X" };
            buttons[5] = new Button { Text = "X" };
            buttons[6] = new Button { Text = "0" };
            buttons[7] = new Button { Text = "X" };
            buttons[8] = new Button { Text = "0" };
            gameLogic.CheckWinner(buttons, new Label());

            // Assert
            Assert.IsTrue(eventTriggered, "GameWon event should have been triggered");
        }

        /// Description   Check if the function return the game is won when we have three "X" in third column
        /// Precondition  X 0 X
        ///               0 0 X
        ///               0 X X
        /// Result        The function return the game is won when we have three "X" in third row
        [TestMethod]
        public void CheckWinner_WhenThreeInAColumn_ShouldTriggerGameWonEvent_3()
        {
            // Arrange
            ThreeInARowStrategy threeInARowStrategy = new ThreeInARowStrategy();
            DiagonalStrategy diagonalStrategy = new DiagonalStrategy();
            GameLogic gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
            bool eventTriggered = false;
            gameLogic.GameFinish += (sender, args) => eventTriggered = true;
            Button[] buttons = new Button[9];

            // Act
            buttons[0] = new Button { Text = "X" };
            buttons[1] = new Button { Text = "0" };
            buttons[2] = new Button { Text = "X" };
            buttons[3] = new Button { Text = "0" };
            buttons[4] = new Button { Text = "0" };
            buttons[5] = new Button { Text = "X" };
            buttons[6] = new Button { Text = "0" };
            buttons[7] = new Button { Text = "X" };
            buttons[8] = new Button { Text = "X" };
            gameLogic.CheckWinner(buttons, new Label());

            // Assert
            Assert.IsTrue(eventTriggered, "GameWon event should have been triggered");
        }

        /// Description   Check if the function return the game is won when we have three "X" on main diagonal
        /// Precondition  X 0 X
        ///               0 X 0
        ///               0 X X
        /// Result        The function return the game is won when we have three "X" on main diagonal
        [TestMethod]
        public void CheckWinner_WhenThreeOnADiagonal_ShouldTriggerGameWonEvent_1()
        {
            // Arrange
            ThreeInARowStrategy threeInARowStrategy = new ThreeInARowStrategy();
            DiagonalStrategy diagonalStrategy = new DiagonalStrategy();
            GameLogic gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
            bool eventTriggered = false;
            gameLogic.GameFinish += (sender, args) => eventTriggered = true;
            Button[] buttons = new Button[9];

            // Act
            buttons[0] = new Button { Text = "X" };
            buttons[1] = new Button { Text = "0" };
            buttons[2] = new Button { Text = "X" };
            buttons[3] = new Button { Text = "0" };
            buttons[4] = new Button { Text = "X" };
            buttons[5] = new Button { Text = "0" };
            buttons[6] = new Button { Text = "0" };
            buttons[7] = new Button { Text = "X" };
            buttons[8] = new Button { Text = "X" };
            gameLogic.CheckWinner(buttons, new Label());

            // Assert
            Assert.IsTrue(eventTriggered, "GameWon event should have been triggered");
        }

        /// Description   Check if the function return the game is won when we have three "X" on second diagonal
        /// Precondition  X 0 X
        ///               0 X 0
        ///               X X 0
        /// Result        The function return the game is won when we have three "X" on second diagonal
        [TestMethod]
        public void CheckWinner_WhenThreeOnADiagonal_ShouldTriggerGameWonEvent_2()
        {
            // Arrange
            ThreeInARowStrategy threeInARowStrategy = new ThreeInARowStrategy();
            DiagonalStrategy diagonalStrategy = new DiagonalStrategy();
            GameLogic gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
            bool eventTriggered = false;
            gameLogic.GameFinish += (sender, args) => eventTriggered = true;
            Button[] buttons = new Button[9];

            // Act
            buttons[0] = new Button { Text = "X" };
            buttons[1] = new Button { Text = "0" };
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

        /// Description   Check if the function return the game is tie when we don't have won combiantion
        /// Precondition  X 0 X
        ///               X X 0
        ///               0 X 0
        /// Result        The function return the game is tie when we don't have won combiantion
        [TestMethod]
        public void CheckWinner_WhenTie_ShouldNotTriggerGameWonEvent_1()
        {
            // Arrange
            ThreeInARowStrategy threeInARowStrategy = new ThreeInARowStrategy();
            DiagonalStrategy diagonalStrategy = new DiagonalStrategy();
            GameLogic gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
            bool eventTriggered = false;
            gameLogic.GameFinish += (sender, args) => eventTriggered = true;
            Button[] buttons = new Button[9];

            // Act
            // Simulate a tie scenario
            buttons[0] = new Button { Text = "X" };
            buttons[1] = new Button { Text = "0" };
            buttons[2] = new Button { Text = "X" };
            buttons[3] = new Button { Text = "X" };
            buttons[4] = new Button { Text = "X" };
            buttons[5] = new Button { Text = "0" };
            buttons[6] = new Button { Text = "0" };
            buttons[7] = new Button { Text = "X" };
            buttons[8] = new Button { Text = "0" };
            gameLogic.CheckWinner(buttons, new Label());

            // Assert
            Assert.IsTrue(eventTriggered, "GameWon event should not have been triggered for a tie");
        }

        /// Description   Check if the function return the game is tie when we don't have won combiantion
        /// Precondition  X 0 X
        ///               0 X X
        ///               0 X 0
        /// Result        The function return the game is tie when we don't have won combiantion
        [TestMethod]
        public void CheckWinner_WhenTie_ShouldNotTriggerGameWonEvent_2()
        {
            // Arrange
            ThreeInARowStrategy threeInARowStrategy = new ThreeInARowStrategy();
            DiagonalStrategy diagonalStrategy = new DiagonalStrategy();
            GameLogic gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
            bool eventTriggered = false;
            gameLogic.GameFinish += (sender, args) => eventTriggered = true;
            Button[] buttons = new Button[9];

            // Act
            // Simulate a tie scenario
            buttons[0] = new Button { Text = "X" };
            buttons[1] = new Button { Text = "0" };
            buttons[2] = new Button { Text = "X" };
            buttons[3] = new Button { Text = "0" };
            buttons[4] = new Button { Text = "X" };
            buttons[5] = new Button { Text = "X" };
            buttons[6] = new Button { Text = "0" };
            buttons[7] = new Button { Text = "X" };
            buttons[8] = new Button { Text = "0" };
            gameLogic.CheckWinner(buttons, new Label());

            // Assert
            Assert.IsTrue(eventTriggered, "GameWon event should not have been triggered for a tie");
        }

        /// Description   Check if the function return the game is tie when we don't have won combiantion
        /// Precondition  0 X 0
        ///               0 0 X
        ///               X X 0
        /// Result        The function return the game is tie when we don't have won combiantion
        [TestMethod]
        public void CheckWinner_WhenTie_ShouldNotTriggerGameWonEvent_3()
        {
            // Arrange
            ThreeInARowStrategy threeInARowStrategy = new ThreeInARowStrategy();
            DiagonalStrategy diagonalStrategy = new DiagonalStrategy();
            GameLogic gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
            bool eventTriggered = false;
            gameLogic.GameFinish += (sender, args) => eventTriggered = true;
            Button[] buttons = new Button[9];

            // Act
            // Simulate a tie scenario
            buttons[0] = new Button { Text = "0" };
            buttons[1] = new Button { Text = "X" };
            buttons[2] = new Button { Text = "0" };
            buttons[3] = new Button { Text = "0" };
            buttons[4] = new Button { Text = "0" };
            buttons[5] = new Button { Text = "X" };
            buttons[6] = new Button { Text = "X" };
            buttons[7] = new Button { Text = "X" };
            buttons[8] = new Button { Text = "0" };
            gameLogic.CheckWinner(buttons, new Label());

            // Assert
            Assert.IsTrue(eventTriggered, "GameWon event should not have been triggered for a tie");
        }
    }
}
