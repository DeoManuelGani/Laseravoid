using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movemeny : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;
    public KeyCode moveRight = KeyCode.RightArrow;
    public KeyCode moveLeft = KeyCode.LeftArrow;
    public float boundX = 2.56f;
    public float boundY = 2.56f;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;

        if (Input.GetKeyDown(moveUp) && pos.y < boundY)
        {
            pos.y = pos.y + 2.56f;
        }
        else if (Input.GetKeyDown(moveDown) && pos.y > -boundY)
        {
            pos.y = pos.y - 2.56f;
        }
        else if (Input.GetKeyDown(moveRight) && pos.x < boundX)
        {
            pos.x = pos.x + 2.56f;
        }
        else if (Input.GetKeyDown(moveLeft) && pos.x > -boundX)
        {
            pos.x = pos.x - 2.56f;
        }
        transform.position = pos;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(gameObject);
        SceneManager.LoadScene("SampleScene");
    }
}
