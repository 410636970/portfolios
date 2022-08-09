using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float voice = 0.3f;
    Rigidbody2D rb;
    bool hasHit = false;
    public float timer;
    public AudioClip startvoice;
    public AudioClip endvoice;
    AudioSource audiosource;
    // Start is called before the first frame update
    void Awake()
    {
        audiosource = GetComponent<AudioSource>();
    }
    void Start()
    {
        audiosource.PlayOneShot(startvoice, voice);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hasHit == false)
        {
            trackMovement();
        }
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void trackMovement()
    {
        Vector2 direction = rb.velocity;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        audiosource.PlayOneShot(endvoice, voice);
        hasHit = true;
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "apple")
        {
            Destroy(gameObject);
        }
    }
}
