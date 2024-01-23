using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beehaviour : MonoBehaviour
{
    public float enemySpeed;
    float randomAngle;
    public Rigidbody thisRigidbody;
    private Vector2 direccion;

    void Start()
    {
        enemySpeed = 10.0f;
        //thisRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(Vector2.right * enemySpeed * Time.deltaTime);
        randomAngle = Random.Range(-45.0f,45.0f);
        transform.Rotate(0.0f, 0.0f, randomAngle, Space.World);
        //cube1.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);

        if(transform.position.x < -25.0f || transform.position.x > 21.0f)
            Destroy(transform.root.gameObject);
    }


}
