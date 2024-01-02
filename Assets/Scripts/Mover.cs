using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
   public Rigidbody2D rb2d;
   public float speed = -10f;

    // Update is called once per frame
    void Start()
    {
        rb2d.velocity = transform.right * speed;
    }
}
