using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController3 : MonoBehaviour
{
    public StageManager StageManager;

    void Start()
    {
        this.StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit.collider != null && hit.collider.transform == this.transform)
            {
                GameObject.Find("challenge").GetComponent<AudioSource>().Play();
                Destroy(hit.transform.gameObject, 0.01f);
                this.StageManager._missionIndex_st3 = true;
            }
        }
    }
}
