//Print ASCII style winning screen.

namespace Presentation
{

    public class WinningScreen{

        private UIManager ui;
        private string description;

        public static readonly string[] Win = {
        @"",
        @"",
        @"",
        @" █████ █████                        █████   ███   █████  ███             ███",
        @"░░███ ░░███                        ░░███   ░███  ░░███  ░░░            ░███",
        @"░░███ ███    ██████  █████ ████    ░███   ░███   ░███  ████  ████████  ░███",
        @"░░█████    ███░░███░░███ ░███     ░███   ░███   ░███ ░░███ ░░███░░███ ░███",
        @"░░███    ░███ ░███ ░███ ░███     ░░███  █████  ███   ░███  ░███ ░███ ░███",
        @" ░███    ░███ ░███ ░███ ░███      ░░░█████░█████░    ░███  ░███ ░███ ░░░",
        @" █████   ░░██████  ░░████████       ░░███ ░░███      █████ ████ █████ ███",
        @" ░░░░░     ░░░░░░    ░░░░░░░░         ░░░   ░░░      ░░░░░ ░░░░ ░░░░░ ░░░",
        @"",
        @"",
        @"",
        @"                  Tillykke du har reddet Broke Block!                   ",
    };

    public WinningScreen (string description)
    {
        ui = new UIManager(); //Genbruge UIManager}
        this.description = description;
    }

    public void Show(){
        Console.ForegroundColor = ConsoleColor.Yellow;
        ui.WriteTitle(Win); //<-- shows ASCII text in console
        Console.ResetColor();

        Console.WriteLine(description + "\n\n");
        Console.WriteLine("Tryk ENTER for at starte quizzen.");
        Console.ReadLine();

        //starter quizzen
        Quiz quiz = new Quiz ();
        quiz.Start();
    }
    }
}
