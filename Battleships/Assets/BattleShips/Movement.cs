using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    Rigidbody rb = null;
    //Input input;
    float minimumSpeed, maximumSpeed, currentSpeed, desiredSpeed, turnSpeed;
    // Use this for initialization
    void Start()
    {
        rb = gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezeRotationZ;
        rb.constraints = RigidbodyConstraints.FreezeRotationX;
        minimumSpeed = 1;
        maximumSpeed = 5;
        currentSpeed = 1;
        desiredSpeed = 1;
        turnSpeed = 0.5F;

        //input = new Input();
    }



    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
        if (currentSpeed > desiredSpeed)
        {
            currentSpeed -= 0.05F;
        }
        if (currentSpeed < desiredSpeed)
        {
            currentSpeed += 0.05F;
        }

        if (Input.GetKeyDown("w"))
        {
            if (desiredSpeed < maximumSpeed)
            {
                desiredSpeed += 1;
            }
        }
        else if (Input.GetKeyDown("s"))
        {
            if (desiredSpeed > minimumSpeed)
            {
                desiredSpeed -= 1;
            }
        }
        else
        {
            if (Input.GetKey("a"))
            {
                transform.Rotate(Vector3.down * turnSpeed, Space.World);
            }
        
         else
        {
            if (Input.GetKey("d"))
            {
                transform.Rotate(Vector3.up * turnSpeed, Space.World);
            }
        }
    } }
}
