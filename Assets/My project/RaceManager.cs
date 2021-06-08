using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceManager : MonoBehaviour
{

    GameObject player;
    GameObject[] Ais;
    AudioSource[] audiosources;
    CheckPoints checkPoints;
   // public GameObject finishMenu;
    public int maxLaps=1;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        checkPoints=player.GetComponent<CheckPoints>();
        Ais=GameObject.FindGameObjectsWithTag("Ai");



        
    }
    // Update is called once per frame
    void Update()
    {
        if(checkPoints.lap > maxLaps)
        {
             if(player)
                {
            
            StopCar(player);
                }
        

        }

        foreach(GameObject ai in Ais)
        {
            if(ai.GetComponent<CheckPoints>().lap>maxLaps)
            {
                if(player)
                {
                StopCar(player);
                }
            }
        }
    }

    void StopCar(GameObject car)
    {
        car.GetComponent<CarController>().enabled=false;
        car.GetComponent<Rigidbody>().velocity=new Vector3(0,0,0);
        car.GetComponent<Rigidbody>().isKinematic=true;

        if(car.GetComponent<CarUserControl>() != null)
        {
            car.GetComponent<CarUserControl>().enabled=false;
        }

        if(car.GetComponent<CarAIControl>() != null)
        {
            car.GetComponent<CarAIControl>().enabled=false;
        }

        if(car.GetComponent<resetCar>() != null)
        {
            car.GetComponent<resetCar>().enabled=false;
        }

        audiosources=car.GetComponents<AudioSource>();
        foreach(AudioSource adSource in audiosources)
        {
            adSource.enabled=false;
        }

        /*if(car.tag=="Player")
        {
            finishMenu.SetActive(true);
            UiScript ui=new UiScript();
            ui.showfinalpos();

        }*/
    }
}
