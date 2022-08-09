using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousekeeperController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D m_rigidbody;
    Animator m_Animator;
    Transform m_tran;
    public GameObject Player;
    private float h = 0;
    private float v = 0;
    public SpriteRenderer[] m_SpriteGroup;
    public CharacterID characterID = CharacterID.NONE;
    private float UpdateTic = 0;
    private bool Hit = false;
    void Start()
    {
        m_rigidbody = this.GetComponent<Rigidbody2D>();
        m_Animator = this.transform.Find("model").GetComponent<Animator>();
        m_tran = this.transform;
        m_SpriteGroup = this.transform.Find("model").GetComponentsInChildren<SpriteRenderer>(true);
    }


    // Update is called once per frame
    void Update()
    {
        StateMachine();
        movechanger();
        UpdateTic += Time.deltaTime;
        //Debug.Log("MOVETEST");
        if (UpdateTic > 0.01f)
        {
            spriteOrder_Controller();
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
            m_Animator.SetFloat("MoveSpeed", Mathf.Abs(m_rigidbody.velocity.x));
            UpdateTic = 0;
        }
    }
    public int sortingOrder = 0;
    public int sortingOrderOrigine = 0;
    private float Update_Tic = 0;
    private float Update_Time = 0.1f;
    void spriteOrder_Controller()
    {
        Update_Tic += Time.deltaTime;
        if (Update_Tic > 0.1f)
        {
            sortingOrder = Mathf.RoundToInt(this.transform.position.y * 100);
            //Debug.Log("y::" + this.transform.position.y);
            //  Debug.Log("sortingOrder::" + sortingOrder);
            for (int i = 0; i < m_SpriteGroup.Length; i++)
            {
                m_SpriteGroup[i].sortingOrder = sortingOrderOrigine - sortingOrder;
            }
            Update_Tic = 0;
        }
    }
    void movechanger()
    {
        if (-0.005 < m_rigidbody.velocity.x && m_rigidbody.velocity.x < 0.005)//移動時不向主角觀看
        {
            if (Player.transform.position.x > this.transform.position.x)
            {
                Vector3 scale = transform.localScale;
                scale.x = -1f;
                transform.localScale = scale;
            }
            else
            {
                Vector3 scale = transform.localScale;
                scale.x = 1f;
                transform.localScale = scale;
            }
        }
        else if (m_rigidbody.velocity.x < -0.005)//左方移動面向左方
        {
            Vector3 scale = transform.localScale;
            scale.x = 1f;
            transform.localScale = scale;
        }
        else if (0.005 < m_rigidbody.velocity.x)//朝右方移動面向右方
        {
            Vector3 scale = transform.localScale;
            scale.x = -1f;
            transform.localScale = scale;
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Weapon")
        {
            Hit = true;
        }
    }
    void StateMachine()
    {
        m_Animator.SetBool("Hit",Hit);
    }
}
