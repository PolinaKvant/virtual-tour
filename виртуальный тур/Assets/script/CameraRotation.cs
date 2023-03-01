using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public FixedJoystick _joystickRote;
    public Transform player;
    public float sensitivity = 1;
    public float smoothing = 1.5f;
    
    Vector2 velocity;
    Vector2 frameVelocity;

    private void Start()
    {
        player = transform.parent;
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 mouseDelta = new Vector2(_joystickRote.Horizontal, _joystickRote.Vertical);
        Vector2 rawFrameVelocity = Vector2.Scale(mouseDelta, Vector2.one * sensitivity);
        frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / smoothing);
        velocity += frameVelocity;
        velocity.y = Mathf.Clamp(velocity.y, -90, 90);

        // Rotate camera up-down and controller left-right from velocity.
        transform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.right);
        player.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);
    }
}