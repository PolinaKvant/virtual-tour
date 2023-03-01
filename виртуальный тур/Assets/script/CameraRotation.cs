using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public FixedJoystick _joystickRote;


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(-_joystickRote.Vertical,_joystickRote.Horizontal, 0));
    }
}
