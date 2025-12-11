/* Command for picking up items
 */

namespace Domain
{

  class CommandTake : BaseCommand, ICommand
  {
    public CommandTake ()
    {
        description = "Saml en ting op";
    }

    public string Execute (Context context, string command, string[] parameters)
    {
      string name = parameters[0].ToLower ();

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
}
