using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalMove = 0f;
    private bool jump = false;

    public Joystick joystick;
    public CharacterController2D controller;


    public float speed = 40f;




    // Update is called once per frame
    void Update()
    {
       
        //horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        horizontalMove = joystick.Horizontal * speed;

        float verticalMove = joystick.Vertical;

        if (verticalMove >= .5f)
        {
            jump = true;
        }

       if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }


}
