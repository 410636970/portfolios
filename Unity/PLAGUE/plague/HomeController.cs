using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class HomeController : MonoBehaviour
{
    public Flowchart flowchart;
    // Start is called before the first frame update
    public GameObject StartPanel;
    [SerializeField] Animator StartPanelAnimation;//開場淡出動畫
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Father == 0 && Amisia == 0)
        {
            if (StartPanelAnimation.GetCurrentAnimatorStateInfo(0).IsName("Over"))
            {
                StartPanel.SetActive(false);
                Father = 1; 
                Amisia = 1;
            }
        }
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
}
