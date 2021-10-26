using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueensGameLogic : MonoBehaviour
{
    // created a check box in the inspector pannel, when checked the script will run 
    //Without having to be in VR (FOR TESTING PERPOSES)
    //===================================================================
    public bool testButton = false;
    //===================================================================

    public List<GameObject> sensors = new List<GameObject>();
    public List<string> triggeredSensors = new List<string>();

    public static List<Queen> queens = new List<Queen>();
    public Material matValidSolution;
    public Material matInvalidSolution;

    void populateQueensVars()
    {
        int queenNumber = 0;
        for (int i = 0; i < sensors.Count; i++)
        {
            if (sensors[i].GetComponent<DetectorScript>().queenInSensor == true)
            {
                queenNumber++;
                Queen aQueen = new Queen(queenNumber, sensors[i].GetComponent<DetectorScript>().queenName, PossibleMovesQueen.getPossibleMoves(sensors[i].name), sensors[i].name);
                queens.Add(aQueen);
            }
        }
    }

    bool compareQueen(string firstQueen, List<string>queenToCompare)
    {
        for (int i = 0; i < queenToCompare.Count; i++)
        {
            if (firstQueen == queenToCompare[i])
            {
                return true;
            }
        }
        return false;
    }
    bool isInLineOfSightQueen()
    {
        //Get first queen to compare
        for (int i = 0; i < queens.Count; i++)
        {
            for (int x = 0; x < queens.Count; x++)
            {
                if (i != x)
                {
                    if (compareQueen(queens[i].getQueenXYChessCoords(), queens[x].getPossibleMoves()) == true) {
                        Debug.Log("QUEEN ONE: " + queens[i].getQueenName());
                        Debug.Log("QUEEN TWO: " + queens[x].getQueenName());
                        return true;
                    } 
                }
                
            }  
        }
        return false;
    }

    private void buttonChangeMesh()
    {
        if (isInLineOfSightQueen() == true)
        {
            MeshRenderer my_renderer = GetComponent<MeshRenderer>();
            my_renderer.material = matInvalidSolution;
        }
        else
        {
            MeshRenderer my_renderer = GetComponent<MeshRenderer>();
            my_renderer.material = matValidSolution;
        }
    }

    //This function is called when the Calculate solution button is clicked in game
    void OnTriggerEnter(Collider entityTriggered)
    {
        if (entityTriggered.gameObject.tag == "Controller")
        {
            populateQueensVars();
            buttonChangeMesh();
        }
    }

    //This functions perpose in this case is to fasilitate the use of the Test button I created in the unity editor 
    //so I dont have to test this script in vr
    private void Update()
    {
        if (testButton == true)
        {
            populateQueensVars();
            Debug.Log(" ");
            debugFuncQueens();
            Debug.Log(" ");
            buttonChangeMesh();


        }
    }


    //For debugging ============================================================
    void debugFuncQueens()
    {
        for (int i = 0; i < queens.Count; i++)
        {
            Debug.Log("===========================================================================");
            Debug.Log("Queen Number: " + queens[i].getQueenNumber());
            Debug.Log("Queen Name: " + queens[i].getQueenName());
            PossibleMovesQueen.debugCalculateQueenMoves(queens[i].getQueenXYChessCoords());
            Debug.Log("Queen XY Coords: " + queens[i].getQueenXYChessCoords());
            Debug.Log("===========================================================================");
        }
    }
}