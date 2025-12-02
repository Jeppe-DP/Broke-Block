/* Class that handles interaction with Domain
 */

public class Shell
{
  private Game game;
  private Terminal terminal;
  private UIManager ui;

  public Shell (Game instance)
  {
    game = instance;
    terminal = new Terminal ();
    ui = new UIManager(); // <-- Initialize it here
  }

  public void Run ()
  {
    GameState state = Game.State;
    Space currentSpace = game.GetContext().GetCurrent();

    terminal.PrintWelcome ();
    terminal.Clear ();
    terminal.Print("════════════════════════════════════════════════════════════════════════");
    ui.PrintDescription(currentSpace.GetDescription());
    ui.PrintChoice1(currentSpace.Choice1Text, currentSpace.Choice2Text); //Reuses UIManager
    terminal.Print("════════════════════════════════════════════════════════════════════════"); //this prints right after the first room text


    while (state != GameState.Done)
    {
      currentSpace = game.GetContext().GetCurrent();

      ui.Clear(); // Clear the screen
      terminal.Print ("════════════════════════════════════════════════════════════════════════"); // Line before description
      // Show the current room description and choices
      ui.PrintDescription(currentSpace.GetDescription());
      ui.PrintChoice1(currentSpace.Choice1Text, currentSpace.Choice2Text);
      terminal.Print ("════════════════════════════════════════════════════════════════════════"); //Line after description


      string line = terminal.GetInput ();
      string response = game.ExecuteCmd (line);
      response = terminal.CheckClear (response);

      state = Game.State;

      switch (state)
      {
        case GameState.GameOver:
          terminal.PrintGameOver (response);
          terminal.Clear ();
          terminal.Print (game.RestartGame ());
          break;
        case GameState.Won:
          terminal.PrintWinScreen (response);
          state = game.EndGame ();
          break;
        default:
          terminal.Print ("response");
          break;
      }
    }
  }
}



