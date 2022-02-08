using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpController_stage4 : MonoBehaviour
{
    Vector3 firstPos;
    float distance = 0.075f;
    float add = 0.001f;
    int direction = 1;

    void Start()
    {
        firstPos = transform.position;
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


    }
}
