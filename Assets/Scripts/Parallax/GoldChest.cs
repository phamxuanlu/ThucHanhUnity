using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldChest : MonoBehaviour
{
    public Sprite OpenChest;
    public Sprite ClosedChest;
    public GameObject coin;

    private bool wasOpen;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !wasOpen)
        {
            GetComponent<SpriteRenderer>().sprite = OpenChest;
            GetComponent<AudioSource>().Play();
            wasOpen = true;
            StartCoroutine(SpawnCoins());
        }
    }

    IEnumerator SpawnCoins()
    {
        int coins = 10;
        GameObject go;
        Rigidbody2D rgb;
        while (coins > 0)
        {
            --coins;
            go = Instantiate(coin, transform.position + new Vector3(0f, 0.5f, 0f), Quaternion.identity, transform) as GameObject;
            rgb = go.GetComponent<Rigidbody2D>();
            rgb.AddRelativeForce(new Vector2(Random.Range(-1f, 1f) * 250f, 250f));
            go = null;
            rgb = null;
            yield return new WaitForSeconds(0.25f);
        }
    }

    void CloseBox()
    {
        wasOpen = false;
        GetComponent<SpriteRenderer>().sprite = ClosedChest;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
