using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {

    public float MoveSpeed;
    public float RepeatMove;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Move", 0f, RepeatMove);
	}
	
	// Update is called once per frame
	void Move() {
        transform.position += new Vector3(MoveSpeed, 0f, 0f);

        if (transform.localPosition.x <= -9f || transform.localPosition.x >= 9f)
        {
            Destroy(gameObject);
        }
	}

}
