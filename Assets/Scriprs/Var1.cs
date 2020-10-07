using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Var1 : MonoBehaviour
{
     /*private Rigidbody rd;
      private float speed = 2;
      void Start()
      {
          rd = GetComponent<Rigidbody>();
      }

      // Update is called once per frame
      void FixedUpdate()
      {
          if (Input.GetKey(KeyCode.RightArrow))
          rd.velocity = Vector3.right * speed;
          if (Input.GetKey(KeyCode.LeftArrow))
          rd.velocity = Vector3.left * speed;
          if (Input.GetKey(KeyCode.UpArrow))
          rd.velocity = Vector3.forward * speed;
          if (Input.GetKey(KeyCode.DownArrow))
          rd.velocity = -Vector3.forward * speed;



      }*/
    public float Speed = 1f;
    private Rigidbody rb;

    void Start()
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
        transform.Translate(movement * Speed * Time.fixedDeltaTime);
    }
}
    /*using UnityEngine;
public class Var1 : MonoBehaviour
{
    public float Speed = 0.3f;
    private Rigidbody _rb;
   

    private Vector3 _movementVector
    {
        get
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");

            return new Vector3(horizontal, 0.0f, vertical);
        }
    }

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MoveLogic();
    }

    private void MoveLogic()
    {
        _rb.AddForce(_movementVector * Speed, ForceMode.VelocityChange);
    }

}*/
