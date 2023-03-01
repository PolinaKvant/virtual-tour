using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class PlayerControllerPhone : MonoBehaviour
{
    public Rigidbody _rigidbody;
    public FixedJoystick _joystickMove;
    public Transform camera;
    public float _moveSpeed;

    private void Start()
    {
        camera = Camera.main!.transform;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        var move = new Vector3(_joystickMove.Horizontal, 0, _joystickMove.Vertical);

        _rigidbody.AddRelativeForce(move * (50f * Time.deltaTime), ForceMode.VelocityChange);

        if (_rigidbody.velocity.magnitude > _moveSpeed)
            _rigidbody.velocity = _rigidbody.velocity.normalized * _moveSpeed;
    }
}