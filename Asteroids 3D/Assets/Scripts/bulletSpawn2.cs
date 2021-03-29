using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawn2 : MonoBehaviour
{
  public GameObject bulletPrefab;
  public float cooldown;
  GameObject ship;
  Rigidbody srb;
    // Start is called before the first frame update
    void Start()
    {
      cooldown = 0.2f;
      ship = GameObject.Find("default");
      srb = ship.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButton(0))
      {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0)
        {
          GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
          Rigidbody brb = bullet.GetComponent<Rigidbody>();
          brb.velocity = srb.velocity;
          cooldown = 0.2f;
        }
      }
      /*if (cooldown <= 0)
      {
        if (Input.GetMouseButton(0))
        {
          GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
          cooldown = 0.395f;
        }
      }*/
    }
}
