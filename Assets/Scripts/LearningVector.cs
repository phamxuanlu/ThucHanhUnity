using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningVector : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(Vector3.zero, new Vector3(100, 0, 0));

        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero, new Vector3(0, 100, 0));

        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, new Vector3(0, 0, 100));
    }

    private void FixedUpdate()
    {
        Debug.DrawLine(Vector3.zero, new Vector3(100, 0, 0), Color.blue);
        Debug.DrawLine(Vector3.zero, new Vector3(0, 100, 0), Color.green);
        Debug.DrawLine(Vector3.zero, new Vector3(0, 0, 100), Color.red);


        //
        //Vector3 A = new Vector3(10, 20, 30);
        //Vector3 B = new Vector3(20, 40, 60);
        //Debug.DrawLine(A, B, Color.white);

        //Vector3 C = new Vector3(10, 20, 30);
        //Vector3 D = new Vector3(0, 70, 50);
        //Debug.DrawLine(C, D, Color.white);

        //Vector3 vec1 = (A + B);

        //Vector3 vec2 = (C + D);

        //Vector3 result = vec1 + vec2;
        //Debug.DrawLine(Vector3.zero, result, Color.cyan);

        //Ve
    }
}
