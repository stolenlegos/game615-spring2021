using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
  public float enemyhealth;
    // Start is called before the first frame update
    void Start()
    {
      enemyhealth = 100;
    }

    void Update()
    {
      if (enemyhealth <= 0)
      {
        Destroy(gameObject);
      }
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
          enemyhealth -= 20;
        }
    }
}
