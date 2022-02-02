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
    void Start()
    {
        int pos1rnd = 0;
        int pos2rnd = 0;

        string pos1;
        string pos2;
        System.Random rnd = new System.Random();

        pos1rnd = rnd.Next(0, 16);
        pos2rnd = rnd.Next(0, 16);

        Debug.Log("pos1rnd: " + pos1rnd);
        Debug.Log("pos2rnd: " + pos2rnd);

        while (pos1rnd == pos2rnd)
        {
            pos2rnd = rnd.Next(0, 16);
        }

        pos1 = Grid.gridWhole[pos1rnd];
        pos2 = Grid.gridWhole[pos2rnd];

        Debug.Log("pos1: " + pos1);
        Debug.Log("pos2: " + pos2);

        Vector3 objPos1 = GameObject.Find(pos1).transform.position;
        Vector3 objPos2 = GameObject.Find(pos2).transform.position;
        Debug.Log("objPos1: " + objPos1);
        Debug.Log("objPos2: " + objPos2);

        Vector3 cubeSpawnPos1 = new Vector3(objPos1.x, objPos1.y + 0.05f, objPos1.z);
        Vector3 cubeSpawnPos2 = new Vector3(objPos2.x, objPos2.y + 0.05f, objPos2.z);
        Debug.Log("cubeSpawnPos1: " + cubeSpawnPos1);
        Debug.Log("cubeSpawnPos2: " + cubeSpawnPos2);

        Instantiate(cube2GameObj, cubeSpawnPos1, Quaternion.identity);
        Instantiate(cube2GameObj, cubeSpawnPos2, Quaternion.identity);
    }
}
