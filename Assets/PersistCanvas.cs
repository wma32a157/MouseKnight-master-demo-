﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistCanvas : MonoBehaviour
{
    public static PersistCanvas instance;
    public CanvasGroup blackScreen;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;

        }

        instance = this;

        DontDestroyOnLoad(gameObject);
        blackScreen = transform.Find("BlackScreen")
            .GetComponent<CanvasGroup>();
    }

    private void OnDestroy()
    {
        instance = null;
    }


}
