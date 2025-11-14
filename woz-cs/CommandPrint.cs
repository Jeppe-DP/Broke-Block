/* Command for printing inventory
 */

 class CommandPrint : BaseCommand, ICommand
 {
    public CommandPrint ()
    {
      description = "Print inventory.";
    }

    public void Execute (Context context, string command, string[] parameters)
    {
      Inventory.PrintInventory ();
    }
 }