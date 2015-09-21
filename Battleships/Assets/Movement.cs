using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    Rigidbody rb = null;

	// Use this for initialization
	void Start () {
        rb = gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
	}

   

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("w")) {
            rb.AddForce(Vector3.forward*10,ForceMode.Acceleration);

        }

    }
}
