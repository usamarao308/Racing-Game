using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiScript : MonoBehaviour
{
    GameObject Player;
    public GameObject missedcheckpointText;
    public GameObject positionText;

    public GameObject pauseGameMenu;


    public GameObject lapText;

   // public Text finalpostext;

    CheckPoints Checkpoint;

    void Start()
    {
        Player= GameObject.FindGameObjectWithTag("Player");
        
    }
    void Update()
    {

      /*  if(Checkpoint.checkpoint == 0 ) 
        {
                   // lap++;
                   // lapText.text= "Lap : " + lap;
                   lapText.GetComponent<Text>().text="Lap: " + Checkpoint.lap;


        }*/

        positionText.GetComponent<Text>().text="Position : " + CalculatePosition.getPositions(Player.name);
        if(Player.GetComponent<CheckPoints>().missed== true)
        {
            StartCoroutine( showMissedCheckPointText() );
            Player.GetComponent<CheckPoints>().missed=false;

        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseGameMenu.SetActive(true);
            Time.timeScale=0;
        }
        
    }

    IEnumerator showMissedCheckPointText()
    {
        missedcheckpointText.SetActive(true);
        yield return new WaitForSeconds(2);
        missedcheckpointText.SetActive(false);

    }

    public void resumeGame()
    {
        Time.timeScale=1;
        pauseGameMenu.SetActive(false);
    }

   /* public void showfinalpos()
    {
        finalpostext.text="Position : " +CalculatePosition.getPositions(Player.name);

    }*/
}
