using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundController2 : MonoBehaviour
{
    SpriteRenderer firstSr;
    SpriteRenderer secondSr;
    public GameObject background1;
    public GameObject background2;
    public int visable;

    void Start()
    {
        firstSr = background1.GetComponent<SpriteRenderer>();
        secondSr = background2.GetComponent<SpriteRenderer>();
        visable = 0;
    }

    void Update()
    {
        if (visable == 1)
        {
            firstBackground();
            visable = 0;
        }

        if (visable == 2)
        {
            secondBackground();
            visable = 0;
        }
    }

    void firstBackground()
    {
        StartCoroutine("firstFade");
    }

    void secondBackground()
    {
        StartCoroutine("secondFade");
    }

    IEnumerator firstFade()
    {
        for (float i = 10; i >= 0; i -= 0.6f)
        {
            float f = i / 10.0f;
            Color c = firstSr.material.color;
            c.a = f;
            firstSr.material.color = c;
            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator secondFade()
    {
        for (float i = 10; i >= 0; i -= 0.6f)
        {
            float f = i / 10.0f;
            Color c = secondSr.material.color;
            c.a = f;
            secondSr.material.color = c;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
