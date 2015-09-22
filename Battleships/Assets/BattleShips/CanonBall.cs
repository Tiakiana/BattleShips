using UnityEngine;
using System.Collections;

public class CanonBall : MonoBehaviour {
    public float damage;
    float timer = 4f;
    // Use this for initialization
    Rigidbody me;

    public void SetDirection(Quaternion q) {
        transform.rotation = q;
    }

    void Start()

    {
        
        Physics.IgnoreLayerCollision(8, 8, true);
        me = this.GetComponent<Rigidbody>();
        me.AddForce(transform.forward*1000, ForceMode.Acceleration);
      //  me.AddRelativeForce(this.transform.forward * 100);
        timer = 0;
        this.gameObject.GetComponentInChildren<Renderer>().material.color = Color.red;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Respawn") {
            DestroyObject(gameObject);
        }

        if (col.gameObject.tag == "Player") {
            col.gameObject.SendMessage("TakeDamage", 1);
        }

    }

    // Update is called once per frame
    void Update () {
      /*  timer -= Time.deltaTime;
        if (timer< 0)
        {
            DestroyObject(this.gameObject);
        }*/
	}
}
