using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desk : MonoBehaviour
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
            GUI.Box(new Rect(850, 700, 600, 25), "Ooo look these somthing written on that book i wonder if miss has hidden anytging in her desk");
        }
    }
}
