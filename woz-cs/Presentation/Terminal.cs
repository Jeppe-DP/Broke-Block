/* Class that acts as user interface
 */

public class Terminal
{
  private UIManager ui;

  public Terminal ()
  {
    ui = new UIManager ();
  }

  public string GetInput ()
  {
    string input = null;

    while (input == null)
    {
      Console.Write (">");
      input = Console.ReadLine ();
    }
  }

  public void Print (string output)
  {
    Console.WriteLine (output);
  }

  public void Clear ()
  {
    Console.Clear ();
  }

  public void PrintWelcome ()
  {
    Console.WriteLine("Velkommen til Broke-Broke!");

    TitleScreen titleScreen = new TitleScreen();
    titleScreen.Show();
  }

  public void PrintGameOver ()
  {
    GameOverScreen gameOver = new GameOverScreen();
    gameOver.Show();
  }

  public void PrintWinScreen ()
  {
    WinningScreen winScreen = new WinningScreen();
    winScreen.Show();
  }
}
