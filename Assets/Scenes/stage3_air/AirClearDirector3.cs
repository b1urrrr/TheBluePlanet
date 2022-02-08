using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AirClearDirector3 : MonoBehaviour
{
    bool finish = false;
    void Update()
    {
        Invoke("isFinish", 13.5f);
        if (finish)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("스테이지 4 (연결하지 않음)");
                // 스테이지 4로 넘어감
                // SceneManager.LoadScene(" ");
            }
        }
    }

    void isFinish()
    {
        finish = true;
        return;
    }
}
