using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController1 : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("wed1");
    }

    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        if (playerPos.x >= 0 && playerPos.x <= 20.3f)
            transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z);
    }
}
