using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// DontDestroyOnLoad로 모든 씬에서 사용
public class StageManager : MonoBehaviour
{
    // 도전과제 전체 변수 (stage1~4 도전과제 state)
    public bool _missionIndex_st1 = false;
    public bool _missionIndex_st2 = false;
    public bool _missionIndex_st3 = false;
    public bool _missionIndex_st4 = false;

    // 스테이지 저장변수
    public int _saveStageIndex = 0;

}
