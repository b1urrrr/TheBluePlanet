using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButtonManager1 : MonoBehaviour
{
    GameObject player;
    PlayerController1 playerScript;

    public void Init()
    {
        player = GameObject.Find("wed1");
        playerScript = player.GetComponent<PlayerController1>();
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
