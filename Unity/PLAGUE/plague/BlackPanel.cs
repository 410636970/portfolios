using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackPanel: MonoBehaviour
{
    Animator animator;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Over"))
        {
            Panel.SetActive(true);
            SceneManager.LoadScene("Knight Challenge");
        }
    }
}
