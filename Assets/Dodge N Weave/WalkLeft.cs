using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkLeft : MonoBehaviour
{
    public static float speed = -5;
    void Update()
    {
        transform.position += new Vector3(Time.deltaTime * WalkLeft.speed, 0);

        if(transform.position.x < -10) {
            GameObject.Destroy(this.gameObject);
        }
    }
}
