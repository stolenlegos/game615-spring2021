using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBusForward : MonoBehaviour
{
  public float speed;
    // Start is called before the first frame update
    void Start()
    {
      speed = Random.Range(0.75f, 2.25f);
    }

    // Update is called once per frame
    void Update()
    {
      transform.position += -transform.forward * Time.deltaTime * speed;
    }
}
