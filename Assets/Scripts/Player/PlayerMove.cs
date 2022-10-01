using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D _playerRigBody;
    public float _moveSpeed = 50f;
    public float _velocity = 20f;

    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            _playerRigBody.AddForce(new Vector2 (-_moveSpeed, 0));
        }

        if (Input.GetKeyDown("d"))
        {
            _playerRigBody.AddForce(new Vector2 (_moveSpeed, 0));
        }
    }
}
