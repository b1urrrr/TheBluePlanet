using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookManager : MonoBehaviour
{
    public bool bookState = false;

    public GameObject book;
    public GameObject bookBackground;

    void Update()
    {
        bookUpdate();
    }

    public void bookUpdate()
    {
        if (bookState)
        {
            book.SetActive(false);
            bookBackground.SetActive(false);
        }
    }
}
