using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_stage4 : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float walkForce = 35.0f;
    float maxWalkSpeed = 3.0f;

    public bool inputLeft = false;
    public bool inputRight = false;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();

        MoveButtonManager4 moveUi = GameObject.Find("MoveButtonManager").GetComponent<MoveButtonManager4>();
        moveUi.Init();
    }

    void Update()
    {
        //좌우 이동
        int key = 0;
        if (inputRight) key = 1;
        if (inputLeft) key = -1;

        //주인공 애니메이션
        if (key != 0)
        {
            this.animator.SetTrigger("WalkTrigger");
            transform.localScale = new Vector3(key, 1, 1);
        }
        else //정지
        {
            this.animator.SetTrigger("StopTrigger");
            transform.localScale = new Vector3(1, 1, 1);
        }

        //주인공 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        //속도 제한
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }
        
    }
}
