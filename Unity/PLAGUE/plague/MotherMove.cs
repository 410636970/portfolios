using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class MotherMove : MonoBehaviour
{
    public float Speed;
    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = this.GetComponent<Rigidbody2D>();
    }
    public Flowchart flowchart;
    // Update is called once per frame
    void Update()
    {
        if(Mother == 2)
        {
            body.AddForce(Vector2.right * Speed);
            Mother = 3;
        }
    }
    public int Mother
    {
        get { return flowchart.GetIntegerVariable("母親"); }
        set { flowchart.SetIntegerVariable("母親", value); }
    }
    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if(collision.gameObject.tag == "NPC")
        {
            Mother = 3;
        }
    }
}
