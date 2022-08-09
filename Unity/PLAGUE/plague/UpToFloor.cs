using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpToFloor : MonoBehaviour
{
    public GameObject Floor1;
    public GameObject Floor2;
    public GameObject UpFloor1Detect;
    public GameObject UpFloor2Detect;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Floor1" && Input.GetKeyDown(KeyCode.S))
        {
            Floor1.SetActive(false);
        }
        if (collision.gameObject.tag == "Floor2" && Input.GetKeyDown(KeyCode.S))
        {
            Floor2.SetActive(false);
        }
        if (collision.gameObject.tag == "FloorDectect1"|| collision.gameObject.tag == "FloorDectect2")
        {
            Floor1.SetActive(true);
            Floor2.SetActive(true);
            UpFloor1Detect.SetActive(false);
            UpFloor2Detect.SetActive(false);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor1"|| collision.gameObject.tag == "Floor2")
        {
            UpFloor1Detect.SetActive(true);
            UpFloor2Detect.SetActive(true);
        }

    }
}
