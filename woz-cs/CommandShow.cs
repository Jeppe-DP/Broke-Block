/* Command for printing inventory
 */

class CommandShow : BaseCommand, ICommand
{
  public CommandShow ()
  {
    description = "Print inventory.";
  }

  public void Execute (Context context, string command, string[] parameters)
  {
    Inventory.PrintInventory ();
  }
}
