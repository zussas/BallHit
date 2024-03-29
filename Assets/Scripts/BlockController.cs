﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public int count;
    int randomCount;

    // Start is called before the first frame update
    void Start()
    {
        randomCount = Random.Range(1, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (randomCount > 1)
         {
             this.randomCount -= 1;
         }
         else if (randomCount == 1)
         {
               if (collision != null)
               {
                    // 自身の持つテキストを消去
                    GameObject blockText = GameObject.Find("Text");
                    Destroy(blockText);

                    // 自身のブロックを消去
                    Destroy(this.gameObject);
               }
          }
    }

    public int CountNumber()
    {
        return randomCount;
    }
}
