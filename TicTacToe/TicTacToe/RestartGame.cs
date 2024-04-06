using System;

public class RestartGame
{
    private static RestartGame instance;
    private RestartGame() { }

    public event EventHandler GameReset;

    public static RestartGame Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new RestartGame();
            }
            return instance;
        }
    }

    public void ResetGame()
    {
        Console.WriteLine("Game reset...");
        OnGameReset();
    }

    protected virtual void OnGameReset()
    {
        GameReset?.Invoke(this, EventArgs.Empty);
    }
}
