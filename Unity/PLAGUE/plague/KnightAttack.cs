using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightAttack : MonoBehaviour
{
    [SerializeField] Animator KightAnimator;

    private bool Attack = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StateMachine();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "NPC")
        {
            Attack = true;
        }
    }
    void StateMachine()
    {
        KightAnimator.SetBool("Attack", Attack);
    }
}
