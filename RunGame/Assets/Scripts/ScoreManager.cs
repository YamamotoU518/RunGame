using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager _instance;
    public static ScoreManager Instance => _instance;
    
    [SerializeField] private Text _text = null;
    
    public int _highScore { get; private set; }

    public int _currentScore { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
        
    }

    void Start()
    {
        _currentScore = 0;
        _highScore = PlayerPrefs.GetInt("HighScore", 0);
    }
    
    void Update()
    {
        if (_text) { _text.text = _currentScore.ToString(); }
    }

    public void AddScore(int score)
    {
        _currentScore += score;
    }
}
