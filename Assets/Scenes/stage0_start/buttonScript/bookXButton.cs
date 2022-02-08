using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookXButton : MonoBehaviour
{
    public GameObject book;

    public void XButtonClick()
    {
        book.SetActive(false);
    }
}
