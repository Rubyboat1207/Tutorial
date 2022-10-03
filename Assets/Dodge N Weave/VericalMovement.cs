using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VericalMovement : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(0, Input.GetAxis("Vertical")) * Time.deltaTime * 5;
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4, 4));
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
