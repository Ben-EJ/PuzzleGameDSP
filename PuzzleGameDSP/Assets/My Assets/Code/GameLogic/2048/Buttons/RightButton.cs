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
            buttonPressed = true;
            needToMoveRowA = true;
            needToMoveRowB = true;
            needToMoveRowC = true;
            needToMoveRowD = true;
        }

        if (buttonPressed == true && needToMoveRowA == true)
        {
            needToMoveRowA = CubeHandle.move(sensorsRowA);
        }
        if (buttonPressed == true && needToMoveRowB == true)
        {
            needToMoveRowB = CubeHandle.move(sensorsRowB);
        }
        if (buttonPressed == true && needToMoveRowC == true)
        {
            needToMoveRowC = CubeHandle.move(sensorsRowC);
        }
        if (buttonPressed == true && needToMoveRowD == true)
        {
            needToMoveRowD = CubeHandle.move(sensorsRowD);
        }
        if (needToMoveRowA == false && needToMoveRowB == false && needToMoveRowC == false && needToMoveRowD == false)
        {
            buttonPressed = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Controller")
        {
            buttonPressed = true;
            needToMoveRowA = true;
            needToMoveRowB = true;
            needToMoveRowC = true;
            needToMoveRowD = true;
        }
    }
}
