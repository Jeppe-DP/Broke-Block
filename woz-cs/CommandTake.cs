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

    string name = parameters[0].ToLower ();

    Item? item = location.PickUpItem (name);

    if (item != null)
    {
      Inventory.Add (item);
      Console.WriteLine ("You picked up the " + name);
    }
    else
    {
      Console.WriteLine ("There is no " + name + " here.");
    }
  }
}
