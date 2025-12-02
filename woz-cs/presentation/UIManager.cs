//UserInterface til at display screen gennem Game.cs

public class UIManager
{
// Clear the console screen

    public void Clear()
    {
        Console.Clear();
    }

// Print text centered horizontally

   public void WriteCentered (string text){
    int left = (Console.WindowWidth - text.Length) / 2;
    //Adding new spaces to simulate centered.

    Console.WriteLine(new string(' ', Math.Max(left,0)) + text);
}

//Print ASCII style title.

public void WriteTitle (string[] ascii){ //Kan lave det her mere OOP ved at lave en separat fil under UIManager ved at kalde den TitleScreen.cs

    Clear(); //clears console screen.

    foreach(string line in ascii){

        WriteCentered(line);
    }
    Console.WriteLine();
}

//Print room description.
public void PrintDescription (string text){
    Console.WriteLine(text);
    Console.WriteLine(""); //empty lines
    Console.WriteLine(""); //empty lines
    Console.WriteLine(""); //empty lines
    Console.ResetColor();
}

//Print choices in color.
public void PrintChoice1 (string choice1, string choice2){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("1) " + choice1);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("2) " + choice2);
    Console.ResetColor();
}
}


