using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
  public float moveSpeed;
  public float lookSpeed;
  private Rigidbody rb;
  private float forwardInput;
  private float sideInput;
  private float turnInput;

    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.anyKey)
      {
        if (Input.GetKey(KeyCode.Q))
        {
          turnInput = -1;
        }
        if (Input.GetKey(KeyCode.E))
        {
          turnInput = 1;
        }
      } else {
        turnInput = 0;
      }

      sideInput = Input.GetAxis("Horizontal");
      forwardInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
      Move();
      TurnCamera();
    }

    private void TurnCamera()
    {
      float turn = turnInput * lookSpeed * Time.deltaTime;

      Quaternion turnRotation = Quaternion.Euler(0, turn, 0);
      rb.MoveRotation(rb.rotation * turnRotation);
    }

    private void Move()
    {
      Vector3 movementForward = transform.forward * forwardInput * moveSpeed * Time.deltaTime;
      Vector3 movementSide = transform.right * sideInput * moveSpeed * Time.deltaTime;

      rb.MovePosition(rb.position + movementForward + movementSide);
    }
}
