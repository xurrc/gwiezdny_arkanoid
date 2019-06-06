using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{



    [SerializeField] Paddle paddle1;
    [SerializeField] bool HasStarted = false;
    [SerializeField] float xPush;
    [SerializeField] float yPush;
    [SerializeField] Rigidbody2D rb;
    Vector2 paddleToBallVectorl;

    // Start is called before the first frame update
    private void Start()
    {
        paddleToBallVectorl = transform.position - paddle1.transform.position;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.simulated = false;


    }

    // Update is called once per frame
    private void Update()
        { 
        if (!HasStarted)
        {   
        LockBallToPaddle();
        LaunchToPaddle();
         }
        }
    private void LaunchToPaddle()
    {
        if (Input.GetMouseButtonDown(0))

        {
            HasStarted = true;

            rb.simulated = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVectorl;
    }
}
