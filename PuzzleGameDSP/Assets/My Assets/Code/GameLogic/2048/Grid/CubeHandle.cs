using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHandle : MonoBehaviour
{
    public static List<GameObject> populateSensorList(List<string> line)
    {
        List<GameObject> sensors = new List<GameObject>();
        for (int i = 0; i < line.Count; i++)
        {
            sensors.Add(GameObject.Find(line[i]));
        }
        return sensors;
    }

    public static bool move(List<GameObject> sensors)
    {
        bool moveMade = false;
        for (int i = 0; i < sensors.Count - 1; i++)
        {
            if (sensors[i].GetComponent<CubeDetector>().isCubeInSensor() == true && sensors[i + 1].GetComponent<CubeDetector>().isCubeInSensor() == false)
            {
                Vector3 newSensorLocation = GameObject.Find(sensors[i + 1].name).transform.position;
                Vector3 toMoveToActual = new Vector3(newSensorLocation.x, newSensorLocation.y + 0.02f, newSensorLocation.z);
                GameObject.Find(sensors[i].GetComponent<CubeDetector>().getCubeName()).transform.position = toMoveToActual;
                moveMade = true;
            }
        }
        return moveMade;
    }
}
