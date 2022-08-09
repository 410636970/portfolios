using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackPanelFadeIn : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject Panel;
    public GameObject restriction;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Over"))
        {
            Panel.SetActive(false);
            restriction.SetActive(false);
        }
    }
}
