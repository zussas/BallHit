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
        // ボタン離す時、クリック方向にボールを移動
        if (Input.GetMouseButtonUp(0))
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

        // y座標が-4.5以下の時ストップ
        if (this.transform.position.y < -4.5)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            this.transform.position = new Vector3(transform.position.x, -4.5f, 0);

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
