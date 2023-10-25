using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    //public Animator animator;

    Image timerBar;
    public float maxTime = 5f;
    float timeLeft;

    void Start ()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;

        //animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            SceneManager.LoadScene("Main");
            Time.timeScale = 0;
        }
    }
}
