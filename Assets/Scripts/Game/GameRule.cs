using UnityEngine;
using UnityEngine.Events;


public class GameRule : MonoBehaviour
{

   [SerializeField] private Cube cube1;
   [SerializeField] private Cube cube2;
   [SerializeField] private ScoreCounter scoreCounterPlayer;

 

   private int numberOfGame = 0;



   public void CompareResult()
   {
      if (numberOfGame % 2 == 0)
      {
         scoreCounterPlayer.Add(cube1.CurrentSideAbove.Number);
         scoreCounterPlayer.Add(cube2.CurrentSideAbove.Number);
      }
      else
      {
         scoreCounterPlayer.TakeAway(cube1.CurrentSideAbove.Number);
         scoreCounterPlayer.TakeAway(cube2.CurrentSideAbove.Number);
      }

      numberOfGame++;
   }

 
  
}
