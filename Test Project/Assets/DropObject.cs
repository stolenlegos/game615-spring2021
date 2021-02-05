using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
          Rigidbody rb = gameObject.GetComponent<Rigidbody>();
          rb.useGravity = true;
          rb.AddForce(transform.forward * 1000.0f);
        }

        if (Input.GetKey(KeyCode.W)) {
          transform.Rotate(Vector3.right * 60 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)) {
          transform.Rotate(Vector3.left * 60 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A)) {
          transform.Rotate(Vector3.down * 60 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) {
          transform.Rotate(Vector3.up * 60 * Time.deltaTime);
        }
    }
}
