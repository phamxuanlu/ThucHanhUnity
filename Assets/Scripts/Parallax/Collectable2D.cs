using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable2D : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player"){
            collision.gameObject.SendMessage("AddCoins", 10);
            GetComponent<AudioSource>().Play();
            this.GetComponents<Collider2D>()[0].enabled = false;
            this.GetComponents<Collider2D>()[1].enabled = false;
            Destroy(this.gameObject, GetComponent<AudioSource>().clip.length);
        }
    }
}
