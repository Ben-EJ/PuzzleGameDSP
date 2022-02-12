using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePopulate : MonoBehaviour
{
    public static List<string> cubeTypes = new List<string>() {"cube2", "cube4", "cube8", "cube16",
        "cube32", "cube64", "cube128", "cube256","cube512", "cube1024", "cube2048"};

    public static List<GameObject> cubeList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cubeTypes.Count; i++)
        {
            cubeList.Add(GameObject.FindGameObjectWithTag(cubeTypes[i]));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
