using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _blackBackground : MonoBehaviour
{
    Image backgroundImg;

    void Awake()
    {
        backgroundImg = GetComponent<Image>();
        StartCoroutine(FadeTextToZero());        
    }

     public IEnumerator FadeTextToZero()  // 알파값 1에서 0으로 전환
    {
        backgroundImg.color = new Color(backgroundImg.color.r, backgroundImg.color.g, backgroundImg.color.b, 1);
        while (backgroundImg.color.a > 0.0f)
        {
            backgroundImg.color = new Color(backgroundImg.color.r, backgroundImg.color.g, backgroundImg.color.b, backgroundImg.color.a - (Time.deltaTime / 2.5f));           
            yield return null;
        }
        backgroundImg.gameObject.SetActive(false);
    }

}
