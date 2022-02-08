using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//타이머 클릭 시 단계 변화 체크
public class TimerController : MonoBehaviour
{
    const int SIZE = 15;
    GameSettings SettingScript; //게임 세팅 스크립트
    GameObject[] childSoils = new GameObject[SIZE];  //토양 배열
    GameObject[] childTimers = new GameObject[2 * SIZE]; //타이머 배열
    GameObject[] childSeeds = new GameObject[SIZE]; //씨앗 배열
    GameObject[] childSprouts = new GameObject[SIZE];   //새싹 배열
    GameObject[] childPlants = new GameObject[SIZE];    //식물 배열
    Queue<int> firstQue;
    Queue<int> secondQue;
    int[] once;
    float delay = 2.0f;

    void Start()
    {
        this.SettingScript = GameObject.Find("GameSettings").GetComponent<GameSettings>();

        this.childSoils = SettingScript.soils;  
        this.childTimers = SettingScript.timers;
        this.childSeeds = SettingScript.seeds;
        this.childSprouts = SettingScript.sprouts;
        this.childPlants = SettingScript.plants;
        this.once = SettingScript.once;

        firstQue = new Queue<int>();
        secondQue = new Queue<int>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //타이머 클릭 시 비활성화
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);


            if (hit.collider != null && hit.collider.transform == this.transform)
            {
                this.gameObject.SetActive(false);
            }

            //레벨 변경
            for (int index = 0; index < SIZE; index++)
            {
                SoilToSeed(index);
                SeedToSprout(index);
                SproutToPlant(index);
            }
        }
    }

    void timerActive1()
    {
        int index = firstQue.Dequeue();
        childTimers[2 * index].SetActive(true);
        childTimers[2 * index + 1].SetActive(true);
        once[index] = 2;
        Debug.Log("firstD : " + index + ", once : " + once[index]);
    }

    void timerActive2()
    {
        int index = secondQue.Dequeue();
        childTimers[2 * index].SetActive(true);
        childTimers[2 * index + 1].SetActive(true);
        once[index] = 4;
        Debug.Log("secondD : " + index + ", once : " + once[index]);
    }

    void SoilToSeed(int i)
    {
        //토양 활성화 & 두 타이머 모두 클릭시 흙 -> 씨앗
        if (childSoils[i] != null)
        {
            if (childSoils[i].activeSelf && childTimers[2 * i].activeSelf == false && childTimers[2 * i + 1].activeSelf == false)
            {
                Debug.Log("(soilToSeed) " + i + " : " + childTimers[2 * i].activeSelf + ", " + childTimers[2 * i + 1].activeSelf + " / once : " + once[i]);
                if (once[i] == 0)
                {
                    firstQue.Enqueue(i);
                    once[i] = 1;
                    Debug.Log("firstE : " + i + ", once : " + once[i]);
                    Destroy(childSoils[i]);
                    childSeeds[i].SetActive(true);    //씨앗
                    Invoke("timerActive1", delay);

                }
            }
        }
    }

    void SeedToSprout(int i)
    {
        //씨앗 활성화 & 두 타이머 모두 클릭 시 씨앗 -> 새싹
        if (childSeeds[i] != null)
        {
            if (childSeeds[i].activeSelf && childTimers[2 * i].activeSelf == false && childTimers[2 * i + 1].activeSelf == false)
            {
                Debug.Log("(SeedToSprout) " + i + " : " + childTimers[2 * i].activeSelf + ", " + childTimers[2 * i + 1].activeSelf + " / once : " + once[i]);
                if (once[i] == 2)
                {
                    once[i] = 3;
                    secondQue.Enqueue(i);
                    Debug.Log("secondE : " + i + ", once : " + once[i]);
                    Destroy(childSeeds[i]);
                    childSprouts[i].SetActive(true);    //새싹
                    Invoke("timerActive2", delay);
                }
            }
        }
    }

    void SproutToPlant(int i)
    {
        //새싹 활성화 & 두 타이머 모두 클릭 시 새싹 -> 식물
        if (childSprouts[i] != null)
        {
            if (childSprouts[i].activeSelf && childTimers[2 * i].activeSelf == false && childTimers[2 * i + 1].activeSelf == false)
            {
                Debug.Log("(SproutToPlant) " + i + " : " + childTimers[2 * i].activeSelf + ", " + childTimers[2 * i + 1].activeSelf + " / once : " + once[i]);
                if (once[i] == 4)
                {
                    childSprouts[i].SetActive(false);
                    Destroy(childSprouts[i]);
                    Destroy(childTimers[2 * i]);
                    Destroy(childTimers[2 * i + 1]);
                    childPlants[i].SetActive(true); //식물
                    once[i] = 5;
                    Debug.Log("(Finish) once : " + once[i]);

                    //점수 증가
                    GameObject director = GameObject.Find("GameDirector");
                    director.GetComponent<GameDirector_stage4>().getScore();
                }
            }
        }
    }
}
















