using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBus : MonoBehaviour
{
  public GameObject busPrefab;
  public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 30;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
          SpawnBus();
          timer = 30;
        }
    }

    void SpawnBus()
    {
      GameObject bus = Instantiate(busPrefab, transform.position, transform.rotation);
    }
}
