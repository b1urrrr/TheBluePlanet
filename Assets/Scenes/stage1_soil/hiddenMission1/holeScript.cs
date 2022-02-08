using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holeScript : MonoBehaviour
{
    public GameManager_1 manager;

    void Start()
    {
        this.manager = GameObject.Find("Manager").GetComponent<GameManager_1>();
        gameObject.GetComponent<Renderer>().enabled = false;
        Invoke("holeUpdate", 72.6f);
    }

    void holeUpdate()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
    }

    void Update()
    {
            if (this.manager.hiddenPolState && Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

                if (hit.collider != null && hit.collider.transform == this.transform)
                {
                    GameObject.Find("challenge").GetComponent<AudioSource>().Play();
                    this.manager.holeState = true;
                    Destroy(this.gameObject);
                 }
            }
    }
}
