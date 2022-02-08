using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionBookScript : MonoBehaviour
{
    public StageManager StageManager;
    public Image soil;
    public Image soil_change;
    public Image water;
    public Image water_change;
    public Image air;
    public Image air_change;
    public Image plant;
    public Image plant_change;

    void Start()
    {
        this.StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    void Update()
    {
        MissionBookImgUpdate();
    }

    public void MissionBookImgUpdate()
    {
        // 각각 if문으로 도전과제 클리어 시 이미지 보이도록
        if (this.StageManager._missionIndex_st1)
        {
            soil.gameObject.SetActive(false);
            soil_change.gameObject.SetActive(true);
        }
        if (this.StageManager._missionIndex_st2)
        {
            water.gameObject.SetActive(false);
            water_change.gameObject.SetActive(true);
        }
        if (this.StageManager._missionIndex_st3)
        {
            air.gameObject.SetActive(false);
            air_change.gameObject.SetActive(true);
        }
        if (this.StageManager._missionIndex_st4)
        {
            plant.gameObject.SetActive(false);
            plant_change.gameObject.SetActive(true);
        }
    }
}
