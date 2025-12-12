//Print ASCII style winning screen.

using Domain;

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
        ui = new UIManager(); //Genbruger UIManager
        this.description = description;
    }

    public void Show(){
        Console.ForegroundColor = ConsoleColor.Yellow;
        ui.WriteTitle(Win); // shows ASCII text in console
        Console.ResetColor();

        Console.WriteLine(description + "\n\n");
        Console.WriteLine("Tillykke med at have vundet Broke-Block.\nNu kommer der en lille quiz, for at teste din viden om bekæmpelse af fattigdom.");
        Console.WriteLine("Tryk ENTER for at starte quizzen.");
        Console.ReadLine();

        //starter quizzen
        Quiz quiz = new Quiz ();
        quiz.Start();
    }
    }
}
