using UnityEngine;

public class BubbleDestroy : MonoBehaviour
{
    public float destroyHeight = 5f;

    void Update()
    {
        // Tracks the position 
        transform.Translate(Vector3.up * Time.deltaTime);

        // Destroy when reaching height
        if (transform.position.y >= destroyHeight)
        {
            Destroy(gameObject); //I wonder what this does! 
        }
    }
}