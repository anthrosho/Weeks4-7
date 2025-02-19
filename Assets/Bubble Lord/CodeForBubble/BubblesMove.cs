using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblesMove : MonoBehaviour
{
    public float floatSpeed = 1.0f;
    public float swirlSpeed = 1.0f;
    public float directionChange = 1.0f;
    public float previousSwirl;
    public float currentSwirl;

    private float timeCounter = 0f; 

    void Start()
    {
        currentSwirl = 1f; 
        
    }

    void Update()
    {
        //Swirl logic! We take previous and make it equal to current and then - that.
        timeCounter += Time.deltaTime; // make Time = to delta time for tracking. 
        if (timeCounter > directionChange)

        {
            previousSwirl = currentSwirl;
            currentSwirl = -currentSwirl;
            timeCounter = 0f;
        }
        //SWIRLLLLLLLLLLL 
        float UpDownMovement = currentSwirl * swirlSpeed * Time.deltaTime;
        float SideWayMovement = floatSpeed * Time.deltaTime;

        transform.position += new Vector3(UpDownMovement, SideWayMovement, 0);
            //Using Vector3 functions to update transform position.
    }
}
