//Print ASCII style winning screen.

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

    Console.WriteLine(description);
 }
}


