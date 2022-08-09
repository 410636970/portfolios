using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightHp : MonoBehaviour
{
    // Start is called before the first frame update
    int hp = 0;
    public int max_hp = 10;
    public GameObject hp_top;
    public GameObject L_Arm_wear;
    public GameObject L_Shoulder_wear;
    public GameObject R_Leg_wear;
    public GameObject Head_wear;
    private bool Die = false;
    [SerializeField] Animator Knight;
    void Awake()
    {
        hp = max_hp;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(hp == 0)
        {
            Die = true;
        }
        float percent = ((float)hp / (float)max_hp);
        hp_top.transform.localScale = new Vector3(percent, hp_top.transform.localScale.y, hp_top.transform.localScale.z);
    }
    void StateMachine()
    {
        Knight.SetBool("Die", Die);
    }
    public int Hp()
    {
        return hp;
    }
}
