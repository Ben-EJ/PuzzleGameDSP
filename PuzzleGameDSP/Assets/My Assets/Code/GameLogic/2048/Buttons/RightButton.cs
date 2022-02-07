using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour
{
    private bool buttonPressed = false;
    private bool needToMoveRowA = false;
    private bool needToMoveRowB = false;
    private bool needToMoveRowC = false;
    private bool needToMoveRowD = false;

    public void Update()
    {
        Grid grid = new Grid();
        List<GameObject> sensorsRowA = CubeHandle.populateSensorList(grid.gridLineRightOne);
        List<GameObject> sensorsRowB = CubeHandle.populateSensorList(grid.gridLineRightTwo);
        List<GameObject> sensorsRowC = CubeHandle.populateSensorList(grid.gridLineRightThree);
        List<GameObject> sensorsRowD = CubeHandle.populateSensorList(grid.gridLineRightFour);
        List<GameObject> allSensors = CubeHandle.populateSensorList(grid.gridWhole);

        if (Input.GetKeyDown(KeyCode.D) || buttonPressed == true )//For Testing
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
