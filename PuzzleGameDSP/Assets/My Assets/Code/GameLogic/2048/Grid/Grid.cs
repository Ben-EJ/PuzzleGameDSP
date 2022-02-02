using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public static List<string> gridWhole = new List<string>() { "location1", "location2", "location3", "location4", "location5", "location6",
    "location7", "location8", "location9","location10", "location11", "location12","location13", "location14", "location15","location16"};

    public static List<string> gridLineUpOne = new List<string>();
    public static List<string> gridLineUpTwo = new List<string>();
    public static List<string> gridLineUpThree = new List<string>();
    public static List<string> gridLineUpFour = new List<string>();

    public static List<string> gridLineDownOne = new List<string>();
    public static List<string> gridLineDownTwo = new List<string>();
    public static List<string> gridLineDownThree = new List<string>();
    public static List<string> gridLineDownFour = new List<string>();

    public static List<string> gridLineLeftOne = new List<string>();
    public static List<string> gridLineLeftTwo = new List<string>();
    public static List<string> gridLineLeftThree = new List<string>();
    public static List<string> gridLineLeftFour = new List<string>();

    public static List<string> gridLineRightOne = new List<string>();
    public static List<string> gridLineRightTwo = new List<string>();
    public static List<string> gridLineRightThree = new List<string>();
    public static List<string> gridLineRightFour = new List<string>();

    public List<string> gridLineReverce(List<string> List)
    {
        List.Reverse();
        return List;
    }

    public Grid()
    {
        gridLineDownOne = gridLineReverce(gridLineUpOne);
        gridLineDownTwo = gridLineReverce(gridLineUpTwo);
        gridLineDownThree = gridLineReverce(gridLineUpThree);
        gridLineDownFour = gridLineReverce(gridLineUpFour);

        gridLineRightOne = gridLineReverce(gridLineLeftOne);
        gridLineRightTwo = gridLineReverce(gridLineLeftTwo);
        gridLineRightThree = gridLineReverce(gridLineLeftThree);
        gridLineRightFour = gridLineReverce(gridLineLeftFour);
    }
}
