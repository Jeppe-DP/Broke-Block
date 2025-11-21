 /* Main class for launching the game
 */

 public class GameLauncher
 {
   static World world = new World();
   static Context context = new Context(world.GetEntry());
   static ICommand fallback = new CommandUnknown();
   static Registry registry = new Registry(context, fallback);

   private static void InitRegistry()
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

   static void Main(string[] args)
   {
     Console.WriteLine("Velkommen til Broke-Broke!");

     UIManager ui = new UIManager(); //Call en instance
     TitleScreen titleScreen = new TitleScreen();
     titleScreen.Show();

     InitRegistry();
     context.GetCurrent().Welcome();

     while (!context.IsDone())
     {
       Console.Write("> ");
       string? line = Console.ReadLine();
       if (line != null) registry.Dispatch(line);
     }

     Console.WriteLine("Game Over 😥");
   }

   // Make world more static
   public static World GetWorld()
   {
     return world;
   }
 }



