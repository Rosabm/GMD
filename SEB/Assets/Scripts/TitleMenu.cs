using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        pointCounter.PointCount = 0;
        SceneManager.LoadScene("game");
    }

    public void PlayTutorial()
    {
        pointCounter.PointCount = 0;
        SceneManager.LoadScene("tutorial");
    }

    public void Settings()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }
}
