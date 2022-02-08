using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    public StageManager StageManager;

    void Start()
    {
        this.StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    // 다이얼로그 씬으로 이동(기존에 저장된 데이터 있을 시 초기화 및 재시작)
    public void StartDialougeScene()
    {

        StageManager._missionIndex_st1 = false;
        StageManager._missionIndex_st2 = false;
        StageManager._missionIndex_st3 = false;
        StageManager._missionIndex_st4 = false;

        StageManager._saveStageIndex = 0;

        Debug.Log("북타임");
        SceneManager.LoadScene("stage0_1_talking");
    }
}
