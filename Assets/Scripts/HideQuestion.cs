using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HideQuestion : MonoBehaviour
{
    public GameObject question1;
    public GameObject question2;
    public GameObject question3;

    public GameObject scroll1;
    public GameObject scroll2;
    public GameObject scroll3;

    public static int rightAnswers = 0;

    public GameObject gate;

    public GameObject meme;

    private string input;

    static class Answers
    {
        public static class Level1
        {
            public static string question1_ans = "�������";
            public static string question2_ans = "������";
            public static string question3_ans = "�������";
        }
        public static class Level2
        {
            public static string question1_ans = "d";
            public static string question2_ans = "e";
            public static string question3_ans = "f";
        }
    }

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

        Time.timeScale = 1;
    }

    public void WrongAnswer()
    {
        Time.timeScale = 1;
    }

    public void HideScroll()
    {
        Time.timeScale = 1;

        if (scroll1.active == true)
            scroll1.SetActive(false);
        else if (scroll2.active == true)
            scroll2.SetActive(false);
        else if (scroll3.active == true)
            scroll3.SetActive(false);
    }

    public void CheckAnswer(string str)
    {
        input = str.ToLower();
        Debug.Log(input);

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (question1.active == true)
            {
                question1.SetActive(false);
                if (input == Answers.Level1.question1_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
            if (question2.active == true)
            {
                question2.SetActive(false);
                if (input == Answers.Level1.question2_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
            if (question3.active == true)
            {
                question3.SetActive(false);
                if (input == Answers.Level1.question3_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (question1.active == true)
            {
                question1.SetActive(false);
                if (input == Answers.Level2.question1_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
            if (question2.active == true)
            {
                question2.SetActive(false);
                if (input == Answers.Level2.question2_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
            if (question3.active == true)
            {
                question3.SetActive(false);
                if (str == Answers.Level2.question3_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
        }
    }

    public void LoadNextLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerController.respawn_point = transform.position;
    }

    public void RestartLevel()
    {
        rightAnswers = 0;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}


