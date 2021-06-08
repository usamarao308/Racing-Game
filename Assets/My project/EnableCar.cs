//using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCar : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject car1;
    public GameObject car2;
    public GameObject car3;


    void Awake() 
    {

        if(Options.getCar()=="car1")
        {
            car2.SetActive(false);
            car3.SetActive(false);
        }
        else if(Options.getCar()=="car2")
        {
            car1.SetActive(false);
            car3.SetActive(false);
        }
        else if(Options.getCar()=="car3")
        {
             car1.SetActive(false);
             car2.SetActive(false);

        }
        
    }
    
    void Start()
    {
        Invoke("EnableCalPos",1);
    }

    void EnableCalPos()
    {
        GameObject.Find(Options.getCar()).GetComponent<CalculatePosition>().enabled=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
