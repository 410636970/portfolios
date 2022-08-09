using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
    bool front = true;
    
    void Start()
    {
        //front = GameObject.Find("UnityChanSoul").transform.gameObject.GetComponent<MovementController>().getFace();
    }
    // Update is called once per frame
    void Update()
    {

        if (front)
        {
            this.gameObject.transform.position += new Vector3(0.5f * Time.deltaTime * 60, 0, 0);
        }
        else
        {
            this.gameObject.transform.position += new Vector3(-0.5f * Time.deltaTime * 60, 0, 0);
        }  
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
