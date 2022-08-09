using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightHitDetect : MonoBehaviour
{
    // Start is called before the first frame update
    private bool Hit = false;
    private bool Die = false;
    int max_hp = 0;
    public int hp = 10;
    public GameObject hp_under;
    public GameObject hp_top;
    public GameObject L_Arm_wear;
    public GameObject L_Shoulder_wear;
    public GameObject R_Leg_wear;
    public GameObject Head_wear;
    [SerializeField] Animator KnightModel;
    void Start()
    {
        max_hp = hp;
    }

    // Update is called once per frame
    void Update()
    {
        SetMachine();
        if (Hit)
        {
            if (KnightModel.GetCurrentAnimatorStateInfo(0).IsName("HitOver"))
            {
                Hit = false;
            }
        }
        if (hp > 0)
        {
            switch (hp)
            {
                case 2:
                    Head_wear.SetActive(false);
                    break;
                case 3:
                    R_Leg_wear.SetActive(false);
                    break;
                case 5:
                    L_Shoulder_wear.SetActive(false);
                    break;
                case 7:
                    L_Arm_wear.SetActive(false);
                    break;
                default:
                    break;
            }
        }
        if (hp == 0)
        {
            hp_under.SetActive(false);
            Die = true;
        }
        float percent = ((float)hp / (float)max_hp);
        hp_top.transform.localScale = new Vector3(percent, hp_top.transform.localScale.y, hp_top.transform.localScale.z);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Arrow")
        {
            hp--;
            Hit = true;
        }
    }
    void SetMachine()
    {
        KnightModel.SetBool("Die", Die);
        KnightModel.SetBool("Hit", Hit);
    }
    public bool Death()
    {
        return Die;
    }
}
