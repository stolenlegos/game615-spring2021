using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFly : MonoBehaviour
{
  float timeOut;
  Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
      timeOut = 5;
      rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timeOut -= Time.deltaTime;
        if (timeOut <= 0)
        {
          Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
      rb.AddForce(transform.up * 1000 * Time.deltaTime);
    }
}
