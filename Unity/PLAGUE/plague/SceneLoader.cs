using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public int currentScene;
    public void nextScene()//下個場景
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }
    public void jumpToScene(int sceneIndex) { SceneManager.LoadScene(sceneIndex); }
    public void JumpToSceneByString(string sceneName) { SceneManager.LoadScene(sceneName); }
    public void doQuit()//離開遊戲
    {
        Application.Quit();
    }
    public void lastScene()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene - 1);
    }
    public void replay()
    {
        Time.timeScale = 1;
        currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
   }
    public void menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("menu");
    }
    public void Rank2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void Rank3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }
    public void Rank4()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }
    public void Rank5()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(5);
    }
}
