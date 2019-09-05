using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // ボタンクリック時、クリック方向にボールを移動
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 startPos = new Vector3(this.transform.position.x, this.transform.position.y);
            Vector2 endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 dir = endPos - startPos;
            this.GetComponent<Rigidbody2D>().AddForce(dir * speed);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("衝突");
        if (collision.gameObject.tag == "Block")
        {
            Destroy(collision.gameObject);
        }
    }
}
