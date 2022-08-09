using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxing : MonoBehaviour
{
    public Transform[] backgrounds;     //背景數量 列表
    private float[] parallacScales;     //背景移動比例(視差範圍)
    public float smoothing = 1f;        //視差移動平滑度，必須>0

    private Transform cam;              //MainCam Transform
    private Vector3 previousCamPos;     //Cam前一偵的位置

    //在Start()前呼叫，
    private void Awake()
    {
        //引用MainCamera Transform
        cam = Camera.main.transform;
    }

    void Start()
    {
        //紀錄MainCam位置至前一偵
        previousCamPos = cam.position;
        //分配對應的背景移動比例
        parallacScales = new float[backgrounds.Length];
        for (int i = 0; i < backgrounds.Length; i++) {
            parallacScales[i] = backgrounds[i].position.z * -1;
        }
    }

    void Update()
    {
        for (int i = 0; i < backgrounds.Length; i++) {
            //計算視差 = 上一偵移動到當前偵的相反值
            float parallax = (previousCamPos.x - cam.position.x) * parallacScales[i];
            //計算視差移動後，背景圖的新位置
            float backgroundTaegetPosX = backgrounds[i].position.x + parallax;
            //背景當前位置(放入新X，YZ不變)
            Vector3 backgroundTargetPos = new Vector3(backgroundTaegetPosX, backgrounds[i].position.y, backgrounds[i].position.z);
            //用lerp使背景移動變平滑(取差值)
            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
        }
        //刷新MainCam位置
        previousCamPos = cam.position;
    }
}
