using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletController2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
    bool front = true;
    //Vector3 mousepos = Camera.main.ScreenToViewportPoint(Input.mousePosition);


    void Start()
    {
        //front = GameObject.Find("UnityChanSoul").transform.gameObject.GetComponent<MovementController>().getFace();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 mousepos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        if (front)
        {
            //this.gameObject.transform.position += new Vector3(0.5f * Time.deltaTime * 60, 0.2f * Time.deltaTime * 60, 0);
            this.gameObject.transform.position += new Vector3(0.5f * Time.deltaTime * 60, mousepos.y * Time.deltaTime * 60, 0);
        }
        else
        {
            //this.gameObject.transform.position += new Vector3(-0.5f * Time.deltaTime*60, 0.2f * Time.deltaTime * 60, 0);
            this.gameObject.transform.position += new Vector3(-0.5f * Time.deltaTime * 60, mousepos.y * Time.deltaTime * 60, 0);
        }
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(this.gameObject);
        }      
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "apple")
        {
            Destroy(this.gameObject);
        }
    }
}
