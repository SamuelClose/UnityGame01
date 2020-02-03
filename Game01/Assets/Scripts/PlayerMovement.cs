using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public float speed, gravity, jumpForce, jumpCount, jumpMax;
    public CharacterController controller;
    private Vector3 posDirection;

   


    void Update()
    {
        controller.Move(posDirection * Time.deltaTime);
        posDirection.y = gravity;
        HorMovement();
        Jump();
    }


    private void HorMovement()
    {
        posDirection.x = Input.GetAxis("Horizontal") * speed;
    }
    
    private void Jump()
    {
        if (Input.GetButtonDown("Jump")&& controller.isGrounded)
        {
            posDirection.y += jumpForce;
        }
    }


}
