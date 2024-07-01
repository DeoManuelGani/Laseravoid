using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorSwing : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if (transform.position.x > 0f)
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
        vel.x = speed;
        rb2d.velocity = vel;
        var pos = transform.position;
        transform.position = pos;
    }
}
