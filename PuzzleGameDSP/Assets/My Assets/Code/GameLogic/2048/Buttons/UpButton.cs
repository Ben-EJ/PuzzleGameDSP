using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButton : MonoBehaviour
{
    private bool buttonPressed = false;
    private bool needToMoveRowA = false;
    private bool needToMoveRowB = false;
    private bool needToMoveRowC = false;
    private bool needToMoveRowD = false;

    public void Update()
    {
        Grid grid = new Grid();
        List<GameObject> sensorsRowA = CubeHandle.populateSensorList(grid.gridLineUpOne);
        List<GameObject> sensorsRowB = CubeHandle.populateSensorList(grid.gridLineUpTwo);
        List<GameObject> sensorsRowC = CubeHandle.populateSensorList(grid.gridLineUpThree);
        List<GameObject> sensorsRowD = CubeHandle.populateSensorList(grid.gridLineUpFour);
        List<GameObject> allSensors = CubeHandle.populateSensorList(grid.gridWhole);
        if (Input.GetKeyDown(KeyCode.W) || buttonPressed == true)//For Testing
        {
            CubeHandle.cubeMoveMerge(sensorsRowA, true);
            CubeHandle.cubeMoveMerge(sensorsRowB, true);
            CubeHandle.cubeMoveMerge(sensorsRowC, true);
            CubeHandle.cubeMoveMerge(sensorsRowD, true);
            CubeHandle.spawnRandomCube(allSensors);
            buttonPressed = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Controller")
        {
            buttonPressed = true;
        }
    }
}
