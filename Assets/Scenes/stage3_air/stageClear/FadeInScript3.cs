using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeInScript3 : MonoBehaviour
{
    SpriteRenderer blackSr;
    SpriteRenderer stageClearSr;
    SpriteRenderer tapToContinueSr;
    public GameObject black;
    public GameObject stageClear;
    public GameObject tapToContinue;
    bool finish = false;
    // 시작(0), 투명(-1), 불투명(1)
    int visable = 0;

    void Start()
    {
        blackSr = black.GetComponent<SpriteRenderer>();
        stageClearSr = stageClear.GetComponent<SpriteRenderer>();
        tapToContinueSr = tapToContinue.GetComponent<SpriteRenderer>();

        // 투명하게 초기화
        reset(blackSr);
        reset(stageClearSr);
        reset(tapToContinueSr);
    }
    void isFinish()
    {
        finish = true;
    }

    void reset(SpriteRenderer sr)
    {
        Color c = sr.material.color;
        c.a = 0;
        sr.material.color = c;
    }

    void Update()
    {
        if (finish == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                // Debug.Log("스테이지 이동 (연결되지 않음)");
                SceneManager.LoadScene("stage4_plant");
            }
        }

        if (visable == 0)
        {
            Destroy(GameObject.Find("Left"));
            Destroy(GameObject.Find("Right"));
            Destroy(GameObject.Find("Pause"));
            Invoke("blackIn", 10.0f);
            Invoke("stageClearIn", 12f);
            Invoke("tapToContinueIn", 13.5f);
            Invoke("isFinish", 13.5f);
            visable = 1;
        }
    }

    void blackIn()
    {
        StartCoroutine("fadeBlack");
    }

    void stageClearIn()
    {
        StartCoroutine("fadeStageClear");
    }

    void tapToContinueIn()
    {
        StartCoroutine("fadeTapToContinue");
    }

    IEnumerator fadeBlack ()
    {
        for (float i = 0; i <= 11; i+= 0.1f)
        {
            float f = i / 10.0f;
            Color c = blackSr.material.color;
            c.a = f;
            blackSr.material.color = c;
            yield return new WaitForSeconds(0.02f);
        }
    }

    IEnumerator fadeStageClear()
    {
        for (float i = 0; i <= 11; i+= 0.1f)
        {
            float f = i / 10.0f;
            Color c = stageClearSr.material.color;
            c.a = f;
            stageClearSr.material.color = c;
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator fadeTapToContinue()
    {
        for (float i = 0; i <= 11; i+= 0.3f)
        {
            float f = i / 10.0f;
            Color c = tapToContinueSr.material.color;
            c.a = f;
            tapToContinueSr.material.color = c;
            yield return new WaitForSeconds(0.03f);
        }
    }
}
