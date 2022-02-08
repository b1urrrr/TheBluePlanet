using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleController2 : MonoBehaviour
{
    SpriteRenderer whaleSr;
    SpriteRenderer whaleFrontSr;
    public GameObject help;
    public GameObject whale;
    public GameObject whaleFront;
    public int trash = 0;

    public StageManager StageManager;

    void Start()
    {
        whaleSr = GameObject.Find("whale").GetComponent<SpriteRenderer>();
        whaleFrontSr = GameObject.Find("whaleFront").GetComponent<SpriteRenderer>();
        this.StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    void Update()
    {
        if (trash == 10)
        {
            GameObject.Find("challenge").GetComponent<AudioSource>().Play();
            Destroy(help);
            StartCoroutine("fadeWhale");
            StartCoroutine("fadeWhaleFront");
            trash = 0;
            Destroy(whale, 1.8f);
            Destroy(whaleFront, 1.8f);
            this.StageManager._missionIndex_st2 = true;
        }
    }

    IEnumerator fadeWhale()
    {
        for (float i = 10; i >= 0; i -= 0.1f)
        {
            float f = i / 10.0f;
            Color c = whaleSr.material.color;
            c.a = f;
            whaleSr.material.color = c;
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator fadeWhaleFront()
    {
        for (float i = 10; i >= 0; i -= 0.1f)
        {
            float f = i / 10.0f;
            Color c = whaleFrontSr.material.color;
            c.a = f;
            whaleFrontSr.material.color = c;
            yield return new WaitForSeconds(0.01f);
        }
    }
}