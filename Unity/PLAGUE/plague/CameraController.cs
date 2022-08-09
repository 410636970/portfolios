using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject maincamera;
    public GameObject Camera;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    // Start is called before the first frame update
    Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        maincamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetBool("start", start);
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Over"))
        {           
            maincamera.SetActive(true);
            Camera.SetActive(false);
            panel1.SetActive(false);
            panel2.SetActive(false);
            panel3.SetActive(true);
            panel4.SetActive(true);
        }
    }
}
