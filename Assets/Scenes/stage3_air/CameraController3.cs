using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController3 : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("wed");
    }

    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        if (playerPos.y >= 0 && playerPos.y <= 90)
        {
            transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
        }
    }
}
