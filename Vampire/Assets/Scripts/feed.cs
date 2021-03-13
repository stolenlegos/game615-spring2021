using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feed : MonoBehaviour
{
  private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
      gameObject.transform.LookAt(player.transform);
    }

    void OnTriggerEnter (Collider other)
    {
        gameObject.SetActive(false);
    }
}
