using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderVoice : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource undervoice;
    public AudioClip voice;
    void Start()
    {
        undervoice = GameObject.Find("Main Camera").transform.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "undervoice")
        {
            undervoice.Stop();
            undervoice.loop = true;
        }
    }
}
