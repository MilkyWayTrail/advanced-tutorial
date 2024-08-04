using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    public float speed;
    public float forwardSpeed = 10;

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        _rigidbody.AddForce(new Vector3(horizontalInput * speed, 0, forwardSpeed));
    }
}