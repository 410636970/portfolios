using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    static GameManager instance;
    void Awake()
    {
        if(instance == null )
        {
            instance = this;
            DontDestroyOnLoad(this);
            name = "最初的遊戲管理物件";
        }
        else if( this!=instance )
        {
            string sceneName = SceneManager.GetActiveScene().name;
            Destroy(gameObject);
        }
    }
    void Update()
    {
        
    }

}
