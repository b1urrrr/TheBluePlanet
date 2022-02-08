using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_1 : MonoBehaviour
{
    public int total = 0;
    public GameObject num;
    public GameObject score;
    public bool hiddenPolState = false;
    public bool holeState = false;
    int once = 0;
    public bool isPause = false;    //메뉴가 호출되면 true(필요하면 쓰기)
    GameObject StageManager;

    void Start()
    { 
        this.num = GameObject.Find("num1");
        this.score = GameObject.Find("score");
        StageManager = GameObject.Find("StageManager");
    }

    void Update()
    {
        if (total >= 30 && once == 0)
        {
            GameObject.Find("Main Camera").GetComponent<AudioSource>().volume = 0;
            GetComponent<AudioSource>().Play();
            Destroy(num);
            Destroy(score);
            GameObject.Find("Main Camera").GetComponent<FadeInScript1>().visable1 = 1;
            once = 1;
        }
    }
    public void Total()
    {
        total++;
        Debug.Log(total);
        NumOfPol();
    }

    // 제거한 오염물질 UI로 표시
    public void NumOfPol()
    {
        this.num.GetComponent<Text>().text = total.ToString("D2") + " / 30";
    }
}