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

        if (Input.GetKeyDown(KeyCode.D))//For Testing
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
