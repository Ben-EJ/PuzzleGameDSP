using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDetector : MonoBehaviour
{
    private bool cubeInSensor = false;
    private string cubeName = "";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cube2" || collision.gameObject.tag == "cube4" 
           || collision.gameObject.tag == "cube8" || collision.gameObject.tag == "cube16" ||
           collision.gameObject.tag == "cube32" || collision.gameObject.tag == "cube64" ||
           collision.gameObject.tag == "cube128" || collision.gameObject.tag == "cube256" ||
           collision.gameObject.tag == "cube512" || collision.gameObject.tag == "cube1024" ||
           collision.gameObject.tag == "cube2048")
        {
            cubeInSensor = true;
            cubeName = collision.gameObject.name;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "cube2" || collision.gameObject.tag == "cube4"
           || collision.gameObject.tag == "cube8" || collision.gameObject.tag == "cube16" ||
           collision.gameObject.tag == "cube32" || collision.gameObject.tag == "cube64" ||
           collision.gameObject.tag == "cube128" || collision.gameObject.tag == "cube256" ||
           collision.gameObject.tag == "cube512" || collision.gameObject.tag == "cube1024" ||
           collision.gameObject.tag == "cube2048")
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
    public void isCubeInSensorSet(bool set)
    {
        cubeInSensor = set;
    }
    public void setCubeName(string name)
    {
        cubeName = name;
    }
}
