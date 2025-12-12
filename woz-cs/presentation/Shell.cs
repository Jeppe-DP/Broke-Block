/* Class that handles interaction with Domain
 */
using Domain;
namespace Presentation{
  public class Shell
  {
    private Game game;
    private Terminal terminal;
    private UIManager ui;

    public Shell (Game instance)
    {
      game = instance;
      terminal = new Terminal ();
      ui = new UIManager();
    }

    // Helper method in Shell.cs
    public string ConvertNumberChoice(string input, Space currentRoom)
    {
      List<string> exitNames = currentRoom.GetExitNames();

      if (input == "1" && exitNames.Count >= 1)
        return "vælg " + exitNames[0];

      if (input == "2" && exitNames.Count >= 2)
        return "vælg " + exitNames[1];

      return input;
    }

    public void Run ()
    {
      // show title screen first
      TitleScreen title = new TitleScreen();
      title.Show();

      ui.Clear();
      Space currentRoom = game.GetContext().GetCurrent(); //enables first room to have lines and colored choices too.
      ui.PrintDescription(currentRoom.Welcome());
      ui.PrintChoices(currentRoom);
      string response = "";


      GameState state = Game.State;

      while (state != GameState.Done)
      {
        string line = terminal.GetInput ();

        // Check if input is "1" or "2" and convert it

        if (line == "1" || line == "2")
        {
          currentRoom = game.GetContext().GetCurrent();
          line = ConvertNumberChoice(line, currentRoom);
        }
        try
        {
          response = game.ExecuteCmd (line);
          response = terminal.CheckClear (response);
        }
        catch
        {
        }

        // Always update currentRoom after any command
        currentRoom = game.GetContext().GetCurrent();

        state = Game.State;

        switch (state)
        {
          case GameState.GameOver:
            GameOverScreen screen = new GameOverScreen(response);
            screen.Show();
            terminal.Clear ();

            string restartText = game.RestartGame();
            ui.PrintDescription(restartText);

            // Print choices for the new first room
            Space newRoom = game.GetContext().GetCurrent();
            ui.PrintChoices(newRoom);
            break;
          case GameState.Won:
            WinningScreen winScreen = new WinningScreen(response);
            winScreen.Show();
            state = game.EndGame();
            break;
          default:
            ui.PrintDescription(response);

            // Update currentRoom after command execution
            currentRoom = game.GetContext().GetCurrent();

            // Only print choices if we are still playing
            if (Game.State == GameState.Running)
            {
              ui.PrintChoices(currentRoom);
            }
            break;
        }
      }
    }
  }
}
