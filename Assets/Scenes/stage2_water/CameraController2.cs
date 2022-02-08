using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController2 : MonoBehaviour
{
    GameObject wed;
    void Start()
    {
        this.wed = GameObject.Find("wed");
    }

    void Update()
    {
        Vector3 playerPos = this.wed.transform.position;
        if (playerPos.x > 0 && playerPos.x < 61.69f)
            transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z);
    }
}
