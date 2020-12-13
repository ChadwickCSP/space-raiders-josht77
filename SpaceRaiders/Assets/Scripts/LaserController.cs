using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    // specifies how fast the laser moves
    public float speed;
    // specifies how far off the screen the laser can be before it is destroyed
    public float maxY, minY;

    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Uses the speed and deltaTime to move the laser toward the top of the screen
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        float y = transform.position.y;

        // Checks if the y position is outside of the upper bound and if it is it destroys it
        if (y > maxY)
        {
            UnityEngine.Object.Destroy(this.gameObject);
        }
    }
}
