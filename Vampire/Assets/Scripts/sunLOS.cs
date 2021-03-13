using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunLOS : MonoBehaviour
{
    public GameObject vampire;
    public bool visible;
    public bool result;
    public string hello;
    private GameObject restartUI;
    private GameObject restartButton;
    private GameObject playerCharacter;
    private bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
      restartUI = GameObject.Find("RestartUI");
      restartButton = GameObject.Find("RestartButton");
      playerCharacter = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
      SunLOS();
    }

    private void SunLOS()
    {
      Vector3 origin = transform.position;
      Vector3 direction = vampire.transform.position;
      var playerControls = playerCharacter.GetComponent<playerMovement>();
      var playerMesh = playerCharacter.GetComponent<MeshRenderer>();

      Debug.DrawRay(origin, direction - origin, Color.red);
      Ray ray = new Ray(origin, direction - origin);

      RaycastHit hit;

      result = Physics.Raycast(ray, out hit);

      Debug.DrawRay(ray.origin, hit.point - ray.origin, Color.yellow);
      if (Physics.Raycast(ray, out hit))
      {
        hello = hit.collider.ToString();
        if (alive)
        {
          if (hello == "Player (UnityEngine.SphereCollider)")
          {
            //stops player movement and shows UI to restart level
            visible = true;
            restartUI.SetActive(true);
            restartButton.SetActive(true);
            playerControls.enabled = false;
            playerMesh.enabled = false;
            alive = false;
          } else {
            visible = false;
            restartUI.SetActive(false);
            restartButton.SetActive(false);
            playerControls.enabled = true;
            playerMesh.enabled = true;
          }
        } else {
          visible = true;
          restartUI.SetActive(true);
          restartButton.SetActive(true);
          playerControls.enabled = false;
          playerMesh.enabled = false;
          alive = false;
        }
      }
    }
}
