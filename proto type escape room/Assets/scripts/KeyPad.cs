using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : MonoBehaviour
{
    public string CurrentPin = "1234";
    public string input = "";
    public string tempinput = "";
    public bool onTrigger;
    public bool doorOpen;
    public bool keyPadScreen;
    
    public Transform doorHinge;

    private void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        keyPadScreen = false;

        input = null;
    }

    private void Update()
    {
        if (input == CurrentPin)
        {
            doorOpen = true;
        }

        if (doorOpen)
        {
            var newRotation = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 250);
            doorHinge.rotation = newRotation;
        }
    }

    private void OnGUI()
    {
        if (!doorOpen)
        {
            if (onTrigger)
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Press 'E' to Interact with Keypad");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    keyPadScreen = true;
                    onTrigger = false;
                }
            }

            if (keyPadScreen)
            {
                GUI.Box(new Rect(0, 0, 320, 455), "");
                GUI.Box(new Rect(5, 5, 310, 25), input);
                GUI.Button(new Rect(5, 35, 100, 100), "1");
                GUI.Button(new Rect(110, 35, 100, 100), "2");
                GUI.Button(new Rect(215, 35, 100, 100), "3");
                GUI.Button(new Rect(5, 140, 100, 100), "4");
                GUI.Button(new Rect(110, 140, 100, 100), "4");
                GUI.Button(new Rect(215, 140, 100, 100), "6");
                GUI.Button(new Rect(5, 245, 100, 100), "7");
                GUI.Button(new Rect(110, 245, 100, 100), "8");
                GUI.Button(new Rect(215, 245, 100, 100), "9");
                GUI.Button(new Rect(100, 350, 100, 100), "0");

                if (Input.GetKeyUp(KeyCode.Alpha1))
                {
                    tempinput += "1";
                    input += tempinput[0];
                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    tempinput += "2";
                }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    input += "3";
                }
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    input += "4";
                }
                if (Input.GetKeyDown(KeyCode.Alpha5))
                {
                    input += "5";
                }
                if (Input.GetKeyDown(KeyCode.Alpha6))
                {
                    input += "6";
                }
                if (Input.GetKeyDown(KeyCode.Alpha7))
                {
                    input += "7";
                }
                if (Input.GetKeyDown(KeyCode.Alpha8))
                {
                    input += "8";
                }
                if (Input.GetKeyDown(KeyCode.Alpha9))
                {
                    input += "9";
                }
                if (Input.GetKeyDown(KeyCode.Alpha0))
                {
                    input += "0";
                }
                
                tempinput = "";
            }
        }
    }
}
