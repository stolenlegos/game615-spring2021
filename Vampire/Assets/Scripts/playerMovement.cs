using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
  public float moveSpeed;
  public float lookSpeed;
  private Rigidbody rb;
  private float movementInput;
  private float turnInput;

    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        turnInput = Input.GetAxis("Horizontal");
        movementInput = Input.GetAxis("Vertical");
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
      Vector3 movement = transform.forward * movementInput * moveSpeed * Time.deltaTime;

      rb.MovePosition(rb.position + movement);
    }
}
