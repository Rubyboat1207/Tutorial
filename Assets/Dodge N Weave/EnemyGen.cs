using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGen : MonoBehaviour
{
    public GameObject enemy;

    public int bozo = 0;

    public float timer;
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0) {
            bozo++;
            timer = 1;
            GameObject instance = GameObject.Instantiate(enemy, transform);
            instance.transform.position += new Vector3(0, Random.Range(-4, 4));
            WalkLeft.speed -= 0.1f;
        }
    }
}
