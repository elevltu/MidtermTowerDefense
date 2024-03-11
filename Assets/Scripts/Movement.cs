using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2[] locations = {
        new Vector2(-8.8f, -3.33f), 
        new Vector2(.22f, -3.33f), 
        new Vector2(.22f, 2.09f),
        new Vector2(-3.05f, 2.09f),
        new Vector2(-3.05f, -0.71f),
        new Vector2(-5.84f, -0.71f),
        new Vector2(-5.84f, 4.06f),
        new Vector2(3.34f, 4.06f),
        new Vector2(3.34f, -10f)
    };
    private int speed = 3;
    private int nodeNumber = 0;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        gameObject.tag = "Enemy";
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 node = locations[nodeNumber];
        Vector2 movementDirection = node - rb.position;
        movementDirection.Normalize();
        movementDirection *= (speed * Time.deltaTime);
        rb.position += movementDirection;
        if(Mathf.Floor(rb.position.x*10)/10 == Mathf.Floor(node.x*10)/10 && Mathf.Floor(rb.position.y * 10) / 10 == Mathf.Floor(node.y * 10) / 10)
        {
            nodeNumber++;
            if (nodeNumber >= 9)
            {
                GlobalStuff.health -= 1;
                DestroyObject(gameObject);
            }
        }
    }
}
