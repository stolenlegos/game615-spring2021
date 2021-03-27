using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotation : MonoBehaviour
{
  float rotationX;
  float rotationY;
  float rotationZ;
    // Start is called before the first frame update
    void Start()
    {
        rotationX = Random.Range(-10, 10);
        rotationY = Random.Range(-10, 10);
        rotationZ = Random.Range(-10, 10);
    }

    // Update is called once per frame
    void Update()
    {
      transform.Rotate (Vector3.up * (rotationY * Time.deltaTime));
      transform.Rotate (Vector3.forward * (rotationZ * Time.deltaTime));
      transform.Rotate (Vector3.left * (rotationX * Time.deltaTime));
    }
}
