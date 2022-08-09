using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class KnightTest : MonoBehaviour
{
    // Start is called before the first frame update
    private bool testfinish = false;
    private bool gamefinish = false;
    public Flowchart flowchart;
    public GameObject timecounter;
    public GameObject wlidpig;
    public GameObject testcontroll;
    public GameObject paneltop;
    public GameObject paneldown;
    public GameObject paneltop1;
    public GameObject paneldown1;
    public GameObject block;
    public GameObject Panel;
    public GameObject Panel2;

    Animator animator;
    [SerializeField] Animator tenseconds;
    [SerializeField] Animator panelanimation;
    [SerializeField] Animator panel2animation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fathernumber == 4)
        {
            timecounter.SetActive(true);
            if (tenseconds.GetCurrentAnimatorStateInfo(0).IsName("Over"))
            {
                fathernumber = 5;
                amisianumber = 5;
                timecounter.SetActive(false);
                testcontroll.SetActive(false);
                testfinish = true;
                paneldown.SetActive(true);
                paneltop.SetActive(true);
            }
        }
        if(fathernumber == 6)
        {
            paneldown1.SetActive(false);
            paneltop1.SetActive(false);
        }
        if(Deer == 1)
        {
            wlidpig.SetActive(true);
        }
        /*if (tenseconds.GetCurrentAnimatorStateInfo(0).IsName("Over"))
        {
            fathernumber = 5;
            amisianumber = 5;
            timecounter.SetActive(false);
            testcontroll.SetActive(false);
            paneldown.SetActive(true);
            paneltop.SetActive(true);
        }*/
        if(testfinish)//測試結束
        {
            if (panelanimation.GetCurrentAnimatorStateInfo(0).IsName("Over"))
            {
                paneldown.SetActive(false);
                paneltop.SetActive(false);
                paneldown1.SetActive(true);
                paneltop1.SetActive(true);
                testfinish = false;
            }
        }
        if(gamefinish)
        {
            if(panel2animation.GetCurrentAnimatorStateInfo(0).IsName("Over"))
            {
                Panel.SetActive(false);
                Panel2.SetActive(true);
                SceneManager.LoadScene("Dark Forest");
                gamefinish = false;
            }
        }
        
        if(Deer == 2)
        {
            block.SetActive(false);
        }
    }

    public float fathernumber
    {
        get { return flowchart.GetFloatVariable("Father騎士考驗"); }
        set { flowchart.SetFloatVariable("Father騎士考驗", value); }
    }
    public float amisianumber
    {
        get { return flowchart.GetFloatVariable("主角騎士考驗"); }
        set { flowchart.SetFloatVariable("主角騎士考驗", value); }
    }
    public float Deer
    {
        get { return flowchart.GetFloatVariable("野鹿"); }
        set { flowchart.SetFloatVariable("野鹿", value); }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Panel.SetActive(true);
            gamefinish = true;
        }
    }
}
