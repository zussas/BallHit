using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockTextController : MonoBehaviour
{
    GameObject block;
    GameObject text;
    Vector2 blockPos;

    // Start is called before the first frame update
    void Start()
    {
        // テキストの位置をブロックに合わせる
        block = GameObject.Find("Block");
        blockPos = block.transform.position;
        text = GameObject.Find("Text");
        text.transform.position = blockPos;

        // ブロックの count 番号をテキストに反映
        int count = block.GetComponent<BlockController>().CountNumber();
        text.GetComponent<Text>().text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
