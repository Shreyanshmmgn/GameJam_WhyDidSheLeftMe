using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCaluculator : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement player;

  
   public void ClaculateScore()
    {
        if (player.trophy < 3 && player.enemy <= 4)
        {
            print("You have gone mad behind success");
            SceneManager.LoadScene("Ending2");

        }
        else if (player.trophy == 3 && player.enemy == 0)
        {
            print("Winer ! You have left all problems behind");
            SceneManager.LoadScene("Ending1");
        }
    }
}
