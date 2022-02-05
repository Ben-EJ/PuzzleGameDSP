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

        if (Input.GetKeyDown(KeyCode.W))//For Testing
        {
            CubeHandle.cubeMoveMerge(sensorsRowA, false);
            CubeHandle.cubeMoveMerge(sensorsRowB, false);
            CubeHandle.cubeMoveMerge(sensorsRowC, false);
            CubeHandle.cubeMoveMerge(sensorsRowD, false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Controller")
        {
           
        }
    }
}
