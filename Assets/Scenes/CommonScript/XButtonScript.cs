using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XButtonScript : MonoBehaviour
{
    public GameObject book;
    public BookManager bookManager;

    void Start()
    {
        bookManager = GameObject.Find("bookManager").GetComponent<BookManager>();
    }

    public void XButtonClick()
    {
        this.bookManager.bookState = true;
        book.SetActive(false);
    }
}
