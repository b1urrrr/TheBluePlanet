using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NarrationController : MonoBehaviour
{
    public GameObject text;
    SpriteRenderer textSr;
    int visable = 0;

    void Start()
    {
        textSr = text.GetComponent<SpriteRenderer>();
        reset(textSr);
    }

    void reset(SpriteRenderer sr)
    {
        Color c = sr.material.color;
        c.a = 0;
        sr.material.color = c;
    }

    void Update()
    {
        if (visable == 0)
        {
            Invoke("In", 1.0f);
            Invoke("Out", 7.5f);
            Invoke("next", 9.5f);
            visable = 1;
        }
    }

    void next()
    {
        SceneManager.LoadScene("stage1_soil");
    }

    void In()
    {
        StartCoroutine("fadeBlack");
    }

    void Out()
    {
        StartCoroutine("fadeBlackOut");
    }

    IEnumerator fadeBlack()
    {
        for (float i = 0; i <= 12; i += 0.1f)
        {
            float f = i / 10.0f;
            Color c = textSr.material.color;
            c.a = f;
            textSr.material.color = c;
            yield return new WaitForSeconds(0.02f);
        }
    }
    IEnumerator fadeBlackOut()
    {
        for (float i = 12; i >= 0; i -= 0.1f)
        {
            float f = i / 10.0f;
            Color c = textSr.material.color;
            c.a = f;
            textSr.material.color = c;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
