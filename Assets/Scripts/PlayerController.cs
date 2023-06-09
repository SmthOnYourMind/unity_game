using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRB;

    public float speed = 0;
    public float jump_force = 0;
    private float direction = 0;

    public Transform ground_check;
    public float ground_check_radius = 0;
    public bool is_on_ground = false;
    public LayerMask ground_layer;

    public static Vector3 respawn_point;
    public GameObject fall_detector;

    public Animator playerAnimation;

    public GameObject question1;
    public GameObject question2;
    public GameObject question3;

    public GameObject scroll1;
    public GameObject scroll2;
    public GameObject scroll3;

    public GameObject mem1;
    public GameObject mem2;
    public GameObject mem3;

    public GameObject mem1info;
    public GameObject mem2info;
    public GameObject mem3info;


    public GameObject restart_button;
    public Text rightAnsCount;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Animator>();

        respawn_point = transform.position;

        question1.SetActive(false);
        question2.SetActive(false);
        question3.SetActive(false);

        scroll1.SetActive(false);
        scroll2.SetActive(false);
        scroll3.SetActive(false);

        mem1.SetActive(false);
        mem2.SetActive(false);
        mem3.SetActive(false);

        mem1info.SetActive(false);
        mem2info.SetActive(false);
        mem3info.SetActive(false);


        rightAnsCount.text = "Правильных ответов: " + HideQuestion.rightAnswers;
    }

    // Update is called once per frame
    private void Update()
    {
        is_on_ground = Physics2D.OverlapCircle(ground_check.position, ground_check_radius, ground_layer);
        direction = Input.GetAxis("Horizontal");

        if (direction > 0)
        {
            playerRB.velocity = new Vector2(direction * speed, playerRB.velocity.y);
            transform.localScale = new Vector2(0.25f, 0.25f);
        }
        else if (direction < 0)
        {
            playerRB.velocity = new Vector2(direction * speed, playerRB.velocity.y);
            transform.localScale = new Vector2(-0.25f, 0.25f);
        }
        else
        {
            playerRB.velocity = new Vector2(0, playerRB.velocity.y);
        }

        if (Input.GetButtonDown("Jump") && is_on_ground == true)
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, jump_force);
        }

        //playerAnimation.SetFloat("Speed", Mathf.Abs(player.velocity.x));
        //playerAnimation.SetBool("Is on ground", is_on_ground);

        fall_detector.transform.position = new Vector2(transform.position.x, fall_detector.transform.position.y);

        rightAnsCount.text = "Правильных ответов: " + HideQuestion.rightAnswers;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Fall detector")
        {
            transform.position = respawn_point;
        }
        else if (collision.tag == "Checkpoint")
        {
            respawn_point = transform.position;
        }
        else if (collision.tag == "Next level")
        {
            mem1.SetActive(true);
            Time.timeScale = 0;
            
            HideQuestion.rightAnswers = 0;
        }
        else if (collision.tag == "Chest")
        {
            collision.gameObject.SetActive(false);
            if (collision.gameObject.name == "Chest1")
            {
                ShowQuestion(1);
                Time.timeScale = 0;
            }
            else if (collision.gameObject.name == "Chest2")
            {
                ShowQuestion(2);
                Time.timeScale = 0;
            }
            else if (collision.gameObject.name == "Chest3")
            {
                ShowQuestion(3);
                Time.timeScale = 0;
            }
        }
        else if (collision.tag == "scroll")
        {
            collision.gameObject.SetActive(false);
            Time.timeScale = 0;
            restart_button.SetActive(false);

            if (collision.gameObject.name == "Scroll1")
            {
                scroll1.SetActive(true);
            }
            else if (collision.gameObject.name == "Scroll2")
            {
                scroll2.SetActive(true);
            }
            else if (collision.gameObject.name == "Scroll3")
            {
                scroll3.SetActive(true);
            }
        }
    }

    public void ShowQuestion(int num)
    {
        if (num == 1)
            question1.SetActive(true);
        else if (num == 2)
            question2.SetActive(true);
        else if (num == 3)
            question3.SetActive(true);
    }

}
