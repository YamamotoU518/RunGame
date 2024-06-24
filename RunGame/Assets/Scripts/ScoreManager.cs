using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance = null;
    
    [SerializeField] private Text _text = null;

    private int _currentScore;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            return;
        }
        Destroy(this.gameObject);
    }

    void Start()
    {
        _currentScore = 0;
    }
    
    void Update()
    {
        _text.text = _currentScore.ToString();
    }

    public void AddScore(int score)
    {
        _currentScore += score;
    }
}
