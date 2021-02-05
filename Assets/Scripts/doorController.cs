using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
    private HingeJoint2D doorHinge;

    private void Awake()
    {
        doorHinge = GetComponent<HingeJoint2D>();
    }

  public void SetDoorSpeed(float doorSpeed)
    {
        JointMotor2D doorMotor = doorHinge.motor;
        doorMotor.motorSpeed = doorSpeed;
        doorHinge.motor = doorMotor;
    }
}
