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
        rotationX = Random.Range(-0.5f, 0.5f);
        rotationY = Random.Range(-0.5f, 0.5f);
        rotationZ = Random.Range(-0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
      transform.Rotate (Vector3.up * (rotationY * Time.deltaTime));
      transform.Rotate (Vector3.forward * (rotationZ * Time.deltaTime));
      transform.Rotate (Vector3.left * (rotationX * Time.deltaTime));
    }
}
