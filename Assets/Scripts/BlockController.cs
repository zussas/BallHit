using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (count > 1)
        {
            this.count -= 1;
        }
        else if (count == 1)
        {
            Destroy(this.gameObject);
        }
    }

    public int CountNumber()
    {
        return count;
    }
}
