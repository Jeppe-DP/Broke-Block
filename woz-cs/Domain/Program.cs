class Program{
    static void Main(string[] args){

        Console.WriteLine("Velkommen til Broke-Broke!");

        UIManager ui = new UIManager(); // Call an instance
        TitleScreen titleScreen = new TitleScreen();
        titleScreen.Show();

        GameLauncher.InitRegistry();
        GameLauncher.context.GetCurrent().Welcome();

        while (!GameLauncher.context.IsDone())
        {
            Console.Write("> ");
            string? line = Console.ReadLine();
            if (line != null) GameLauncher.registry.Dispatch(line);
        }

        Console.WriteLine("Game Over 😥");
    }

    // Optional helper to access the world
public static World GetWorld(){

        return GameLauncher.world;
    }
}
