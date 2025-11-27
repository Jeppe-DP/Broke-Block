//Print ASCII style winning screen.

public class WinningScreen{

    private UIManager ui;

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

public WinningScreen()
{
    ui = new UIManager(); //Genbruge UIManager}
}

public void Show(){
    Console.ForegroundColor = ConsoleColor.Yellow;
    ui.WriteTitle(Win); //<-- shows ASCII text in console
    Console.ResetColor();

    Console.WriteLine("🎉🎉 Broke-Block har bedre veje nu og lastbilerne kan transportere varer frem og tilbage.\n"
    +"Broke-Block sælger mange varer til nabolandene og økonomien vokser.\n"
    +"Tillykke!Broke-Block er nu kommet ud af fattigdom.\n"
    +"Beboerne er glade og kan nu leve i et velfungerende samfund");
    Console.ReadLine();

    //starter quizzen
    Quiz quiz = new Quiz ();
    quiz.Start();

 }
}


