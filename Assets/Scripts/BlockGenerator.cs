using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockGenerator : MonoBehaviour
{
    public GameObject blockPrefab;
    GameObject block;
    GameObject blockText;

    // Start is called before the first frame update
    void Start()
    {
        // ブロックの生成
        block = Instantiate(blockPrefab) as GameObject;
        int px = 2;
        int py = 2;
        block.transform.position = new Vector3(px, py, 0);

        // テキストの位置をブロックに合わせる
        blockText= GameObject.Find("Text");
        blockText.transform.position = block.transform.position;

        // ブロックの count 番号をテキストに反映
        int count = block.GetComponent<BlockController>().CountNumber();
        blockText.GetComponent<Text>().text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //衝突時にテキストをカウントダウン
        int count = block.GetComponent<BlockController>().CountNumber();
        blockText.GetComponent<Text>().text = count.ToString();
    }
}
