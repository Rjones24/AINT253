﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDraw : MonoBehaviour
{
   
    public bool onTrigger;
    public bool DrawOpen = false;
    public GameObject drawer;
    [SerializeField] private Animator myAnimation;

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
        if (!DrawOpen)
        {
            if (onTrigger)
            {
                GUI.Box(new Rect(850, 700, 200, 25), "Press 'E' to open draw");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    myAnimation.SetBool("open", true);                   
                    drawer.GetComponent<AudioSource>().Play();
                    DrawOpen = true;
                    
                }
            }

        }
        
    }
}
