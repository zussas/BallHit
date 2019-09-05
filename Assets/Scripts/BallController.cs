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
            //Vector2 ballWay = new Vector2(3.0f, 4.0f);

            Vector2 startPos = new Vector3(this.transform.position.x, this.transform.position.y);
            Debug.Log("starPos : " + startPos);
            Vector2 endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("endPos : " + endPos);

            Vector2 dir = endPos - startPos;
            Debug.Log("dir : " + dir);


            this.GetComponent<Rigidbody2D>().AddForce(dir * speed);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("衝突");
        Destroy(collision.gameObject);
    }
}
