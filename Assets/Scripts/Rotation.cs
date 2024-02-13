using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    
	public float rotationVelocity;
    public Vector2 rot = Vector2.zero;

    void Start()
    {
        rotationVelocity = 15.0f;
        rot.y = 10.0f;
    }


	void Update () {
        this.transform.Rotate(rot*Time.deltaTime * rotationVelocity);
	}

}
