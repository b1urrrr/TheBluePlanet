using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController_stage4 : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("Wed");
    }

    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        if(playerPos.x >= -11.0f && playerPos.x <= 11.0f)
            transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z);
    }
}
