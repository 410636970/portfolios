using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D m_rigidbody;
    Animator m_Animator;
    public GameObject Player;
    void Start()
    {
        m_rigidbody = this.GetComponent<Rigidbody2D>();
        m_Animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        movechanger();
    }
    void movechanger()
    {
        if (-0.005 < m_rigidbody.velocity.x && m_rigidbody.velocity.x < 0.005)//移動時不向主角觀看
        {
            if (Player.transform.position.x > this.transform.position.x)
            {
                Vector3 scale = transform.localScale;
                scale.x = 1.5f;
                transform.localScale = scale;
            }
            else
            {
                Vector3 scale = transform.localScale;
                scale.x = -1.5f;
                transform.localScale = scale;
            }
        }
    }
}
