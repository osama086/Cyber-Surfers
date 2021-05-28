using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;

    private int desiredLane = 1;
    public float laneDistance = 8;

    public bool isGrounded;
    public LayerMask groundLayer;
    public Transform groundCheck;

    public float jumpForce;
    public float Gravity = -20;

    public Animator animator;
    public float increaseHeight;
    public float reducedHeight;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.z = forwardSpeed;

        direction.y += Gravity * Time.deltaTime;
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.15f, groundLayer);
        if (controller.isGrounded)
        {
           
            if (SwipeManager.swipeUp)
            {
                Jump();
                animator.Play("jump");
            }
            if (SwipeManager.swipeDown)
            {
                controller.height = reducedHeight;
                animator.Play("slide");
                Invoke("StopSlideing", 1f);
            }
        }

        if(SwipeManager.swipeRight)
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;
        }

        if (SwipeManager.swipeLeft)
        {
            desiredLane--;
            if (desiredLane == -1)
                desiredLane = 0;
        }

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }
        else if(desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        transform.position = targetPosition;
        controller.center = controller.center;
    }
    private void FixedUpdate()
    {
        controller.Move(direction * Time.deltaTime);
    }

    private void Jump()
    {
        direction.y = jumpForce;
    }
    void StopSlideing()
    {
        controller.height = increaseHeight;
    }

   
}
