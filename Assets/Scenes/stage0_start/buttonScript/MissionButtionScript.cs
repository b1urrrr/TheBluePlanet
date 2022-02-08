using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionButtionScript : MonoBehaviour
{
    public GameObject bookImg;

    public void settingBook()
    {
        bookImg = GameObject.Find("Canvas").transform.Find("missionBook").gameObject;
        bookImg.SetActive(true);
    }
}
