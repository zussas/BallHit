using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;

    Vector2 dir;
    bool move;


    // Update is called once per frame
    void Update()
    {
        // ボタンクリック時、クリック方向にボールを移動
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 startPos = new Vector3(this.transform.position.x, this.transform.position.y);
            Vector2 endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dir = (endPos - startPos).normalized;
            move = true;
        }
        else
        {
            move = false;
        }
    }

    private void FixedUpdate()
    {
        if (move)
        {
            this.GetComponent<Rigidbody2D>().AddForce(dir * speed);
        }
    }
}
