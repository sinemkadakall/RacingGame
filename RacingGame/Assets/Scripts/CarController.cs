
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public float speed =1500;
    private float movement =0f;

    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;

    private void Update()
    {
        movement = -Input.GetAxisRaw("Vertical") * speed;
    }

    private void FixedUpdate()
    {
        if(movement == 0f)
        {
            backWheel.useMotor = false;
        }
        else
        {
            backWheel.useMotor=true;
            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
            backWheel.motor = motor;

        }



    }
}
