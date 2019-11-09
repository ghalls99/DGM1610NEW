﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private Rigidbody playerRB;
    private float zBound = 10;
    private float xBound = 10;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRB.AddForce(Vector3.right * speed * verticalInput);
        playerRB.AddForce(Vector3.forward * speed * horizontalInput);
        
        if(transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
        if(transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        if (transform.position.z < -xBound)
        {
            transform.position = new Vector3(transform.position.z, transform.position.y, -xBound);
        }
        if (transform.position.z > xBound)
        {
            transform.position = new Vector3(transform.position.z, transform.position.y, xBound);
        }
    }
}
