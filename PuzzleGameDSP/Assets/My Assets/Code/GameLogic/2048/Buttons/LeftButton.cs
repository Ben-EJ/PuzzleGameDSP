using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
    private bool buttonPressed = false;
    private bool needToMoveRowA = false;
    private bool needToMoveRowB = false;
    private bool needToMoveRowC = false;
    private bool needToMoveRowD = false;

    private bool needToMergeRowA = false;
    private bool needToMergeRowB = false;
    private bool needToMergeRowC = false;
    private bool needToMergeRowD = false;

    public List<GameObject> reverseGameObjects(List<GameObject> list)
    {
        list.Reverse();
        return list;
    }

    public void Update()
    {
        Grid grid = new Grid();
        List<GameObject> sensorsRowA = CubeHandle.populateSensorList(grid.gridLineLeftOne);
        List<GameObject> sensorsRowB = CubeHandle.populateSensorList(grid.gridLineLeftTwo);
        List<GameObject> sensorsRowC = CubeHandle.populateSensorList(grid.gridLineLeftThree);
        List<GameObject> sensorsRowD = CubeHandle.populateSensorList(grid.gridLineLeftFour);

        if (Input.GetKeyDown(KeyCode.A))//For Testing
        {
            Debug.Log("APressed");
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
            buttonPressed = true;
            needToMoveRowA = true;
            needToMoveRowB = true;
            needToMoveRowC = true;
            needToMoveRowD = true;
        }
    }
}
