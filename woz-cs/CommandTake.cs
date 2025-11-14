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
    Space location = context.GetCurrent ();

    string item = parameters[0];

    if (location.ContainsItem (item))
    {
      Inventory.PickUp (item);
      location.RemoveItem (item);
      Console.WriteLine ("You picked up the " + item);
    }
    else
    {
      Console.WriteLine ("There is no " + item + " here.");
    }
  }
}
