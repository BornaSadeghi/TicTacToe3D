using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // below variables are for expanding and contracting the faces
    public GameObject[] faces;
    public float tolerance;
    public Vector3[] startPoints;
    public Vector3[] endPoints;
    public bool isExpanded = false;
    public float expandDistance = 2f;
    void Awake()
    {
        faces = GameObject.FindGameObjectsWithTag("Face");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            isExpanded = !isExpanded;
        }

        if (isExpanded) {
            ChangeToCube();
        } else {
            OpenFaces();
        }
    }
    void OpenFaces() {
        // code to expand into 3 faces
        if (faces[0].transform.position != endPoints[0]) {
            faces[0].transform.position += new Vector3 (0.5f, 0.0f, 0);
            faces[2].transform.position += new Vector3 (-0.5f, 0.0f, 0);
        }
        if (faces[2].transform.position != endPoints[1]) {
        }
        // sets isExpanded to false for next time
        isExpanded = false;
    }
    void ChangeToCube() {
        // Vector3 heading1 = currentTarget - faces[0].transform.position;
        // add the respective Vector3 to each face until it reaches the new point
        if (faces[0].transform.position != startPoints[0]) {
            faces[0].transform.position += new Vector3 (-0.5f, 0.0f, 0);
            faces[2].transform.position += new Vector3 (0.5f, 0.0f, 0);
        }
        if (faces[2].transform.position != startPoints[1]) {
        }
        // sets isExpanded to true for next time
        isExpanded = true;
    }
}
