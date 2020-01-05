using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDraw : MonoBehaviour
{
   
    public bool onTrigger;
    public bool DrawOpen;
   

    public Transform Draw;

    private void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        onTrigger = false;
    }

    private void Update()
    {
        if (DrawOpen)
        {
            
            Draw.Translate(0.0f, 10.0f, 0f);
        }
    }

    private void OnGUI()
    {
        if (!DrawOpen)
        {
            if (onTrigger)
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Press 'E' to open draw");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    DrawOpen = true;
                }
            }

        }
    }
}
