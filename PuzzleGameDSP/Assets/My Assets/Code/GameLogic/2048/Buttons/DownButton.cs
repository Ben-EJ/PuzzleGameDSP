using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownButton : MonoBehaviour
{
    private bool buttonPressed = false;
    private bool needToMoveRowA = false;
    private bool needToMoveRowB = false;
    private bool needToMoveRowC = false;
    private bool needToMoveRowD = false;

    public void Update()
    {
        Grid grid = new Grid();
        
        List<GameObject> sensorsRowA = CubeHandle.populateSensorList(grid.gridLineDownOne);
        List<GameObject> sensorsRowB = CubeHandle.populateSensorList(grid.gridLineDownTwo);
        List<GameObject> sensorsRowC = CubeHandle.populateSensorList(grid.gridLineDownThree);
        List<GameObject> sensorsRowD = CubeHandle.populateSensorList(grid.gridLineDownFour);
        List<GameObject> allSensors = CubeHandle.populateSensorList(grid.gridWhole);

        if (Input.GetKeyDown(KeyCode.S) || buttonPressed == true)//For Testing
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
