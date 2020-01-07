using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxClutterCollection : MonoBehaviour
{
  
    void Update()
    {
        int Compleate = BoxPuzzle.CurrentCorrect;

        if (Compleate >= 4)
        {
            Destroy(this.gameObject);
        }
    }
}
