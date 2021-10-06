using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField] private float playerSpeed = 2.0f;
    [SerializeField] private float jumpHeight = 1.0f;
    [SerializeField] private float gravityValue = -9.81f;
    private Player_Joystick playerInput;

    Rigidbody myRb;

    public void Awake()
    {
        playerInput = new Player_Joystick();
        controller = GetComponent<CharacterController>();
    }

    public void OnEnable()
    {
        playerInput.Enable();
    }

    public void OnDisable()
    {
        playerInput.Disable();
    }

    public void Update()
    {
        //groundedPlayer = controller.isGrounded;
        /*if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }*/

        Vector2 movementInput = playerInput.Joystick_Main.Move.ReadValue<Vector2>();
        Vector3 move = new Vector3(0, movementInput.x, 0);
        // controller.Move(move * Time.deltaTime * playerSpeed);
        transform.Rotate(move);
        if (move != Vector3.zero)
        {
            gameObject.transform.forward = new Vector3(movementInput.x,0,movementInput.y);
            GetComponent<Rigidbody>().velocity = new Vector3(movementInput.x, 0, movementInput.y);
        }

        /* // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }
        */
        //playerVelocity.y += gravityValue * Time.deltaTime;
        //controller.Move(move * Time.deltaTime * playerSpeed + playerVelocity * Time.deltaTime);
    }
}
