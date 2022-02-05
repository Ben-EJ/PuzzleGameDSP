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

        if (Input.GetKeyDown(KeyCode.S))//For Testing
        {
            CubeHandle.cubeMoveMerge(sensorsRowA, false);
            CubeHandle.cubeMoveMerge(sensorsRowB, false);
            CubeHandle.cubeMoveMerge(sensorsRowC, false);
            CubeHandle.cubeMoveMerge(sensorsRowD, false);
            CubeHandle.spawnRandomCube(allSensors);
        }

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Controller")
        {
            
        }
    }
}
