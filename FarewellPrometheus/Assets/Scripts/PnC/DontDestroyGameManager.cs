﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyGameManager : MonoBehaviour
{
    public static DontDestroyGameManager instance;
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
