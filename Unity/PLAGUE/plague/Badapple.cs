using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Badapple : MonoBehaviour
{
    private bool ExplosionFinish = false;
    private bool AppleDestroy = false;
    public GameObject apple;
    public GameObject explosion;
    public AudioClip explosionvoice;
    [SerializeField] Animator Explosion;
    AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GameObject.Find("Amisiavoice").transform.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ExplosionFinish)
        {
            if(Explosion.GetCurrentAnimatorStateInfo(0).IsName("Over"))
            {
                explosion.SetActive(false);
                ExplosionFinish = false;
                Destroy(this.gameObject);
            }    
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Arrow")
        {
            Debug.Log("rock");
            Destroy(apple.gameObject);
            if(!AppleDestroy)
            {
                explosion.SetActive(true);
                audiosource.PlayOneShot(explosionvoice);
                AppleDestroy = true;
            }
            ExplosionFinish = true;
        }
    }
}
