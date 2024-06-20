using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public bool _start;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            return;
        }
        Destroy(this.gameObject);

        _start = false;
    }

    void Start()
    {
        Invoke("GameStart", 3f);
    }
    
    void Update()
    {
        
    }

    void GameStart()
    {
        _start = true;
    }
}
