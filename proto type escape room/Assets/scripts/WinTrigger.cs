using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    
 

    private void OnTriggerEnter(Collider other)
    {
        GameManagment.win = true;
    }


}
