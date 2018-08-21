using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    [SerializeField] List<Waypoint> path;        //an array is fixed 'Block[]', while a list is variable 'List<Block>'.

	// Use this for initialization
	void Start ()
    {
        PrintAllWaypoints();
	}

    private void PrintAllWaypoints()
    {
        foreach(Waypoint waypoint in path)
        {
            print(waypoint.name);       
        }
    }

}
