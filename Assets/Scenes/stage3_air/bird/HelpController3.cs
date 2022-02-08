using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpController3 : MonoBehaviour
{
    GameObject bird;
    Vector3 firstPos;
    float distance = 0.075f;
    float add = 0.001f;
    int direction = 1;

    void Start()
    {
        firstPos = transform.position;
        this.bird = GameObject.Find("bird_before");
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

        // 클릭 판정
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit.collider != null && hit.collider.transform == bird.transform)
            {
                Destroy(gameObject);
            }
        }
    }
}
