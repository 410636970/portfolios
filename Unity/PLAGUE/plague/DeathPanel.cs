using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPanel : MonoBehaviour
{
    public GameObject MenuButton;
    public GameObject Restart;
    public GameObject ExitGame;
    public GameObject GameMenu;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Time.timeScale = 0;
        MenuButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Over"))
        {
            GameMenu.SetActive(true);
            ExitGame.SetActive(true);
            Restart.SetActive(true);
        }
    }
}
