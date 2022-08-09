using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmisiaRunAndJumpMusic : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D body;
    public float voice = 0.3f;
    public AudioClip runvoice;
    AudioSource audiosource;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Idle()
    {
        audiosource.Stop();
    }
    public void Run()
    {
        if((body.velocity.y == 0) && (body.velocity.x != 0))//在平地時移動才有跑步音效
        {
            audiosource.PlayOneShot(runvoice, voice);
        }
        else
            audiosource.Stop();
    }
}
