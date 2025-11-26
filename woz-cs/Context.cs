/* Context class to hold all context relevant to a session.
 */

public class Context {
  Space current;
  GameState State { get; set; }
  
  public Context (Space node) {
    current = node;
    State = Running;
  }
  
  public Space GetCurrent() {
    return current;
  }
  
  public void Transition (string direction) {
    Space next = current.FollowEdge(direction);

    UpdateState (next);
  }

  private void UpdateState (Space next)
  {
    next.GetName() switch
    {
      "start"         => State = GameOver,
      "forbedre veje" => State = Won,
      _               => State = Running
    }
  }

  public enum GameState
  {
    Running,
    Done,
    GameOver,
    Won
  }
}

