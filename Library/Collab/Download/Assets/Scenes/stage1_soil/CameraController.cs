using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject A;
    Transform AT;
    void Start()
    {
        AT = A.transform;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, AT.position, 2f * Time.deltaTime);
        transform.Translate(0, 0, -10); //카메라를 원래 z축으로 이동
    }
}
