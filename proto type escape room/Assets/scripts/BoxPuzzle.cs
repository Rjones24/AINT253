using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPuzzle : MonoBehaviour
{

    public bool onTrigger;
    public static int CurrentCorrect = 0;
    public bool BoxOpen;


    public Transform BoxHinge;

    private void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        onTrigger = false;
   

        CurrentCorrect = 0;
    }

    private void Update()
    {
        if (4 <= CurrentCorrect)
        {
            BoxOpen = true;
        }

        if (BoxOpen)
        {
            var newRotation = Quaternion.RotateTowards(BoxHinge.rotation, Quaternion.Euler(-90.0f, 0f, 0.0f), Time.deltaTime * 250);
            BoxHinge.rotation = newRotation;
        }
    }

    private void OnGUI()
    {
        if (!BoxOpen)
        {
            if (onTrigger)
            {
                GUI.Box(new Rect(200, 400, 600, 25), "use the mouse to pick up the blocks and move them to the right pad");
               
            }

        }
    }
}


