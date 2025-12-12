/* Implementation of an inventory
 */

namespace Domain
{

  public class Inventory
  {
    private static List<Item> inventory = new List<Item>();

    public static void Add (Item item)
    {
      inventory.Add (item);
    }

    public static string PrintInventory ()
    {
      if (inventory.Count == 0)
      {
        return "Inventory er tom.";
      }

      string result = "Inventory:\n\n";

      for (int i = 0; i < inventory.Count; i++)
      {
        result += inventory[i].ToString () + (i == inventory.Count - 1 ? "" : "\n");
      }

      return result;
    }

    public static bool Contains (string name)
    {
      foreach (Item item in inventory)
      {
        if (item.Name.Equals (name)) return true;
      }

      return false;
    }
  }
}
