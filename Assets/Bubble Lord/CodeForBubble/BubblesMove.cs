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

    // Start is called before the first frame update
    void Start()
    {
        currentSwirl = 1f; 
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        if (timeCounter > directionChange)

        {
            previousSwirl = currentSwirl;
            currentSwirl = -currentSwirl;
            timeCounter = 0f;
        }

        float UpDownMovement = currentSwirl * swirlSpeed * Time.deltaTime;
        float SideWayMovement = floatSpeed * Time.deltaTime;

        transform.position += new Vector3(UpDownMovement, SideWayMovement, 0);
            
    }
}
