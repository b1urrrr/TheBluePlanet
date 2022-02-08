using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    void Start()
    {
        //일시정지 -> 메인 메뉴로 돌아오면 timeScale 원래대로
        Time.timeScale = 1f;
    }

}
