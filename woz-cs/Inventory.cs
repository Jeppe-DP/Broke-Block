/* Implementing an inventory
 */

public class Inventory
{
  private static List<string> inventory = new List<string>();

  public static void PickUp (string name)
  {
    inventory.Add (name);
  }

  public static void PrintInventory ()
  {
    foreach (string item in inventory)
    {
      Console.WriteLine (item);
    }
  }
}
