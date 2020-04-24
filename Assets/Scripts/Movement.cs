using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.localPosition.y >= -10.5f)
        {
            transform.position += new Vector3(0, -1, 0);
            transform.rotation = Quaternion.Euler(0f, 0f, 180f);
        }
        else if (Input.GetKeyDown(KeyCode.A) && transform.localPosition.x >= -5.5f)
        {
            transform.position += new Vector3(-1, 0, 0);
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        }
        else if (Input.GetKeyDown(KeyCode.D) && transform.localPosition.x <= 6.5f)
        {
            transform.position += new Vector3(1, 0, 0);
            transform.rotation = Quaternion.Euler(0f, 0f, -90f);
        }
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "WaterObject")
        {
            //rb.velocity = new Vector3(collision.gameObject.GetComponent<Rigidbody2D>().velocity.x, 0f, 0f);
            transform.position = collision.gameObject.transform.localPosition;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        rb.velocity = new Vector3(0f, 0f, 0f);
    }
}
