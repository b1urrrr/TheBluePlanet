using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//당근 클릭하면 당근과 Help 문구가 사라지고, 토끼 애니메이션 실행
public class CarrotController : MonoBehaviour
{
    GameObject help;    //help 문구
    Animator rabbitAnim;    //토끼 애니메이터
    public StageManager StageManager;

    void Start()
    {
        this.help = GameObject.Find("Help");
        this.rabbitAnim = GameObject.Find("rabbit").GetComponent<Animator>();
        this.StageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
        this.rabbitAnim.SetFloat("SpeedFloat", 0);  //처음 : 애니메이션 정지
    }

    void Update()
    {   
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null && hit.collider.transform == this.transform)
            {
                GameObject.Find("challenge").GetComponent<AudioSource>().Play();
                Destroy(this.gameObject);   //당근 소멸
                Destroy(this.help);  //help 문구 소멸
                this.StageManager._missionIndex_st4 = true;
                this.rabbitAnim.SetFloat("SpeedFloat", 1);    //애니메이션 실행
                
            }
        }
    }
}
