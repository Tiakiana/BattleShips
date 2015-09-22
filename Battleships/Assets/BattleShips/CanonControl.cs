using UnityEngine;
using System.Collections;

public class CanonControl : MonoBehaviour
{
    public GameObject canonBall;
    public GameObject[] Canons = new GameObject[8];

   
    void ShootMissile(int cn){
        Debug.Log("Skudt");
        Transform weapon = Canons[cn].transform;
        Transform direction = Canons[cn].transform;
        GameObject ngo = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        ngo.AddComponent<Rigidbody>();
        ngo.AddComponent<CanonBall>();
        ngo.GetComponent<CanonBall>().SetDirection(Canons[cn].transform.rotation);
        ngo.transform.localScale = new Vector3(.3f, .3f, .3f);
        ngo.transform.position= weapon.transform.position;
        ngo.transform.rotation = weapon.transform.rotation;

      //  ngo.GetComponent<Rigidbody>().AddForce(Canons[cn].transform.forward, ForceMode.Force);
        /*
        direction.localRotation = Quaternion.Euler(weapon.rotation.x, weapon.rotation.y, weapon.rotation.z);
        clone = Instantiate(canonBall, weapon.position, weapon.rotation) as Rigidbody;
        clone.AddForce(weapon.forward * 1500,ForceMode.Force);
        */
        /*
       
        clone.AddForce(Canons[cn].transform.forward * 1500);
        */



        //float rnd;
        //rnd = Random.Range(-5,6);
        //direction.localRotation =  Quaternion.Euler(weapon.rotation.x,weapon.rotation.y+rnd,weapon.rotation.z);


    }

    void FireCanon(int cn)
    {
        switch (cn)
        {
            case 1:

                break;

            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

                break;
            default:
                break;
        }
    }

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown("y"))
        {
            ShootMissile(0);
        }
        if (Input.GetKeyDown("h"))
        {
            ShootMissile(1);
        }
        if (Input.GetKeyDown("n"))
        {
            ShootMissile(2);
        }
        if (Input.GetKeyDown("i"))
        {
            ShootMissile(3);
        }
        if (Input.GetKeyDown("k"))
        {
            ShootMissile(4);
        }
        if (Input.GetKeyDown(","))
        {
            ShootMissile(5);
        }
    }
}
