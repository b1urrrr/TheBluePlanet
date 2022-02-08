using System.Collections;
using System.Collections.Generic;using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public void GameOverClick()
    {
        Debug.Log("게임 종료");
        // 유니티 에디터의 경우
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        //앱의 경우
#else
        Application.Quit();
#endif
    }
}
