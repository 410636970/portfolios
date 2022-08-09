using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class AmisiaController : MonoBehaviour
{

    // Start is called before the first frame update
    public float voice = 0.3f;
    public AudioClip drawingvoice;
    private bool IsWeapon = false;
    private bool IsAttack = false;
    private bool release = false;
    private bool test = false;
    private bool face = true;
    private float voiceonetime = 1;
    private int frame = 0;
    public GameObject bow;//弓
    [SerializeField] Animator AmisiaAttackingBody;
    [SerializeField] Animator AmisiaAttackingHip;
    [SerializeField] Animator AmisiaPlayer;
    [SerializeField] Rigidbody2D PlayerBody2D;
    public GameObject Attacking;
    public GameObject Player;
    public GameObject AmisiaVoice;
    public static Flowchart flowchartManager;
    bool death;
    AudioSource audiosource;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        death = GameObject.Find("Amisiavoice").transform.gameObject.GetComponent<Heart>().IsDeath();
        AnimationController();
        Location();
        if(!death)
            Attack();
        if (Input.GetKey(KeyCode.A))
            face = false;
        if (Input.GetKey(KeyCode.D))
            face = true;

    }
    void Attack()
    {
        if (!Talkable.isTalking && (Mathf.Abs(PlayerBody2D.velocity.y) == 0))
        {
            if (Input.GetMouseButtonDown(0) && IsWeapon == true)
            {
                release = false;
                IsAttack = true;
                Player.SetActive(false);
                Attacking.SetActive(true);
                audiosource = GameObject.Find("AmisiaAttacking").transform.gameObject.GetComponent<AudioSource>();
                AnimationController();
                audiosource.PlayOneShot(drawingvoice, voice);
            }
            if (Input.GetMouseButtonUp(0) && IsWeapon == true)
            {
                release = true;
                IsAttack = false;
                Bow.shooter.Shoot();
                Player.SetActive(true);
                Attacking.SetActive(false);
            }
        }
    }
    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("對話中"); }
    }
    void AnimationController()
    {
        if(IsAttack)
            AmisiaAttackingBody.SetBool("Release", release);
        AmisiaPlayer.SetBool("IsBow",IsWeapon);
        if (Input.GetKeyDown(KeyCode.LeftShift))//無任何攻擊動畫時按下左shift鍵切換武器
        {
            if (IsWeapon)
                IsWeapon = false;
            else
                IsWeapon = true;
        }
    }
    void Location()
    {
        if (!IsAttack)
        {
            AmisiaVoice.transform.position = Player.transform.position;
            Attacking.transform.position = Player.transform.position;
        }
        else
        {
            AmisiaVoice.transform.position = Attacking.transform.position;
            Player.transform.position = Attacking.transform.position;
        }
    }
    public bool getFace()
    {
        return face;
    }
    public bool Drawing()
    {
        return IsAttack;
    }
}
