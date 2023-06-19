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
    public GameObject mem1;
    public GameObject mem2;
    public GameObject mem3;

    public GameObject mem1info;
    public GameObject mem2info;
    public GameObject mem3info;


    private string input;

    public GameObject restart_button;

    static class Answers
    {
        public static class Level1
        {
            public static string question1_ans = "письмо";
            public static string question2_ans = "порт-артур";
            public static string question3_ans = "со€";
        }
        public static class Level2
        {
            public static string question1_ans = "кровавое воскресенье";
            public static string question2_ans = "4";
            public static string question3_ans = "манифест";
        }

        public static class Level3
        {
            public static string question1_ans = "4";
            public static string question2_ans = "запугивани€";
            public static string question3_ans = "испанский грипп";
        }

        public static class Level4
        {
            public static string question1_ans = "домохоз€йки";
            public static string question2_ans = "родз€нко";
            public static string question3_ans = "2 марта";
        }

        public static class Level5
        {
            public static string question1_ans = "вином";
            public static string question2_ans = "аврора";
            public static string question3_ans = "26 окт€бр€";
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

        restart_button.SetActive(true);

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

        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (question1.active == true)
            {
                question1.SetActive(false);
                if (input == Answers.Level3.question1_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
            if (question2.active == true)
            {
                question2.SetActive(false);
                if (input == Answers.Level3.question2_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
            if (question3.active == true)
            {
                question3.SetActive(false);
                if (str == Answers.Level3.question3_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            if (question1.active == true)
            {
                question1.SetActive(false);
                if (input == Answers.Level4.question1_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
            if (question2.active == true)
            {
                question2.SetActive(false);
                if (input == Answers.Level4.question2_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
            if (question3.active == true)
            {
                question3.SetActive(false);
                if (str == Answers.Level4.question3_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            if (question1.active == true)
            {
                question1.SetActive(false);
                if (input == Answers.Level5.question1_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
            if (question2.active == true)
            {
                question2.SetActive(false);
                if (input == Answers.Level5.question2_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
            if (question3.active == true)
            {
                question3.SetActive(false);
                if (str == Answers.Level5.question3_ans)
                    RightAnswer();
                else
                    WrongAnswer();
            }
        }
    }

    public void ShowMemInfo()
    {
        if (mem1.active)
        {
            mem1.SetActive(false);
            mem1info.SetActive(true);
        }
        else if (mem2.active)
        {
            mem2.SetActive(false);
            mem2info.SetActive(true);
        }
        else if (mem3.active)
        {
            mem3.SetActive(false);
            mem3info.SetActive(true);
        }
    }

    public void HideMemInfo()
    {
        if (mem1info.active)
        {
            mem1info.SetActive(false);
            mem1.SetActive(true);
        }
        else if (mem2info.active)
        {
            mem2info.SetActive(false);
            mem2.SetActive(true);
        }
        else if (mem3info.active)
        {
            mem3info.SetActive(false);
            mem3.SetActive(true);
        }
    }

    public void LoadMem2()
    {
        mem1.SetActive(false);
        mem2.SetActive(true);
    }
    public void LoadMem3()
    {
        mem2.SetActive(false);
        mem3.SetActive(true);
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


