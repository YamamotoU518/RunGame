using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    /// <summary> Gameが始まっているか </summary>
    public bool _isPlaying { get; private set;}

    [SerializeField] private Text _text = null;
    
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

    public void Finish()
    {
        _isPlaying = false;
        _text.enabled = true;
    }
}
