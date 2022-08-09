using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Talkable : MonoBehaviour
{
    public static Flowchart flowchartManager;
    public Flowchart talkFlowchart;
    public string onCollosionEnter;
    Rigidbody2D playerRigidbody;


    void Awake()
    {
        flowchartManager = GameObject.Find("對話管理器").GetComponent<Flowchart>();
        playerRigidbody = FindObjectOfType<MovementController>().GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("對話中"); }
    }
    void PlayBlock(string targetBlockName)
    {
        Block targetBlock = talkFlowchart.FindBlock(targetBlockName);
        if (targetBlock != null)
        {
            talkFlowchart.ExecuteBlock(targetBlock);
        }
        else
        {
            Debug.LogError("找不到在 " + talkFlowchart.name + "裡的" + targetBlockName + "Block");
        }
    }

    //Fungus 3.7版以後也內建了一個Collision
    //為了避免跟Unity內建的Collision混淆,這邊需要特別指明是Unity本身的Collision
    /*void OnCollisionEnter2D(UnityEngine.Collision2D other)
    {
        if (!isTalking)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("success");
                playerRigidbody.Sleep();
            }
        }
    }*/
}
