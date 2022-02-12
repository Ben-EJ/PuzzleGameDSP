using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CubeHandle : MonoBehaviour
{
    public static string emptyPlaceHolder = "Empty";
    public static List<GameObject> populateSensorList(List<string> line)
    {
        List<GameObject> sensors = new List<GameObject>();
        for (int i = 0; i < line.Count; i++)
        {
            sensors.Add(GameObject.Find(line[i]));
        }
        return sensors;
    }


    public static string whichCube(int result)
    {
        switch (result)
        {
            case 2:
                return "cube2";
            case 4:
                return "cube4";
            case 8:
                return "cube8";
            case 16:
                return "cube16";
            case 32:
                return "cube32";
            case 64:
                return "cube64";
            case 128:
                return "cube128";
            case 256:
                return "cube256";
            case 512:
                return "cube512";
            case 1024:
                return "cube1024";
            case 2048:
                return "cube2048";
            default:
                return null;
        }
    }

    /*
     * Once its found a pair to merge it stops finding pairs to merge, then when it goes to merge again, the two pairs that have been merged are
     * still in the sensors list, but in reality they have been deleted, therefore an error occurs.
     */
    /*
     * The game does not merge a newly merged cube and a non merged cube
     * So:
     * 
     * 1. IF: CHECK TO SEE IF CAN MERGE FIRST OTHERWISE GOTO LINE 10
     * 2. GET all cubes in row
     * 3. LOOP: Start from beginning: Sensor[0] -> Sensor[x + 1] 
     * 4. IF: check all other sensors in row against that one, if a merge can occur:
     * 5. DELETE: Remove cubes(Acive Sensors) to be deleted from the array
     * 6. ADD: New cube In the pos of the Sensor[0]
     * 7. CONTINUE: on to the next sensor Sensor[1] etc...
     * 8. GOTO: line 4
     * 9. LOOP END: move all down to far left/right/up/down
     * 10. ELSE: NO MERGES CAN OCCUR, USE THE READY MADE CUBE MOVE FUNCTION
     */

    
    public static List<string> makeCopyList(List<GameObject> sensors)
    {
        List<string> output = new List<string>();
       
        for (int i = 0; i < sensors.Count; i++)
        {
            if(sensors[i].GetComponent<CubeDetector>().isCubeInSensor() == true)
            {
                output.Add(sensors[i].GetComponent<CubeDetector>().getCubeValue().ToString());
            }
            else
            {
                output.Add(emptyPlaceHolder);
            }
           
        }
        return output;
    }

    public static void clearGridRow(List<GameObject> sensors)
    {
        for (int i = 0; i < sensors.Count; i++)
        {
            GameObject.Destroy(GameObject.Find(sensors[i].GetComponent<CubeDetector>().getCubeName()));
            sensors[i].GetComponent<CubeDetector>().setCubeName("");
            sensors[i].GetComponent<CubeDetector>().isCubeInSensorSet(false);
            sensors[i].GetComponent<CubeDetector>().setCubeValue(0);
        }
    }
    public static void updateGridRow(List<GameObject> sensors, List<string> newCubes)
    {
        for (int i = 0; i < newCubes.Count; i++)
        {
            if (!newCubes[i].Equals(emptyPlaceHolder))
            {
                Vector3 sensorLocation = sensors[i].transform.position;
                Vector3 toSpawnAt = new Vector3(sensorLocation.x, sensorLocation.y + Spawning.spawnHeight, sensorLocation.z);
                Quaternion rotationOfCube = new Quaternion();
                rotationOfCube.x = 0;
                rotationOfCube.y = 180;
                rotationOfCube.z = 0;

                int cubeType = Int32.Parse(newCubes[i]);
                Spawning.cubeCounter = Spawning.cubeCounter + 1;
                string newCubeName = "cube" + Spawning.cubeCounter;

                Instantiate(GameObject.FindGameObjectWithTag(whichCube(cubeType)), toSpawnAt, rotationOfCube).name = newCubeName;

                sensors[i].GetComponent<CubeDetector>().setCubeName(newCubeName);
                sensors[i].GetComponent<CubeDetector>().isCubeInSensorSet(true);
                sensors[i].GetComponent<CubeDetector>().setCubeValue(cubeType);
            }
            else
            {
                sensors[i].GetComponent<CubeDetector>().setCubeName("");
                sensors[i].GetComponent<CubeDetector>().isCubeInSensorSet(false);
                sensors[i].GetComponent<CubeDetector>().setCubeValue(0);
            }
        }
    }
    
    public static void spawnRandomCube(List<GameObject> sensors)
    {
        List<GameObject> avalableSensors = new List<GameObject>();
        for(int i = 0; i < sensors.Count; i++)
        {
            if (sensors[i].GetComponent<CubeDetector>().isCubeInSensor() == false)
            {
                avalableSensors.Add(sensors[i]);
            }
        }
        
        if (avalableSensors.Count != 0)
        {
            System.Random rnd = new System.Random();
            int chosenRandomCube = rnd.Next(0, avalableSensors.Count);
            GameObject sensor = avalableSensors[chosenRandomCube];
            Vector3 sensorLocation = sensor.transform.position;
            Vector3 toSpawnAt = new Vector3(sensorLocation.x, sensorLocation.y + Spawning.spawnHeight, sensorLocation.z);
            Quaternion rotationOfCube = new Quaternion();
            rotationOfCube.x = 0;
            rotationOfCube.y = 180;
            rotationOfCube.z = 0;

            Spawning.cubeCounter = Spawning.cubeCounter + 1;
            string newCubeName = "cube" + Spawning.cubeCounter;

            Instantiate(GameObject.FindGameObjectWithTag("cube2"), toSpawnAt, rotationOfCube).name = newCubeName;

            sensor.GetComponent<CubeDetector>().setCubeName(newCubeName);
            sensor.GetComponent<CubeDetector>().isCubeInSensorSet(true);
            sensor.GetComponent<CubeDetector>().setCubeValue(2);
        }
        else
        {

        }
    }

    //This function has 2 applications. Its main function is it calculates a row of cubes moves I.E if they can merge or move, and this can be used it 2 ways:
    //The first is facilitating cube movement and merging, when the flagAllowUpdateGrid flag is set to true, the cubes will move on the grid based on the functions calculated state of a row,
    //
    //The second use case is to detect wether or not moves and merges are possible in a given row,
    //if there are moves and merges possible the function will return false, otherwise true to indicate no changes to the row can be made,
    //when the flagAllowUpdateGrid flag is set to false this can be used to
    //check wether or not the player has lost without actually making any physical moves on the grid.
    public static bool cubeMoveMerge(List<GameObject> sensors, bool flagAllowUpdateGrid)
    {

        bool flagMergesMade = false;
        
        List<string> cubePos = makeCopyList(sensors);
        List<string> cubePosBackup = makeCopyList(sensors);
        
        List<string> output = new List<string>() { emptyPlaceHolder, emptyPlaceHolder, emptyPlaceHolder, emptyPlaceHolder };

        bool flagGameWon = false;

        for (int i = 0; i < cubePos.Count; i++)//For each cube in list
        {
            bool foundCube = false;
            if (!cubePos[i].Equals(emptyPlaceHolder))//If its not empty (I.E no cube) then
            {
                for (int x = 0; x < cubePos.Count; x++)//For each other sensor past it
                {
                    if (i != x && !cubePos[x].Equals(emptyPlaceHolder))//if there not the same sensor and X cubePos is not empty then
                    {
                        if (cubePos[i].Equals(cubePos[x]))// If it finds a cube in line with the first cube and they are of the same value then:
                        {//Merge
                            foundCube = true;
                            int result = Int32.Parse(cubePos[i]) + Int32.Parse(cubePos[x]);
                            output[i] = result.ToString();
                            cubePos[i] = emptyPlaceHolder;
                            cubePos[x] = emptyPlaceHolder;
                            if (result == 2048 && flagAllowUpdateGrid == true)
                            {
                                flagGameWon = true;
                            }
                            if (flagAllowUpdateGrid == true)// If this flag is set to true then update userscore if a merge occurs.
                            {
                                GameState.playerScore = GameState.playerScore + 10;
                            }

                            flagMergesMade = true;
                            break;
                        }
                        else if (!cubePos[i].Equals(cubePos[x]) && !cubePos[x].Equals(emptyPlaceHolder))//If it finds a cube and they are not of the same value then:
                        {//the first cube cant move so just add it to the output list where it is in the input list
                            foundCube = true;
                            output[i] = cubePos[i];
                            output[x] = cubePos[x];
                            cubePos[i] = emptyPlaceHolder;
                            break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                if (foundCube == false)
                {
                    output[i] = cubePos[i];
                }
            }
            else
            {
                continue;
            }
        }

        //If no merges have been done then just add the origonal list to the "listToUse" list 
        //to calculate new pos of cubes (if they need to move).
        List<string> listToUse = new List<string>();
        if (flagMergesMade == false)
        {
            for (int j = 0; j < cubePosBackup.Count; j++)
            {
                listToUse.Add(cubePosBackup[j]);
            }
        }
        else
        {
            for (int j = 0; j < cubePosBackup.Count; j++)
            {
                listToUse.Add(output[j]);
            }
        }

        //For loop and While loop for shifting/Moving cubes
        List<string> finalList = new List<string>();
        //Takes away all "Empty" slots to move cubes to the end of the row
        for (int i = 0; i < listToUse.Count; i++)
        {
            if (!listToUse[i].Equals(emptyPlaceHolder))
            {
                finalList.Add(listToUse[i]);
            }
        }
        //Adds the empty slots back to the end of the row
        while (finalList.Count < 4)
        {
            finalList.Add(emptyPlaceHolder);
        }

        //Checks to see if the list given to the function is the same as the functions output, if they are the same then no changes were made to the cubes
        bool listsSame = true;
        for (int i = 0; i < finalList.Count; i++)
        {
            if (!finalList[i].Equals(cubePosBackup[i]))
            {
                listsSame = false;
            }
        }

        //If flagAllowUpdateGrid is true allow changes to be made to grid
        if (flagAllowUpdateGrid == true)
        {
            if (listsSame == false)//If listsSame is false, I.E changes to the row have been made then, these two functions are called to:
            {
                clearGridRow(sensors);// Clear the grid
                updateGridRow(sensors, finalList);// Update grid with new cubes and positions.
            }
        }
        // This if statment is used to ensure the move is completed before the player is anounced victorious hence why it is after the
        // clearGridRow and updateGridRow function calls.
        if (flagGameWon == true)
        {
            GameState.playerWon = true;
        }
        return listsSame;
    }
    
    private static void debugOutputList(List<string> list)
    {
        Debug.Log("==========================================================");
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i]);
        }
        Debug.Log("==========================================================");
    }

}
