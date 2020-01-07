﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookOutWindow : MonoBehaviour
{
    public bool onTrigger;


  

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
            GUI.Box(new Rect(850, 700, 500, 25), "you notice somthing out side but are to small to read it");

        }
    }
}
