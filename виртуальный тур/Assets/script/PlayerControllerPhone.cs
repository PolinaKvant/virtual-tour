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

    private void Start() {
        camera = Camera.main.transform;
    }

    private void FixedUpdate() {
        _rigidbody.AddRelativeForce(_joystickMove.Horizontal * _moveSpeed, 0, _joystickMove.Vertical * _moveSpeed);
        
        transform.rotation = new Quaternion (0f, camera.rotation.y,0f,0f);
    }

}
