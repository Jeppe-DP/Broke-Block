public class TitleScreen{

    private UIManager ui;

    // Add this static field
    public static readonly string[] Art = {
            @"",
            @"",
            @"",
            @"",
            @"  /$$$$$$$   /$$$$$$$    /$$$$$$    /$$   /$$/   $$$$$$$$       /$$$$$$$   /$$         /$$$$$$    /$$$$$$   /$$   /$$",
            @" | $$__  $$ | $$__  $$  /$$__  $$  | $$  /$$/  | $$_____/      | $$__  $$ | $$        /$$__  $$  /$$__  $$ | $$  /$$/",
            @" | $$  \ $$ | $$  \ $$ | $$  \ $$  | $$ /$$/   | $$            | $$  \ $$ | $$       | $$  \ $$ | $$  \__/ | $$ /$$/",
            @" | $$$$$$$  | $$$$$$$/ | $$  | $$  | $$$$$/    | $$$$$         | $$$$$$$  | $$       | $$  | $$ | $$       | $$$$$/",
            @" | $$__  $$ | $$__  $$ | $$  | $$  | $$  $$    | $$__/         | $$__  $$ | $$       | $$  | $$ | $$       | $$  $$",
            @" | $$  \ $$ | $$  \ $$ | $$  | $$  | $$\  $$   | $$            | $$  \ $$ | $$       | $$  | $$ | $$    $$ | $$\  $$",
            @" | $$$$$$$/ | $$  | $$ |  $$$$$$/  | $$ \  $$  | $$$$$$$$      | $$$$$$$/ | $$$$$$$$ |  $$$$$$/ |  $$$$$$/ | $$ \  $$",
            @" |_______/  |__/  |__/  \______/   |__/  \__/  |________/      |_______/  |________/  \______/   \______/  |__/  \__/",
            @"",
            @"",
            @"                                   Velkommen til Broke Block.                                            "
        };


    public TitleScreen(){

        ui = new UIManager(); // creates new UI object
    }


   // Show method to display the title
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        ui.WriteTitle(Art); //<-- shows ASCII text in console
        Console.ResetColor();

        Console.WriteLine("Tryk ENTER for at starte...");
        Console.ReadLine();
    }
}
