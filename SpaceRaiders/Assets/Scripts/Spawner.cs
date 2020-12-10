using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject toSpawn;

    public float respawnTime;

    public bool isDead = false;

    public Vector2 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = Time.time;

        if(isDead && respawnTime < currentTime)
        {
            print("Spawned Player!");

            GameObject respawnedPlayerShip = UnityEngine.Object.Instantiate(toSpawn);

            transform.Translate(startPosition);

            PlayerController playerController = respawnedPlayerShip.GetComponent<PlayerController>();
            playerController.speed = -10;
            playerController.minX = -8.5f;
            playerController.maxX = 8.5f;
            playerController.minY = -5.2f;
            playerController.maxY = -5.2f;

            isDead = true;
        }
    }
}
