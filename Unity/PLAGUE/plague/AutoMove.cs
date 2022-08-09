using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{

    private Transform son;

    public bool moveToLeft = false;
    public float speed;
    public float moverange; //移動範圍
    Vector3 StartPosition;
    Quaternion quate = Quaternion.identity;
    private float sonposx;
    private float startx;
    private void Awake()
    {
        startx = this.transform.position.x;
    }
    private void Start()
    {
        son = this.transform;
        son.position = this.transform.position;
        //Debug.Log(this.transform.position);
    }
    private void FixedUpdate()
    {
        Move();
        sonposx = this.gameObject.transform.position.x;
        quate.eulerAngles = new Vector3(0, 0, 0);
        this.gameObject.transform.rotation = quate;
    }

    private void Move()
    {
        if (son.position.x < -moverange+startx && moveToLeft)
        {
            moveToLeft = false;
        }
        if (son.position.x >= moverange+startx && !moveToLeft)
        {
            moveToLeft = true;
        }
        son.position += (moveToLeft ? Vector3.left : Vector3.right) * Time.deltaTime * speed;
    }
}