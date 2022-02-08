using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public GameManager_1 Manager;
    Rigidbody2D rigid2D;
    Animator animator;
    float walkForce = 35.0f;
    float maxWalkSpeed = 3.0f;

    public bool inputLeft = false;
    public bool inputRight = false;

    void Start()
    {
        this.Manager = GameObject.Find("Manager").GetComponent<GameManager_1>();
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();

        MoveButtonManager1 moveUi = GameObject.Find("MoveButtonManager").GetComponent<MoveButtonManager1>();
        moveUi.Init();
    }

    void Update()
    {
        // 좌우 이동
        int key = 0;
        if (inputRight) key = 1;
        if (inputLeft) key = -1;

        if (key != 0)
        {
            this.animator.SetTrigger("WalkTrigger1");
            transform.localScale = new Vector3(key, 1, 1);
        }
        else
        {
            this.animator.SetTrigger("StillTrigger1");
            transform.localScale = new Vector3(1, 1, 1);
        }


        // 플레이어 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // 스피드 제한
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }
    }
}
