/* Command for printing inventory
 */

namespace Domain
{

  class CommandShow : BaseCommand, ICommand
  {
    public CommandShow ()
    {
      description = "Print inventory.";
    }

    public string Execute (Context context, string command, string[] parameters)
    {
      return Inventory.PrintInventory ();
    }
  }
}
