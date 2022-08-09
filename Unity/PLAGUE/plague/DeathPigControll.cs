using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class DeathPigControll : MonoBehaviour
{
    public GameObject pig;
    public GameObject deathpigimage;
    public GameObject deathpig;
    [SerializeField] Animator deathpiganimation;
    public Flowchart flowchart;
    public GameObject block;
    public GameObject Panel0;
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;
    public GameObject Panel5;
    public GameObject Panel6;
    public GameObject Father1;
    public GameObject Father2;
    [SerializeField] Animator PanelAnimation;
    [SerializeField] Animator PanelAnimation1;
    [SerializeField] Animator PanelAnimation2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Father == 0)
        {
            if (PanelAnimation.GetCurrentAnimatorStateInfo(0).IsName("Over"))//開場時立刻對話
            {
                block.SetActive(false);
                Panel0.SetActive(false);
                Father = 1;
                Amisia = 1;
            }
        }
        if (PanelAnimation1.GetCurrentAnimatorStateInfo(0).IsName("Over"))//上下黑幕動畫結束後，準備接shock
        {
            Panel1.SetActive(false);
            Panel2.SetActive(false);
            Panel3.SetActive(true);
            Panel4.SetActive(true);
            deathpigimage.SetActive(false);
            deathpig.SetActive(true);
            Father1.SetActive(false);
            Father2.SetActive(true);
            Father = 3;
            Amisia = 3;
            cartoon = 1;//Shock
        }
        if (deathpiganimation.GetCurrentAnimatorStateInfo(0).IsName("Over"))//野鹿死亡的動畫結束後(shock)
        {
            deathpig.SetActive(false);
            Panel3.SetActive(false);
            Panel4.SetActive(false);
        }
        if(Father == 6)//控制傳入淡入動畫
        {
            Panel5.SetActive(true);
        }
        if (PanelAnimation2.GetCurrentAnimatorStateInfo(0).IsName("Over"))//淡入動畫結束後轉場
        {
            Panel5.SetActive(false);
            Panel6.SetActive(true);
            SceneManager.LoadScene("Home");
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "pig")
        {
            pig.SetActive(false);
            deathpigimage.SetActive(true);
        }
        if (collision.gameObject.tag == "Player")
        {
            Deer = 2;
        }
    }
    public float Deer
    {
        get { return flowchart.GetFloatVariable("野鹿"); }
        set { flowchart.SetFloatVariable("野鹿", value); }
    }
    public float Father
    {
        get { return flowchart.GetFloatVariable("Father騎士考驗"); }
        set { flowchart.SetFloatVariable("Father騎士考驗", value); }
    }
    public float Amisia
    {
        get { return flowchart.GetFloatVariable("主角騎士考驗"); }
        set { flowchart.SetFloatVariable("主角騎士考驗", value); }
    }
    public float cartoon
    {
        get { return flowchart.GetFloatVariable("動畫"); }
        set { flowchart.SetFloatVariable("動畫", value); }
    }
}
