﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigidbody : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody rb;


    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    public void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 tempVect = new Vector3(h, 0, v);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(transform.position + tempVect);
    }
}
