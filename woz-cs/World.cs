/* World class for modeling the entire in-game world
 */

class World {
  Space start;
  
  public World () {
    Space start              = new Space("Start");
    Space byggematerialer    = new Space("Byggematerialer");
    Space by                 = new Space("By");
    Space feje               = new Space("Feje");
    Space byg                = new Space("Byg");
    Space mere_tid_i_vildnis = new Space("mere_tid_i_vildnis");
    
    start.AddEdge("byggematerialer", byggematerialer);
    start.AddEdge("By", by);
    by.AddEdge("feje", feje);
    by.AddEdge("Byg", byg);
    byggematerialer.AddEdge("Byg", byg);
    byggematerialer.AddEdge("mere_tid_i_vildnis", mere_tid_i_vildnis);
    
    this.start = start;
  }
  
  public Space GetEntry () {
    return start;
  }
}

