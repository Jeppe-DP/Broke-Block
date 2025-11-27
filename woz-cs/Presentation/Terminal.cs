/* Class that acts as user interface
 */

public class Terminal
{
  public string GetInput ()
  {
    string? input = null;

    while (input == null)
    {
      Console.Write (">");
      input = Console.ReadLine ();
    }

    return input;
  }

  public void Print (string output)
  {
    Console.WriteLine (output);
  }

  public void Clear ()
  {
    Console.Clear ();
  }

  public string CheckClear (string str)
  {
    if (str[0] == '*')
    {
      Clear ();
      return str.Substring (1);
    }

    return str;
  }

  public void PrintWelcome ()
  {
    Print ("Velkommen til Broke-Broke!");

    TitleScreen titleScreen = new TitleScreen();
    titleScreen.Show();
  }

  public void PrintGameOver (string description)
  {
    GameOverScreen gameOver = new GameOverScreen(description);
    gameOver.Show();
  }

  public void PrintWinScreen (string description)
  {
    WinningScreen winScreen = new WinningScreen(description);
    winScreen.Show();
  }
}
