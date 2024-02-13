using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    
	public float rotationVelocity;
    public Vector3 rot = Vector3.zero;

    void Start()
    {
        rotationVelocity = 15.0f;
        rot.z = 10.0f;
    }


	void Update () {
        this.transform.Rotate(rot*Time.deltaTime * rotationVelocity);
	}

}
