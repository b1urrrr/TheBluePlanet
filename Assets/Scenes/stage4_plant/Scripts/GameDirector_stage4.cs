using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//UI(점수) 갱신
public class GameDirector_stage4 : MonoBehaviour
{
    GameObject scoreText;
    public GameObject carrot;   //당근
    int total = 0;  //클리어 갯수
    int once = 0;

    public bool isPause = false;    //메뉴가 호출되면 true

    void Start()
    {
        this.scoreText = GameObject.Find("scoreText");
    }

    void Update()
    {
        //클리어 갯수 도달(15개) & 도전과제 클리어 시 -> 클리어 씬으로 이동
        if (this.total == 15 && this.carrot == null && once == 0)
        {
            GameObject.Find("Main Camera").GetComponent<AudioSource>().volume = 0;
            GameObject.Find("clear").GetComponent<AudioSource>().Play();
            GameObject.Find("Main Camera").GetComponent<FadeInScript4>().visable4 = 1;
            once = 1;
        }
    }

    public void getScore()
    {
        this.total++;
        Debug.Log("클리어 식물 : " + total + "개");
        this.scoreText.GetComponent<Text>().text = (total).ToString() + "/15";
    }
}
