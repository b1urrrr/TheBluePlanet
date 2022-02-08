using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moleScript : objFadeController_1
{
    public GameManager_1 manager;
    public StageManager StageManager;

    void Start()
    {
        this.manager = GameObject.Find("Manager").GetComponent<GameManager_1>();
        this.StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    void Update()
    {
        if (this.manager.holeState)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
            base.objFadeIn();
            this.StageManager._missionIndex_st1 = true;
        }
    }
}
