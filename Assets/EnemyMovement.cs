using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    [SerializeField] List<Waypoint> path;        //an array is fixed 'Block[]', while a list is variable 'List<Block>'.

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(FollowPath());
        print("I'm back at start");    //does this after FollowPath & yield. But not before end patrol
        
	}

    IEnumerator FollowPath()                //a co-routine sits along site a regular routine. 
    {
        print("Start Pat");
        foreach(Waypoint waypoint in path)
        {
            transform.position = waypoint.transform.position;
            print("visiting: " + waypoint);
            yield return new WaitForSeconds(1f);     //"I will give-up for [a second]
        }
        print("End patrol");
    }
}



//coroutines have to do with invoke. InvokeRepeating will allow repeating for delta t, but doesn't work w/ loops.
