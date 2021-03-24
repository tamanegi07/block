﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 20.0f;

    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce(
            (transform.forward + transform.right) * speed,
            ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
