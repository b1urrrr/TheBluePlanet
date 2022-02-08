using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashController2 : MonoBehaviour
{
    int score;
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit.collider != null && hit.collider.transform == this.transform)
            {
                if(this.tag == "whale")
                {
                    GameObject.Find("Main Camera").GetComponent<WhaleController2>().trash++;
                }
                Destroy(hit.transform.gameObject, 0.01f);
                GameObject.Find("GameDirector").GetComponent<GameDirector2>().score++;
                
                if (GameObject.Find("GameDirector").GetComponent<GameDirector2>().score == 30)
                {
                    GameObject.Find("Main Camera").GetComponent<AudioSource>().volume = 0;
                    GameObject.Find("clear").GetComponent<AudioSource>().Play();
                    GameObject.Find("Main Camera").GetComponent<FadeInScript2>().visable = 1;
                }
            }
        }
    }
}
