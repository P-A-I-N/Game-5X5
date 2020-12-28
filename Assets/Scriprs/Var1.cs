using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Var1 : MonoBehaviour
{
    public float Speed = 1f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MovementLogic();
    }

    private void MovementLogic()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.MovePosition(rb.position + movement * (Speed * Time.fixedDeltaTime));
        //transform.Translate(movement * Speed * Time.fixedDeltaTime);
    }
}
   
