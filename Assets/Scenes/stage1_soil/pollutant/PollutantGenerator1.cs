using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollutantGenerator1 : MonoBehaviour
{
    public GameManager_1 Manager;
    public GameObject pollutantPrefab;
    float span = 11.0f;
    float delta = 0;

    void Start()
    {
        this.Manager = GameObject.Find("Manager").GetComponent<GameManager_1>();
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            if (this.Manager.total == 30)
                return;
            this.delta = 0;
            GameObject pollutant = Instantiate(pollutantPrefab) as GameObject;
            float px = Random.Range(-8, 28f);
            float py = Random.Range(-3.8f, -4.5f);
            pollutant.transform.position = new Vector3(px, py, 0);
        }
    }
}
