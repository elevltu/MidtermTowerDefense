using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.position = new Vector3(transform.position.x, transform.position.y, -1);
        GetComponent<Renderer>().material.color = new Color(UnityEngine.Random.Range(0, 100f), UnityEngine.Random.Range(0, 100f), UnityEngine.Random.Range(0, 100f), 1);
    }
    
    // Update is called once per frame
    void Update()
    {
        rb.AddRelativeForce(new Vector2(0,10));
    }
    
}
