using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    /*
      Algorithm:
     Check line by line depending on direction for cubes, check to see if each cube to the left,right,up,down is the same
     if so add numbers delete two cubes and place new cube

     for movement
     check to see if there is a space if so move until space is unavalable
      */
    // Start is called before the first frame update
    public GameObject cube2GameObj;
    public static int cubeCounter = 0;
    void Start()
    {
        /*int pos1rnd = 0;
        int pos2rnd = 0;

        string pos1;
        string pos2;
        System.Random rnd = new System.Random();
        Grid grid = new Grid();
        pos1rnd = rnd.Next(0, 16);
        pos2rnd = rnd.Next(0, 16);

        while (pos1rnd == pos2rnd)
        {
            pos2rnd = rnd.Next(0, 16);
        }

        pos1 = grid.gridWhole[pos1rnd];
        pos2 = grid.gridWhole[pos2rnd];

        Vector3 objPos1 = GameObject.Find(pos1).transform.position;
        Vector3 objPos2 = GameObject.Find(pos2).transform.position;

        Vector3 cubeSpawnPos1 = new Vector3(objPos1.x, objPos1.y + 0.02f, objPos1.z);
        Vector3 cubeSpawnPos2 = new Vector3(objPos2.x, objPos2.y + 0.02f, objPos2.z);

        cubeCounter = cubeCounter + 1;

        Instantiate(cube2GameObj, cubeSpawnPos1, Quaternion.identity).name = "cube" + cubeCounter;

        cubeCounter = cubeCounter + 1;
        Instantiate(cube2GameObj, cubeSpawnPos2, Quaternion.identity).name = "cube" + cubeCounter;*/
    }
}
