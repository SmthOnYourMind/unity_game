using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu_script : MonoBehaviour
{
    public GameObject info;

    private void Start()
    {
        CloseTutorial();
    }

    public void Start_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ShowTutorial()
    {
        info.SetActive(true);
    }

    public void CloseTutorial()
    {
        info.SetActive(false);
    }

    public void Exit_game()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }
}
