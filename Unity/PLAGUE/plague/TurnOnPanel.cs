using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnPanel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Panel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PanelOn()
    {
        Panel.SetActive(true);
    }
}
