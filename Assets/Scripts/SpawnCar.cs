using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour {

    public GameObject Car;
    public Vector3 SpawnPos;
    public float SpawnTime;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", 0f, SpawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Spawn()
    {
        Instantiate(Car, SpawnPos, Quaternion.identity);
    }
}
