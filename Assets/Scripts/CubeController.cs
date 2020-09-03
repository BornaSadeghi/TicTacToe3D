﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // speed of rotation: public allows it to be changed in Unity inspector
    public int speed = 20;
    // Start is called before the first frame update - unused in this case
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        // Input.GetAxis is a built in control that takes in the horizontal arrow keys
        float rotateHorizontal = Input.GetAxis("Horizontal");
        // if one of the horizontal arrow keys is pressed
        if (rotateHorizontal != 0) {
            // rotate the cube (it actually calls "this.transform.Rotate" but the "this" is not necessary)
            transform.Rotate (new Vector3 (0, rotateHorizontal * speed, 0) * Time.deltaTime);
        }
    }
}