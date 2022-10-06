using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSound : MonoBehaviour
{
    public static BGSound bgSound;

    void Awake()
    {
        if (bgSound == null)
        {
            bgSound = this;
            DontDestroyOnLoad( gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }   

}
