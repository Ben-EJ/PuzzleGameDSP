using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static bool playerWon = false;
    public static bool playerLost = false;
    
    public static bool flagToldPlayerWon = false;//Ensures the player is notified only once
    public static bool flagToldPlayerLost = false;//Ensures the player is notified only once

    public static int playerScore = 0;
    // Update is called once per frame
    void Update()
    {
        if(playerLost == true && flagToldPlayerLost != true)
        {
            Debug.Log("================--------------Player Lost--------------================");
            Debug.Log("Player Score: " + playerScore);
            flagToldPlayerLost = true;
            
        }
        if (playerWon == true && flagToldPlayerWon != true)
        {
            Debug.Log("================--------------Player Won--------------================");
            Debug.Log("Player Score: " + playerScore);
            flagToldPlayerWon = true;
        }
    }
}
