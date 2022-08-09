using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class MovieController : MonoBehaviour
{
    // Start is called before the first frame update
    VideoPlayer VP = new VideoPlayer();
    public List<VideoClip> videos = new List<VideoClip>();
    public Button Btn1;
    public Button Btn2;
    public GameObject Button2;
    public GameObject ButtonPresentation;
    public AudioClip typevoice;
    AudioSource audiosource;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        VP = GetComponent<VideoPlayer>();
        VP.playOnAwake = false;
        //Each time we reach the end, we slow down the playback by a factor of 10.
        VP.loopPointReached += EndReached;
        audiosource.loop = true;
        audiosource.PlayOneShot(typevoice, 0.5f);
        VP.Stop();//停止
        VP.clip = videos[0];//把影片轉換成影片0
        VP.Play();//播放
        Btn2.onClick.AddListener(delegate
        {
            //VP.Stop();//停止
            //VP.clip = videos[1];//把影片轉換成影片1
            //VP.Play();//播放
            SceneManager.LoadScene(2);
        });
    }
    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        audiosource.Stop();
        ButtonPresentation.SetActive(true);
        Button2.SetActive(true); 
        //SceneManager.LoadScene(2);
        //videoindex += 1;
        //VP.Stop();//停止
        //VP.clip = videos[videoindex];//把影片轉換成影片1
        //VP.Play();//播放
        //if (videoindex == 3)
        //{
        //    videoindex = 0;
        //}
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
