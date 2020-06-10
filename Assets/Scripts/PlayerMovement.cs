using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalMove = 0f;
    private bool jump = false;

    public CharacterController2D controller;


    public float speed = 40f;




    // Update is called once per frame
    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

       if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            Debug.Log("sad");
        }

    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }


}
