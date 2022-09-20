using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2D;

    public float speed = 10.0f;
    public float xMovement;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rb2D.velocity = new Vector2(xMovement * speed, rb2D.velocity.y);
    }
}
