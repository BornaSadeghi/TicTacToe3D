using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed;// speed of rotation: public allows it to be changed in Unity inspector
    public Transform target;//the target object; in this case the cube
    private Vector3 point;//the coord to the point where the camera looks at
    // Start is called before the first frame update
    void Start()
    {
        point = target.transform.position;//get target's coords
        transform.LookAt(point);//makes the camera look to it
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetAxis is a built in control that takes in the horizontal arrow keys
        float rotateHorizontal = Input.GetAxis("Horizontal");
        
        // if one of the horizontal arrow keys is pressed
        if (rotateHorizontal != 0) { 
            // points camera at the cube
            transform.LookAt(target);
            // rotate the camera around the cube
            transform.RotateAround (point,new Vector3(0.0f,rotateHorizontal,0.0f),20 * Time.deltaTime * speed);
        }
    }
}
