using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    // Start is called before the first frame update
    private bool Death = false;
    public GameObject heart0;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;
    public int PlayerHp = 5;
    public GameObject DeathPanel;
    public AudioClip BeAttacked;
    public AudioClip DeathVoice;
    public AudioClip HeartEatVoice;
    AudioSource Voice;
    void Start()
    {
        Voice = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {    
        if(PlayerHp != 0)
        {
            HpController();
        }
        if(PlayerHp == 0)
        {
            Death = true;
            Voice.PlayOneShot(DeathVoice, 0.5f);
            heart0.SetActive(false);
            DeathPanel.SetActive(true);
            PlayerHp = -1;
        }
    }
    void HpController()
    {
        switch (PlayerHp)
        {
            case 1:
                heart1.SetActive(true);
                heart2.SetActive(false);
                heart3.SetActive(false);
                heart4.SetActive(false);
                heart5.SetActive(false);
                break;
            case 2:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(false);
                heart4.SetActive(false);
                heart5.SetActive(false);
                break;
            case 3:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                heart4.SetActive(false);
                heart5.SetActive(false);
                break;
            case 4:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                heart4.SetActive(true);
                heart5.SetActive(false);
                break;
            case 5:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                heart4.SetActive(true);
                heart5.SetActive(true);
                break;
            default:
                break;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Heart")
        {
            Voice.PlayOneShot(HeartEatVoice, 0.3f);
            
            if (PlayerHp < 5)
                PlayerHp++;
        }
        if (collision.gameObject.tag == "Weapon")
        {
            print(collision.name);
            print("Attacked by weapon");
            Voice.PlayOneShot(BeAttacked, 0.3f);
            PlayerHp--;
        }
        if (collision.gameObject.tag == "DeathZone")
        {
            PlayerHp = 0;
        }
    }
    public int playerhp()
    {
        return PlayerHp;
    }
    public bool IsDeath()
    {
        return Death;
    }
}
