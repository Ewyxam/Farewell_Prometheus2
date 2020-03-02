using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyCollMan : MonoBehaviour
{

    public static DontDestroyCollMan instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }
}
