using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//토양&타이머 활성화
public class SetSoilAndTimer : MonoBehaviour
{
    const int SIZE = 15;
    GameObject[] childSoils = new GameObject[SIZE]; //토양 배열
    GameObject[] childTimers = new GameObject[2 * SIZE];    //타이머 배열

    List<int> indexList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }; //인덱스 리스트

    void Start()
    {
        childSoils = GameObject.Find("GameSettings").GetComponent<GameSettings>().soils;
        childTimers = GameObject.Find("GameSettings").GetComponent<GameSettings>().timers;

        //게임 시작 3초 후, 4초마다 토양&타이머 생성
        InvokeRepeating("MakeSoilAndTimer", 3, 4);
    }

    void MakeSoilAndTimer()
    {

        if (indexList.Count == 0)
        {
            CancelInvoke();
            Debug.Log("토양&타이머 생성 종료");
        }
        else
        {
            int tempIndex = Random.Range(0, indexList.Count);
            int index = indexList[tempIndex];   //진짜 토양 번호

            //토양 활성화
            childSoils[index].SetActive(true);

            //타이머 활성화
            childTimers[2*index].SetActive(true);
            childTimers[2 * index + 1].SetActive(true);

            indexList.RemoveAt(tempIndex);
        }

    }
}
