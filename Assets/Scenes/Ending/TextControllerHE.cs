using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextControllerHE : MonoBehaviour
{
    SpriteRenderer blackSr;
    public GameObject black;
    public Text text;
    // 시작(0), 투명(-1), 불투명(1)
    public int visable;

    void Start()
    {
        blackSr = black.GetComponent<SpriteRenderer>();
        visable = 0;
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0.0f);
        Color c = blackSr.material.color;
        c.a = 1.1f;
        blackSr.material.color = c;
    }
    void Update()
    {
        if (visable == 0)
        {
            Invoke("halfBlackOut", 1.4f);
            Invoke("halfBlackIn", 3.4f);
            Invoke("blackOut", 6.0f);
            Invoke("textIn", 10.0f);
            Invoke("textOut", 18.0f);
            Invoke("blackIn", 19.0f);
            Invoke("startScene", 23.5f);
            visable = 1;
        }
    }

    void startScene()
    {
        SceneManager.LoadScene("stage0_start");
    }

    void blackIn()
    {
        StartCoroutine("fadeBlack");
    }

    void blackOut()
    {
        StartCoroutine("fadeBlackOut");
    }

    void halfBlackIn()
    {
        StartCoroutine("halfFadeBlack");
    }

    void halfBlackOut() {
        StartCoroutine("halfFadeBlackOut");
    } 
    void textIn()
    {
        StartCoroutine("FadeTextToFullAlpha");
    }

    void textOut()
    {
        StartCoroutine("FadeTextToZeroAlpha");
    }
    IEnumerator halfFadeBlack() // 검은색 절반 진해짐.
    {
        for (float i = 8; i <= 11; i += 0.04f)
        {
            float f = i / 10.0f;
            Color c = blackSr.material.color;
            c.a = f;
            blackSr.material.color = c;
            yield return new WaitForSeconds(0.02f);
        }
    }

    IEnumerator halfFadeBlackOut() // 검은색 절반 투명해짐.
    {
        for (float i = 11; i >= 8; i -= 0.04f)
        {
            float f = i / 10.0f;
            Color c = blackSr.material.color;
            c.a = f;
            blackSr.material.color = c;
            yield return new WaitForSeconds(0.02f);
        }
    }

    IEnumerator fadeBlack() // 검은색 진해짐.
    {
        for (float i = 0; i <= 11; i += 0.1f)
        {
            float f = i / 10.0f;
            Color c = blackSr.material.color;
            c.a = f;
            blackSr.material.color = c;
            yield return new WaitForSeconds(0.02f);
        }
    }
    IEnumerator fadeBlackOut() // 검은색 투명해짐.
    {
        for (float i = 10; i >= 0; i -= 0.1f)
        {
            float f = i / 10.0f;
            Color c = blackSr.material.color;
            c.a = f;
            blackSr.material.color = c;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public IEnumerator FadeTextToZeroAlpha()  // 페이드 아웃
    {
        while (text.color.a > 0.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a - (Time.deltaTime / 2.0f));
            yield return null;
        }
    }

    public IEnumerator FadeTextToFullAlpha() // 페이드 인
    {
        while (text.color.a < 1.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a + (Time.deltaTime / 2.0f));
            yield return null;
        }
    }
}
