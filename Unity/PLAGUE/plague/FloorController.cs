using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Floor1;
    public GameObject Floor12;
    public GameObject Floor2;
    public GameObject Floor22;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Floor1ClimbStairs();
        Floor2ClimbStairs();
    }
    void Floor1ClimbStairs()
    {
        if (Player.transform.position.y > 2 )//有跳才出現一樓樓梯
        {
            Floor1.SetActive(true);
            Floor12.SetActive(true);
        }
        else
        {
            Floor1.SetActive(false);
            Floor12.SetActive(false);
        }
    }
    void Floor2ClimbStairs()
    {
        if (Player.transform.position.y > 9)//有跳才出現二樓樓梯
        {
            Floor2.SetActive(true);
            Floor22.SetActive(true);
        }
        else
        {
            Floor2.SetActive(false);
            Floor22.SetActive(false);
        }
    }
}
