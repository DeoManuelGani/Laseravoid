using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertSwing : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if (transform.position.y > 0f)
       {
           speed = -speed;
       }
        else
        {
            speed = speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
        vel.y = -speed;
        rb2d.velocity = vel;
        var pos = transform.position;
        transform.position = pos;
    }
}
