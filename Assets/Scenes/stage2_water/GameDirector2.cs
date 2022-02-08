using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector2 : MonoBehaviour
{
    int once = 0;
    public int score;
    GameObject text;

    public bool isPause = false;    //메뉴가 호출되면 true(필요하면 쓰기)

    void Start()
    {
        score = 0;
        this.text = GameObject.Find("scoreText");
    }

    void Update()
    {
        if (score < 10)
        {
            this.text.GetComponent<Text>().text = score.ToString("D1") + " / 30";
        } else if (score != 30)
        {
            this.text.GetComponent<Text>().text = score.ToString("D2") + " / 30";
        }

        if (score == 10 && once == 0)
        {
            GameObject.Find("Main Camera").GetComponent<BackgroundController2>().visable = 1;
            once = 1;
        }

        if (score == 20 && once == 1)
        {
            GameObject.Find("Main Camera").GetComponent<BackgroundController2>().visable = 2;
            once = 2;
        }
    }
}
