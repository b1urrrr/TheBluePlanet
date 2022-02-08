using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController4 : MonoBehaviour
{
    Vector3 cloudPos;
    float distance = 8;
    float addVelocity = 0.03f;
    float direction;

    void Start()
    {
        cloudPos = transform.position;
        direction = -1;
    }

    void Update()
    {
        // 구름 이동 방향 : 오른쪽(1), 왼쪽(-1)
        if (direction == 1)
        {
            if (transform.position.x < cloudPos.x + distance)
            {
                transform.position = new Vector3(transform.position.x + addVelocity, cloudPos.y, cloudPos.z);

            }
            else direction = -1;
        }
        else
        {
            if (transform.position.x > cloudPos.x)
            {
                transform.position = new Vector3(transform.position.x - addVelocity, cloudPos.y, cloudPos.z);
            }
            else direction = 1;
        }
    }
}
