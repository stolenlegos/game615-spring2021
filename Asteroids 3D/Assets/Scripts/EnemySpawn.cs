using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
  public GameObject enemyPrefab;
  float timer;
  float gameTime;
  float wave;
    // Start is called before the first frame update
    void Start()
    {
      timer = 10;
      gameTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        gameTime += Time.deltaTime;

        if (gameTime < 60)
        {
          if (timer <= 0)
          {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            timer = 60;
            wave += 1;
          }
        } if (gameTime > 60 && gameTime < 120)
        {
          if (timer <= 0)
          {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            timer = 50;
            wave += 1;
          }
        } if (gameTime > 120 && gameTime< 180)
        {
          if (timer <= 0)
          {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            timer = 40;
            wave += 1;
          }
        } if (gameTime > 180 && gameTime < 240)
        {
          if (timer <= 0)
          {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            timer = 30;
            wave += 1;
          }
        } if (gameTime > 240 && gameTime < 300)
        {
          if (timer <= 0)
          {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            timer = 20;
            wave += 1;
          }
        } if (gameTime > 300 && gameTime < 360)
        {
          if (timer <= 0)
          {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            timer = 10;
            wave += 1;
          }
        } if (gameTime > 360 && gameTime < 420)
        {
          if (timer <= 0)
          {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            timer = 5;
            wave += 1;
          }
        } if (gameTime > 420)
        {
          if (timer <= 0)
          {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            timer = 2;
            wave += 1;
          }
        }
    }
}
