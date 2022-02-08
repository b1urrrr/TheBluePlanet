using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenPolScript : PollutantScript
{
    public GameManager_1 manager;

    // 히든도전과제(70초 후 등장): 두더지 구멍 위에 오염물질 생성
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
        this.manager = GameObject.Find("Manager").GetComponent<GameManager_1>();
        gameObject.SetActive(false);
        Invoke("hiddenUpdate", 69.8f);
    }

    void hiddenUpdate()
    {
        gameObject.SetActive(true);
    }

    void Update()
    {
        base.sizeUp();
        if (Input.GetMouseButtonDown(0))
        {
            this.manager.hiddenPolState = true;
            base.DestroyPol();
        }
    }
}


