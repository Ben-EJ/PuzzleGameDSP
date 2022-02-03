using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDetector : MonoBehaviour
{
    private bool cubeInSensor = false;
    private string cubeName = "";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "numberCube")
        {
            cubeInSensor = true;
            cubeName = collision.gameObject.name;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "numberCube")
        {
            cubeInSensor = false;
            cubeName = "";
        }
    }

    public bool isCubeInSensor()
    {
        return cubeInSensor;
    }
    public string getCubeName()
    {
        return cubeName;
    }
}
