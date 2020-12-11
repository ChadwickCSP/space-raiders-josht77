using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public EnemyController enemyShip;
    public float speed;
    public float maxX, minX;
    public float maxY, minY;
    public GameObject respawnedPlayerShip;
    public EnemyController enemyLaser;

    // The laser gameobject to clone when firing
    public GameObject laser;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        handleFire();
    }

    private void handleFire()
    {
        // allows the player to use space bar to fire the laser
        bool isFiring = Input.GetKeyDown(KeyCode.Space);

        if(isFiring)
        {
            print("Fire!");
            GameObject newLaser = UnityEngine.Object.Instantiate(laser);
            float x, y;
            x = transform.position.x;
            y = transform.position.y + 0.5f;
            newLaser.transform.position = new Vector2(x, y);

            LaserController laserController = newLaser.GetComponent<LaserController>();
            laserController.speed = 7;
            // creates the object which is a laser allowing the ship to fire it
        }
    }
    void movePlayer()
    {
        float playerInput = Input.GetAxis("Horizontal");
        float playerYInput = Input.GetAxis("Vertical");

        // allows for the player to control the movement of the ship with wasd
        transform.Translate(Vector3.right * speed * Time.deltaTime * playerInput);
        transform.Translate(Vector3.up * speed * Time.deltaTime * playerYInput);

        // variables
        float x = transform.position.x;
        float y = transform.position.y;

        // if the ship is past the minimum x value, it will print out "Beyond left side"
        if(x < minX)
        {
            // will not allow the ship to move past the minX value
            print("Beyond left side!");
            transform.position = new Vector3(minX, y);
        }

        if(x > maxX)
        {
            // will not allow the ship to move past the maxX value
            print("Beyond right side!");
            transform.position = new Vector3(maxX, y);
        }

        if(y < minY)
        {
            print("Beyond bottom");
            transform.position = new Vector3(x, minY);
        }

        if(y > maxY)
        {
            print("Beyond top");
            transform.position = new Vector3(x, maxY);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(enemyShip || enemyLaser != null)
        {
            print("Destroy");
            UnityEngine.Object.Destroy(this.gameObject);

            Spawner playerSpawner = respawnedPlayerShip.GetComponent<Spawner>();

            playerSpawner.isDead = true;

            playerSpawner.respawnTime = Time.time + 2;
        }
    }
}
