using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Test : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        Vector2 v2 = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        Vector2 newPoint = new Vector2(v2.x - 0.5f, v2.y - 0.5f);
        Vector2 temp = new Vector2(newPoint.x * 1080, newPoint.y * 1920);
        transform.right = temp;
    }
}