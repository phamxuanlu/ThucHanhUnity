using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

    [SerializeField]
    private int speed;

	// Use this for initialization
	void Start () {
        speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
        transform.Rotate(Vector3.right * Time.deltaTime * speed);
	}
}
