using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Controls the speed of this enemy ship
    public float speedX, speedY;
    // Controls the bounds of the Y axis
    public float minY, maxY;
    // Controls the bounds of the X axis
    public float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemy();
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
            // Destroy both the enemy ship and the laser game obects
            UnityEngine.Object.Destroy(this.gameObject);
            UnityEngine.Object.Destroy(otherObject);
        }
    }
}
