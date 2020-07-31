﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketboosterscript : MonoBehaviour

{
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputprocess();   
    }

     private void inputprocess()
    {
      if(Input.GetKey(KeyCode.Space)  || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddRelativeForce(Vector3.up);
        }
      if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            transform.Rotate(-Vector3.forward);
        }
    }
}
