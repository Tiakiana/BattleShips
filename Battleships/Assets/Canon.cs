using UnityEngine;
using System.Collections;

public class Canon : MonoBehaviour {
    public void FireBullet() {
        GameObject ngo = new GameObject();
        ngo.AddComponent<CanonBall>();
        ngo.AddComponent<Rigidbody>().AddForce(Vector3.forward * 5,ForceMode.VelocityChange);
        
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
