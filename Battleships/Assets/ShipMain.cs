using UnityEngine;
using System.Collections;

public class ShipMain : MonoBehaviour {
    float health = 20;
    // Use this for initialization



    public void TakeDamage(int i) {
        health -= i;
        if (health <= 0)
            DestroyObject(gameObject);
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
