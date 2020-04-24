using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathscript : MonoBehaviour
{

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            Debug.Log("u ded");
            Die();
        }
    }

    void Update()
    {
        
    }

    void Die()
    {
        transform.position = new Vector3(0.5f, -11.5f, 0f);
    }
}

