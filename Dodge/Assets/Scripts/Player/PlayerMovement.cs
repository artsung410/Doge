using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed = 16f;
    public bool UseSpeed = false;

    private PlayerInput _input;
    private Rigidbody _rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        // _input에 값을 할당한다.
        _input = GetComponent<PlayerInput>();
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xSpeed = _input.X * Speed;
        float zSpeed = _input.Y * Speed;

        if (UseSpeed)
        {
            _rigidBody.velocity = new Vector3(xSpeed, 0f, zSpeed);
        }
        else
        {
            _rigidBody.AddForce(xSpeed, 0f, zSpeed);
        }
    }
}
