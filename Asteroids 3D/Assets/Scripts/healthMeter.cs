using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthMeter : MonoBehaviour
{
  float health;
  private GameObject bulletspawn1;
  private GameObject bulletspawn2;
  public GameObject restartButton;
  public Slider healthBar;
    // Start is called before the first frame update
    void Start()
    {
      health = 100;
      bulletspawn1 = GameObject.Find("Bullet Spawn 1");
      bulletspawn2 = GameObject.Find("Bullet Spawn 2");
    }

    void Update ()
    {
      var PlayerControls = gameObject.GetComponent<newShipMovement>();
      var PlayerShoot1 = bulletspawn1.GetComponent<bulletSpawn1>();
      var PlayerShoot2 = bulletspawn2.GetComponent<bulletSpawn2>();
      var PlayerMesh = gameObject.GetComponent<MeshRenderer>();

      healthBar.value = health;

      if (health <= 0)
      {
        restartButton.SetActive(true);
        PlayerControls.enabled = false;
        PlayerMesh.enabled = false;
        PlayerShoot1.enabled = false;
        PlayerShoot2.enabled = false;
      } else
      {
        restartButton.SetActive(false);
      }


    }

    // Update is called once per frame
    void OnTriggerStay (Collider other)
    {
        if (other.tag == "LevelBounds")
        {
          health -= 5 * Time.deltaTime;
        }

        if (other.tag == "ENEMY")
        {
          health -= 20 * Time.deltaTime;
        }
    }
}
