using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageClearScript1 : objFadeController_1
{
    public GameManager_1 Manager;
    GameObject player;

    void Start()
    {
        this.Manager = GameObject.Find("Manager").GetComponent<GameManager_1>();
        this.player = GameObject.Find("wed1");
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    void Update()
    {
        ClearUpdate();
    }

    public void ClearUpdate()
    {
        if (this.Manager.total == 30)
        {
            Vector3 playerPos = this.player.transform.position;
            if (playerPos.x >= 0 && playerPos.x <= 20.3f)
                transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z);
            Invoke("blackIn", 1f);
        }
    }

    void blackIn()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
        base.objFadeIn();
    }
}

