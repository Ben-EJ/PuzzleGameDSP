using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject cube2GameObj;
    public static int cubeCounter = 0;
    public static float spawnHeight = 0.01f;
    void Start()
    {
        int pos1rnd = 0;
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

        GameObject sensor = GameObject.Find(pos1);
        GameObject sensor2 = GameObject.Find(pos2);

        Vector3 objPos1 = sensor.transform.position;
        Vector3 objPos2 = sensor2.transform.position;

        Vector3 cubeSpawnPos1 = new Vector3(objPos1.x, objPos1.y + spawnHeight, objPos1.z);
        Vector3 cubeSpawnPos2 = new Vector3(objPos2.x, objPos2.y + spawnHeight, objPos2.z);
        
        Quaternion rotationOfCube = new Quaternion();
        rotationOfCube.x = 0;
        rotationOfCube.y = 180;
        rotationOfCube.z = 0;
        
        cubeCounter = cubeCounter + 1;
        string cube1Name = "cube" + cubeCounter;
        Instantiate(cube2GameObj, cubeSpawnPos1, rotationOfCube).name = cube1Name;

        cubeCounter = cubeCounter + 1;
        string cube2Name = "cube" + cubeCounter;
        Instantiate(cube2GameObj, cubeSpawnPos2, rotationOfCube).name = cube2Name;

        sensor.GetComponent<CubeDetector>().setCubeName(cube1Name);
        sensor2.GetComponent<CubeDetector>().setCubeName(cube2Name);

        sensor.GetComponent<CubeDetector>().isCubeInSensorSet(true);
        sensor2.GetComponent<CubeDetector>().isCubeInSensorSet(true);

        sensor.GetComponent<CubeDetector>().setCubeValue(2);
        sensor2.GetComponent<CubeDetector>().setCubeValue(2);
    }
}
