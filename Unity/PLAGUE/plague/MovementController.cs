using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
using MoonSharp.Interpreter;

public class MovementController : MonoBehaviour
{
    public bool AmisiaAttack = false;
    public float voice = 0.3f;
    private float runSpeed = 8;
    private float jumpHeight = 20000;
    private bool jumping = false;
    private bool attacking = false;
    private bool Hit = false;
    private bool IsGround = true;
    Rigidbody2D body;
    Animator animator;
    AudioSource AmisiaVoice;
    bool front = true;
    public int hp = 0;
    public int max_hp = 0;
    public Image hp_bar;
    public AudioClip jumpvoice;
    static bool add = false;
    public static Flowchart flowchartManager;
    [SerializeField] Animator AmisiaAttackingHip;
    // Start is called before the first frame update
    void Awake()
    {
        if (!AmisiaAttack)
            animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        max_hp = 10;
        hp = max_hp;
    }
    void Update()
    {
        front = GameObject.Find("Amisia").transform.gameObject.GetComponent<AmisiaController>().getFace();
        if (front)
        {
            Vector3 scale = transform.localScale;
            scale.x = -0.5f;
            transform.localScale = scale;
        }
        else
        {
            Vector3 scale = transform.localScale;
            scale.x = 0.5f;
            transform.localScale = scale;
        }
        attacking = GameObject.Find("Amisia").transform.gameObject.GetComponent<AmisiaController>().Drawing();
        AmisiaVoice = GameObject.Find("Amisiavoice").transform.gameObject.GetComponent<AudioSource>();
        StateMachine();
        SetJumpState();   
        //hp_bar.transform.localScale = new Vector3((float)hp / (float)max_hp, hp_bar.transform.localScale.y, hp_bar.transform.localScale.z);//血條
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Jump();
        Move();
        movementController(); 
        StateMachine();
        //SetJumpState();
    }
    void SetJumpState()
    {
        if(Mathf.Abs(body.velocity.y) > 0.1)
        {
            IsGround = false;   
        }
        else if (Mathf.Abs(body.velocity.y) < 0.1)
        {
            IsGround = true;
        }
    }
    void StateMachine()
    {
        if(attacking)
            AmisiaAttackingHip.SetFloat("MoveSpeed", Mathf.Abs(body.velocity.x));
        else
        {
            animator.SetFloat("MoveSpeed", Mathf.Abs(body.velocity.x));
            animator.SetBool("IsGround", IsGround);
        }
    }
    void Jump()
    {
        if (body.velocity.y == 0f)
        {
            //Debug.Log("Is ground");
            if (Input.GetButton("Jump") && !add)
            {
                body.AddForce(new Vector2(0, jumpHeight));
                add = true;
            }
        }
        else
        {    
            add = false;
        }
    }
    void Jumpvoice()
    {
        AmisiaVoice.PlayOneShot(jumpvoice,voice);
    }
    public void Move()
    {
        float horizontaDirection = Input.GetAxis("Horizontal");
        float speed = horizontaDirection * runSpeed;//給移動的值
        body.velocity = new Vector2(speed, body.velocity.y);//
        if (speed != 0f)
        {
            Vector3 scale = transform.localScale;
            scale.x = Mathf.Sign(body.velocity.x) == 1f ? -0.5f : 0.5f;
            transform.localScale = scale;
        }
    }
    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("對話中"); }
    }
    void movementController()
    {
        if (!Talkable.isTalking)//沒對話時，可以移動(對話時，無法移動)
        {
            Jump();
            Move();
        }
        else//對話時，剛體取消
        {
            body.Sleep();
        }
    }
    /*void OnCollisionStay2D(UnityEngine.Collision2D co)
    {
        if (co.gameObject.tag == "Ground" && co.contacts[0].normal == Vector2.up)
        {
            isGround = true;
            drop = false;
        }      
    }*/
    void OnCollisionEnter2D(UnityEngine.Collision2D coll)
    {
        if (coll.gameObject.tag == "Weapon")
        {
            hp -= 1;
        }
    }
}
