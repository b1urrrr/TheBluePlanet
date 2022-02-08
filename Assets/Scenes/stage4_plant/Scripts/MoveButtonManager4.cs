using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButtonManager4 : MonoBehaviour
{
    GameObject player;
    PlayerController_stage4 playerScript;

    public void Init()
    {
        player = GameObject.Find("Wed");
        playerScript = player.GetComponent<PlayerController_stage4>();
    }

    public void LeftDown()
    {
        playerScript.inputLeft = true;
    }

    public void LeftUp()
    {
        playerScript.inputLeft = false;
    }

    public void RightDown()
    {
        playerScript.inputRight = true;
    }

    public void RightUp()
    {
        playerScript.inputRight = false;
    }

}
