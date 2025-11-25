 /* Main class for launching the game
 */

public class Game
{
  public World World { set; get; };
  public Context Context { set; get; }
  public ICommand Fallback { set; get; }
  public Registry Registry { set; get; }

  public Game ()
  {
    world = new World ();
    context = new Context (world.GetEntry());
    fallback = new CommandUnknown();
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

  public static World GetWorld()
  {
    return world;
  }
}
