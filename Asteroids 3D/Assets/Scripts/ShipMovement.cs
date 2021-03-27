using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
  Rigidbody ship;
  public float speed;
  public float turnSpeed;
  float roll;
  float pitch;
  float rollDirection;
  float pitchDirection;
  float yaw;
  float yawDirection;
  public float afterBurn;
  public float afterBurnTimer;
    // Start is called before the first frame update
    void Start()
    {
      ship = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      rollDirection = Input.GetAxis("Horizontal");
      pitchDirection = Input.GetAxis("Vertical");

      if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.E))
      {
        if (Input.GetKey(KeyCode.Q))
        {
          yawDirection = -1;
        }
        if (Input.GetKey(KeyCode.E))
        {
          yawDirection = 1;
        }
      } else {
        yawDirection = 0;
      }
      if (Input.GetKeyDown(KeyCode.Space) || afterBurnTimer >= 0.01)
      {
        if (afterBurnTimer >= 0.01)
        {
          if (Input.GetKeyUp(KeyCode.Space))
          {
            afterBurn = 30;
            afterBurnTimer = 30;
          }

        afterBurn -= Time.deltaTime * 1.25f;
        afterBurnTimer -= Time.deltaTime;
        }
      } else {
        afterBurn = 1;
      }

      /*if (Input.GetMouseButtonDown(1))
      {
        if (afterBurnTimer < 0)
        {
          afterBurn = 20 - Time.deltaTime;
          afterBurnTimer = 30;
        } else {
          afterBurnTimer = 0;
        }
      } else {
        afterBurn = 1;
      }

      afterBurnTimer -= Time.deltaTime;*/
    }

    void FixedUpdate()
    {
      Move();
      Turn();
    }

    void Move()
    {
      Vector3 moveForward = transform.forward * speed * afterBurn * Time.deltaTime;
      ship.MovePosition(ship.position + moveForward);
    }

    void Turn()
    {
      roll = -rollDirection * turnSpeed * 3 * Time.deltaTime;
      pitch = -pitchDirection * turnSpeed * 2 * Time.deltaTime;
      yaw = yawDirection * turnSpeed * 2 * Time.deltaTime;

      Quaternion turnRotation = Quaternion.Euler(pitch, yaw, roll);
      ship.MoveRotation(ship.rotation * turnRotation);
    }
}
