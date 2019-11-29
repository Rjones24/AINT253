﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPScontroler : MonoBehaviour
{
    private CharacterController controller;

    private float VertiavlVerlocity;
    private float gravity = 14.0f;
    private float jumpForce = 10.0f;
    private float jumpDelay = 1.5f;
    private bool Isjumping = false;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void SetJumping()
    {
        Isjumping = false;
    }

    // Update is called once per frame
    void Update()
    {

        float Horizintal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");
        bool Jump = Input.GetButton("Jump");
        

        transform.Rotate(0f, 0f, Horizintal/2, Space.Self);


        if (controller.isGrounded)
        {
            if (Jump)
            {
                if (!Isjumping)
                {
                    Isjumping = true;
                    VertiavlVerlocity = jumpForce;
                    Vector3 jumpVector = new Vector3(0, VertiavlVerlocity, 0);
                    controller.Move(jumpVector * Time.deltaTime);
                    Invoke("SetJumping", jumpDelay);
                }
            }


        }

        else
        {
            VertiavlVerlocity -= gravity * Time.deltaTime;
            Vector3 jumpVector = new Vector3(0, VertiavlVerlocity, 0);
            controller.Move(jumpVector * Time.deltaTime);

        }
 
            MoveMech( Vertical);
        
    }

    void MoveMech( float Vertical)
    {
        transform.Translate( 0.0f, Vertical * Time.deltaTime * 10, 0f);
    }

}
