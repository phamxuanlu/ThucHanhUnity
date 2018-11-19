using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{

    public int speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.Find("Bee");
        Vector3 pos = (go.transform.position += Vector3.up * Time.deltaTime * speed);

        Text debugText = GameObject.FindObjectOfType<Text>();
        string text = string.Format("X={0}\nY={1}\nZ={2}", pos.x, pos.y, pos.z);
        debugText.text = text;
    }

    public void OnClicked()
    {
       
    }
}
