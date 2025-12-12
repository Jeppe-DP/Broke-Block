using Domain;

namespace Presentation
{

    public class TitleScreen{

        private UIManager ui;

        public TitleScreen()
        {
            ui = new UIManager();
        }

        public void Show()
        {
            // Add ASCII title
            string[] title = {
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

            Console.ForegroundColor = ConsoleColor.Green;
            ui.WriteTitle(title); //shows ASCII text in console
            Console.ResetColor();
            Console.WriteLine("Tryk ENTER for at starte...");
            Console.ReadLine();
        }
    }
}
