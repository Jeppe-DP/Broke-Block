/* Implementation of an inventory
 */

public class Inventory
{
  private static List<Item> inventory = new List<Item>();

  public static void Add (Item item)
  {
    inventory.Add (item);
  }

  public static string PrintInventory ()
  {
    string result = "";

    for (int i = 0; i < inventory.Count; i++)
    {
      result += inventory[i].ToString () + (i == inventory.Count - 1 ? "" : "\n");
    }

    return result;
  }
}
