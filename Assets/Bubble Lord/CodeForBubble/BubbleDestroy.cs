using UnityEngine;

public class BubbleDestroy : MonoBehaviour
{
    public float floatSpeed = 1.0f; 
    public float destroyHeight = 20f; 

    void Update()
    {
        transform.position += new Vector3(0, floatSpeed * Time.deltaTime, 0);

        if (transform.position.y >= destroyHeight)
        {
            Destroy(gameObject); 
        }
    }
}