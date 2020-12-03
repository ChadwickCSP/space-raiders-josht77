using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // The number of seconds between enemy spawns
    public float spawnRate;

    // the time at which the last spawn occurred
    public float lastSpawnTime;

    // This is the enemy to spawn
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        lastSpawnTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = Time.time;
        float elapsedTime = currentTime - lastSpawnTime;

        if (elapsedTime > spawnRate)
        {
            print("Spawn");

            // Create a new enemy instance and set its starting position
            GameObject newEnemy = UnityEngine.Object.Instantiate(enemy);
            newEnemy.transform.position = new Vector2(-10, 5);

            // Set the speed of the enemy
            EnemyController enemyController = newEnemy.GetComponent<EnemyController>();
            enemyController.speedX = 5;
            enemyController.speedY = -2;

            lastSpawnTime = currentTime;
        }
    }
}
