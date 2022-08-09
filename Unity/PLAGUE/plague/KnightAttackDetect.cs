using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightAttackDetect : MonoBehaviour
{
    [SerializeField] Animator KnightModel;
    private bool Attack = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetMachine();
        if (Attack)
        {
            if (KnightModel.GetCurrentAnimatorStateInfo(0).IsName("AttackOver"))
            {
                Attack = false;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Playertrigger")
        {
            Attack = true;
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Playertrigger")
        {
            Attack = true;
        }
    }
    void SetMachine()
    {
        KnightModel.SetBool("Attack",Attack);
    }
}
