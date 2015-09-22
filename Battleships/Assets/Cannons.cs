using UnityEngine;
using System.Collections;

public class Cannons : MonoBehaviour {

    public void FireBullet()
    {
        GameObject ngo = new GameObject();
        ngo.AddComponent<CanonBall>();
        ngo.AddComponent<Rigidbody>().AddForce(Vector3.forward * 5, ForceMode.VelocityChange);

    }
    
    void Start () {
	
	}
	
	
	void Update () {
	
	}
}
