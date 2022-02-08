using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soilBackground1 : objFadeController_1
{
    public GameManager_1 Manager;
 
    void Start()
    {
        this.Manager = GameObject.Find("Manager").GetComponent<GameManager_1>();
    }

    void Update()
    {
        // 오염물질 10개 제거 시 soilbackground1 페이드 아웃
        if (this.Manager.total >= 10)
        {
            base.objFadeOut();
        }
    }
}
