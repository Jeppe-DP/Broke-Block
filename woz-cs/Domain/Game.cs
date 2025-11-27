 /* Main class for launching the game
 */

public class Game
{
  public static GameState State { get; set; }

  private static World world = new World ();
  private Context context;
  private ICommand fallback;
  private Registry registry;

  public Game ()
  {
    State = GameState.Running;

    context = new Context (world.GetEntry());
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
    registry.Register("vælg", new CommandGo());
    registry.Register("help", new CommandHelp(registry));
    registry.Register("take", new CommandTake());
    registry.Register("modtag", new CommandTake());
    registry.Register("show", new CommandShow());
    registry.Register("vis", new CommandShow());
  }

  public string ExecuteCmd (string input)
  {
    return registry.Dispatch(input);
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
