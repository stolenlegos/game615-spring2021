using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newShipMovement : MonoBehaviour
{
  public float speed;
  public float angularVelocity;
  Rigidbody rb;
  float pitch;
  float roll;
  float yaw;
  public float forwardVelocity;

    // Start is called before the first frame update
    void Start()
    {
      rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      speed = rb.velocity.magnitude;
      angularVelocity = rb.angularVelocity.magnitude;

//Pitch Control
      if (Input.GetKey(KeyCode.W))
      {
        pitch -= Time.deltaTime / 2;
      }

      if (Input.GetKey(KeyCode.S))
      {
        pitch += Time.deltaTime / 2;
      }

//Roll Control
      if (Input.GetKey(KeyCode.A))
      {
        roll += Time.deltaTime / 2;
      }

      if (Input.GetKey(KeyCode.D))
      {
        roll -= Time.deltaTime / 2;
      }

//Yaw Control
      if (Input.GetKey(KeyCode.Q))
      {
        yaw -= Time.deltaTime / 2;
      }

      if (Input.GetKey(KeyCode.E))
      {
        yaw += Time.deltaTime / 2;
      }

//Forward velocity Control
      if (Input.GetKey(KeyCode.Space))
      {
        forwardVelocity += Time.deltaTime * 1.5f;
      }

//slows all rotational velocity over time while left shift is pressed
      if (Input.GetKey(KeyCode.LeftShift))
      {
        if (yaw != 0)
        {
          yaw *= 0.95f;
        }

        if (roll != 0)
        {
          roll *= 0.95f;
        }

        if (pitch != 0)
        {
          pitch *= 0.95f;
        }
      }

//slows forward velocity over time
      if (Input.GetKey(KeyCode.LeftAlt))
      {
        if (forwardVelocity != 0)
        {
          forwardVelocity *= 0.95f;
        }
      }

//applies pitch, yaw, roll values into angular velocity
      rb.maxAngularVelocity = float.MaxValue;
      rb.AddTorque(transform.right * pitch);
      rb.AddTorque(transform.forward * roll);
      rb.AddTorque(transform.up * yaw);

//applies forward velocity
      rb.AddForce(transform.forward * forwardVelocity);
    }
}
