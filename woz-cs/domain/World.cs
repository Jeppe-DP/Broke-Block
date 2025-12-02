/*World class for modeling the entire in-game world*/


public class World {
  private Space start;

  public World() {
    // Declare spaces as local variables
    Space startRoom = new Space("start");
    Space vildnisByggematerialer = new Space("vildnis");
    Space by = new Space("by");
    Space feje = new Space("feje");
    Space bygHus = new Space("byg hus");
    Space mereTidIVildnis = new Space("mere tid i vildnis");
    Space hospital = new Space("ressourcer til hospital");
    Space sælgMedicin = new Space("sælg medicin");
    Space skole = new Space("byg skole");
    Space bar = new Space("byg bar");
    Space samarbejdeMedBønder = new Space("samarbejde med bønder");
    Space fortsætUdenSamarbejde = new Space("fortsæt uden samarbejde");
    Space bygDæmninger = new Space("byg dæmninger");
    Space ignorereFloden = new Space("ignorere floden");
    Space sælgeRåvarer = new Space("sælge råvarer");
    Space beholdRåvarer = new Space("behold råvarer");
    Space forbedreVeje = new Space("forbedre veje");
    Space beholdVeje = new Space("behold veje");

    // Add edges
    startRoom.AddEdge("vildnis", vildnisByggematerialer);
    startRoom.AddEdge("by", by);
    by.AddEdge("feje", feje);
    by.AddEdge("byg hus", bygHus);
    vildnisByggematerialer.AddEdge("byg hus", bygHus);
    vildnisByggematerialer.AddEdge("mere tid i vildnis", mereTidIVildnis);
    bygHus.AddEdge("ressourcer til hospital", hospital);
    bygHus.AddEdge("sælg medicin", sælgMedicin);
    hospital.AddEdge("byg skole", skole);
    hospital.AddEdge("byg bar", bar);
    skole.AddEdge("samarbejde med bønder", samarbejdeMedBønder);
    skole.AddEdge("fortsæt uden samarbejde", fortsætUdenSamarbejde);
    samarbejdeMedBønder.AddEdge("byg dæmninger", bygDæmninger);
    samarbejdeMedBønder.AddEdge("ignorere floden", ignorereFloden);
    bygDæmninger.AddEdge("sælge råvarer", sælgeRåvarer);
    bygDæmninger.AddEdge("behold råvarer", beholdRåvarer);
    sælgeRåvarer.AddEdge("forbedre veje", forbedreVeje);
    sælgeRåvarer.AddEdge("behold veje", beholdVeje);

    // Add items
    by.AddItem(new Tool("hammer"));
    by.AddItem(new Material("søm"));
    by.AddItem(new Material("træ"));
    bygHus.AddItem(new Material("medicin"));
    vildnisByggematerialer.AddItem(new Material("træ"));
    vildnisByggematerialer.AddItem(new Material("sten"));

    // Assign to class field
    this.start = startRoom;
  }

  public Space GetEntry() {
    return start;
  }
}
