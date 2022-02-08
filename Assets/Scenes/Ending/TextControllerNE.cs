using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextControllerNE : MonoBehaviour
{
    SpriteRenderer blackSr;
    public GameObject credit;
    public GameObject black;
    public Text text;
    // 시작(0), 투명(-1), 불투명(1)
    public int visable;
    public StageManager StageManager;
    float add = 0.025f;
    bool isCredit = false;

    void Start()
    {
        this.credit = GameObject.Find("endingCredit");
        this.StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
        blackSr = black.GetComponent<SpriteRenderer>();
        visable = 0;
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0.0f);
    }

    void isFinish()
    {
        isCredit = true;
    }

    void hiddenEnding()
    {
        if (StageManager._missionIndex_st1 && StageManager._missionIndex_st2
                && StageManager._missionIndex_st3 && StageManager._missionIndex_st4)
        {
            SceneManager.LoadScene("HiddenEnding");
        }
        else
        {
            SceneManager.LoadScene("stage0_start");
        }
    }

    void goUp()
    {
        this.credit.transform.position = new Vector3(credit.transform.position.x, credit.transform.position.y + add, credit.transform.position.z);
    }

    void beginning()
    {
        GameObject.Find("music").GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        if (isCredit)
        {
            goUp();
        }

        if (visable == 0)
        {
            blackOut();
            Invoke("textIn", 2.0f);
            Invoke("textOut", 9.0f);
            Invoke("isFinish", 9.0f);
            Invoke("beginning", 9.0f);
            Invoke("blackIn", 38.0f);
            Invoke("hiddenEnding", 42.0f);
            visable = 1;
        }
    }

    void blackIn()
    {
        StartCoroutine("fadeBlack");
    }

    void blackOut()
    {
        StartCoroutine("fadeBlackOut");
    }
    void textIn()
    {
        StartCoroutine("FadeTextToFullAlpha");
    }

    void textOut()
    {
        StartCoroutine("FadeTextToZeroAlpha");
    }

    IEnumerator fadeBlack()
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
    IEnumerator fadeBlackOut()
    {
        for (float i = 10; i >= 0; i -= 0.1f)
        {
            float f = i / 10.0f;
            Color c = blackSr.material.color;
            c.a = f;
            blackSr.material.color = c;
            yield return new WaitForSeconds(0.01f);
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
