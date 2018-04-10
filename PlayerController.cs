using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rigi;
    public float MoveSpeed = 3;
    public Vector2 JumpHeight;

    // Use this for initialization
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rigi.velocity = new Vector2(MoveSpeed, rigi.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rigi.velocity = new Vector2(-MoveSpeed, rigi.velocity.y);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            rigi.AddForce(JumpHeight);
        }


    }
}
