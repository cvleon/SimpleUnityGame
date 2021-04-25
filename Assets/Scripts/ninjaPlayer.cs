using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ninjaPlayer : MonoBehaviour
{
    public float speed;
    private float input;
    Rigidbody2D rb;
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Animation transition
        if (input != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else {
            anim.SetBool("isRunning", false);
        }

        // Rotating Character so that it faces the way it runs
        if (input > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (input < 0) {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Storing player's input
        input = Input.GetAxisRaw("Horizontal");

        // Moving player
        rb.velocity = new Vector2(input * speed, rb.velocity.y);

    }
}
