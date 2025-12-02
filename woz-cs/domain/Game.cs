 /* Main class for launching the game
 */

public class Game : IGame
{
  public static GameState State { get; set; }

  private static World world = new World ();
  private Context context;
  private ICommand fallback;
  private Registry registry;

  public Game ()
  {
    State = GameState.Running;

    context = new Context (world.GetEntry(), world);//world.GetEntry() gives the starting room (Space) for the player.
    fallback = new CommandUnknown ();
    registry = new Registry (context, fallback);

    InitRegistry ();
  }

  private void InitRegistry()
  {
    ICommand cmdExit = new CommandExit();
    registry.Register("exit", cmdExit);
    registry.Register("quit", cmdExit);
    registry.Register("bye", cmdExit);
    registry.Register("help", new CommandHelp(registry));
    registry.Register("take", new CommandTake());
    registry.Register("modtag", new CommandTake());
    registry.Register("show", new CommandShow());
    registry.Register("vis", new CommandShow());
    registry.Register("go", new CommandGo());
  }
  public void choices()
  {
    while (State == GameState.Running)
    {
      var room = context.GetCurrent();

      Console.WriteLine(room.GetDescription());
      Console.WriteLine("1." + room.Choice1Text);
      Console.WriteLine("2." + room.Choice2Text);
      Console.Write("Enter 1 eller 2: ");

      string input = Console.ReadLine()?.Trim();

      // Instead of sending the next room name, send "go" + user choice
      if (input == "1" || input == "2")
      {
        input = $"go {input}";
      }
      else
      {
        Console.WriteLine("Invalid choice.");
      }

      Console.WriteLine();
    }
  }


  public string ExecuteCmd(string input)
  {
    // Old system: commands like "take hammer", "show" //This fixes your interface error and supports choice commands.
    return registry.Dispatch(input);
  }

  public string ExecuteCmd(string command, string[] parameters)
  {
    // New system: commands like GO with parameters (1 or 2)
    return registry.Dispatch(command, parameters);
  }

  public string RestartGame ()
  {
    State = GameState.Running;

    return context.GetCurrent().Welcome ();
  }

  public GameState EndGame ()
  {
    State = GameState.Done;

    return State;
  }

  public Context GetContext ()
  {
    return context;
  }

  public static World GetWorld ()
  {
    return world;
  }
}

// Repræsenterer mulige spiltilstande
public enum GameState
{
  Running,
  Done,
  GameOver,
  Won
}
