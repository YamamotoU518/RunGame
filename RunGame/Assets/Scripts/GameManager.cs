using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    /// <summary> Gameが始まっているか </summary>
    public bool _isPlaying { get; set;}
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            return;
        }
        Destroy(this.gameObject);

        _isPlaying = false;
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
        _isPlaying = true;
    }
}
