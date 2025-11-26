/* Class that handles interaction with Domain
 */

public class Shell
{
  private Game game;
  private Terminal terminal;

  public Shell (Game instance)
  {
    game = instance;
    terminal = new Terminal ();
  }

  public void Run ()
  {
    terminal.PrintWelcome ();
    terminal.Clear ();
    terminal.Print(game.GetContext().GetCurrent().Welcome());

    GameState state = game.GetContext().State;

    while (state != GameState.Done)
    {
      string line = terminal.GetInput ();
      string response = game.ExecuteCmd (line);

      state = game.GetContext().State;

      terminal.Clear ();

      switch (state)
      {
        case GameState.GameOver:
          terminal.PrintGameOver (response);
          terminal.Clear ();
          terminal.Print (game.RestartGame ());
          break;
        case GameState.Won:
          terminal.PrintWinScreen (response);
          game.EndGame ();
          break;
        default:
          terminal.Print (response);
          break;
      }
    }
  }
}
