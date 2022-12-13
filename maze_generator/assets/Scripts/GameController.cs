using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MazeGenerator
{
    public GameObject Background;
    void Start()
    {
        Instantiate(Background, new Vector3(0, 0, 1), Quaternion.identity);

        GenerateMaze(mazeRows, mazeColumns);
        //Player.transform.Translate(Vector2.zero);
        // player -8.5  4.65
    }
}
