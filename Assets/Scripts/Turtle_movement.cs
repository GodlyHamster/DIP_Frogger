using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle_movement : MonoBehaviour {

    public float MoveSpeed;
    public float RepeatMove;
    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("Move", 0f, RepeatMove);
    }

    // Update is called once per frame
    void Move()
    {
        //transform.position += new Vector3(MoveSpeed, 0f, 0f);
        rb.velocity = new Vector3(MoveSpeed, 0f, 0f);

        if (transform.localPosition.x <= -14f || transform.localPosition.x >= 14f)
        {
            Destroy(gameObject);
        }
    }
}
