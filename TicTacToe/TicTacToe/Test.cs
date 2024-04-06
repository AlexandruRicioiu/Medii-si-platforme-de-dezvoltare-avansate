using NUnit.Framework;
using System.Windows.Forms;
using TicTacToe;

[TestFixture]
public class TicTacToeTests
{
    [Test]
    public void GameLogic_CheckWinner_ThreeInARowWinner_ReturnsWinnerText()
    {
        // Arrange
        var threeInARowStrategy = new ThreeInARowStrategy();
        var diagonalStrategy = new DiagonalStrategy();
        var gameLogic = new GameLogic(threeInARowStrategy, diagonalStrategy);
        var buttons = new Button[9];
        var label = new Label();

        // Create and initialize buttons
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i] = new Button();
        }

        // Act
        buttons[0].Text = buttons[1].Text = buttons[2].Text = "X";
        gameLogic.CheckWinner(buttons, label);

        // Assert
        Assert.That(label.Text, Is.EqualTo("The winner is: X"));
    }
}
