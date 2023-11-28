using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAcceleration : MonoBehaviour
{
    public float speed = 10.0f;
    Rigidbody rb;
    public Quaternion callibrationQuaternion;

    private void Start()
    {
       rb = GetComponent<Rigidbody>();
        CallibrateAccelerometr();
    }

    public void CallibrateAccelerometr()
    {
        Vector3 accelerationSnapsShot = Input.acceleration;
        Quaternion rotateQuaternion = Quaternion.FromToRotation(new Vector3(0.0f, 0.0f, -1.0f), accelerationSnapsShot);
        callibrationQuaternion = Quaternion.Inverse(rotateQuaternion);
    }

    public Vector3 FixAcceleration (Vector3 acceleration)
    {
        Vector3 fixedAcceleration = callibrationQuaternion * acceleration;
        return fixedAcceleration;
    }

    void FixedUpdate()
    {
        MoveBall();
        Vector3 accelerationRaw = Input.acceleration;
        Vector3 acceleration = FixAcceleration(accelerationRaw);
    }

    void MoveBall()
    {
        Vector3 acceleration = Input.acceleration;
        rb.velocity = new Vector3(acceleration.y, 0f, acceleration.x * -1) * speed;
    }

}
