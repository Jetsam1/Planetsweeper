using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject Player;
    public float BulletSpeed;
    public Rigidbody2D rb;
    public static string ColName;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        rb.velocity = transform.right * BulletSpeed;
        Invoke("destructor", 2.5f);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        Destroy(gameObject);
        ColName = collision.tag;
        Player.GetComponent<Movement>().Converter(ColName);
    }


    private void destructor()
    {
        Destroy(gameObject);
    }

}
