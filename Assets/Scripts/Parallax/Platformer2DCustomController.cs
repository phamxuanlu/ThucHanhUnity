using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Platformer2DCustomController : MonoBehaviour {


    private int score;

    //UI
    public GameObject scoreLabel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void AddCoins(int quantity)
    {
        score += quantity;
        scoreLabel.GetComponent<Text>().text = string.Format("Score: {0}", score);
    }
}
