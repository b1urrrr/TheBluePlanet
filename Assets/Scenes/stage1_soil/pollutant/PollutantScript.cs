using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollutantScript : MonoBehaviour
{
    public float time;
    public GameManager_1 Manager;

    void Start()
    {
        transform.localScale = new Vector3(0,0,0);
        this.Manager = GameObject.Find("Manager").GetComponent<GameManager_1>();
    }

    void Update()
    {
        sizeUp();

        // 오염물질 클릭 시 삭제
        if (Input.GetMouseButtonDown(0))
        {
            DestroyPol();
        }
    }

    public void DestroyPol()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

        if (hit.collider != null && hit.collider.transform == this.transform)
        {
            Destroy(gameObject);
            GameObject manager = GameObject.Find("Manager");
            manager.GetComponent<GameManager_1>().Total();
        }
    }

    public void sizeUp()
    {
        // 오염물질 커지기 효과
        transform.localScale = Vector3.one * time / 10;
        if(time < 10.5f)
            time += Time.deltaTime;
    }
}
