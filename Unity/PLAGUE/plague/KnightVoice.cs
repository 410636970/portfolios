using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightVoice : MonoBehaviour
{
    public float voice = 0.3f;
    public AudioClip Attackvoice;
    public AudioClip Hitvoice;
    AudioSource Knightvoice;
    // Start is called before the first frame update
    void Start()
    {
        Knightvoice = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Attack()
    {
        Knightvoice.PlayOneShot(Attackvoice , voice);
    }
    void Hit()
    {
        Knightvoice.PlayOneShot(Hitvoice, voice);
    }
}
