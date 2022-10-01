using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveV2 : MonoBehaviour
{
    Vector2 moveInput;
    Rigidbody2D playerRB2D;
    CircleCollider2D playerCOLL2D;

    public static AudioClip jumpAudio;

    //speeds of character
    [SerializeField] float circleSpeed = 10f;
    [SerializeField] float circleUpSpeed = 5f;

    void Start()
    {
        Time.timeScale = 1f;
        playerRB2D = GetComponent<Rigidbody2D>();
        playerCOLL2D = GetComponent<CircleCollider2D>();

    }

    void Update()
    {
        MoveCircleMove();        
    }

    //gets the input manager and makes player move
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    //how the player jumps via input manager
    void OnJump(InputValue value)
    {
        if (!playerCOLL2D.IsTouchingLayers(LayerMask.GetMask("Ground"))) { return; }
        
        if(value.isPressed)
        {
            playerRB2D.velocity += new Vector2 (0f, circleUpSpeed);
        }
    }
    
    //Velocity and speed of how high player jumps and falls
    void MoveCircleMove()
    {
        Vector2 circleVelocity = new Vector2(moveInput.x * circleSpeed, playerRB2D.velocity.y);
        playerRB2D.velocity = circleVelocity;
    }
}