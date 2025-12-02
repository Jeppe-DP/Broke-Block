/* Command for picking up items
 */

class CommandTake : BaseCommand, ICommand
{
  public CommandTake ()
  {
      description = "Pick up an item.";
  }

  public string Execute (Context context, string command, string[] parameters)
  {
    string name = "";
    if(parameters.Length>0)
    {
      name = parameters[0].ToLower ();
    }
    Space location = context.GetCurrent ();

    Item? item = location.PickUpItem (name);

    if (item != null)
    {
      Inventory.Add (item);
      return "Du samlede " + name + " op";
    }
    else
    {
      return "Der er ingen " + name + " her.";
    }
  }
}
