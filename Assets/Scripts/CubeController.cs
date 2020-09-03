using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public int speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        float rotateHorizontal = Input.GetAxis("Horizontal");
        if (rotateHorizontal != 0) {
            transform.Rotate (new Vector3 (0, rotateHorizontal * speed, 0) * Time.deltaTime);
        }
    }
}
