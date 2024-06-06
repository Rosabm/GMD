using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using static Unity.VisualScripting.Member;

public class Pausemenu : MonoBehaviour
{

    public GameObject pauseMenu;
    [SerializeField] private PlayerController playerScript;
    [SerializeField] private GameObject firstSelected;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
            playerScript.enabled = false;
            EventSystem.current.SetSelectedGameObject(firstSelected);
        }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        playerScript.enabled = true;
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        playerScript.enabled = true;
        EventSystem.current.SetSelectedGameObject(null);
        pointCounter.PointCount = 0;
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
        playerScript.enabled = true;
        EventSystem.current.SetSelectedGameObject(null);
        pointCounter.PointCount = 0;

    }
}
