using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Panel;
    float leftTime = 0f;
    bool open = false;
    public GameObject Heart;
    private void Start()
    {
        //   leftTime = float.Parse(GameObject.Find("Time").GetComponent<UnityEngine.UI.Text>().text;
    }
    private void Update()
    {

    }

    public void Panelopener()
    {
        open = !open;
        if (open)
        {
            Heart.SetActive(false);
            Panel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Heart.SetActive(true);
            Panel.SetActive(false);
            Time.timeScale = 1;
        }    
    }
}
