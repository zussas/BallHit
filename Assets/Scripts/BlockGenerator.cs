using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public GameObject blockPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject block = Instantiate(blockPrefab) as GameObject;
        int px = 0;
        int py = 0;
        block.transform.position = new Vector3(px, py, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
