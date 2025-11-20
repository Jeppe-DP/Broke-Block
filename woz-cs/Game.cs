 /* Main class for launching the game
 */

 public class Game
 {
   private UIManager ui;

   public Game()
   {
     ui = new UIManager(); // creates new UI object
   }

   public void Start()  // <-- added parentheses
   {
     // Add ASCII title
     string[] title = {  // <-- fixed syntax
       @"",
       @"",
       @"",
       @"",
       @" /$$$$$$$  /$$$$$$$   /$$$$$$  /$$   /$$ /$$$$$$$$       /$$$$$$$  /$$        /$$$$$$   /$$$$$$  /$$   /$$",
       @" | $$__  $$| $$__  $$ /$$__  $$| $$  /$$/| $$_____/      | $$__  $$| $$       /$$__  $$ /$$__  $$| $$  /$$/",
       @" | $$  \ $$| $$  \ $$| $$  \ $$| $$ /$$/ | $$            | $$  \ $$| $$      | $$  \ $$| $$  \__/| $$ /$$/",
       @" | $$$$$$$ | $$$$$$$/| $$  | $$| $$$$$/  | $$$$$         | $$$$$$$ | $$      | $$  | $$| $$      | $$$$$/",
       @" | $$__  $$| $$__  $$| $$  | $$| $$  $$  | $$__/         | $$__  $$| $$      | $$  | $$| $$      | $$  $$",
       @" | $$  \ $$| $$  \ $$| $$  | $$| $$\  $$ | $$            | $$  \ $$| $$      | $$  | $$| $$    $$| $$\  $$",
       @" | $$$$$$$/| $$  | $$|  $$$$$$/| $$ \  $$| $$$$$$$$      | $$$$$$$/| $$$$$$$$|  $$$$$$/|  $$$$$$/| $$ \  $$",
       @" |_______/ |__/  |__/ \______/ |__/  \__/|________/      |_______/ |________/ \______/  \______/ |__/  \__/",
       @"",
       @"",
       @"                                   Velkommen til Broke Block.                                            "
     };


     ui.WriteTitle(title); //<-- shows ASCII text in console

     Console.WriteLine("Tryk ENTER for at starte...");
     Console.ReadLine();
   }


 }
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

     // Laver objekt til screen.
     Game game = new Game();
     game.Start();   // <-- viser Ascii screen

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



