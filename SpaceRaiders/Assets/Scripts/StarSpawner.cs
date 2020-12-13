using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    // The starting Y position of the background starts spawning
    public float startY;
    // Specifies the range of spawning locations for stars
    public float minX, maxX;
    // Specifies the min and max size of the stars to be spawned
    public float minScale, maxScale;
    // Specifies the min and max speed of the stars being spawned
    public float minSpeed, maxSpeed;
    // Specifies the rate at which stars spawn
    public double spawnRate;

    // The star to spawn
    public GameObject star;

    // The last time a star was spawned
    private float lastSpawn;

    // Start is called before the first frame update
    void Start()
    {
        lastSpawn = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        checkSpawn();
    }

    void checkSpawn()
    {
        // Get the current time
        float currentTime = Time.time;

        // Check how much time has passed since the last spawn
        float timeSinceLastSpawn = currentTime - lastSpawn;

        // If the time is greaterd than the spawnRate, spawn an enemy!
        if (timeSinceLastSpawn > spawnRate)
        {
            // Create a new star object
            GameObject newStar = UnityEngine.Object.Instantiate(star);
            float startX = Random.Range(minX, maxX);
            float scale = Random.Range(minScale, maxScale);

            // Set the stars starting position
            newStar.transform.position = new Vector3(startX, startY, 2);
            newStar.transform.localScale = new Vector2(scale, scale);
            // Get the StarController
            StarController starController = newStar.GetComponent<StarController>();

            // Set the enemy speed
            float speed = Random.Range(minSpeed, maxSpeed);
            starController.speed = speed;

            // Reset the timer!
            lastSpawn = currentTime;
        }
    }
}
