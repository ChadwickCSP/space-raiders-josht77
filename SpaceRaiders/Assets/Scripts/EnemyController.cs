using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public EnemyController laser;
    // controls firerate
    public float fireRate;
    // controls the time of the last shot
    public float lastShot;
    // controls laser speed
    public float laserSpeed;
    // Controls the speed of this enemy ship
    public float speedX, speedY;
    // Controls the bounds of the Y axis
    public float minY, maxY;
    // Controls the bounds of the X axis
    public float minX, maxX;
    // controls hull strength
    public float hullStrength;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // will update the two different voids
        moveEnemy();

        checkFireLaser();
    }

    void moveEnemy()
    {
        // Updates my enemys position on the screen
        transform.Translate(new Vector2(speedX, speedY) * Time.deltaTime);

        float x = transform.position.x;
        float y = transform.position.y;

        // Checks if the ship is out of bounds, if it is it destroys itself
        if ( x < minX || x > maxX || y < minY || y > maxY )
        {
            UnityEngine.Object.Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // This is the object that collided with the Enemy!
        GameObject otherObject = collision.gameObject;

        // Returns a LaserController if the otheObject contains one otherwise
        // returns null
        LaserController laserController = otherObject.GetComponent<LaserController>();

        // If the otherObject has a LaserController, that means our EnemyShip should be destroyed
        if ( laserController != null)
        {
            // print the statement hit if the ship is hit
            print ("hit");
            this.hullStrength -= laserController.damage;
            // Destroy both the enemy ship and the laser game obects
            UnityEngine.Object.Destroy(otherObject);
        // if the hull strenght is less than 1, then the ship will be destroyed
            if (hullStrength < 1)
            {
                // play the "EnemyDeath" sound clip if the enemy ship is destroyed
                SoundManagerScript.PlaySound ("EnemyDeath");
                // print dead if the enemy ship is destroyed
                print ("dead");
                UnityEngine.Object.Destroy(this.gameObject);
            }
        }
    }

    void checkFireLaser()
    {
        // the next shot from the enemy is the fire rate + the last shot
        float nextShot = fireRate + lastShot;

        float currentTime = Time.time;

        if (laser != null && nextShot < currentTime)
        {
            // play the "EnemyLaser" sound script when the enemy fires a laser
            SoundManagerScript.PlaySound ("EnemyLaser");
            
            EnemyController enemyLaser = UnityEngine.Object.Instantiate(laser);

            float x, y;

            x = transform.position.x;
            // the laser will fire just below the ship to make it look like it is coming out of it
            y = transform.position.y - 0.5f;
            // the enemy laser position is transformed to wherever the enemy ship is
            enemyLaser.transform.position = new Vector2(x, y);

            lastShot = currentTime;
            // the speed the laser will travel
            enemyLaser.speedY = 6;
        }
    }
}
