using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class ProductorMenu : MonoBehaviour
{
    // Start is called before the first frame update
    VideoPlayer VP = new VideoPlayer();
    public List<VideoClip> videos = new List<VideoClip>();
    public Button Btn2;
    public GameObject Button2;
    public GameObject MainCamera;
    private void Awake()
    {
        
    }

    void Start()
    {
        VP = GetComponent<VideoPlayer>();
        VP.playOnAwake = false;
        //Each time we reach the end, we slow down the playback by a factor of 10.
        VP.loopPointReached += EndReached;
        VP.Stop();//停止
        VP.clip = videos[0];//把影片轉換成影片0
        VP.Play();//播放
    }
    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        Button2.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        MainCamera.SetActive(false);
    }
}
