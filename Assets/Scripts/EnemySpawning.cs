using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameObject enemy;
    public int delay;
    private bool canSpawn = false;
    // Start is called before the first frame update
    void Start()
    {
        EnemySpawningDelay();
    }

    // Update is called once per frame
    void Update()
    {
        if (canSpawn)
            {
                Instantiate(enemy);
                canSpawn = false;
                EnemySpawningDelay();
            }
        
    }
     async void EnemySpawningDelay()
    {
        await Task.Delay(delay);
        canSpawn= true;
    }
}
