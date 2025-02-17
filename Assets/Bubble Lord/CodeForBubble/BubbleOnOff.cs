using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleOnOff : MonoBehaviour
{
    // Spawning settings
    public GameObject bubblePrefab; // Assign your bubble prefab in the Inspector
    public bool bubbleSpawning = false; // Toggle spawning with a button
    public float spawnTime = 1.0f; // Time between spawns
    public float spawnHeight = -5f; // Y position where bubbles spawn
    private float spawnRate = 0f;

    // Bubble movement settings
    public float floatSpeed = 1.0f; // Speed at which bubbles move upward
    public float swirlSpeed = 1.0f; // Speed at which bubbles sway side-to-side
    public float directionChange = 1.0f; // Time between direction changes for swaying
    private float timeCounter = 0f;
    private float currentSwirlDirection = 1f;

    void Update()
    {
        // Handle bubble spawning
        if (bubbleSpawning)
        {
            spawnRate += Time.deltaTime;
            if (spawnRate >= spawnTime)
            {
                SpawnBubble();
                spawnRate = 0f;
            }
        }
    }

    void SpawnBubble()
    {
        // Random X position within a range
        float randomX = UnityEngine.Random.Range(-2f, 2f);

        // Spawn position (random X, fixed Y, and Z = 0)
        Vector3 spawnPosition = new Vector3(randomX, spawnHeight, 0);

        // Instantiate the bubble at the spawn position
        GameObject bubble = Instantiate(bubblePrefab, spawnPosition, Quaternion.identity);

        // Add the BubbleMovement script to the spawned bubble
        bubble.AddComponent<BubbleMovement>().Initialize(floatSpeed, swirlSpeed, directionChange);
    }

    public void ToggleSpawnBubbles()
    {
        // Toggle the spawning state
        bubbleSpawning = !bubbleSpawning;
    }
}

// Script to handle bubble movement
public class BubbleMovement : MonoBehaviour
{
    private float floatSpeed; // Speed at which the bubble moves upward
    private float swirlSpeed; // Speed at which the bubble sways side-to-side
    private float directionChange; // Time between direction changes for swaying
    private float timeCounter = 0f;
    private float currentSwirlDirection = 1f;

    public void Initialize(float floatSpd, float swirlSpd, float dirChange)
    {
        floatSpeed = floatSpd;
        swirlSpeed = swirlSpd;
        directionChange = dirChange;
    }

    void Update()
    {
        // Handle bubble movement
        timeCounter += Time.deltaTime;

        if (timeCounter > directionChange)
        {
            currentSwirlDirection = -currentSwirlDirection; // Reverse sway direction
            timeCounter = 0f;
        }

        // Calculate movement
        float horizontalMovement = currentSwirlDirection * swirlSpeed * Time.deltaTime;
        float verticalMovement = floatSpeed * Time.deltaTime;

        // Apply movement
        transform.position += new Vector3(horizontalMovement, verticalMovement, 0);
    }
}