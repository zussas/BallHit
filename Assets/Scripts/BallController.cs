using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("衝突");
        Destroy(collision.gameObject);
    }
}
