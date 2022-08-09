using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioClip[] au;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void PlaySound(int id)
	{
		if (GetComponent<AudioSource>().isPlaying)
		{
			return;
		}
		GetComponent<AudioSource>().clip = au[id];
		GetComponent<AudioSource>().Play();
	}
}
