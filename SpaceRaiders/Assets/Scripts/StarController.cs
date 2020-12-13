using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{

    public float speed;
    public float minX, maxX;
    public float minY, maxY;

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
        transform.Translate(Vector2.down * Time.deltaTime * speed);

        float x = transform.position.x;
        float y = transform.position.y;

        if (x < minX || x > maxX || y < minY || y > maxY)
        {
            UnityEngine.Object.Destroy(this.gameObject);
        }
    }
}
