using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup1 : MonoBehaviour
{
    Vector3 objectpos;
    float distance;

    public bool canHold = true;
    public GameObject item;
    public GameObject TempParent;
    public bool isHolding = false;


    // Update is called once per frame
    void Update()
    {

        if (isHolding == true)
        {
            
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(TempParent.transform);

        }
        else
        {
            
            objectpos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objectpos;
        }
    }

    void OnMouseDown()
    {
        isHolding = true;
        item.transform.position = TempParent.transform.position;
        
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().detectCollisions = true;
       

    }

    void OnMouseUp()
    {
        isHolding = false;
     
    }
}
