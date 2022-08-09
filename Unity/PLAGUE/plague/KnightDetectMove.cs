using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightDetectMove : MonoBehaviour
{
    private float Bulletposx;
    private int keyframe = 0;
    public GameObject Range;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Bulletposx = collision.gameObject.transform.position.x;
        keyframe++;
        if (collision.tag == "Arrow" && Bulletposx < this.transform.position.x && keyframe < 5)
        {
            Debug.Log("YES");
            Vector2 newPoint = new Vector2(this.transform.position.x - 1.5f, this.transform.position.y);
            this.transform.position = newPoint;
            Debug.Log("左");
        }
        else if (collision.gameObject.tag == "Arrow" && Bulletposx > this.transform.position.x && keyframe < 5)
        {
            Vector2 newPoint = new Vector2(this.transform.position.x + 1.5f, this.transform.position.y);
            this.transform.position = newPoint;
            Debug.Log("右");
        }
        else
            keyframe = 0;
    }
}
