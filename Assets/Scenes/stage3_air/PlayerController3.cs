using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController3 : MonoBehaviour
{
    GameObject player;
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 800.0f;
    float walkForce = 35.0f;
    float maxWalkSpeed = 3.0f;
    float delay = 1.5f;

    public bool inputLeft = false;
    public bool inputRight = false;
    public bool inputJump = false;

    void Start()
    {
        this.player = GameObject.Find("wed");
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();

        MoveButtonManager3 moveUi = GameObject.Find("MoveButtonManager").GetComponent<MoveButtonManager3>();
        moveUi.Init();
    }

    void Update()
    {
        // 주인공 좌우 이동
        int key = 0;
        if (inputRight) key = 1;
        if (inputLeft) key = -1;

        // 주인공 애니메이션
        if (inputJump && this.rigid2D.velocity.y == 0) // 다른 방식도 가능
        {
            inputJump = false;
            transform.localScale = new UnityEngine.Vector3(1, 1, 1);
            this.animator.SetTrigger("JumpTrigger");
            GetComponent<AudioSource>().Play();
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        else if (key != 0 && this.rigid2D.velocity.y == 0)
        {
            this.animator.SetTrigger("WalkTrigger");
            transform.localScale = new UnityEngine.Vector3(key, 1, 1);
        }
        else
        {
            transform.localScale = new UnityEngine.Vector3(1, 1, 1);
            this.animator.SetTrigger("StillTrigger");
        }

        // 주인공 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // 주인공 속도 제한
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        // 게임 오버
        UnityEngine.Vector3 playerPos = this.player.transform.position;
        if (playerPos.y < -10)
        {
            SceneManager.LoadScene("stage3_gameOver");
        }
    }

    //게임 클리어
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Invoke("clear", delay);

        }
    }

    void clear()
    {
        SceneManager.LoadScene("stage3_clearScene");
    }
}