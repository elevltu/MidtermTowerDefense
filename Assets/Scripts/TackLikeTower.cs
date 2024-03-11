using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class TackLikeTower : MonoBehaviour
{
    private Rigidbody2D rb;
    public int cooldown; //make private later probably
    private bool isOnCooldown;
    public GameObject bullet;
    private int numOfBullets;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isOnCooldown = false;
        numOfBullets = 4;
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
    private async void Shoot()
    {
        if (!isOnCooldown)
        {
            isOnCooldown = true;
            for (float i = 0f; i < numOfBullets; i++)
            {
                Instantiate(bullet, rb.position, Quaternion.Euler(new Vector3(0, 0, i * 360 / numOfBullets)));
            }
            await Task.Delay(cooldown);
            isOnCooldown=false;
        }
    }
}
