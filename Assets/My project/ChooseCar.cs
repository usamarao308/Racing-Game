using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCar : MonoBehaviour
{

    public GameObject[] cars;

    static int index=0;


    void Start()
    {
        
    }

    public void nextCar()
    {
        index =index+1;

        if(index==0)
        {
            foreach (GameObject car  in cars)
            {
                car.SetActive(false);
            }
            cars[0].SetActive(true);
            Options.setCar("car1");
        }
        else if(index==1)
        {
            foreach (GameObject car  in cars)
            {
                car.SetActive(false);
            }
            cars[1].SetActive(true);
            Options.setCar("car2");
        }
        else if(index==2)
        {
            foreach (GameObject car  in cars)
            {
                car.SetActive(false);
            }
            cars[2].SetActive(true);
            Options.setCar("car3");
        }
       /* else if(index==3)
        {
            foreach (GameObject car  in cars)
            {
                car.SetActive(false);
            }
            cars[3].SetActive(true);
        }*/
        else
        {
            index=2;
        }
    }

    public void previousCar()
    {
                index =index-1;

        if(index==0)
        {
            foreach (GameObject car  in cars)
            {
                car.SetActive(false);
            }
            cars[0].SetActive(true);
             Options.setCar("car1");
        }
        else if(index==1)
        {
            foreach (GameObject car  in cars)
            {
                car.SetActive(false);
            }
            cars[1].SetActive(true);
             Options.setCar("car2");
        }
        else if(index==2)
        {
            foreach (GameObject car  in cars)
            {
                car.SetActive(false);
            }
            cars[2].SetActive(true);
            Options.setCar("car3");
        }
      /*  else if(index==3)
        {
            foreach (GameObject car  in cars)
            {
                car.SetActive(false);
            }
            cars[3].SetActive(true);
        }*/
        else
        {
            index=0;
        }
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }
}
