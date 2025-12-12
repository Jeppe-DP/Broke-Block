/*World class for modeling the entire in-game world*/

namespace Domain
{

  public class World {
    Space start;

    public World () {
      Space start                      = new Space("start");
      Space vildnis_byggematerialer    = new Space("vildnis");
      Space by                         = new Space("by");
      Space feje                       = new Space("feje");
      Space byg_hus                    = new Space("byg hus");
      Space mere_tid_i_vildnis         = new Space("mere tid i vildnis");
      Space hospital                   = new Space ("ressourcer til hospital");
      Space sælg_medicin               = new Space ("sælg medicin");
      Space skole                      = new Space ("byg skole");
      Space bar                        = new Space ("byg bar");
      Space samarbejde_med_bønder      = new Space ("samarbejde med bønder");
      Space fortsæt_uden_samarbejde    = new Space ("fortsæt uden samarbejde");
      Space byg_dæmninger              = new Space ("byg dæmninger");
      Space ignorere_floden            = new Space ("ignorere floden");
      Space sælge_råvarer              = new Space ("sælge råvarer");
      Space behold_råvarer             = new Space ("behold råvarer");
      Space forbedre_veje              = new Space ("forbedre veje");
      Space behold_veje                = new Space ("behold veje");

      start.AddEdge("vildnis", vildnis_byggematerialer);
      start.AddEdge("by", by);
      by.AddEdge("feje", feje);
      by.AddEdge("byg hus", byg_hus);
      vildnis_byggematerialer.AddEdge("byg hus", byg_hus);
      vildnis_byggematerialer.AddEdge("mere tid i vildnis", mere_tid_i_vildnis);
      byg_hus.AddEdge("ressourcer til hospital", hospital);
      byg_hus.AddEdge("sælg medicin", sælg_medicin);
      hospital.AddEdge("byg skole", skole);
      hospital.AddEdge("byg bar", bar);
      skole.AddEdge("samarbejde med bønder", samarbejde_med_bønder);
      skole.AddEdge("fortsæt uden samarbejde", fortsæt_uden_samarbejde);
      samarbejde_med_bønder.AddEdge("byg dæmninger", byg_dæmninger);
      samarbejde_med_bønder.AddEdge("ignorere floden", ignorere_floden);
      byg_dæmninger.AddEdge("sælge råvarer", sælge_råvarer);
      byg_dæmninger.AddEdge("behold råvarer", behold_råvarer);
      sælge_råvarer.AddEdge("forbedre veje", forbedre_veje);
      sælge_råvarer.AddEdge("behold veje", behold_veje);

      Item hammer = new Item ("hammer");
      Item søm = new Item ("søm");
      Item træ = new Item ("træ");

      start.AddItem (hammer);

      vildnis_byggematerialer.AddRequiredItem (hammer);
      by.AddRequiredItem (hammer);

      vildnis_byggematerialer.Message = "Husk at samle hammeren op - du får brug for den!";
      by.Message = "Husk at samle hammeren op - du får brug for den!";

      by.AddItem (søm);
      by.AddItem (træ);

      byg_hus.AddRequiredItem (søm);
      byg_hus.AddRequiredItem (træ);

      byg_hus.Message = "Du skal bruge både træ og søm til at bygge husene!";

      Item medicin = new Item ("medicin");

      byg_hus.AddItem (medicin);
      hospital.AddRequiredItem (medicin);

      hospital.Message = "Du har ingen medicin!";

      Item sten = new Item ("sten");

      vildnis_byggematerialer.AddItem (søm);
      vildnis_byggematerialer.AddItem (træ);

      Item råvarer = new Item ("råvarer");

      byg_dæmninger.AddItem (råvarer);
      sælge_råvarer.AddRequiredItem (råvarer);

      sælge_råvarer.Message = "Du samlede ikke råvarerne op!";

      behold_råvarer.AddRequiredItem(råvarer);
      behold_råvarer.Message = "Du samlede ikke råvarerne op!";
      this.start = start;
    }

  public Space GetEntry () {
      return start;
    }
  }
}
