using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GlobalStuff : MonoBehaviour
{
    public static int currentSelection;
    public static GameObject[] towers = { };
    public static int health;
    public static bool towerIsSelected;
    public GameObject a;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        towers.Append(a);
        currentSelection = 0;
        print(towers.Length);
        towerIsSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnMouseUp()
    {
        currentSelection = 0;
        towerIsSelected = false;
    }*/
}
