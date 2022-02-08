using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeepButtonScript : MonoBehaviour
{
    public StageManager StageManager;
    GameObject noData;

    void Start()
    {
        this.StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
        noData = GameObject.Find("Canvas").transform.Find("noData").gameObject;
    }

    public void KeepingScene()
    {
        if (StageManager._saveStageIndex == 0)
        {
            noData.SetActive(true);
            Invoke("closeNoData", 0.8f);
        }
        else if (StageManager._saveStageIndex == 1)
            SceneManager.LoadScene("stage1_soil");
        else if (StageManager._saveStageIndex == 2)
            SceneManager.LoadScene("stage2_water");
        else if (StageManager._saveStageIndex == 3)
            SceneManager.LoadScene("stage3_air");
        else if (StageManager._saveStageIndex == 4)
            SceneManager.LoadScene("stage4_plant");
    }

    public void closeNoData()
    {
        noData.SetActive(false);
    }
}
