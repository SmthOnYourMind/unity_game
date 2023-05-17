using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HideQuestion : MonoBehaviour
{
    public GameObject question1;
    public GameObject question2;
    public GameObject question3;

    public static int rightAnswers = 0;

    public GameObject gate;

    void Start()
    {
        
    }

    void Update()
    {
        if (rightAnswers == 3)
        {
            gate.SetActive(false);
        }
    }

    public void RightAnswer()
    {
        rightAnswers++;

        if (question1.active == true)
            question1.SetActive(false);
        else if (question2.active == true)
            question2.SetActive(false);
        else if (question3.active == true)
            question3.SetActive(false);

        Time.timeScale = 1;
    }

    public void WrongAnswer()
    {
        

        if (question1.active == true)
            question1.SetActive(false);
        else if (question2.active == true)
            question2.SetActive(false);
        else if (question3.active == true)
            question3.SetActive(false);

        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        rightAnswers = 0;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
