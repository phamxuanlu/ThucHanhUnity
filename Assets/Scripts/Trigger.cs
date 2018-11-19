using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter " + other.name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter " + collision.gameObject.name);
        if (collision.gameObject.tag.Equals("Ground"))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay " + other.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision Stay " + collision.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit " + other.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision Exit " + collision.gameObject.name);
    }
}
