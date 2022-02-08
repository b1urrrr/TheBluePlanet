using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButtonManager2 : MonoBehaviour
{
    GameObject player;
    PlayerController2 playerScript;

    public void Init()
    {
        player = GameObject.Find("wed");
        playerScript = player.GetComponent<PlayerController2>();
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
