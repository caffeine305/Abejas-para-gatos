using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bee;
    public float cadence;
    public Transform origen;
    private GameObject instance_bee;
     void Awake()
    {
        cadence = 0.5f;
        InvokeRepeating("InstanceBees",0f,cadence);
        origen = this.transform;
    }

    private void InstanceBees()
    {
        instance_bee = Instantiate(bee, origen.position,Quaternion.identity);
        //instance_bullet.transform.right = origen.forward;
        //instance_bee.GetComponent<Rigidbody>().AddForce(origen.forward * bulletForce, ForceMode.Impulse );
    }

    private void MoveSidetoSide()
    {
        //if moveRight
    }
}
