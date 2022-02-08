using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objFadeController_1 : MonoBehaviour
{
    public float time = 0;
    public float fadeTime = 3f;

    // 페이드 아웃 효과
    public void objFadeOut()
    {
        if (time < fadeTime)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f - time / fadeTime);
        }
        else
        {
            time = 0;
            this.gameObject.SetActive(false);
        }
        time += Time.deltaTime;
    }

    public void objFadeIn()
    {
        if (time < fadeTime)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, time / fadeTime);
        }
        time += Time.deltaTime;
    }

}
