using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class NPCmove : MonoBehaviour
{
    public Flowchart flowchart;
    public float Speed = 7;
    private bool MoveRight = false;
    public GameObject FatherBlockInDK;
    Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        DK();
        chapter1();
    }
    public float Father
    {
        get { return flowchart.GetFloatVariable("Father騎士考驗"); }
        set { flowchart.SetFloatVariable("Father騎士考驗", value); }
    }
    public float Amisia
    {
        get { return flowchart.GetFloatVariable("主角騎士考驗"); }
        set { flowchart.SetFloatVariable("主角騎士考驗", value); }
    }
    public bool FatherRun
    {
        get { return flowchart.GetBooleanVariable("跑"); }
        set { flowchart.SetBooleanVariable("跑", value); }
    }
    public bool chapterone
    {
        get { return flowchart.GetBooleanVariable("章節一"); }
        set { flowchart.SetBooleanVariable("章節一", value); }
    }
    public bool DarkForest
    {
        get { return flowchart.GetBooleanVariable("黑暗森林"); }
        set { flowchart.SetBooleanVariable("黑暗森林", value); }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "FatherRun")
        {
            FatherRun = false;
        }
    }
    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if(collision.gameObject.tag == "KnightTest")
        {
            FatherBlockInDK.SetActive(false);
            Father = 4;
            Amisia = 4;
        }
    }
    void chapter1()
    {
        if(chapterone)//只會往右走的Father
        {
            if (FatherRun == true)
            {
                MoveRight = true;
            }
            else
                MoveRight = false;
            if (MoveRight == true)
            {
                body.AddForce(Vector2.right * 200);
                MoveRight = false;
            }
        }
    }
    void DK()
    {
        if(DarkForest)
        {
            if(Father == 3)
            {
                body.AddForce(Vector2.right * 200);          
            }
        }
    }
}
