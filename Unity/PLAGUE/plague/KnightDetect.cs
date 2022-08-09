using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightDetect : MonoBehaviour
{
    // Start is called before the first frame update
    public bool moveToLeft = false;
    public float speed;
    private int count = 0;
    Rigidbody2D body;
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

    }
    void FixedUpdate()
    {
        if (count == 0)//初始動力
        {
            body.AddForce(Vector2.right * speed);
            count++;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!moveToLeft && collision.gameObject.tag == "RangeR")
        {
            moveToLeft = true;
            body.AddForce(Vector2.left * speed);
        }
        else if (moveToLeft && collision.gameObject.tag == "RangeL")
        {
            moveToLeft = false;
            body.AddForce(Vector2.right * speed);
        }
    }
}
