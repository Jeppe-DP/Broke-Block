/* Implementation of an inventory
 */

public class Inventory
{
  private static List<Item> inventory = new List<Item>();

  public static void Add (Item item)
  {
    inventory.Add (item);
  }

  public static void PrintInventory ()
  {
    foreach (Item item in inventory)
    {
      Console.WriteLine (item);
    }
  }
}
