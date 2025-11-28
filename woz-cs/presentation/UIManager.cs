//UserInterface til at display title screen gennem Game.cs

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
}

