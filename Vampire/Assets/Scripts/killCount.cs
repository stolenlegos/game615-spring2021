using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killCount : MonoBehaviour
{
  public float kills = 0;
  private GameObject winUI;
  private GameObject playerCharacter;
  private Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {
      winUI = GameObject.Find("WinUI");
      winUI.SetActive(false);
      playerCharacter = GameObject.Find("Player");
      playerRB = playerCharacter.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      var playerControls = playerCharacter.GetComponent<Rigidbody>();

      if (kills >= 20)
      {
        playerRB.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        winUI.SetActive(true);
      }
    }

    void OnTriggerEnter (Collider other)
    {
      if (other.tag == "enemy")
      {
        kills += 1;
      }
    }
}
