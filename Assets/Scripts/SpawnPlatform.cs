using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    private bool mouseIsIn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUp()
    {
        if (GlobalStuff.towers[GlobalStuff.currentSelection] != null && mouseIsIn)
        {
            Instantiate(GlobalStuff.towers[GlobalStuff.currentSelection]);
            mouseIsIn= false;

        }
        GlobalStuff.currentSelection = 0;
        GlobalStuff.towerIsSelected = false;
    }
    private void OnMouseEnter()
    {
        mouseIsIn = true;
        print("a");
    }
    private void OnMouseExit()
    {
        mouseIsIn = false;
    }
}
