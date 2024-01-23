using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beehaviour : MonoBehaviour
{
    public float enemySpeed;
    public float randomAngle;
    float cadence;
    public Rigidbody thisRigidbody;
    private Vector2 direccion;

    void Start()
    {
        enemySpeed = 8.0f;
        cadence = 0.05f;
        InvokeRepeating("ChangeAngle",0f,cadence);
        //thisRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        enemySpeed = Random.Range(10.0f,13.0f); 
        transform.Translate(Vector2.right * enemySpeed * Time.deltaTime);
        
        transform.Rotate(0.0f, 0.0f, randomAngle, Space.World);
        //cube1.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);

        if(transform.position.x < -9.5f || transform.position.x > 9.5f)
            Destroy(transform.root.gameObject);
        
        if(transform.position.y < -5.5f || transform.position.y > 5.5f)
            Destroy(transform.root.gameObject);

        OnTouchDestroy();

    }

    void OnTouchDestroy()
    {
        if (Input.touchCount == 1)
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPos = new Vector2(wp.x, wp.y);

            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {
                Destroy(this.transform.gameObject);
            }
        }

    }

    void ChangeAngle()
    {
        randomAngle = Random.Range(-30.0f,30.0f);
    }

    
    void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        //GameManager.instanceGameManager.PointsManager(points);
        //loadSound.destroySound();
        Destroy(this.gameObject, 1.0f);

    }
    







}
