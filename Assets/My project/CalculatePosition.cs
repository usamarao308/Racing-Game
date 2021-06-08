//using System.Diagnostics;
using System.Security.AccessControl;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CalculatePosition : MonoBehaviour
{

    struct playerPosition
    {
        public int position;
        public float time;

        public playerPosition(int p, float t)
        {
            position=p;
            time=t;
        }
    };

    CheckPoints checkpoints;
    static Dictionary< string, playerPosition> positions = new Dictionary< string, playerPosition >();

    public GameObject player;
    string name;

    // Start is called before the first frame update
    void Start()
    {
        name=player.name;

        if(positions.ContainsKey(name)==false)
        {
            positions.Add(name, new playerPosition(0,0));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(checkpoints == null)
        {
            checkpoints=GetComponent<CheckPoints>();
        }

        SetPosition(name, checkpoints.lap, checkpoints.checkpoint, checkpoints.timehit);

        if(name=="MyPlayer" || name=="MyPlayer")
        {
            string position=getPositions(name);
            Debug.Log(position);
        }
    }

    public static void SetPosition(string name, int lap, int checkpoint, float time)
    {
        int position =lap*500 + checkpoint;

        positions[name] = new playerPosition(position, time);

    }

    public static string getPositions(string name)
    {
        int index = 0;

        foreach(KeyValuePair<string,playerPosition> pos in positions.OrderByDescending(Key => Key.Value.position).ThenBy(Key=>Key.Value.time))
        {
            index++;
            if(pos.Key == name)
            {
                switch(index)
                {
                    case 1: return "First";
                    case 2: return "Second";
                    case 3: return "Third";
                }
            }
        }
        return "Unkonwn";
    }
    
}
