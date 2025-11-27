/* Space class for modeling spaces (rooms, caves, ...)
 */
class Space : Node {

  public Space (String name) : base(name)
  {
  }

  public void Welcome () {
  //tilføjet mellemrum
    Console.Clear();
    Console.WriteLine();
  //oversat
    Console.WriteLine("Du er nu ved "+name);
    Console.WriteLine();

    Console.WriteLine(Description.GetDescription(name));
    HashSet<string> exits = edges.Keys.ToHashSet();
    Console.WriteLine();
    Console.WriteLine("Nuværende udgange er:");
    foreach (String exit in exits)
    {
      Console.WriteLine(" - "+exit);
    }
  }

  public void Goodbye () {
  }

  public override Space FollowEdge (string direction)
  {
    return (Space) (base.FollowEdge(direction));
  }
}
