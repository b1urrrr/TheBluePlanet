using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private static DontDestroy instance = null;

    void Awake()
    {
        if(instance == null)
            instance = this;
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }       
        DontDestroyOnLoad(gameObject);
    }
}
