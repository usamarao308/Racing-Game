using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CheckPoints : MonoBehaviour
{
    [HideInInspector]
    public int lap=0;
    [HideInInspector]
    public int checkpoint= -1;
    int checkPointCount;

    int nextCheckPoint=0;

    Dictionary<int, bool> visited=new Dictionary<int, bool>();
    public Text lapText;
    
    [HideInInspector]
    public bool missed= false;

    public GameObject prevCheckPoint;

    public float timehit;



    void Start()
    {

        GameObject[] checkpoints = GameObject.FindGameObjectsWithTag("checkpoint");

        checkPointCount= checkpoints.Length;

        foreach (GameObject checkpoint in checkpoints)
        {
            if(checkpoint.name == "0")
            {
            prevCheckPoint= checkpoint;
            break;
            }
        }

        foreach(GameObject cp in checkpoints)
        {
            visited.Add(Int32.Parse(cp.name), false);
        }
        
    }

    void OnTriggerEnter(Collider col) 
    {
        if(col.gameObject.tag == "checkpoint")
        {
            int checkpointCurrent= int.Parse(col.gameObject.name);

            if(checkpointCurrent == nextCheckPoint)
            {
                timehit=Time.time;

                prevCheckPoint=col.gameObject;

                visited[checkpointCurrent]= true;

                checkpoint= checkpointCurrent;

                 if(checkpoint == 0)
                 {
                     lap++;
                 }

               if(checkpoint == 0 && gameObject.tag=="Player") 
                {
                   // lap++;
                    lapText.text= "Lap : " + lap;
                }

                nextCheckPoint++;

                if(nextCheckPoint >= checkPointCount)
                {
                    var keys = new List<int>(visited.Keys);

                    foreach(int key in keys)
                    {
                        visited[key]=false;
                    }

                    nextCheckPoint=0;
                }
            }
            else if(checkpointCurrent != nextCheckPoint && visited[checkpointCurrent] == false)
            {
                missed=true;

            }
        }
        
    }

}
