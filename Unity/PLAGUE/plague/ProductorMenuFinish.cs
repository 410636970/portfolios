using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductorMenuFinish : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Panel;
    public GameObject Menu;
    public GameObject self;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void turnoff()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        Panel.SetActive(true);
        Menu.SetActive(true);
        self.SetActive(false);
    }
}
