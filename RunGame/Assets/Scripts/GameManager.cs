using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState
{
    BeforeGame,
    IsPlaying,
    Finish
}
public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    [SerializeField] private Text _text = null;
    [SerializeField] private SceneLoader _sceneLoader = null;

    /// <summary> Gameのステート </summary>
    public GameState _gameState { get; private set; }
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            return;
        }
        Destroy(this.gameObject);
        
        _gameState = GameState.BeforeGame;
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
        _gameState = GameState.IsPlaying;
        SEManager.Instance.PlayBGM();
    }

    public void Finish()
    {
        _gameState = GameState.Finish;
        _text.enabled = true;
        Invoke("LoadScene", 2f);
    }

    void LoadScene()
    {
        _sceneLoader.SceneLoad("Result");
    }
}
