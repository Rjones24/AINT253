using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxPuzzleComplet : MonoBehaviour
{
    private int compleate = 0;
    


    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (compleate == 2)
        {
            openBox();
        }
        compleate += 1;
    }

    public void openBox()
    {
        transform.Rotate(-90f, 0.0f,0f);
    }
}
