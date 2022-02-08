using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//일시정지 기능
public class PauseManager4 : MonoBehaviour
{
    bool isPause;   //Pause 상태인지
    public GameObject PauseMenu;    //일시정지 메뉴
    public GameObject pause;   //일시정지 UI
    public StageManager StageManager;

    void Start()
    {
        isPause = GameObject.Find("GameDirector").GetComponent<GameDirector_stage4>().isPause;
        this.StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
        PauseMenu.SetActive(false);
    }

    public void Pause()
    {
        isPause = true;
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("일시 정지");
            
    }

    public void ClickContinue()
    {
        isPause = false;
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Debug.Log("재시작");
    }

    public void ClickMainMenu()
    {
        SceneManager.LoadScene("stage0_start");
        this.StageManager._saveStageIndex = 4;
        Debug.Log("메인 메뉴로");
    }

    public void ClickExit()
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
