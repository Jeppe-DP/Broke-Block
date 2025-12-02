/* Command for transitioning between spaces
 */

class CommandGo : BaseCommand, ICommand
{
  public CommandGo ()
  {
    description = "Follow an exit";
  }
  
  public string Execute (Context context, string command, string[] parameters){

    // Check if the player typed a choice
    if (parameters.Length == 0)
    {
      return "Skriv 1 eller 2 for at vælge."; // "Type 1 or 2 to choose."
    }

    // Get the choice from the player
    string choice = parameters[0];

    // Decide the next room based on the choice
    string nextRoom = null;

    if (choice == "1")
    {
      nextRoom = context.Current.Choice1NextRoom;
    }
    else if (choice == "2")
    {
      nextRoom = context.Current.Choice2NextRoom;
    }
    else
    {
      return "Vælg 1 eller 2."; // Invalid choice
    }

    return context.Transition(nextRoom);// Move the player to the next room and return its description
 }
}




