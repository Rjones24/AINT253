using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectweight : MonoBehaviour
{
    public string spesifiedtag;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == spesifiedtag)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
