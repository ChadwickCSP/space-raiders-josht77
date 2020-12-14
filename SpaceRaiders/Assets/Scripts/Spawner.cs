using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // class of playercontroller to spawn
    public PlayerController toSpawn;
    // sets the respawnTime of the player
    public float respawnTime;
    // isdead is set equal to false
    public bool isDead = false;
    // the start position of the playership spawner
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
            // print spawned player when the playership spawns
            print("Spawned Player!");
            // creating the object to spawn
            PlayerController playerController = UnityEngine.Object.Instantiate(toSpawn);
            // the game object will be transformed to the position of the start position
            playerController.gameObject.transform.position = startPosition;
            // controlling the different bounds and speed
            playerController.speed = 10;
            playerController.minX = -8.5f;
            playerController.maxX = 8.5f;
            playerController.minY = -5.2f;
            playerController.maxY = 5.2f;
            // all of this code will happen if is dead is true
            isDead = false;
        }
    }
}
