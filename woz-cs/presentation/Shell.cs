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
    ui = new UIManager(); //Initialize UI
  }

  // Helper method in Shell.cs
  public string ConvertNumberChoice(string input, Space currentRoom)
  {
    var exitNames = currentRoom.GetExitNames();

    if (input == "1" && exitNames.Count >= 1)
      return "vælg " + exitNames[0];

    if (input == "2" && exitNames.Count >= 2)
      return "vælg " + exitNames[1];

    return input;
  }

  public void Run ()
  {
    // show title screen first
    var title = new TitleScreen();
    title.Show();

    ui.Clear();
    var currentRoom = game.GetContext().GetCurrent(); //enables first room to have lines and colored choices too.
    ui.PrintDescription(currentRoom.Welcome());
    ui.PrintChoices(currentRoom);


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


      string response = game.ExecuteCmd (line);
      response = terminal.CheckClear (response);

      // Always update currentRoom after any command
      currentRoom = game.GetContext().GetCurrent();

      state = Game.State;

      switch (state)
      {
        case GameState.GameOver:
          var screen = new GameOverScreen(response); //C# picks type of variable and calls for class file (GameOverScreen.cs).
          screen.Show();
          terminal.Clear ();

          // Restart game and get the new starting room description
          string restartText = game.RestartGame();
          ui.PrintDescription(restartText);

          // Print choices for the new first room
          Space newRoom = game.GetContext().GetCurrent();
          ui.PrintChoices(newRoom);
          break;
        case GameState.Won:
          var winScreen = new WinningScreen(response); // calls for class file (WinningScreen.cs)
          winScreen.Show();
          state = game.EndGame();
          break;
        default:
          ui.PrintDescription(response);

          // CRITICAL: Update currentRoom after command execution
          currentRoom = game.GetContext().GetCurrent();

          // Only print choices if we are still playing
          if (Game.State == GameState.Running)
          {
            ui.PrintChoices(currentRoom);  // Now shows CORRECT room's choices
          }
          break;
      }
    }
  }
}
