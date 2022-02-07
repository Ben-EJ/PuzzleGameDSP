using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
    private bool buttonPressed = false;

    public List<GameObject> reverseGameObjects(List<GameObject> list)
    {
        list.Reverse();
        return list;
    }

    public void Update()
    {
        Grid grid = new Grid();
        List<GameObject> sensorsRowALeft = CubeHandle.populateSensorList(grid.gridLineLeftOne);
        List<GameObject> sensorsRowBLeft = CubeHandle.populateSensorList(grid.gridLineLeftTwo);
        List<GameObject> sensorsRowCLeft = CubeHandle.populateSensorList(grid.gridLineLeftThree);
        List<GameObject> sensorsRowDLeft = CubeHandle.populateSensorList(grid.gridLineLeftFour);

        List<GameObject> sensorsRowARight = CubeHandle.populateSensorList(grid.gridLineRightOne);
        List<GameObject> sensorsRowBRight = CubeHandle.populateSensorList(grid.gridLineRightTwo);
        List<GameObject> sensorsRowCRight = CubeHandle.populateSensorList(grid.gridLineRightThree);
        List<GameObject> sensorsRowDRight = CubeHandle.populateSensorList(grid.gridLineRightFour);

        List<GameObject> sensorsRowAUp = CubeHandle.populateSensorList(grid.gridLineUpOne);
        List<GameObject> sensorsRowBUp = CubeHandle.populateSensorList(grid.gridLineUpTwo);
        List<GameObject> sensorsRowCUp = CubeHandle.populateSensorList(grid.gridLineUpThree);
        List<GameObject> sensorsRowDUp = CubeHandle.populateSensorList(grid.gridLineUpFour);

        List<GameObject> sensorsRowADown = CubeHandle.populateSensorList(grid.gridLineDownOne);
        List<GameObject> sensorsRowBDown = CubeHandle.populateSensorList(grid.gridLineDownTwo);
        List<GameObject> sensorsRowCDown = CubeHandle.populateSensorList(grid.gridLineDownThree);
        List<GameObject> sensorsRowDDown = CubeHandle.populateSensorList(grid.gridLineDownFour);

        List<GameObject> allSensors = CubeHandle.populateSensorList(grid.gridWhole);

        if (Input.GetKeyDown(KeyCode.A) || buttonPressed == true)//For Testing
        {
            bool canMoveLeftA = CubeHandle.cubeMoveMerge(sensorsRowALeft, true);
            bool canMoveLeftB = CubeHandle.cubeMoveMerge(sensorsRowBLeft, true);
            bool canMoveLeftC = CubeHandle.cubeMoveMerge(sensorsRowCLeft, true);
            bool canMoveLeftD = CubeHandle.cubeMoveMerge(sensorsRowDLeft, true);

            bool canMoveRightA = CubeHandle.cubeMoveMerge(sensorsRowARight, false);
            bool canMoveRightB = CubeHandle.cubeMoveMerge(sensorsRowBRight, false);
            bool canMoveRightC = CubeHandle.cubeMoveMerge(sensorsRowCRight, false);
            bool canMoveRightD = CubeHandle.cubeMoveMerge(sensorsRowDRight, false);

            bool canMoveUpA = CubeHandle.cubeMoveMerge(sensorsRowAUp, false);
            bool canMoveUpB = CubeHandle.cubeMoveMerge(sensorsRowBUp, false);
            bool canMoveUpC = CubeHandle.cubeMoveMerge(sensorsRowCUp, false);
            bool canMoveUpD = CubeHandle.cubeMoveMerge(sensorsRowDUp, false);

            bool canMoveDownA = CubeHandle.cubeMoveMerge(sensorsRowADown, false);
            bool canMoveDownB = CubeHandle.cubeMoveMerge(sensorsRowBDown, false);
            bool canMoveDownC = CubeHandle.cubeMoveMerge(sensorsRowCDown, false);
            bool canMoveDownD = CubeHandle.cubeMoveMerge(sensorsRowDDown, false);

            if (canMoveLeftA == true && canMoveLeftB == true && canMoveLeftC == true && canMoveLeftD == true &&
                canMoveRightA == true && canMoveRightB == true && canMoveRightC == true && canMoveRightD == true &&
                canMoveUpA == true && canMoveUpB == true && canMoveUpC == true && canMoveUpD == true &&
                canMoveDownA == true && canMoveDownB == true && canMoveDownC == true && canMoveDownD == true)
            {
                GameState.playerLost = true;
            }
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
