using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D rigi;
    public Vector2 MoveSpeed;

    // Use this for initialization
    void Start () {
        rigi = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		while(Input.GetKeyDown(KeyCode.A))
        {
            rigi.AddForce(MoveSpeed);
        }

	}
}
