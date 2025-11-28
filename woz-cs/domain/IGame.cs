/* Defines members for controlling the GameState
 */

public interface IGame
{
  static GameState State { get; set; }

  string ExecuteCmd (string input);
  string RestartGame ();
  GameState EndGame ();
}
