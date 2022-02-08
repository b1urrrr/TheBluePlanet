using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//타이머, 토양, 씨앗, 새싹, 식물 --> 배열 초기화 
public class GameSettings : MonoBehaviour
{
    const int SIZE = 15;    //크기
    public GameObject[] soils = new GameObject[SIZE];  //반짝이는 토양 배열
    public GameObject[] timers = new GameObject[2 * SIZE]; //타이머 배열
    public GameObject[] seeds = new GameObject[SIZE];   //씨앗 배열
    public GameObject[] sprouts = new GameObject[SIZE];   //새싹 배열
    public GameObject[] plants = new GameObject[SIZE];    //식물 배열
    public int[] once = new int[SIZE];

    void Awake()
    {
        for (int i = 0; i < SIZE; i++)
        {
            once[i] = 0;
        }

        //토양 초기 비활성화
        for (int i = 0; i < SIZE; i++)
            soils[i].SetActive(false);

        //타이머 초기 비활성화
        for (int i = 0; i < 2 * SIZE; i++)
            timers[i].SetActive(false);

        //씨앗 초기 비활성화
        for (int i = 0; i < SIZE; i++)
            seeds[i].SetActive(false);

        //새싹 초기 비활성화
        for (int i = 0; i < SIZE; i++)
            sprouts[i].SetActive(false);

        //식물 초기 비활성화
        for (int i = 0; i < SIZE; i++)
            plants[i].SetActive(false);

        Debug.Log("오브젝트 초기 비활성화 완료");
    }

}