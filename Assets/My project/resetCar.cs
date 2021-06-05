using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetCar : MonoBehaviour
{
    float elapsedtime=0;
    CheckPoints checkpoints;
    Rigidbody rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb= GetComponent<Rigidbody>();
        checkpoints= GetComponent<CheckPoints>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(rb.velocity.magnitude<=1)
        {
            elapsedtime= elapsedtime + Time.deltaTime;
        }
        else
        {
            elapsedtime=0;
        }
        
        if(elapsedtime>5)
        {
            gameObject.transform.position=checkpoints.prevCheckPoint.transform.position;
        }
    }
}
