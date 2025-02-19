using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    //Declare all the stuff we need, esp Inntervals as it'll help us here.
    public GameObject bubblePrefab;
    public GameObject Make;
    public float spawnInterval = 1.0f;
    public float spawnHeight = -5f;
    private float timer = 0f;




    void Update()
    {
        timer += Time.deltaTime; // Once again, always set something to deltaTime. 
        if (timer >= spawnInterval)
        {
            SpawnBubble(); // Calls upon this when a certain time passes. So bubbles don't just flood out. 
            timer = 0f;
        }
    }

    void SpawnBubble()
    {
        // Spawn at a random X position
        Vector3 spawnPos = new Vector3(Random.Range(-2f, 2f), spawnHeight, 0);
        Instantiate(bubblePrefab, spawnPos, Quaternion.identity);
        //Grab the bubblePrefab and cause it to spawn. 
    }
}