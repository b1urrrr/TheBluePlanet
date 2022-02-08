using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HelpController1 : objFadeController_1
{
    public GameManager_1 manager;
    Vector3 firstPos;
    float distance = 0.075f;
    float add = 0.001f;
    int direction = 1;


    void Start()
    {
        this.manager = GameObject.Find("Manager").GetComponent<GameManager_1>();
        firstPos = transform.position;
        gameObject.GetComponent<Renderer>().enabled = false;
        //gameObject.SetActive(false);
        Invoke("helpUpdate", 72.6f);
    }

    void helpUpdate()
    {
        //gameObject.SetActive(true);
        gameObject.GetComponent<Renderer>().enabled = true;
        
    }


    void Update()
    {
        if (direction == 1)
        {
            if (transform.position.y <= firstPos.y + distance)
            {
                transform.position = new Vector3(firstPos.x, transform.position.y + add, firstPos.z);
            }
            else direction = -1;
        }
        else
        {
            if (transform.position.y >= firstPos.y)
            {
                transform.position = new Vector3(firstPos.x, transform.position.y - add, firstPos.z);
            }
            else direction = 1;
        }

        if (this.manager.holeState)
        {
            Destroy(gameObject);
            base.objFadeIn();
        }

    }
}