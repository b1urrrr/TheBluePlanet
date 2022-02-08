using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector_stage4 : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("엔딩 씬 이동");
            //엔딩 씬으로 이동
            //SceneManager.LoadScene("");
        }
    }
}
