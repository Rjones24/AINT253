using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectweight : MonoBehaviour
{
    public string spesifiedtag;
    bool compleate = false;
  
    private void OnCollisionEnter(Collision collision)
    {
        if (!compleate)
        {
            if (collision.gameObject.tag == spesifiedtag)
            {
                compleate = true;
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                BoxPuzzle.CurrentCorrect += 1;
                

            }
            else
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
