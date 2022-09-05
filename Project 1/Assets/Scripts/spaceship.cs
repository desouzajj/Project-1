using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceship : MonoBehaviour
{

    public Transform thisShip;
     Rigidbody rb;

    public float turnSpeed = 60f;
    public float boostSpeed = 45f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Turn();
        Thrust();
    }

    void Turn()
    {
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        float roll = turnSpeed * Time.deltaTime * Input.GetAxis("Rotate");
        thisShip.Rotate(pitch, yaw, roll);


    }

    void Thrust()
    {
        thisShip.position += thisShip.forward * boostSpeed * Time.deltaTime * Input.GetAxis("Throttle");
    }
}
