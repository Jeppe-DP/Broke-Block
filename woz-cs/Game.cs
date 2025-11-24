 /* Main class for launching the game
 */

public class GameLauncher{

   public static World world = new World();
   public static Context context = new Context(world.GetEntry());
   public static ICommand fallback = new CommandUnknown();
   public static Registry registry = new Registry(context, fallback);

public static void InitRegistry()
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

public static World GetWorld(){
  return world;
}
 }
