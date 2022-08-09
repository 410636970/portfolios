using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackSide : MonoBehaviour
{
    public GameObject Side;
    public GameObject restriction;
    Animator animator;

    // Start is called before the first frame update
    public void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Over"))
        {
            restriction.SetActive(false);
            Side.SetActive(false);
        }
    }
}
