using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class End : MonoBehaviour
{
    public Flowchart flowchart;
    public GameObject EndPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (end)
            EndPanel.SetActive(true);
    }
    public bool end
    {
        get { return flowchart.GetBooleanVariable("end"); }
        set { flowchart.SetBooleanVariable("end", value); }
    }
}
