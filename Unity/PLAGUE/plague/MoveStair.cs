using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStair : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            var target = c.gameObject.transform;
            target.SetParent(this.transform);
        }
    }

    void OnCollisionExit2D(Collision2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            var target = c.gameObject.transform;
            var original = target.GetComponent<TransformState>().OriginalParent;
            target.SetParent(original);
        }
    }
}