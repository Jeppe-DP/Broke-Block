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
    game.GetContext.GetCurrent().Welcome();

    do
    {
      string line = terminal.GetInput();
      string response = game.ExecuteCmd (line);

      GameState state = game.GetContext().State;

      terminal.Clear ();

      switch (state)
      {
        case GameOver :
          terminal.PrintGameOver ();
          break;
        case Won:
          terminal.PrintWinScreen ();
          break;
      }

      terminal.Print (response);

    } while (state != Done);
  }
}
