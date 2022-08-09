using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.Assertions.Must;

public class DeerMove : MonoBehaviour
{
    private bool DeerLimitEnter = true;
    private bool DeerBlock1 = true;
    private bool DeerBlock2 = true;
    Rigidbody2D body;
    Animator animator;
    public GameObject deathpig;
    public GameObject deathpigimage;
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;
    public GameObject DeerBlockInKnightTest;//KnightTest
    public GameObject DeerBlockInDarkForest1;
    public GameObject DeerBlockInDarkForest2;
    public Flowchart flowchart;
    [SerializeField] Animator PanelAnimation;


    // Start is called before the first frame update
    public float Deer
    {
        get { return flowchart.GetFloatVariable("野鹿"); }
        set { flowchart.SetFloatVariable("野鹿", value); }
    }
    public float cartoon
    {
        get { return flowchart.GetFloatVariable("動畫"); }
        set { flowchart.SetFloatVariable("動畫", value); }
    }
    public bool KnightTest
    {
        get { return flowchart.GetBooleanVariable("騎士考驗"); }
        set { flowchart.SetBooleanVariable("騎士考驗", value); }
    }
    public bool DarkForest
    {
        get { return flowchart.GetBooleanVariable("黑暗森林"); }
        set { flowchart.SetBooleanVariable("黑暗森林", value); }
    }

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movechanger();
        DeerMovement();
        StateMachine();

    }
    void movechanger()
    {
        if (body.velocity.x > 0)//朝右方移動面向右方
        {
            Vector3 scale = transform.localScale;
            scale.x = 0.02f;
            transform.localScale = scale;
        }
        else//左方移動面相左方
        {
            Vector3 scale = transform.localScale;
            scale.x = -0.02f;
            transform.localScale = scale;
        }
    }
    void DeerMovement()
    {
        if(KnightTest)
        {
            if(Deer == 1)
            {
                body.AddForce(Vector2.left * 15);
            }
            if(Deer == 2)
            {
                body.AddForce(Vector2.right * 15);
            }
        }
        if(DarkForest)
        {
            if(Deer == 1)
            {
                body.AddForce(Vector2.right * 20);
            }
        }
    }
    void StateMachine()
    {
        animator.SetFloat("MoveSpeed", Mathf.Abs(body.velocity.x));
    }
    void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Deer != 2 && DarkForest)//Dark Forest，主角靠近野鹿時，野鹿跑
        {
            Deer = 1;
        }
        if (collision.gameObject.tag == "Player" && Deer == 2 && DarkForest)//Dark Forest，野鹿已在老鼠洞上，主角靠近上下黑幕開啟
        {
            Panel1.SetActive(true);
            Panel2.SetActive(true);
        }
    }
    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.tag == "NPC" && KnightTest && DeerLimitEnter)//KnightTest，野鹿撞到鹿控制暫停
        {
            Deer = 0;
            DeerLimitEnter = false;
            DeerBlockInKnightTest.SetActive(false);
        }
        if(collision.gameObject.tag == "NPC" && DarkForest)//Dark Forest，野鹿撞到鹿控制暫停
        {
            if(DeerBlock1)
            {
                Deer = 0;
                DeerBlock1 = false;
                DeerBlockInDarkForest1.SetActive(false);
            }
            if (DeerBlock2)
            {
                Deer = 0;
                DeerBlock2 = false;
                DeerBlockInDarkForest2.SetActive(false);
            }
        }
    }
}
