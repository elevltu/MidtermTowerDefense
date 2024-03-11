using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        for (int i = 0; i < GlobalStuff.towers.Length; i++) { 
            if (GlobalStuff.towers[i].name == gameObject.name) { // i could probably just check the game objects but im not confident that would work and im tired
                GlobalStuff.currentSelection = i;
                GlobalStuff.towerIsSelected = true;
            }
        }
    }
}
