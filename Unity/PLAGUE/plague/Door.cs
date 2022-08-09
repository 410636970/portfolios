using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject DoorOpen;
    public GameObject DoorClose;
    private bool door = true;
    void Start()
    {

    }
    void Update()
    {

    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            if (door == true)
            {
                DoorOpen.SetActive(true);
                DoorClose.SetActive(false);
                door = false;
            }
            else if (door != true)
            {
                DoorOpen.SetActive(false);
                DoorClose.SetActive(true);
                door = true;
            }
        }
    }
}
