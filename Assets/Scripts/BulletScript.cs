using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Mathematics;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.position = new Vector3(rb.position.x, rb.position.y, -1);
       //rb.position = new Vector3(-rb.position.x, -rb.position.y, -0.4f);
        rb.AddRelativeForce(new Vector2(0, 1000));
        DestroyAfterTime();
        
    }
    
    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }
    }
    
    async void DestroyAfterTime()
    {
        await Task.Delay(1000);
        Destroy(gameObject);
    }
}
