/* Command for picking up items
 */

 class CommandTake : BaseCommand, ICommand 
 {
    public CommandTake ()
    {
        description = "Pick up an item.";
    }

    public void Execute (Context context, string command, string[] parameters)
    {
      Inventory.PickUp (parameters[0]);

      /*
      if (Inventory.PickUp (parameters[0]))
      {
        Console.WriteLine ("You picked up the " + parameters[0]);
      }
      else
      {
        Console.WriteLine (parameters[0] + " does not exist in the room.");
      }
      */
    }
 }