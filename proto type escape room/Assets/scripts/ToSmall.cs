using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToSmall : MonoBehaviour
{
    public bool onTrigger;


    public Transform doorHinge;

    private void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        onTrigger = false;
    }



    private void OnGUI()
    {

        if (onTrigger)
        {
            GUI.Box(new Rect(50, 250, 500, 25), "you are to small to reach the keypad try and find a step do that you can reach it");
           
        }
    }
}
