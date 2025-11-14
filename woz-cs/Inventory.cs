/* Implementing an inventory
 */

 public class Inventory
 {
    public static List<string> inventory;

    public static void PickUp (string name)
    {
        //if (context.GetCurrent ().IsInSpace (item))
        //{
          inventory.Add (name);
          
        //}

        
    }   

    public static void PrintInventory ()
    {
      foreach (string item in inventory)
      {
        Console.WriteLine (item);
      }
    }
 }