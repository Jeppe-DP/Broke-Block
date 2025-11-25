class Program
{
  static void Main(string[] args)
  {
    UIManager ui = new UIManager(); // Call an instance

    Console.WriteLine("Velkommen til Broke-Broke!");

    TitleScreen titleScreen = new TitleScreen();
    titleScreen.Show();

    Game game = new Game ();
    game.Context.GetCurrent().Welcome();

    Terminal terminal = new Terminal ();

    while (!context.State == Done)
    {
      terminal.Prompt ();
      string? line = terminal.Input();

      if (line != null) string response = game.Registry.Dispatch(line);

      GameState state = game.Context.State;

      switch (state)
      {
        case Done :
          terminal.PrintClear (response);
          terminal.Print ("Thanks for playing!");
          break;
        case Won :
          terminal.Print (response);
          WinningScreen winScreen = new WinningScreen();
          winScreen.Show();
          break;
        case GameOver :
          terminal.Print (response);
          GameOverScreen gameOver = new GameOverScreen();
          gameOver.Show();
        default :
          terminal.PrintClear (response);
          break;
      }
    }

    Console.WriteLine("Game Over 😥");
  }
}
