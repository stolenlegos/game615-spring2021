using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
  public float speed;
  GameObject player;
  float speedTimer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("default");
        speedTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(player.transform);
        transform.position += transform.forward * Time.deltaTime * speed;
        speedTimer += Time.deltaTime;
        if (speedTimer > 10)
        {
          speed *= 1.1f;
          speedTimer = 0;
        }
    }
}
