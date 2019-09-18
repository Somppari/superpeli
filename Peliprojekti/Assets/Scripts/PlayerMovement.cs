using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 7f;
    public float crouchSpeed = 3f;
    public float jumpHeight = 10f;
    public Animator animator;

    Rigidbody2D rb;

    private bool jumpActive = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {

        moveForward();
        jump();
        crouch();
        DisablePlayerToPassLeftCorner();
    }

    void moveForward()
    {
        float inputX = Input.GetAxisRaw("Horizontal") * playerSpeed;

        //this moves the player forward
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            Debug.Log("Moving forwards");
            transform.localEulerAngles = new Vector3(0, 0, 0);
            transform.Translate(Vector2.right * inputX * Time.deltaTime);
            animator.SetFloat("Speed", inputX);
        }

        // This moves the player backwards
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            Debug.Log("Moving backwards");
            transform.localEulerAngles = new Vector3(0, 180, 0);
            transform.Translate(Vector2.right * -inputX * Time.deltaTime);
            animator.SetFloat("Speed", -inputX);
        }

        // This stops the animation for the player
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            animator.SetFloat("Speed", 0);
        }
    }

    void jump()
    {
        if (Input.GetKeyDown("space") && jumpActive == true)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            jumpActive = false;
            animator.SetBool("JumpEnabled", true);
        }
    }

    void crouch()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            playerSpeed = crouchSpeed;
            animator.SetBool("CrouchEnabled", true);
        }
        if (!Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("CrouchEnabled", false);
            playerSpeed = 7f;
        }
    }

    void OnCollisionEnter2D()
    {
        // Disable the jump animation
        jumpActive = true;
        animator.SetBool("JumpEnabled", false);
    }

    void DisablePlayerToPassLeftCorner()
    {
        if (transform.position.x < -17)
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }

        if (transform.position.x > -17)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        }
    }
}
